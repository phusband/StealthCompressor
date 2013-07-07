namespace Stealth_Compressor
{
    partial class ArchiveSettingsForm
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
            this.txt_BufferIO = new System.Windows.Forms.TextBox();
            this.txt_BufferCodec = new System.Windows.Forms.TextBox();
            this.lbl_BufferCodec = new System.Windows.Forms.Label();
            this.grp_Buffer = new System.Windows.Forms.GroupBox();
            this.lbl_BufferIO = new System.Windows.Forms.Label();
            this.chk_openComplete = new System.Windows.Forms.CheckBox();
            this.chk_alert = new System.Windows.Forms.CheckBox();
            this.lbl_64bit = new System.Windows.Forms.Label();
            this.grp_Options = new System.Windows.Forms.GroupBox();
            this.txt_64Bit = new System.Windows.Forms.ComboBox();
            this.chk_useMemory = new System.Windows.Forms.CheckBox();
            this.tab_Archive = new System.Windows.Forms.TabPage();
            this.grp_Compression = new System.Windows.Forms.GroupBox();
            this.txt_Strategy = new System.Windows.Forms.ComboBox();
            this.lbl_Strategy = new System.Windows.Forms.Label();
            this.txt_Method = new System.Windows.Forms.ComboBox();
            this.lbl_Method = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_currentlevel = new System.Windows.Forms.Label();
            this.trk_CompressionLevel = new System.Windows.Forms.TrackBar();
            this.tab_Master = new System.Windows.Forms.TabControl();
            this.tab_Encryption = new System.Windows.Forms.TabPage();
            this.chk_UseEncryption = new System.Windows.Forms.CheckBox();
            this.grp_Password = new System.Windows.Forms.GroupBox();
            this.chk_CharMask = new System.Windows.Forms.CheckBox();
            this.chk_Symbol = new System.Windows.Forms.CheckBox();
            this.chk_Numeric = new System.Windows.Forms.CheckBox();
            this.chk_ucase = new System.Windows.Forms.CheckBox();
            this.chk_lcase = new System.Windows.Forms.CheckBox();
            this.chk_Validate = new System.Windows.Forms.CheckBox();
            this.lbl_PassChars = new System.Windows.Forms.Label();
            this.num_PassChar = new System.Windows.Forms.NumericUpDown();
            this.grp_Encryption = new System.Windows.Forms.GroupBox();
            this.txt_Algorithm = new System.Windows.Forms.ComboBox();
            this.lbl_Algorithm = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.grp_Buffer.SuspendLayout();
            this.grp_Options.SuspendLayout();
            this.tab_Archive.SuspendLayout();
            this.grp_Compression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_CompressionLevel)).BeginInit();
            this.tab_Master.SuspendLayout();
            this.tab_Encryption.SuspendLayout();
            this.grp_Password.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PassChar)).BeginInit();
            this.grp_Encryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BufferIO
            // 
            this.txt_BufferIO.Location = new System.Drawing.Point(9, 19);
            this.txt_BufferIO.Name = "txt_BufferIO";
            this.txt_BufferIO.Size = new System.Drawing.Size(57, 20);
            this.txt_BufferIO.TabIndex = 0;
            // 
            // txt_BufferCodec
            // 
            this.txt_BufferCodec.Location = new System.Drawing.Point(9, 45);
            this.txt_BufferCodec.Name = "txt_BufferCodec";
            this.txt_BufferCodec.Size = new System.Drawing.Size(57, 20);
            this.txt_BufferCodec.TabIndex = 2;
            // 
            // lbl_BufferCodec
            // 
            this.lbl_BufferCodec.AutoSize = true;
            this.lbl_BufferCodec.Location = new System.Drawing.Point(72, 48);
            this.lbl_BufferCodec.Name = "lbl_BufferCodec";
            this.lbl_BufferCodec.Size = new System.Drawing.Size(72, 13);
            this.lbl_BufferCodec.TabIndex = 3;
            this.lbl_BufferCodec.Text = " Codec Buffer";
            this.lbl_BufferCodec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grp_Buffer
            // 
            this.grp_Buffer.Controls.Add(this.lbl_BufferCodec);
            this.grp_Buffer.Controls.Add(this.txt_BufferCodec);
            this.grp_Buffer.Controls.Add(this.lbl_BufferIO);
            this.grp_Buffer.Controls.Add(this.txt_BufferIO);
            this.grp_Buffer.Location = new System.Drawing.Point(202, 7);
            this.grp_Buffer.Name = "grp_Buffer";
            this.grp_Buffer.Size = new System.Drawing.Size(160, 75);
            this.grp_Buffer.TabIndex = 1;
            this.grp_Buffer.TabStop = false;
            this.grp_Buffer.Text = "Buffer Sizes (bytes)";
            // 
            // lbl_BufferIO
            // 
            this.lbl_BufferIO.AutoSize = true;
            this.lbl_BufferIO.Location = new System.Drawing.Point(75, 22);
            this.lbl_BufferIO.Name = "lbl_BufferIO";
            this.lbl_BufferIO.Size = new System.Drawing.Size(49, 13);
            this.lbl_BufferIO.TabIndex = 1;
            this.lbl_BufferIO.Text = "IO Buffer";
            this.lbl_BufferIO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_openComplete
            // 
            this.chk_openComplete.AutoSize = true;
            this.chk_openComplete.Location = new System.Drawing.Point(7, 42);
            this.chk_openComplete.Name = "chk_openComplete";
            this.chk_openComplete.Size = new System.Drawing.Size(121, 17);
            this.chk_openComplete.TabIndex = 1;
            this.chk_openComplete.Text = "Open on completion";
            this.chk_openComplete.UseVisualStyleBackColor = true;
            // 
            // chk_alert
            // 
            this.chk_alert.AutoSize = true;
            this.chk_alert.Location = new System.Drawing.Point(7, 65);
            this.chk_alert.Name = "chk_alert";
            this.chk_alert.Size = new System.Drawing.Size(116, 17);
            this.chk_alert.TabIndex = 2;
            this.chk_alert.Text = "Alert on completion";
            this.chk_alert.UseVisualStyleBackColor = true;
            // 
            // lbl_64bit
            // 
            this.lbl_64bit.AutoSize = true;
            this.lbl_64bit.Location = new System.Drawing.Point(9, 94);
            this.lbl_64bit.Name = "lbl_64bit";
            this.lbl_64bit.Size = new System.Drawing.Size(83, 13);
            this.lbl_64bit.TabIndex = 3;
            this.lbl_64bit.Text = "64-bit Archiving:";
            // 
            // grp_Options
            // 
            this.grp_Options.Controls.Add(this.txt_64Bit);
            this.grp_Options.Controls.Add(this.lbl_64bit);
            this.grp_Options.Controls.Add(this.chk_alert);
            this.grp_Options.Controls.Add(this.chk_openComplete);
            this.grp_Options.Controls.Add(this.chk_useMemory);
            this.grp_Options.Location = new System.Drawing.Point(202, 88);
            this.grp_Options.Name = "grp_Options";
            this.grp_Options.Size = new System.Drawing.Size(160, 141);
            this.grp_Options.TabIndex = 2;
            this.grp_Options.TabStop = false;
            this.grp_Options.Text = "Archival Options";
            // 
            // txt_64Bit
            // 
            this.txt_64Bit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_64Bit.FormattingEnabled = true;
            this.txt_64Bit.Items.AddRange(new object[] {
            "Always",
            "Never",
            "As Needed"});
            this.txt_64Bit.Location = new System.Drawing.Point(12, 110);
            this.txt_64Bit.Name = "txt_64Bit";
            this.txt_64Bit.Size = new System.Drawing.Size(136, 21);
            this.txt_64Bit.TabIndex = 3;
            // 
            // chk_useMemory
            // 
            this.chk_useMemory.AutoSize = true;
            this.chk_useMemory.Location = new System.Drawing.Point(7, 19);
            this.chk_useMemory.Name = "chk_useMemory";
            this.chk_useMemory.Size = new System.Drawing.Size(101, 17);
            this.chk_useMemory.TabIndex = 0;
            this.chk_useMemory.Text = "Memory archive";
            this.chk_useMemory.UseVisualStyleBackColor = true;
            // 
            // tab_Archive
            // 
            this.tab_Archive.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Archive.Controls.Add(this.grp_Compression);
            this.tab_Archive.Controls.Add(this.grp_Options);
            this.tab_Archive.Controls.Add(this.grp_Buffer);
            this.tab_Archive.Location = new System.Drawing.Point(4, 22);
            this.tab_Archive.Name = "tab_Archive";
            this.tab_Archive.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Archive.Size = new System.Drawing.Size(377, 245);
            this.tab_Archive.TabIndex = 1;
            this.tab_Archive.Text = "Archive";
            // 
            // grp_Compression
            // 
            this.grp_Compression.BackColor = System.Drawing.Color.Transparent;
            this.grp_Compression.Controls.Add(this.txt_Strategy);
            this.grp_Compression.Controls.Add(this.lbl_Strategy);
            this.grp_Compression.Controls.Add(this.txt_Method);
            this.grp_Compression.Controls.Add(this.lbl_Method);
            this.grp_Compression.Controls.Add(this.lbl_level);
            this.grp_Compression.Controls.Add(this.lbl_currentlevel);
            this.grp_Compression.Controls.Add(this.trk_CompressionLevel);
            this.grp_Compression.Location = new System.Drawing.Point(10, 7);
            this.grp_Compression.Name = "grp_Compression";
            this.grp_Compression.Size = new System.Drawing.Size(180, 222);
            this.grp_Compression.TabIndex = 0;
            this.grp_Compression.TabStop = false;
            this.grp_Compression.Text = "Compression";
            // 
            // txt_Strategy
            // 
            this.txt_Strategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Strategy.FormattingEnabled = true;
            this.txt_Strategy.Items.AddRange(new object[] {
            "Default",
            "Filtered",
            "Huffman Only"});
            this.txt_Strategy.Location = new System.Drawing.Point(12, 192);
            this.txt_Strategy.Name = "txt_Strategy";
            this.txt_Strategy.Size = new System.Drawing.Size(153, 21);
            this.txt_Strategy.TabIndex = 6;
            // 
            // lbl_Strategy
            // 
            this.lbl_Strategy.AutoSize = true;
            this.lbl_Strategy.Location = new System.Drawing.Point(9, 175);
            this.lbl_Strategy.Name = "lbl_Strategy";
            this.lbl_Strategy.Size = new System.Drawing.Size(49, 13);
            this.lbl_Strategy.TabIndex = 5;
            this.lbl_Strategy.Text = "Strategy:";
            this.lbl_Strategy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Method
            // 
            this.txt_Method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Method.FormattingEnabled = true;
            this.txt_Method.Items.AddRange(new object[] {
            "Bzip2",
            "Deflate",
            "None"});
            this.txt_Method.Location = new System.Drawing.Point(12, 140);
            this.txt_Method.Name = "txt_Method";
            this.txt_Method.Size = new System.Drawing.Size(153, 21);
            this.txt_Method.TabIndex = 4;
            // 
            // lbl_Method
            // 
            this.lbl_Method.AutoSize = true;
            this.lbl_Method.Location = new System.Drawing.Point(9, 123);
            this.lbl_Method.Name = "lbl_Method";
            this.lbl_Method.Size = new System.Drawing.Size(46, 13);
            this.lbl_Method.TabIndex = 3;
            this.lbl_Method.Text = "Method:";
            this.lbl_Method.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Location = new System.Drawing.Point(12, 26);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(36, 13);
            this.lbl_level.TabIndex = 2;
            this.lbl_level.Text = "Level:";
            this.lbl_level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_currentlevel
            // 
            this.lbl_currentlevel.AutoSize = true;
            this.lbl_currentlevel.Location = new System.Drawing.Point(12, 81);
            this.lbl_currentlevel.Name = "lbl_currentlevel";
            this.lbl_currentlevel.Size = new System.Drawing.Size(33, 13);
            this.lbl_currentlevel.TabIndex = 1;
            this.lbl_currentlevel.Text = "None";
            this.lbl_currentlevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trk_CompressionLevel
            // 
            this.trk_CompressionLevel.BackColor = this.BackColor;
            this.trk_CompressionLevel.LargeChange = 3;
            this.trk_CompressionLevel.Location = new System.Drawing.Point(9, 44);
            this.trk_CompressionLevel.Maximum = 9;
            this.trk_CompressionLevel.Name = "trk_CompressionLevel";
            this.trk_CompressionLevel.Size = new System.Drawing.Size(156, 45);
            this.trk_CompressionLevel.TabIndex = 0;
            this.trk_CompressionLevel.ValueChanged += new System.EventHandler(this.trk_CompressionLevel_ValueChanged);
            // 
            // tab_Master
            // 
            this.tab_Master.Controls.Add(this.tab_Archive);
            this.tab_Master.Controls.Add(this.tab_Encryption);
            this.tab_Master.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab_Master.Location = new System.Drawing.Point(12, 12);
            this.tab_Master.Name = "tab_Master";
            this.tab_Master.SelectedIndex = 0;
            this.tab_Master.Size = new System.Drawing.Size(385, 271);
            this.tab_Master.TabIndex = 3;
            this.tab_Master.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ChangeTabColor);
            // 
            // tab_Encryption
            // 
            this.tab_Encryption.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Encryption.Controls.Add(this.chk_UseEncryption);
            this.tab_Encryption.Controls.Add(this.grp_Password);
            this.tab_Encryption.Controls.Add(this.grp_Encryption);
            this.tab_Encryption.Location = new System.Drawing.Point(4, 22);
            this.tab_Encryption.Name = "tab_Encryption";
            this.tab_Encryption.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Encryption.Size = new System.Drawing.Size(377, 245);
            this.tab_Encryption.TabIndex = 2;
            this.tab_Encryption.Text = "Encryption";
            // 
            // chk_UseEncryption
            // 
            this.chk_UseEncryption.AutoSize = true;
            this.chk_UseEncryption.Location = new System.Drawing.Point(223, 23);
            this.chk_UseEncryption.Name = "chk_UseEncryption";
            this.chk_UseEncryption.Size = new System.Drawing.Size(100, 17);
            this.chk_UseEncryption.TabIndex = 3;
            this.chk_UseEncryption.Text = "Encrypt archive";
            this.chk_UseEncryption.UseVisualStyleBackColor = true;
            // 
            // grp_Password
            // 
            this.grp_Password.Controls.Add(this.chk_CharMask);
            this.grp_Password.Controls.Add(this.chk_Symbol);
            this.grp_Password.Controls.Add(this.chk_Numeric);
            this.grp_Password.Controls.Add(this.chk_ucase);
            this.grp_Password.Controls.Add(this.chk_lcase);
            this.grp_Password.Controls.Add(this.chk_Validate);
            this.grp_Password.Controls.Add(this.lbl_PassChars);
            this.grp_Password.Controls.Add(this.num_PassChar);
            this.grp_Password.Location = new System.Drawing.Point(6, 6);
            this.grp_Password.Name = "grp_Password";
            this.grp_Password.Size = new System.Drawing.Size(195, 206);
            this.grp_Password.TabIndex = 2;
            this.grp_Password.TabStop = false;
            this.grp_Password.Text = "Password";
            // 
            // chk_CharMask
            // 
            this.chk_CharMask.AutoSize = true;
            this.chk_CharMask.Location = new System.Drawing.Point(6, 55);
            this.chk_CharMask.Name = "chk_CharMask";
            this.chk_CharMask.Size = new System.Drawing.Size(122, 17);
            this.chk_CharMask.TabIndex = 8;
            this.chk_CharMask.Text = "Hide character input";
            this.chk_CharMask.UseVisualStyleBackColor = true;
            // 
            // chk_Symbol
            // 
            this.chk_Symbol.AutoSize = true;
            this.chk_Symbol.Location = new System.Drawing.Point(6, 170);
            this.chk_Symbol.Name = "chk_Symbol";
            this.chk_Symbol.Size = new System.Drawing.Size(165, 17);
            this.chk_Symbol.TabIndex = 7;
            this.chk_Symbol.Text = "At least one symbol character";
            this.chk_Symbol.UseVisualStyleBackColor = true;
            // 
            // chk_Numeric
            // 
            this.chk_Numeric.AutoSize = true;
            this.chk_Numeric.Location = new System.Drawing.Point(6, 147);
            this.chk_Numeric.Name = "chk_Numeric";
            this.chk_Numeric.Size = new System.Drawing.Size(170, 17);
            this.chk_Numeric.TabIndex = 6;
            this.chk_Numeric.Text = "At least one numeric character";
            this.chk_Numeric.UseVisualStyleBackColor = true;
            // 
            // chk_ucase
            // 
            this.chk_ucase.AutoSize = true;
            this.chk_ucase.Location = new System.Drawing.Point(6, 124);
            this.chk_ucase.Name = "chk_ucase";
            this.chk_ucase.Size = new System.Drawing.Size(183, 17);
            this.chk_ucase.TabIndex = 4;
            this.chk_ucase.Text = "At least one uppercase character";
            this.chk_ucase.UseVisualStyleBackColor = true;
            // 
            // chk_lcase
            // 
            this.chk_lcase.AutoSize = true;
            this.chk_lcase.Location = new System.Drawing.Point(6, 101);
            this.chk_lcase.Name = "chk_lcase";
            this.chk_lcase.Size = new System.Drawing.Size(181, 17);
            this.chk_lcase.TabIndex = 3;
            this.chk_lcase.Text = "At least one lowercase character";
            this.chk_lcase.UseVisualStyleBackColor = true;
            // 
            // chk_Validate
            // 
            this.chk_Validate.AutoSize = true;
            this.chk_Validate.Location = new System.Drawing.Point(6, 78);
            this.chk_Validate.Name = "chk_Validate";
            this.chk_Validate.Size = new System.Drawing.Size(167, 17);
            this.chk_Validate.TabIndex = 2;
            this.chk_Validate.Text = "Validate password on archival";
            this.chk_Validate.UseVisualStyleBackColor = true;
            // 
            // lbl_PassChars
            // 
            this.lbl_PassChars.AutoSize = true;
            this.lbl_PassChars.Location = new System.Drawing.Point(51, 21);
            this.lbl_PassChars.Name = "lbl_PassChars";
            this.lbl_PassChars.Size = new System.Drawing.Size(128, 13);
            this.lbl_PassChars.TabIndex = 1;
            this.lbl_PassChars.Text = "Minimum password length";
            // 
            // num_PassChar
            // 
            this.num_PassChar.Location = new System.Drawing.Point(6, 19);
            this.num_PassChar.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.num_PassChar.Name = "num_PassChar";
            this.num_PassChar.Size = new System.Drawing.Size(39, 20);
            this.num_PassChar.TabIndex = 0;
            this.num_PassChar.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // grp_Encryption
            // 
            this.grp_Encryption.Controls.Add(this.txt_Algorithm);
            this.grp_Encryption.Controls.Add(this.lbl_Algorithm);
            this.grp_Encryption.Location = new System.Drawing.Point(214, 51);
            this.grp_Encryption.Name = "grp_Encryption";
            this.grp_Encryption.Size = new System.Drawing.Size(157, 82);
            this.grp_Encryption.TabIndex = 1;
            this.grp_Encryption.TabStop = false;
            this.grp_Encryption.Text = "Encryption Algorithm";
            // 
            // txt_Algorithm
            // 
            this.txt_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_Algorithm.FormattingEnabled = true;
            this.txt_Algorithm.Items.AddRange(new object[] {
            "None",
            "PkzipWeak",
            "Unsupported",
            "WinZipAes128",
            "WinZipAes256"});
            this.txt_Algorithm.Location = new System.Drawing.Point(9, 39);
            this.txt_Algorithm.Name = "txt_Algorithm";
            this.txt_Algorithm.Size = new System.Drawing.Size(136, 21);
            this.txt_Algorithm.TabIndex = 4;
            // 
            // lbl_Algorithm
            // 
            this.lbl_Algorithm.AutoSize = true;
            this.lbl_Algorithm.Location = new System.Drawing.Point(6, 23);
            this.lbl_Algorithm.Name = "lbl_Algorithm";
            this.lbl_Algorithm.Size = new System.Drawing.Size(34, 13);
            this.lbl_Algorithm.TabIndex = 3;
            this.lbl_Algorithm.Text = "Type:";
            this.lbl_Algorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(317, 294);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(80, 26);
            this.btn_Apply.TabIndex = 4;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(231, 294);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 26);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(145, 294);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(80, 26);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ArchiveSettingsForm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(412, 333);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.tab_Master);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchiveSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Archive Settings";
            this.grp_Buffer.ResumeLayout(false);
            this.grp_Buffer.PerformLayout();
            this.grp_Options.ResumeLayout(false);
            this.grp_Options.PerformLayout();
            this.tab_Archive.ResumeLayout(false);
            this.grp_Compression.ResumeLayout(false);
            this.grp_Compression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trk_CompressionLevel)).EndInit();
            this.tab_Master.ResumeLayout(false);
            this.tab_Encryption.ResumeLayout(false);
            this.tab_Encryption.PerformLayout();
            this.grp_Password.ResumeLayout(false);
            this.grp_Password.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_PassChar)).EndInit();
            this.grp_Encryption.ResumeLayout(false);
            this.grp_Encryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_BufferIO;
        private System.Windows.Forms.TextBox txt_BufferCodec;
        private System.Windows.Forms.Label lbl_BufferCodec;
        private System.Windows.Forms.GroupBox grp_Buffer;
        private System.Windows.Forms.Label lbl_BufferIO;
        private System.Windows.Forms.CheckBox chk_openComplete;
        private System.Windows.Forms.CheckBox chk_alert;
        private System.Windows.Forms.Label lbl_64bit;
        private System.Windows.Forms.GroupBox grp_Options;
        private System.Windows.Forms.ComboBox txt_64Bit;
        private System.Windows.Forms.CheckBox chk_useMemory;
        private System.Windows.Forms.TabPage tab_Archive;
        private System.Windows.Forms.GroupBox grp_Compression;
        private System.Windows.Forms.ComboBox txt_Strategy;
        private System.Windows.Forms.Label lbl_Strategy;
        private System.Windows.Forms.ComboBox txt_Method;
        private System.Windows.Forms.Label lbl_Method;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_currentlevel;
        private System.Windows.Forms.TrackBar trk_CompressionLevel;
        private System.Windows.Forms.TabControl tab_Master;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TabPage tab_Encryption;
        private System.Windows.Forms.GroupBox grp_Encryption;
        private System.Windows.Forms.ComboBox txt_Algorithm;
        private System.Windows.Forms.Label lbl_Algorithm;
        private System.Windows.Forms.GroupBox grp_Password;
        private System.Windows.Forms.CheckBox chk_ucase;
        private System.Windows.Forms.CheckBox chk_lcase;
        private System.Windows.Forms.CheckBox chk_Validate;
        private System.Windows.Forms.Label lbl_PassChars;
        private System.Windows.Forms.NumericUpDown num_PassChar;
        private System.Windows.Forms.CheckBox chk_CharMask;
        private System.Windows.Forms.CheckBox chk_Symbol;
        private System.Windows.Forms.CheckBox chk_Numeric;
        private System.Windows.Forms.CheckBox chk_UseEncryption;

    }
}