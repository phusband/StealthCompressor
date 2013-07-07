using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Stealth_Compressor.Properties;

namespace Stealth_Compressor
{
    public partial class MainForm : Form
    {
        // Variable declaration
        public static string tempPath = Environment.GetEnvironmentVariable("TEMP") + "\\";
        private ListViewColumnSorter columnSorter = new ListViewColumnSorter();
        private bool isCanceling; // <- for stopping the archival

        #region Main Form

        // Form Initializer (Runs at startup)
        public MainForm()
        {
            InitializeComponent();

            // Link our sorting class to our listview object
            lst_Files.ListViewItemSorter = columnSorter;

            // Set up the form

            // Load the last toolbar settings
            ToolStripManager.LoadSettings(this);
            tsc_Main.TopToolStripPanel.RowMargin = new Padding(0);
            tlb_Main.Renderer = new ToolStripRendererFix();
            tlb_Archive.Renderer = new ToolStripRendererFix();
            
            if (isCanceling) isCanceling = false; // <- To fix later
            lbl_ImgSize.Text = string.Empty;
            lst_Files_Size.Text = string.Format("File Size ({0})", Settings.Default.UNITS);
            lbl_TotalSize.Text = string.Format("Total File Size ({0}): 0.00", Settings.Default.UNITS);
            sts_Main_Seperator.Text = string.Empty;
            lbl_Status.Text = "Add files to begin...";
            tlb_Archive_Stop.Enabled = false;
            tlb_Archive_Start.Enabled = readyCheck();
            btn_Start.Enabled = readyCheck();

            

            GetValuesFromSettings();
        }
        private void GetValuesFromSettings()
        {
            chk_Encryption.Checked = Settings.Default.ENCRYPT_ARCHIVE;
            chk_OpenComplete.Checked = Settings.Default.OPEN_ON_COMPLETION;
        }

        // Start button is pressed
        private void tlb_Main_Start_Click(object sender, EventArgs e) { Main(); }
        private void btn_Start_Click(object sender, EventArgs e) { Main(); }

        // Browse save button is pressed
        private void btn_Output_Click(object sender, EventArgs e)
        {
            sav_Output.CheckPathExists = true;
            if (!lbl_Image.Visible)
            {
                sav_Output.DefaultExt = img_Image.ImageLocation.Substring(img_Image.ImageLocation.Length - 3, 3);
            }
            else { sav_Output.DefaultExt = "*.*"; }

            sav_Output.Filter = "Image Files|*.bmp;*.jpg;*.png|" +
                               "BitMap (*.bmp)|*.bmp|" +
                               "JPEG (*.jpg)|*.jpg|" +
                               "PNG (*.png)|*.png|" +
                               "All Files (*.*)|*.*";

            sav_Output.FilterIndex = 1;
            sav_Output.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            sav_Output.Title = "Save Compressed Archive As...";

            if (sav_Output.ShowDialog() == DialogResult.OK)
            {
                txt_Output.Text = sav_Output.FileName;
            }

            tlb_Archive_Start.Enabled = readyCheck();
            btn_Start.Enabled = readyCheck();

        }

        // Exit button is pressed
        private void mnu_File_Exit_Click(object sender, EventArgs e) { this.Close(); }

        // Archival is canceled
        private void tlb_Main_Stop_Click(object sender, EventArgs e) { isCanceling = true; }
        private void btn_Stop_Click(object sender, EventArgs e) { isCanceling = true; }

        // Load archive configuration settings
        private void mnu_Tools_Configuration_Click(object sender, EventArgs e)
        {
            ArchiveSettingsForm settings = new ArchiveSettingsForm();
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.ShowDialog(this);
        }


        #endregion

        #region Application Methods

