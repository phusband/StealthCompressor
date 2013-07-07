using System;
using System.IO;
using System.Windows.Forms;
using Stealth_Compressor.Properties;

namespace Stealth_Compressor
{
    public partial class DecloakForm : Form
    {
        // Create an archive object for accessing later
        // This is so we don't have to search for the archive
        // twice in the byte stream.
        internal StealthArchive stealth;
        private bool isEncrypted;

        public DecloakForm()
        {
            InitializeComponent();
            this.Icon = Resources.Stealth;
            this.ShowIcon = true;
            txt_Input.Text = string.Empty;
            sts_Main_Seperator.Text = string.Empty;
            statusCheck();
            col_Size.Text = string.Format("File Size ({0})", Settings.Default.UNITS);
            isEncrypted = false;
            grp_Output.Enabled = false;
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            opn_Cloaked.CheckFileExists = true;
            opn_Cloaked.CheckPathExists = true;
            opn_Cloaked.Multiselect = false;
            opn_Cloaked.Filter = "All Files (*.*)|*.*";
            opn_Cloaked.FilterIndex = 1;
            opn_Cloaked.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            if (opn_Cloaked.ShowDialog() == DialogResult.OK)
            {
                txt_Input.Text = opn_Cloaked.FileName;
                lst_Files.Items.Clear();
                canExtract(false);
                lbl_Status.Text = "Press 'Decloak' to reveal hidden files...";
            }
        }
        private void btn_Output_Click(object sender, EventArgs e)
        {
            bws_Output.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            bws_Output.ShowNewFolderButton = true;

            if (bws_Output.ShowDialog() == DialogResult.OK)
            {
                txt_Output.Text = bws_Output.SelectedPath;
                statusCheck();
            }
        }

        private void btn_Decloak_Click(object sender, EventArgs e)
        {
            if (File.Exists(txt_Input.Text))
            {
                stealth = new StealthArchive(txt_Input.Text);

                try
                {
                    foreach (Ionic.Zip.ZipEntry entry in stealth.GetCloakedEntries(StealthArchive.ArchiveType.Zip))
                    {
                        ListViewItem item = new ListViewItem();
                        item.Name = entry.FileName;
                        item.Text = item.Name;

                        if (entry.UsesEncryption)
                        {
                            item.Text += "*";
                            isEncrypted = true;
                        }

                        item.SubItems.Add((MainForm.formatFileSize(entry.UncompressedSize, Settings.Default.UNITS)));
                        item.SubItems.Add((entry.CompressionRatio * .01).ToString("0%"));
                        item.SubItems.Add(entry.Encryption.ToString());

                        lst_Files.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error de-cloaking file: {0}", ex.Message), "De-Cloak", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (lst_Files.Items.Count > 0)
                {
                    canExtract(true);
                    lbl_Status.Text = "Select files to extract...";
                }
                else
                {
                    MessageBox.Show("This file contains no cloaked data.","De-CLoak", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Input.Clear();
                    statusCheck();
                    return;
                }
            }
        }
        private void btn_Extract_Click(object sender, EventArgs e)
        {
            enableForm(false);

            string[] files = new string[lst_Files.CheckedItems.Count];
            for (int i = 0; i < lst_Files.CheckedItems.Count; i++)
            {
                files[i] = lst_Files.CheckedItems[i].Name;
            }

            if (isEncrypted)
            {
                stealth.ExtractCloakedFiles(files, txt_Output.Text, true, getPassword(false));

            }
            else
            {
                stealth.ExtractCloakedFiles(files, txt_Output.Text, true);
            }

            lbl_Status.Text = string.Format("{0} files extracted!", files.Length);

            enableForm(true);
        }

        private void canExtract(bool value)
        {
            btn_Extract.Visible = value;
            btn_Decloak.Visible = !value;
            statusCheck();
        }
        private void statusCheck()
        {
            if (txt_Input.Text == string.Empty)
            {
                lbl_Status.Text = lbl_Status.Text = "Choose a cloaked file...";
                btn_Decloak.Enabled = false;
                return;
            }
            btn_Decloak.Enabled = true;
            if ((lst_Files.CheckedItems.Count > 0) && (txt_Output.Text == string.Empty))
            {
                lbl_Status.Text = "Choose an output directory...";
                return;
            }
            if ((lst_Files.CheckedItems.Count > 0) && (txt_Output.Text != string.Empty))
            {
                btn_Extract.Enabled = true;
                lbl_Status.Text = "Press 'Extract' to begin!";
                return;
            }
            btn_Extract.Enabled = false;

        }
        private void enableForm(bool choice)
        {
            grp_Input.Enabled = choice;
            grp_Output.Enabled = choice;
            lst_Files.Enabled = choice;
        }
        private void clearForm()
        {
            canExtract(false);
            lst_Files.Items.Clear();
            txt_Output.Clear();
            statusCheck();
            isEncrypted = false;
        }

        // Prompts the user for password entry
        private string getPassword(bool validate)
        {
            // Update the status label
            lbl_Status.Text = "Setting archive password...";

            PassForm pass = new PassForm(validate);
            pass.StartPosition = FormStartPosition.CenterParent;
            pass.ShowDialog(this);
            return pass.Password;
        }

        private void lst_Files_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (lst_Files.CheckedItems.Count > 0) grp_Output.Enabled = true;
            else grp_Output.Enabled = false;

            statusCheck();
        }

    }
}
