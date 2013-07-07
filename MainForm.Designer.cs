namespace Stealth_Compressor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tsc_Main = new System.Windows.Forms.ToolStripContainer();
            this.sts_Main = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.sts_Main_Seperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_TotalSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_ArchiveSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_QuickSettings = new System.Windows.Forms.GroupBox();
            this.chk_OpenComplete = new System.Windows.Forms.CheckBox();
            this.chk_Encryption = new System.Windows.Forms.CheckBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.btn_Output = new System.Windows.Forms.Button();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.grp_Files = new System.Windows.Forms.GroupBox();
            this.ctx_Files = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctx_Files_AddFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_Files_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_Files_RemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_Files_Check = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_Files_Uncheck = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_Files_Invert = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_Files = new System.Windows.Forms.ListView();
            this.lst_Files_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Files_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Files_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grp_Image = new System.Windows.Forms.GroupBox();
            this.ctx_Image = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctx_Image_AddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ImgSize = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.img_Image = new System.Windows.Forms.PictureBox();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.ctx_Toolbars = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctx_Toolbars_Main = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_Toolbars_Archive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Tools_Shortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Tools_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Tools_Compression = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help_ViewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tlb_Main = new System.Windows.Forms.ToolStrip();
            this.tlb_Main_New = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Open = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Save = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlb_Main_AddImage = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_AddFiles = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Remove = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_RemoveAll = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlb_Main_Check = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Uncheck = new System.Windows.Forms.ToolStripButton();
            this.tlb_Main_Invert = new System.Windows.Forms.ToolStripButton();
            this.tlb_Archive = new System.Windows.Forms.ToolStrip();
            this.tlb_Archive_Start = new System.Windows.Forms.ToolStripButton();
            this.tlb_Archive_Stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlb_Archive_Decloak = new System.Windows.Forms.ToolStripButton();
            this.ctx_Main_AddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.sav_Output = new System.Windows.Forms.SaveFileDialog();
            this.opn_Image = new System.Windows.Forms.OpenFileDialog();
            this.opn_Files = new System.Windows.Forms.OpenFileDialog();
            this.tsc_Main.BottomToolStripPanel.SuspendLayout();
            this.tsc_Main.ContentPanel.SuspendLayout();
            this.tsc_Main.TopToolStripPanel.SuspendLayout();
            this.tsc_Main.SuspendLayout();
            this.sts_Main.SuspendLayout();
            this.grp_QuickSettings.SuspendLayout();
            this.grp_Output.SuspendLayout();
            this.grp_Files.SuspendLayout();
            this.ctx_Files.SuspendLayout();
            this.grp_Image.SuspendLayout();
            this.ctx_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Image)).BeginInit();
            this.ctx_Toolbars.SuspendLayout();
            this.mnu_Main.SuspendLayout();
            this.tlb_Main.SuspendLayout();
            this.tlb_Archive.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsc_Main
            // 
            // 
            // tsc_Main.BottomToolStripPanel
            // 
            this.tsc_Main.BottomToolStripPanel.Controls.Add(this.sts_Main);
            this.tsc_Main.BottomToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // tsc_Main.ContentPanel
            // 
            this.tsc_Main.ContentPanel.AutoScroll = true;
            this.tsc_Main.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tsc_Main.ContentPanel.Controls.Add(this.grp_QuickSettings);
            this.tsc_Main.ContentPanel.Controls.Add(this.btn_Start);
            this.tsc_Main.ContentPanel.Controls.Add(this.grp_Output);
            this.tsc_Main.ContentPanel.Controls.Add(this.grp_Files);
            this.tsc_Main.ContentPanel.Controls.Add(this.grp_Image);
            this.tsc_Main.ContentPanel.Controls.Add(this.btn_Stop);
            this.tsc_Main.ContentPanel.Size = new System.Drawing.Size(756, 374);
            this.tsc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc_Main.LeftToolStripPanelVisible = false;
            this.tsc_Main.Location = new System.Drawing.Point(0, 0);
            this.tsc_Main.Name = "tsc_Main";
            this.tsc_Main.RightToolStripPanelVisible = false;
            this.tsc_Main.Size = new System.Drawing.Size(756, 445);
            this.tsc_Main.TabIndex = 1;
            this.tsc_Main.Text = "toolStripContainer1";
            // 
            // tsc_Main.TopToolStripPanel
            // 
            this.tsc_Main.TopToolStripPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tsc_Main.TopToolStripPanel.ContextMenuStrip = this.ctx_Toolbars;
            this.tsc_Main.TopToolStripPanel.Controls.Add(this.mnu_Main);
            this.tsc_Main.TopToolStripPanel.Controls.Add(this.tlb_Main);
            this.tsc_Main.TopToolStripPanel.Controls.Add(this.tlb_Archive);
            this.tsc_Main.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(-3, 0, 0, 0);
            this.tsc_Main.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // sts_Main
            // 
            this.sts_Main.BackColor = System.Drawing.SystemColors.Control;
            this.sts_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.sts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status,
            this.sts_Main_Seperator,
            this.lbl_TotalSize,
            this.lbl_ArchiveSize});
            this.sts_Main.Location = new System.Drawing.Point(0, 0);
            this.sts_Main.Name = "sts_Main";
            this.sts_Main.Size = new System.Drawing.Size(756, 22);
            this.sts_Main.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(48, 17);
            this.lbl_Status.Text = "Status...";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sts_Main_Seperator
            // 
            this.sts_Main_Seperator.Name = "sts_Main_Seperator";
            this.sts_Main_Seperator.Size = new System.Drawing.Size(575, 17);
            this.sts_Main_Seperator.Spring = true;
            this.sts_Main_Seperator.Text = "|- Separator -|";
            // 
            // lbl_TotalSize
            // 
            this.lbl_TotalSize.Name = "lbl_TotalSize";
            this.lbl_TotalSize.Size = new System.Drawing.Size(118, 17);
            this.lbl_TotalSize.Text = "Total File Size (units):";
            this.lbl_TotalSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ArchiveSize
            // 
            this.lbl_ArchiveSize.Enabled = false;
            this.lbl_ArchiveSize.Name = "lbl_ArchiveSize";
            this.lbl_ArchiveSize.Size = new System.Drawing.Size(119, 17);
            this.lbl_ArchiveSize.Text = "Est. Archive Size (KB):";
            this.lbl_ArchiveSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_ArchiveSize.Visible = false;
            // 
            // grp_QuickSettings
            // 
            this.grp_QuickSettings.Controls.Add(this.chk_OpenComplete);
            this.grp_QuickSettings.Controls.Add(this.chk_Encryption);
            this.grp_QuickSettings.Location = new System.Drawing.Point(12, 204);
            this.grp_QuickSettings.Name = "grp_QuickSettings";
            this.grp_QuickSettings.Size = new System.Drawing.Size(168, 99);
            this.grp_QuickSettings.TabIndex = 2;
            this.grp_QuickSettings.TabStop = false;
            this.grp_QuickSettings.Text = "Quick Settings";
            // 
            // chk_OpenComplete
            // 
            this.chk_OpenComplete.AutoSize = true;
            this.chk_OpenComplete.Location = new System.Drawing.Point(6, 42);
            this.chk_OpenComplete.Name = "chk_OpenComplete";
            this.chk_OpenComplete.Size = new System.Drawing.Size(121, 17);
            this.chk_OpenComplete.TabIndex = 3;
            this.chk_OpenComplete.Text = "Open on completion";
            this.chk_OpenComplete.UseVisualStyleBackColor = true;
            // 
            // chk_Encryption
            // 
            this.chk_Encryption.AutoSize = true;
            this.chk_Encryption.Location = new System.Drawing.Point(6, 19);
            this.chk_Encryption.Name = "chk_Encryption";
            this.chk_Encryption.Size = new System.Drawing.Size(97, 17);
            this.chk_Encryption.TabIndex = 2;
            this.chk_Encryption.Text = "Use encryption";
            this.chk_Encryption.UseVisualStyleBackColor = true;
            this.chk_Encryption.CheckedChanged += new System.EventHandler(this.chk_Encryption_CheckedChanged);
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Start.Location = new System.Drawing.Point(554, 330);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(186, 32);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // grp_Output
            // 
            this.grp_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Output.Controls.Add(this.btn_Output);
            this.grp_Output.Controls.Add(this.txt_Output);
            this.grp_Output.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp_Output.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Output.Location = new System.Drawing.Point(10, 314);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(538, 54);
            this.grp_Output.TabIndex = 6;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output File";
            // 
            // btn_Output
            // 
            this.btn_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Output.Location = new System.Drawing.Point(408, 19);
            this.btn_Output.Name = "btn_Output";
            this.btn_Output.Size = new System.Drawing.Size(120, 26);
            this.btn_Output.TabIndex = 1;
            this.btn_Output.Text = "Browse...";
            this.btn_Output.UseVisualStyleBackColor = true;
            this.btn_Output.Click += new System.EventHandler(this.btn_Output_Click);
            // 
            // txt_Output
            // 
            this.txt_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Output.Location = new System.Drawing.Point(6, 22);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.Size = new System.Drawing.Size(396, 20);
            this.txt_Output.TabIndex = 0;
            // 
            // grp_Files
            // 
            this.grp_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Files.ContextMenuStrip = this.ctx_Files;
            this.grp_Files.Controls.Add(this.lst_Files);
            this.grp_Files.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp_Files.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Files.Location = new System.Drawing.Point(186, 14);
            this.grp_Files.Name = "grp_Files";
            this.grp_Files.Size = new System.Drawing.Size(560, 289);
            this.grp_Files.TabIndex = 4;
            this.grp_Files.TabStop = false;
            this.grp_Files.Text = "Files to Compress";
            // 
            // ctx_Files
            // 
            this.ctx_Files.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_Files_AddFiles,
            this.ctx_Files_Remove,
            this.ctx_Files_RemoveAll,
            this.ctx_Files_Check,
            this.ctx_Files_Uncheck,
            this.ctx_Files_Invert});
            this.ctx_Files.Name = "ctx_Files";
            this.ctx_Files.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctx_Files.Size = new System.Drawing.Size(156, 136);
            // 
            // ctx_Files_AddFiles
            // 
            this.ctx_Files_AddFiles.Image = global::Stealth_Compressor.Properties.Resources.AddFiles;
            this.ctx_Files_AddFiles.Name = "ctx_Files_AddFiles";
            this.ctx_Files_AddFiles.Size = new System.Drawing.Size(155, 22);
            this.ctx_Files_AddFiles.Text = "Add Files";
            this.ctx_Files_AddFiles.Click += new System.EventHandler(this.ctx_Files_AddFiles_Click);
            // 
            // ctx_Files_Remove
            // 
            this.ctx_Files_Remove.Image = global::Stealth_Compressor.Properties.Resources.RemoveFiles;
            this.ctx_Files_Remove.Name = "ctx_Files_Remove";
            this.ctx_Files_Remove.Size = new System.Drawing.Size(155, 22);
            this.ctx_Files_Remove.Text = "Remove";
            this.ctx_Files_Remove.Click += new System.EventHandler(this.ctx_Files_Remove_Click);
            // 
            // ctx_Files_RemoveAll
            // 
            this.ctx_Files_RemoveAll.Image = global::Stealth_Compressor.Properties.Resources.RemoveAll;
            this.ctx_Files_RemoveAll.Name = "ctx_Files_RemoveAll";
            this.ctx_Files_RemoveAll.Size = new System.Drawing.Size(155, 22);
            this.ctx_Files_RemoveAll.Text = "Remove All";
            this.ctx_Files_RemoveAll.Click += new System.EventHandler(this.ctx_Files_RemoveAll_Click);
            // 
            // ctx_Files_Check
            // 
            this.ctx_Files_Check.Image = global::Stealth_Compressor.Properties.Resources.Check;
            this.ctx_Files_Check.Name = "ctx_Files_Check";
            this.ctx_Files_Check.Size = new System.Drawing.Size(155, 22);
            this.ctx_Files_Check.Text = "Check";
            this.ctx_Files_Check.Click += new System.EventHandler(this.ctx_Files_Check_Click);
            // 
            // ctx_Files_Uncheck
            // 
            this.ctx_Files_Uncheck.Image = global::Stealth_Compressor.Properties.Resources.Uncheck;
            this.ctx_Files_Uncheck.Name = "ctx_Files_Uncheck";
            this.ctx_Files_Uncheck.Size = new System.Drawing.Size(155, 22);
            this.ctx_Files_Uncheck.Text = "Un-Check";
            this.ctx_Files_Uncheck.Click += new System.EventHandler(this.ctx_Files_Uncheck_Click);
            // 
            // ctx_Files_Invert
            // 
            this.ctx_Files_Invert.Image = global::Stealth_Compressor.Properties.Resources.InvertSelection;
            this.ctx_Files_Invert.Name = "ctx_Files_Invert";
            this.ctx_Files_Invert.Size = new System.Drawing.Size(155, 22);
            this.ctx_Files_Invert.Text = "Invert Selection";
            this.ctx_Files_Invert.Click += new System.EventHandler(this.ctx_Files_Invert_Click);
            // 
            // lst_Files
            // 
            this.lst_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Files.CheckBoxes = true;
            this.lst_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lst_Files_Name,
            this.lst_Files_Path,
            this.lst_Files_Size});
            this.lst_Files.ContextMenuStrip = this.ctx_Files;
            this.lst_Files.FullRowSelect = true;
            this.lst_Files.GridLines = true;
            this.lst_Files.Location = new System.Drawing.Point(6, 22);
            this.lst_Files.Name = "lst_Files";
            this.lst_Files.Size = new System.Drawing.Size(548, 261);
            this.lst_Files.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lst_Files.TabIndex = 0;
            this.lst_Files.UseCompatibleStateImageBehavior = false;
            this.lst_Files.View = System.Windows.Forms.View.Details;
            this.lst_Files.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lst_Files_ColumnClick);
            this.lst_Files.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lst_Files_ColumnWidthChanged);
            this.lst_Files.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lst_Files_ItemChecked);
            // 
            // lst_Files_Name
            // 
            this.lst_Files_Name.Text = "Name";
            this.lst_Files_Name.Width = 165;
            // 
            // lst_Files_Path
            // 
            this.lst_Files_Path.Text = "Path";
            this.lst_Files_Path.Width = 290;
            // 
            // lst_Files_Size
            // 
            this.lst_Files_Size.Text = "File Size (un)";
            this.lst_Files_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lst_Files_Size.Width = 84;
            // 
            // grp_Image
            // 
            this.grp_Image.ContextMenuStrip = this.ctx_Image;
            this.grp_Image.Controls.Add(this.lbl_ImgSize);
            this.grp_Image.Controls.Add(this.lbl_Image);
            this.grp_Image.Controls.Add(this.img_Image);
            this.grp_Image.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp_Image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Image.Location = new System.Drawing.Point(12, 14);
            this.grp_Image.Name = "grp_Image";
            this.grp_Image.Size = new System.Drawing.Size(168, 184);
            this.grp_Image.TabIndex = 3;
            this.grp_Image.TabStop = false;
            this.grp_Image.Text = "Image: <None>";
            // 
            // ctx_Image
            // 
            this.ctx_Image.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_Image_AddImage});
            this.ctx_Image.Name = "ctx_Image";
            this.ctx_Image.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctx_Image.Size = new System.Drawing.Size(133, 26);
            // 
            // ctx_Image_AddImage
            // 
            this.ctx_Image_AddImage.Image = global::Stealth_Compressor.Properties.Resources.AddImage;
            this.ctx_Image_AddImage.Name = "ctx_Image_AddImage";
            this.ctx_Image_AddImage.Size = new System.Drawing.Size(132, 22);
            this.ctx_Image_AddImage.Text = "Add Image";
            this.ctx_Image_AddImage.Click += new System.EventHandler(this.ctx_Image_AddImage_Click);
            // 
            // lbl_ImgSize
            // 
            this.lbl_ImgSize.AutoSize = true;
            this.lbl_ImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImgSize.Location = new System.Drawing.Point(68, 172);
            this.lbl_ImgSize.Name = "lbl_ImgSize";
            this.lbl_ImgSize.Size = new System.Drawing.Size(32, 13);
            this.lbl_ImgSize.TabIndex = 1;
            this.lbl_ImgSize.Text = "h x w";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.ContextMenuStrip = this.ctx_Image;
            this.lbl_Image.Location = new System.Drawing.Point(22, 90);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(124, 13);
            this.lbl_Image.TabIndex = 1;
            this.lbl_Image.Text = "Right-Click to Add Image";
            this.lbl_Image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_Image
            // 
            this.img_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_Image.ContextMenuStrip = this.ctx_Image;
            this.img_Image.InitialImage = null;
            this.img_Image.Location = new System.Drawing.Point(6, 22);
            this.img_Image.Name = "img_Image";
            this.img_Image.Size = new System.Drawing.Size(156, 156);
            this.img_Image.TabIndex = 0;
            this.img_Image.TabStop = false;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Stop.Location = new System.Drawing.Point(554, 330);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(186, 32);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // ctx_Toolbars
            // 
            this.ctx_Toolbars.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_Toolbars_Main,
            this.ctx_Toolbars_Archive});
            this.ctx_Toolbars.Name = "ctx_Toolbars";
            this.ctx_Toolbars.Size = new System.Drawing.Size(115, 48);
            // 
            // ctx_Toolbars_Main
            // 
            this.ctx_Toolbars_Main.Checked = true;
            this.ctx_Toolbars_Main.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctx_Toolbars_Main.Name = "ctx_Toolbars_Main";
            this.ctx_Toolbars_Main.Size = new System.Drawing.Size(114, 22);
            this.ctx_Toolbars_Main.Text = "Main";
            this.ctx_Toolbars_Main.CheckedChanged += new System.EventHandler(this.ctx_Toolbars_Main_CheckedChanged);
            this.ctx_Toolbars_Main.Click += new System.EventHandler(this.ctx_Toolbars_Main_Click);
            // 
            // ctx_Toolbars_Archive
            // 
            this.ctx_Toolbars_Archive.Checked = true;
            this.ctx_Toolbars_Archive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ctx_Toolbars_Archive.Name = "ctx_Toolbars_Archive";
            this.ctx_Toolbars_Archive.Size = new System.Drawing.Size(114, 22);
            this.ctx_Toolbars_Archive.Text = "Archive";
            this.ctx_Toolbars_Archive.CheckedChanged += new System.EventHandler(this.ctx_Toolbars_Archive_CheckedChanged);
            this.ctx_Toolbars_Archive.Click += new System.EventHandler(this.ctx_Toolbars_Archive_Click);
            // 
            // mnu_Main
            // 
            this.mnu_Main.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mnu_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.mnu_Tools,
            this.mnu_Help});
            this.mnu_Main.Location = new System.Drawing.Point(0, 0);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnu_Main.Size = new System.Drawing.Size(756, 24);
            this.mnu_Main.TabIndex = 0;
            this.mnu_Main.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File_New,
            this.mnu_File_Open,
            this.mnu_File_Save,
            this.mnu_File_Exit});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.Size = new System.Drawing.Size(37, 20);
            this.mnu_File.Text = "&File";
            // 
            // mnu_File_New
            // 
            this.mnu_File_New.Image = global::Stealth_Compressor.Properties.Resources.NewWindow;
            this.mnu_File_New.Name = "mnu_File_New";
            this.mnu_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnu_File_New.Size = new System.Drawing.Size(146, 22);
            this.mnu_File_New.Text = "&New";
            this.mnu_File_New.Click += new System.EventHandler(this.mnu_File_New_Click);
            // 
            // mnu_File_Open
            // 
            this.mnu_File_Open.Image = global::Stealth_Compressor.Properties.Resources.Open;
            this.mnu_File_Open.Name = "mnu_File_Open";
            this.mnu_File_Open.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnu_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnu_File_Open.Size = new System.Drawing.Size(146, 22);
            this.mnu_File_Open.Text = "&Open";
            this.mnu_File_Open.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_File_Open.Click += new System.EventHandler(this.mnu_File_Open_Click);
            // 
            // mnu_File_Save
            // 
            this.mnu_File_Save.Image = global::Stealth_Compressor.Properties.Resources.Save;
            this.mnu_File_Save.Name = "mnu_File_Save";
            this.mnu_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnu_File_Save.Size = new System.Drawing.Size(146, 22);
            this.mnu_File_Save.Text = "&Save";
            this.mnu_File_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_File_Save.Click += new System.EventHandler(this.mnu_File_Save_Click);
            // 
            // mnu_File_Exit
            // 
            this.mnu_File_Exit.Name = "mnu_File_Exit";
            this.mnu_File_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnu_File_Exit.Size = new System.Drawing.Size(146, 22);
            this.mnu_File_Exit.Text = "&Exit";
            this.mnu_File_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnu_File_Exit.Click += new System.EventHandler(this.mnu_File_Exit_Click);
            // 
            // mnu_Tools
            // 
            this.mnu_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Tools_Shortcut,
            this.mnu_Tools_Settings,
            this.mnu_Tools_Compression});
            this.mnu_Tools.Name = "mnu_Tools";
            this.mnu_Tools.Size = new System.Drawing.Size(48, 20);
            this.mnu_Tools.Text = "&Tools";
            // 
            // mnu_Tools_Shortcut
            // 
            this.mnu_Tools_Shortcut.Name = "mnu_Tools_Shortcut";
            this.mnu_Tools_Shortcut.Size = new System.Drawing.Size(176, 22);
            this.mnu_Tools_Shortcut.Text = "Create Shortcut";
            this.mnu_Tools_Shortcut.Click += new System.EventHandler(this.mnu_Tools_Shortcut_Click);
            // 
            // mnu_Tools_Settings
            // 
            this.mnu_Tools_Settings.Image = global::Stealth_Compressor.Properties.Resources.Gear;
            this.mnu_Tools_Settings.Name = "mnu_Tools_Settings";
            this.mnu_Tools_Settings.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnu_Tools_Settings.Size = new System.Drawing.Size(176, 22);
            this.mnu_Tools_Settings.Text = "&Settings...";
            this.mnu_Tools_Settings.Click += new System.EventHandler(this.mnu_Tools_Settings_Click);
            // 
            // mnu_Tools_Compression
            // 
            this.mnu_Tools_Compression.Image = global::Stealth_Compressor.Properties.Resources.WinZip_icon;
            this.mnu_Tools_Compression.Name = "mnu_Tools_Compression";
            this.mnu_Tools_Compression.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.mnu_Tools_Compression.Size = new System.Drawing.Size(176, 22);
            this.mnu_Tools_Compression.Text = "&Configuration...";
            this.mnu_Tools_Compression.Click += new System.EventHandler(this.mnu_Tools_Configuration_Click);
            // 
            // mnu_Help
            // 
            this.mnu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Help_ViewHelp,
            this.mnu_Help_About});
            this.mnu_Help.Name = "mnu_Help";
            this.mnu_Help.Size = new System.Drawing.Size(44, 20);
            this.mnu_Help.Text = "&Help";
            // 
            // mnu_Help_ViewHelp
            // 
            this.mnu_Help_ViewHelp.Image = global::Stealth_Compressor.Properties.Resources.Help;
            this.mnu_Help_ViewHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_Help_ViewHelp.Name = "mnu_Help_ViewHelp";
            this.mnu_Help_ViewHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnu_Help_ViewHelp.Size = new System.Drawing.Size(213, 22);
            this.mnu_Help_ViewHelp.Text = "View Help";
            this.mnu_Help_ViewHelp.Click += new System.EventHandler(this.mnu_Help_ViewHelp_Click);
            // 
            // mnu_Help_About
            // 
            this.mnu_Help_About.Image = global::Stealth_Compressor.Properties.Resources.About;
            this.mnu_Help_About.Name = "mnu_Help_About";
            this.mnu_Help_About.Size = new System.Drawing.Size(213, 22);
            this.mnu_Help_About.Text = "About Stealth Compressor";
            this.mnu_Help_About.Click += new System.EventHandler(this.mnu_Help_About_Click);
            // 
            // tlb_Main
            // 
            this.tlb_Main.BackColor = System.Drawing.SystemColors.Control;
            this.tlb_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.tlb_Main.GripMargin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.tlb_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlb_Main_New,
            this.tlb_Main_Open,
            this.tlb_Main_Save,
            this.tlb_Main_Sep1,
            this.tlb_Main_AddImage,
            this.tlb_Main_AddFiles,
            this.tlb_Main_Remove,
            this.tlb_Main_RemoveAll,
            this.tlb_Main_Sep2,
            this.tlb_Main_Check,
            this.tlb_Main_Uncheck,
            this.tlb_Main_Invert});
            this.tlb_Main.Location = new System.Drawing.Point(3, 24);
            this.tlb_Main.Name = "tlb_Main";
            this.tlb_Main.Padding = new System.Windows.Forms.Padding(0);
            this.tlb_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlb_Main.Size = new System.Drawing.Size(251, 25);
            this.tlb_Main.TabIndex = 2;
            this.tlb_Main.Text = "Main Toolbar";
            // 
            // tlb_Main_New
            // 
            this.tlb_Main_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_New.Image = global::Stealth_Compressor.Properties.Resources.NewWindow;
            this.tlb_Main_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_New.Name = "tlb_Main_New";
            this.tlb_Main_New.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_New.Text = "New Session";
            this.tlb_Main_New.Click += new System.EventHandler(this.tlb_Main_New_Click);
            // 
            // tlb_Main_Open
            // 
            this.tlb_Main_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_Open.Image = global::Stealth_Compressor.Properties.Resources.Open;
            this.tlb_Main_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_Open.Name = "tlb_Main_Open";
            this.tlb_Main_Open.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_Open.Text = "Open Session";
            this.tlb_Main_Open.Click += new System.EventHandler(this.tlb_Main_Open_Click);
            // 
            // tlb_Main_Save
            // 
            this.tlb_Main_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_Save.Image = global::Stealth_Compressor.Properties.Resources.Save;
            this.tlb_Main_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_Save.Name = "tlb_Main_Save";
            this.tlb_Main_Save.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_Save.Text = "Save Session";
            this.tlb_Main_Save.Click += new System.EventHandler(this.tlb_Main_Save_Click);
            // 
            // tlb_Main_Sep1
            // 
            this.tlb_Main_Sep1.Name = "tlb_Main_Sep1";
            this.tlb_Main_Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlb_Main_AddImage
            // 
            this.tlb_Main_AddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_AddImage.Image = global::Stealth_Compressor.Properties.Resources.AddImage;
            this.tlb_Main_AddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_AddImage.Margin = new System.Windows.Forms.Padding(0, 1, 0, 4);
            this.tlb_Main_AddImage.Name = "tlb_Main_AddImage";
            this.tlb_Main_AddImage.Size = new System.Drawing.Size(23, 20);
            this.tlb_Main_AddImage.Text = "Add Image";
            this.tlb_Main_AddImage.Click += new System.EventHandler(this.tlb_Main_AddImage_Click);
            // 
            // tlb_Main_AddFiles
            // 
            this.tlb_Main_AddFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_AddFiles.Image = global::Stealth_Compressor.Properties.Resources.AddFiles;
            this.tlb_Main_AddFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_AddFiles.Name = "tlb_Main_AddFiles";
            this.tlb_Main_AddFiles.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_AddFiles.Text = "Add Files";
            this.tlb_Main_AddFiles.Click += new System.EventHandler(this.tlb_Main_AddFiles_Click);
            // 
            // tlb_Main_Remove
            // 
            this.tlb_Main_Remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_Remove.Image = global::Stealth_Compressor.Properties.Resources.RemoveFiles;
            this.tlb_Main_Remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_Remove.Name = "tlb_Main_Remove";
            this.tlb_Main_Remove.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_Remove.Text = "Remove Selected";
            this.tlb_Main_Remove.Click += new System.EventHandler(this.tlb_Main_Remove_Click);
            // 
            // tlb_Main_RemoveAll
            // 
            this.tlb_Main_RemoveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_RemoveAll.Image = global::Stealth_Compressor.Properties.Resources.RemoveAll;
            this.tlb_Main_RemoveAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlb_Main_RemoveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_RemoveAll.Name = "tlb_Main_RemoveAll";
            this.tlb_Main_RemoveAll.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_RemoveAll.Text = "Remove All";
            this.tlb_Main_RemoveAll.Click += new System.EventHandler(this.tlb_Main_RemoveAll_Click);
            // 
            // tlb_Main_Sep2
            // 
            this.tlb_Main_Sep2.Name = "tlb_Main_Sep2";
            this.tlb_Main_Sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // tlb_Main_Check
            // 
            this.tlb_Main_Check.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_Check.Image = global::Stealth_Compressor.Properties.Resources.Check;
            this.tlb_Main_Check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_Check.Name = "tlb_Main_Check";
            this.tlb_Main_Check.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_Check.Text = "Check";
            this.tlb_Main_Check.Click += new System.EventHandler(this.tlb_Main_Check_Click);
            // 
            // tlb_Main_Uncheck
            // 
            this.tlb_Main_Uncheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_Uncheck.Image = global::Stealth_Compressor.Properties.Resources.Uncheck;
            this.tlb_Main_Uncheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_Uncheck.Name = "tlb_Main_Uncheck";
            this.tlb_Main_Uncheck.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_Uncheck.Text = "Un-Check";
            this.tlb_Main_Uncheck.Click += new System.EventHandler(this.tlb_Main_Uncheck_Click);
            // 
            // tlb_Main_Invert
            // 
            this.tlb_Main_Invert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Main_Invert.Image = global::Stealth_Compressor.Properties.Resources.InvertSelection;
            this.tlb_Main_Invert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Main_Invert.Name = "tlb_Main_Invert";
            this.tlb_Main_Invert.Size = new System.Drawing.Size(23, 22);
            this.tlb_Main_Invert.Text = "Invert Selection";
            this.tlb_Main_Invert.Click += new System.EventHandler(this.tlb_Main_Invert_Click);
            // 
            // tlb_Archive
            // 
            this.tlb_Archive.BackColor = System.Drawing.SystemColors.Control;
            this.tlb_Archive.Dock = System.Windows.Forms.DockStyle.None;
            this.tlb_Archive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlb_Archive_Start,
            this.tlb_Archive_Stop,
            this.toolStripSeparator1,
            this.tlb_Archive_Decloak});
            this.tlb_Archive.Location = new System.Drawing.Point(255, 24);
            this.tlb_Archive.Name = "tlb_Archive";
            this.tlb_Archive.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlb_Archive.Size = new System.Drawing.Size(87, 25);
            this.tlb_Archive.TabIndex = 3;
            // 
            // tlb_Archive_Start
            // 
            this.tlb_Archive_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Archive_Start.Image = global::Stealth_Compressor.Properties.Resources.Run;
            this.tlb_Archive_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Archive_Start.Name = "tlb_Archive_Start";
            this.tlb_Archive_Start.Size = new System.Drawing.Size(23, 22);
            this.tlb_Archive_Start.Text = "Start";
            // 
            // tlb_Archive_Stop
            // 
            this.tlb_Archive_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Archive_Stop.Image = global::Stealth_Compressor.Properties.Resources.Stop;
            this.tlb_Archive_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Archive_Stop.Name = "tlb_Archive_Stop";
            this.tlb_Archive_Stop.Size = new System.Drawing.Size(23, 22);
            this.tlb_Archive_Stop.Text = "Stop";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tlb_Archive_Decloak
            // 
            this.tlb_Archive_Decloak.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlb_Archive_Decloak.Image = ((System.Drawing.Image)(resources.GetObject("tlb_Archive_Decloak.Image")));
            this.tlb_Archive_Decloak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlb_Archive_Decloak.Name = "tlb_Archive_Decloak";
            this.tlb_Archive_Decloak.Size = new System.Drawing.Size(23, 22);
            this.tlb_Archive_Decloak.Text = "De-Cloak";
            this.tlb_Archive_Decloak.Click += new System.EventHandler(this.tlb_Archive_Decloak_Click);
            // 
            // ctx_Main_AddImage
            // 
            this.ctx_Main_AddImage.Name = "ctx_Main_AddImage";
            this.ctx_Main_AddImage.Size = new System.Drawing.Size(152, 22);
            this.ctx_Main_AddImage.Text = "Add Image";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 445);
            this.Controls.Add(this.tsc_Main);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu_Main;
            this.MinimumSize = new System.Drawing.Size(550, 472);
            this.Name = "MainForm";
            this.Text = "Stealth Compressor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tsc_Main.BottomToolStripPanel.ResumeLayout(false);
            this.tsc_Main.BottomToolStripPanel.PerformLayout();
            this.tsc_Main.ContentPanel.ResumeLayout(false);
            this.tsc_Main.TopToolStripPanel.ResumeLayout(false);
            this.tsc_Main.TopToolStripPanel.PerformLayout();
            this.tsc_Main.ResumeLayout(false);
            this.tsc_Main.PerformLayout();
            this.sts_Main.ResumeLayout(false);
            this.sts_Main.PerformLayout();
            this.grp_QuickSettings.ResumeLayout(false);
            this.grp_QuickSettings.PerformLayout();
            this.grp_Output.ResumeLayout(false);
            this.grp_Output.PerformLayout();
            this.grp_Files.ResumeLayout(false);
            this.ctx_Files.ResumeLayout(false);
            this.grp_Image.ResumeLayout(false);
            this.grp_Image.PerformLayout();
            this.ctx_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_Image)).EndInit();
            this.ctx_Toolbars.ResumeLayout(false);
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            this.tlb_Main.ResumeLayout(false);
            this.tlb_Main.PerformLayout();
            this.tlb_Archive.ResumeLayout(false);
            this.tlb_Archive.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ToolStripContainer tsc_Main;
        private System.Windows.Forms.MenuStrip mnu_Main;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnu_Tools;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help;
        private System.Windows.Forms.ToolStrip tlb_Main;
        private System.Windows.Forms.GroupBox grp_Image;
        private System.Windows.Forms.PictureBox img_Image;
        private System.Windows.Forms.GroupBox grp_Files;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.SaveFileDialog sav_Output;
        private System.Windows.Forms.OpenFileDialog opn_Image;
        private System.Windows.Forms.Button btn_Output;
        private System.Windows.Forms.ListView lst_Files;
        private System.Windows.Forms.ColumnHeader lst_Files_Name;
        private System.Windows.Forms.ColumnHeader lst_Files_Path;
        private System.Windows.Forms.ToolStripButton tlb_Main_Open;
        private System.Windows.Forms.ToolStripButton tlb_Main_Save;
        private System.Windows.Forms.ToolStripSeparator tlb_Main_Sep1;
        private System.Windows.Forms.ToolStripButton tlb_Main_AddImage;
        private System.Windows.Forms.ToolStripButton tlb_Main_AddFiles;
        private System.Windows.Forms.ToolStripButton tlb_Main_Remove;
        private System.Windows.Forms.ToolStripButton tlb_Main_RemoveAll;
        private System.Windows.Forms.ToolStripSeparator tlb_Main_Sep2;
        private System.Windows.Forms.ToolStripButton tlb_Main_Check;
        private System.Windows.Forms.ToolStripButton tlb_Main_Uncheck;
        private System.Windows.Forms.ToolStripButton tlb_Main_Invert;
        private System.Windows.Forms.ContextMenuStrip ctx_Image;
        private System.Windows.Forms.ToolStripMenuItem ctx_Main_AddImage;
        private System.Windows.Forms.ContextMenuStrip ctx_Files;
        private System.Windows.Forms.ToolStripMenuItem ctx_Files_AddFiles;
        private System.Windows.Forms.ToolStripMenuItem ctx_Files_Remove;
        private System.Windows.Forms.ToolStripMenuItem ctx_Files_RemoveAll;
        private System.Windows.Forms.ToolStripMenuItem ctx_Files_Check;
        private System.Windows.Forms.ToolStripMenuItem ctx_Files_Uncheck;
        private System.Windows.Forms.ToolStripMenuItem ctx_Files_Invert;
        private System.Windows.Forms.ToolStripMenuItem ctx_Image_AddImage;
        private System.Windows.Forms.OpenFileDialog opn_Files;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Open;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem mnu_Tools_Settings;
        private System.Windows.Forms.ToolStripMenuItem mnu_Tools_Compression;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help_ViewHelp;
        private System.Windows.Forms.ToolStripMenuItem mnu_Help_About;
        private System.Windows.Forms.ToolStripMenuItem mnu_Tools_Shortcut;
        private System.Windows.Forms.StatusStrip sts_Main;
        private System.Windows.Forms.ColumnHeader lst_Files_Size;
        private System.Windows.Forms.GroupBox grp_QuickSettings;
        private System.Windows.Forms.Label lbl_ImgSize;
        private System.Windows.Forms.CheckBox chk_Encryption;
        private System.Windows.Forms.ToolStripStatusLabel lbl_ArchiveSize;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.ToolStripStatusLabel sts_Main_Seperator;
        private System.Windows.Forms.ToolStripStatusLabel lbl_TotalSize;
        private System.Windows.Forms.ToolStripButton tlb_Main_New;
        private System.Windows.Forms.ToolStripMenuItem mnu_File_New;
        private System.Windows.Forms.CheckBox chk_OpenComplete;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.ToolStrip tlb_Archive;
        private System.Windows.Forms.ToolStripButton tlb_Archive_Decloak;
        private System.Windows.Forms.ContextMenuStrip ctx_Toolbars;
        private System.Windows.Forms.ToolStripMenuItem ctx_Toolbars_Main;
        private System.Windows.Forms.ToolStripMenuItem ctx_Toolbars_Archive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlb_Archive_Start;
        private System.Windows.Forms.ToolStripButton tlb_Archive_Stop;
    }
}