        // Main Routine
        private void Main()
        {
            // Disable the form during archival
            btn_Start.SendToBack();
            enableForm(false);

            // Copy the image file to the output directory
            File.Copy(img_Image.ImageLocation, txt_Output.Text, true);

            // Create the path to the file
            string outputPath = txt_Output.Text;

            // Try creating an archive
            if (CreateStealthArchive(outputPath))
            {
                // Open file if the option is selected
                if (chk_OpenComplete.Checked) System.Diagnostics.Process.Start(outputPath);

                lbl_Status.Text = "Merge Complete!";
            }
            else // on failure, clean-up
            {
                MessageBox.Show("Failed to create stealth archive!");
                File.Delete(outputPath);
            }

            // Re-enable the form after archival
            btn_Stop.SendToBack();
            enableForm(true);
        }

        // Prompts the user for password entry
        private string getPassword(bool validate)
        {
            // Update the status label
            lbl_Status.Text = "Setting archive password...";
            tsc_Main.Update();

            PassForm pass = new PassForm(validate);
            pass.StartPosition = FormStartPosition.CenterParent;
            pass.ShowDialog(this);
            return pass.Password;
        }

        // Create Zip archive using the DotNetZip library
        private bool CreateStealthArchive(string outputFile)
        {
            using (StealthArchive stealth = new StealthArchive())
            {
                // Set Output Path
                stealth.CloakingFile = txt_Output.Text;

                // Get archive settings
                stealth.CompressionLevel = ArchiveSettingsForm.GetLevel(Settings.Default.COMPRESSION_LEVEL);
                stealth.CompressionMethod = ArchiveSettingsForm.GetMethod(Settings.Default.COMPRESSION_METHOD);
                stealth.Strategy = ArchiveSettingsForm.GetStrategy(Settings.Default.COMPRESSION_STRATEGY);
                stealth.BufferSize = Settings.Default.IO_BUFFER_SIZE;
                stealth.CodecBufferSize = Settings.Default.CODEC_BUFFER_SIZE;
                stealth.UseMemory = Settings.Default.MEMORY_ARCHIVE;
                stealth.UseZip64WhenSaving = ArchiveSettingsForm.Get64Option(Settings.Default.USE_ZIP64);
                
                // Set an optional password
                if (Settings.Default.ENCRYPT_ARCHIVE)
                {
                    // Prompt the user for a password
                    stealth.Password = getPassword(true);
                    stealth.Encryption = ArchiveSettingsForm.GetEncryption(Settings.Default.ENCRYPTION_ALGORITHM);
                }

                try
                {
                    // Iterate through each checked file in the file list
                    foreach (ListViewItem item in lst_Files.CheckedItems)
                    {
                        // Update status label
                        lbl_Status.Text = string.Format("Adding {0} to archive...", item.Text);
                        tsc_Main.Update();

                        // Add entry to archive
                        stealth.AddFile(item.Name, string.Empty);
                    }

                    // Cloak the archive
                    stealth.Cloak();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
            }

            return true;
        }

        // Decloaking form initializer
        private void tlb_Archive_Decloak_Click(object sender, EventArgs e)
        {
            DecloakForm deCloak = new DecloakForm();
            deCloak.StartPosition = FormStartPosition.CenterParent;
            deCloak.ShowDialog(this);
        }

        #endregion

        #region Image File

        // Routines for adding the main image file
        private void addImage()
        {
            opn_Image.CheckFileExists = true;
            opn_Image.CheckPathExists = true;
            opn_Image.Multiselect = false;
            opn_Image.Filter = "Image Files|*.bmp;*.jpg;*.png|" +
                               "BitMap (*.bmp)|*.bmp|" +
                               "JPEG (*.jpg *.jpeg)|*.jpg;*.jpeg|" +
                               "PNG (*.png)|*.png|" +
                               "All Files (*.*)|*.*";
            opn_Image.FilterIndex = 1;
            opn_Image.InitialDirectory = Environment.SpecialFolder.MyPictures.ToString();

            if (opn_Image.ShowDialog() == DialogResult.OK)
            {
                formatImage(opn_Image.FileName);
            }

            tlb_Archive_Start.Enabled = readyCheck();
            btn_Start.Enabled = readyCheck();
        }
        private void formatImage(string imgPath)
        {
            // Hide the image controls
            lbl_Image.Visible = false;
            img_Image.ImageLocation = imgPath;

            // Get the measurements of the selected image
            Size origSize = new Size();
            using (Image curImage = Image.FromFile(opn_Image.FileName))
            {
                origSize.Width = curImage.Width;
                origSize.Height = curImage.Height;
            }

            //Update the Image group label
            FileInfo imgFile = new FileInfo(imgPath);
            grp_Image.Text = String.Format("Image: {0}", imgFile.Name);

            // Update the size label
            lbl_ImgSize.Text = string.Format("{0} x {1}", origSize.Width, origSize.Height);
            lbl_ImgSize.Left = (grp_Image.Width - lbl_ImgSize.Width) / 2;

            // Set the size of the image
            int maxSize = 156; // (Image container is 156x156)
            double aspectRatio;
            Size newSize = new Size();

            // Build the new size based on the aspect ratio of the image
            if (origSize.Width > origSize.Height)
            {
                aspectRatio = Convert.ToDouble(origSize.Width) / Convert.ToDouble(origSize.Height);
                newSize.Width = maxSize;
                newSize.Height = Convert.ToInt16(maxSize / aspectRatio);
            }
            else
            {
                aspectRatio = Convert.ToDouble(origSize.Height) / Convert.ToDouble(origSize.Width);
                newSize.Width = Convert.ToInt16(maxSize / aspectRatio);
                newSize.Height = maxSize;
            }

            // Apply the new size to the image, and maximize it within the container
            img_Image.Size = newSize;
            img_Image.SizeMode = PictureBoxSizeMode.StretchImage;

            // Center the image in the container
            img_Image.Left = (grp_Image.Width - img_Image.Width) / 2;
            img_Image.Top = (grp_Image.Height - img_Image.Height) / 2;

        }
        private void tlb_Main_AddImage_Click(object sender, EventArgs e) { addImage(); }
        private void ctx_Image_AddImage_Click(object sender, EventArgs e){ addImage(); }

        #endregion

        #region File List

        // Routines for adding files to the list
        private void AddFiles()
        {
            opn_Files.CheckFileExists = true;
            opn_Files.CheckPathExists = true;
            opn_Files.Multiselect = true;
            opn_Files.Filter = "All Files (*.*)|*.*";
            opn_Files.FilterIndex = 1;
            opn_Files.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();

            if (opn_Files.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in opn_Files.FileNames)
                {
                    FileInfo curFile = new FileInfo(file);
                    ListViewItem curItem = new ListViewItem(curFile.Name);
                    curItem.Name = curFile.FullName;

                    if (!lst_Files.Items.ContainsKey(curItem.Name))
                    {
                        curItem.SubItems.Add(curFile.DirectoryName);
                        curItem.SubItems.Add(formatFileSize(curFile.Length, Settings.Default.UNITS));
                        curItem.Checked = true;
                        lst_Files.Items.Add(curItem);
                    }
                }
            }

            updateTotal();
            tlb_Archive_Start.Enabled = readyCheck();
            btn_Start.Enabled = readyCheck();
        }
        private void tlb_Main_AddFiles_Click(object sender, EventArgs e) { AddFiles(); }
        private void ctx_Files_AddFiles_Click(object sender, EventArgs e){ AddFiles(); }

