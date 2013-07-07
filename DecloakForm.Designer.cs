namespace Stealth_Compressor
{
    partial class DecloakForm
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
            this.opn_Cloaked = new System.Windows.Forms.OpenFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.sts_Main = new System.Windows.Forms.StatusStrip();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.sts_Main_Seperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.lst_Files = new System.Windows.Forms.ListView();
            this.col_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Ratio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Encryption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Decloak = new System.Windows.Forms.Button();
            this.btn_Extract = new System.Windows.Forms.Button();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.btn_Output = new System.Windows.Forms.Button();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.grp_Input = new System.Windows.Forms.GroupBox();
            this.btn_Input = new System.Windows.Forms.Button();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.grp_Action = new System.Windows.Forms.GroupBox();
            this.bws_Output = new System.Windows.Forms.FolderBrowserDialog();
            this.sts_Main.SuspendLayout();
            this.grp_Output.SuspendLayout();
            this.grp_Input.SuspendLayout();
            this.grp_Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // sts_Main
            // 
            this.sts_Main.BackColor = System.Drawing.SystemColors.Control;
            this.sts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Status,
            this.sts_Main_Seperator});
            this.sts_Main.Location = new System.Drawing.Point(0, 344);
            this.sts_Main.Name = "sts_Main";
            this.sts_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.sts_Main.Size = new System.Drawing.Size(592, 22);
            this.sts_Main.TabIndex = 2;
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(50, 17);
            this.lbl_Status.Text = "Status...";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sts_Main_Seperator
            // 
            this.sts_Main_Seperator.Name = "sts_Main_Seperator";
            this.sts_Main_Seperator.Size = new System.Drawing.Size(527, 17);
            this.sts_Main_Seperator.Spring = true;
            this.sts_Main_Seperator.Text = "|- Separator -|";
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(652, 465);
            // 
            // lst_Files
            // 
            this.lst_Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_Files.CheckBoxes = true;
            this.lst_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_FileName,
            this.col_Size,
            this.col_Ratio,
            this.col_Encryption});
            this.lst_Files.GridLines = true;
            this.lst_Files.Location = new System.Drawing.Point(12, 79);
            this.lst_Files.Name = "lst_Files";
            this.lst_Files.Size = new System.Drawing.Size(568, 191);
            this.lst_Files.TabIndex = 0;
            this.lst_Files.UseCompatibleStateImageBehavior = false;
            this.lst_Files.View = System.Windows.Forms.View.Details;
            this.lst_Files.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lst_Files_ItemChecked);
            // 
            // col_FileName
            // 
            this.col_FileName.Text = "File Name";
            this.col_FileName.Width = 270;
            // 
            // col_Size
            // 
            this.col_Size.Text = "File Size (un)";
            this.col_Size.Width = 78;
            // 
            // col_Ratio
            // 
            this.col_Ratio.Text = "Ratio";
            this.col_Ratio.Width = 88;
            // 
            // col_Encryption
            // 
            this.col_Encryption.Text = "Encryption";
            this.col_Encryption.Width = 118;
            // 
            // btn_Decloak
            // 
            this.btn_Decloak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Decloak.Location = new System.Drawing.Point(6, 12);
            this.btn_Decloak.Name = "btn_Decloak";
            this.btn_Decloak.Size = new System.Drawing.Size(118, 36);
            this.btn_Decloak.TabIndex = 1;
            this.btn_Decloak.Text = "Decloak";
            this.btn_Decloak.UseVisualStyleBackColor = true;
            this.btn_Decloak.Click += new System.EventHandler(this.btn_Decloak_Click);
            // 
            // btn_Extract
            // 
            this.btn_Extract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Extract.Location = new System.Drawing.Point(6, 12);
            this.btn_Extract.Name = "btn_Extract";
            this.btn_Extract.Size = new System.Drawing.Size(118, 36);
            this.btn_Extract.TabIndex = 4;
            this.btn_Extract.Text = "Extract";
            this.btn_Extract.UseVisualStyleBackColor = true;
            this.btn_Extract.Click += new System.EventHandler(this.btn_Extract_Click);
            // 
            // grp_Output
            // 
            this.grp_Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Output.Controls.Add(this.btn_Output);
            this.grp_Output.Controls.Add(this.txt_Output);
            this.grp_Output.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp_Output.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Output.Location = new System.Drawing.Point(12, 276);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(432, 54);
            this.grp_Output.TabIndex = 7;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output Directory";
            // 
            // btn_Output
            // 
            this.btn_Output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Output.Location = new System.Drawing.Point(302, 19);
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
            this.txt_Output.Size = new System.Drawing.Size(290, 20);
            this.txt_Output.TabIndex = 0;
            // 
            // grp_Input
            // 
            this.grp_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Input.Controls.Add(this.btn_Input);
            this.grp_Input.Controls.Add(this.txt_Input);
            this.grp_Input.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grp_Input.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Input.Location = new System.Drawing.Point(12, 19);
            this.grp_Input.Name = "grp_Input";
            this.grp_Input.Size = new System.Drawing.Size(568, 54);
            this.grp_Input.TabIndex = 8;
            this.grp_Input.TabStop = false;
            this.grp_Input.Text = "Input Archive";
            // 
            // btn_Input
            // 
            this.btn_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Input.Location = new System.Drawing.Point(438, 19);
            this.btn_Input.Name = "btn_Input";
            this.btn_Input.Size = new System.Drawing.Size(120, 26);
            this.btn_Input.TabIndex = 1;
            this.btn_Input.Text = "Browse...";
            this.btn_Input.UseVisualStyleBackColor = true;
            this.btn_Input.Click += new System.EventHandler(this.btn_Input_Click);
            // 
            // txt_Input
            // 
            this.txt_Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Input.Location = new System.Drawing.Point(6, 22);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(426, 20);
            this.txt_Input.TabIndex = 0;
            // 
            // grp_Action
            // 
            this.grp_Action.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_Action.Controls.Add(this.btn_Decloak);
            this.grp_Action.Controls.Add(this.btn_Extract);
            this.grp_Action.Location = new System.Drawing.Point(450, 276);
            this.grp_Action.Name = "grp_Action";
            this.grp_Action.Size = new System.Drawing.Size(130, 54);
            this.grp_Action.TabIndex = 9;
            this.grp_Action.TabStop = false;
            // 
            // DecloakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.grp_Action);
            this.Controls.Add(this.sts_Main);
            this.Controls.Add(this.grp_Input);
            this.Controls.Add(this.grp_Output);
            this.Controls.Add(this.lst_Files);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "DecloakForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Archive Decloak";
            this.sts_Main.ResumeLayout(false);
            this.sts_Main.PerformLayout();
            this.grp_Output.ResumeLayout(false);
            this.grp_Output.PerformLayout();
            this.grp_Input.ResumeLayout(false);
            this.grp_Input.PerformLayout();
            this.grp_Action.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opn_Cloaked;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.StatusStrip sts_Main;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ListView lst_Files;
        private System.Windows.Forms.ColumnHeader col_FileName;
        private System.Windows.Forms.ColumnHeader col_Encryption;
        private System.Windows.Forms.Button btn_Decloak;
        private System.Windows.Forms.Button btn_Extract;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.Button btn_Output;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.GroupBox grp_Input;
        private System.Windows.Forms.Button btn_Input;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.GroupBox grp_Action;
        private System.Windows.Forms.ColumnHeader col_Ratio;
        private System.Windows.Forms.ColumnHeader col_Size;
        private System.Windows.Forms.FolderBrowserDialog bws_Output;
        private System.Windows.Forms.ToolStripStatusLabel sts_Main_Seperator;
    }
}