        // Routines for removing selected files from the list
        private void RemoveFiles()
        {
            foreach (ListViewItem item in lst_Files.SelectedItems)
            {
                item.Remove();
            }

            updateTotal();
            tlb_Archive_Start.Enabled = readyCheck();
            btn_Start.Enabled = readyCheck();
        }
        private void tlb_Main_Remove_Click(object sender, EventArgs e) { RemoveFiles(); }
        private void ctx_Files_Remove_Click(object sender, EventArgs e){ RemoveFiles(); }

        // Routines for removing all files from the list
        private void tlb_Main_RemoveAll_Click(object sender, EventArgs e)
        {
            lst_Files.Items.Clear();
            updateTotal();
            tlb_Archive_Start.Enabled = readyCheck();
            btn_Start.Enabled = readyCheck();
        }
        private void ctx_Files_RemoveAll_Click(object sender, EventArgs e)
        {
            lst_Files.Items.Clear();
            updateTotal();
        }

        //Routines for checking/unchecking items in the file list
        private void checkItem(bool isChecked)
        {
            foreach (ListViewItem item in lst_Files.SelectedItems)
            {
                if (isChecked) { item.Checked = true; }
                else { item.Checked = false; }
            }
        }
        private void tlb_Main_Check_Click(object sender, EventArgs e)   { checkItem(true);  }
        private void ctx_Files_Check_Click(object sender, EventArgs e)  { checkItem(true);  }
        private void tlb_Main_Uncheck_Click(object sender, EventArgs e) { checkItem(false); }
        private void ctx_Files_Uncheck_Click(object sender, EventArgs e){ checkItem(false); }
        private void lst_Files_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked) { e.Item.ForeColor = Color.Black; }
            else { e.Item.ForeColor = Color.Gray; }
            updateTotal();
        }

        // Routines for inverting the current file list selection
        private void invertSelection()
        {
            foreach (ListViewItem item in lst_Files.Items)
            {
                if (item.Selected) { item.Selected = false; }
                else { item.Selected = true; }
            }
        }
        private void tlb_Main_Invert_Click(object sender, EventArgs e) { invertSelection(); }
        private void ctx_Files_Invert_Click(object sender, EventArgs e){ invertSelection(); }

        // Handles the column sorting when clicked
        private void lst_Files_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == columnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (columnSorter.Order == SortOrder.Ascending)
                {
                    columnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    columnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lst_Files.Sort();
        }

        // Routines that keep the filesize column anchored to the size of the form
        private void MainForm_SizeChanged(object sender, System.EventArgs e)
        {
            lst_Files.Columns[2].Width = -2;
        }
        private void lst_Files_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (e.ColumnIndex != 2)
            {
                lst_Files.Columns[2].Width = -2;
            }
        }

        #endregion

        #region Tools

        // Creates the desktop shortcut
        private void mnu_Tools_Shortcut_Click(object sender, EventArgs e)
        {
            // The shortcut will only be generated properly when run from the exe, not a VS debugging session
            string exePath = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName;
            string lnkPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Stealth Compressor.lnk";
            ShellLink shortcut = new ShellLink();
            shortcut.Description = "Stealth Compressor - Archive Cloaking";
            shortcut.DisplayMode = ShellLink.LinkDisplayMode.edmNormal;
            shortcut.Target = exePath;
            shortcut.IconPath = exePath;
            shortcut.IconIndex = 0;
            if (File.Exists(lnkPath)) File.Delete(lnkPath);
            shortcut.Save(lnkPath);
        }

        #endregion

        #region Application Utilities

        // Formats the file size to the desired setting
        public static string formatFileSize(double size, string format)
        {
            double divisor;
            switch (format)
            {
                case "KB":
                    divisor = Math.Pow(2, 10);
                    break;
                case "MB":
                    divisor = Math.Pow(2, 20);
                    break;
                case "GB":
                    divisor = Math.Pow(2, 30);
                    break;
                default:
                    divisor = Math.Pow(2, 10);
                    break;
            }

            return Math.Round(size / divisor, 2).ToString("n2"); // <-- Composite formatting
        }

        // Updates the total size label
        private void updateTotal()
        {
            double total = 0;

            // Iterate through each file in the list
            foreach (ListViewItem item in lst_Files.Items)
            {
                if (item.Checked)
                {
                    // Add the file size to the total if it's checked
                    total += Convert.ToDouble(item.SubItems[2].Text);
                }
            }

            // Format the total file size label
            lbl_TotalSize.Text = string.Format("Total Size ({0}): {1}", Settings.Default.UNITS, total.ToString("n2"));

            //// Estimated archive size formatting...
            //string archiveTotal = "Est. Archive Size ({0}): {1}";
            //lbl_ArchiveSize.Text = string.Format(archiveTotal, units, "Calculating...");

            //if (!lbl_TotalSize.Text.Contains("0.00"))
            //{
            //    //long imageSize = 0;
            //    // We can use this to get the size of everything, including the image used
            //    //if (img_Image.Image != null)
            //    //{
            //    //    FileInfo image = new FileInfo(img_Image.ImageLocation);

            //    //}

            //    //Thread archiveThread = new Thread(estimateArchiveThread);
            //    //archiveThread.IsBackground = true;
            //    //archiveThread.Start();
            //}
            //else lbl_ArchiveSize.Text = string.Format(archiveTotal, units, "0.00");

        }

        // Checks that everything is ready for archival
        private bool readyCheck()
        {
            // Check if image is loaded
            if (img_Image.ImageLocation == null)
            {
                return false;
            }

            // Check if files are loaded
            if (lst_Files.CheckedItems.Count == 0)
            {
                return false;
            }

            // Check if a save path exists
            if (txt_Output.Text == string.Empty)
            {
                return false;
            }

            return true;
        }

        // Disables/Enables form controls during archival
        private void enableForm(bool choice)
        {
            // Form buttons
            btn_Start.Enabled = choice;
            btn_Stop.Enabled = !choice;

            // Form groups
            grp_Output.Enabled = choice;
            grp_Image.Enabled = choice;
            grp_Files.Enabled = choice;
            grp_QuickSettings.Enabled = choice;

            // Main menu
            mnu_File_New.Enabled = choice;
            mnu_File_Open.Enabled = choice;
            mnu_File_Save.Enabled = choice;
            mnu_Tools.Enabled = choice;
            mnu_Help.Enabled = choice;

            // Main toolbar
            tlb_Main_New.Enabled = choice;
            tlb_Main_Open.Enabled = choice;
            tlb_Main_Save.Enabled = choice;
            tlb_Main_AddImage.Enabled = choice;
            tlb_Main_AddFiles.Enabled = choice;
            tlb_Main_Remove.Enabled = choice;
            tlb_Main_RemoveAll.Enabled = choice;
            tlb_Main_Check.Enabled = choice;
            tlb_Main_Uncheck.Enabled = choice;
            tlb_Main_Invert.Enabled = choice;
            tlb_Archive_Start.Enabled = choice;
            tlb_Archive_Stop.Enabled = !choice;

            this.Update();
        }

        #endregion

      //-----------\\
        #region To Do Items

        private void mnu_File_Open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add open session method");
        }
        private void mnu_File_Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add save session method");
        }
        private void mnu_File_New_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add new session method");
        }

        private void tlb_Main_Open_Click(object sender, EventArgs e)
        {

        }
        private void tlb_Main_Save_Click(object sender, EventArgs e)
        {

        }
        private void tlb_Main_New_Click(object sender, EventArgs e)
        {

        }

        private void mnu_Tools_Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add settings form");
        }
        private void mnu_Help_ViewHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to create help chm file");
        }
        private void mnu_Help_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Need to add about splashscreen");
        }

        #endregion
      //-----------\\

        // Toolbar controls
        private void ctx_Toolbars_Main_Click(object sender, EventArgs e)
        {
            ctx_Toolbars_Main.Checked = !ctx_Toolbars_Main.Checked;
        }
        private void ctx_Toolbars_Main_CheckedChanged(object sender, System.EventArgs e)
        {
            tlb_Main.Visible = ctx_Toolbars_Main.Checked;
        }
        private void ctx_Toolbars_Archive_Click(object sender, EventArgs e)
        {
            ctx_Toolbars_Archive.Checked = !ctx_Toolbars_Archive.Checked;
        }
        private void ctx_Toolbars_Archive_CheckedChanged(object sender, System.EventArgs e)
        {
            tlb_Archive.Visible = ctx_Toolbars_Archive.Checked;
        }

        // On exit
        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            ToolStripManager.SaveSettings(this);
        }

        // Quick settings
        private void chk_Encryption_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ENCRYPT_ARCHIVE = chk_Encryption.Checked;
        }
        private void chk_OpenComplete_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OPEN_ON_COMPLETION = chk_OpenComplete.Checked;
        }
    }
}
