namespace Stealth_Compressor
{
    partial class PassForm
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
            this.grp_Password = new System.Windows.Forms.GroupBox();
            this.txt_Verify = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Verify = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grp_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Password
            // 
            this.grp_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grp_Password.Controls.Add(this.txt_Verify);
            this.grp_Password.Controls.Add(this.txt_Password);
            this.grp_Password.Controls.Add(this.lbl_Verify);
            this.grp_Password.Controls.Add(this.lbl_Password);
            this.grp_Password.Location = new System.Drawing.Point(12, 12);
            this.grp_Password.Name = "grp_Password";
            this.grp_Password.Size = new System.Drawing.Size(251, 134);
            this.grp_Password.TabIndex = 0;
            this.grp_Password.TabStop = false;
            // 
            // txt_Verify
            // 
            this.txt_Verify.Location = new System.Drawing.Point(12, 92);
            this.txt_Verify.Name = "txt_Verify";
            this.txt_Verify.Size = new System.Drawing.Size(228, 20);
            this.txt_Verify.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(12, 32);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(228, 20);
            this.txt_Password.TabIndex = 1;
            // 
            // lbl_Verify
            // 
            this.lbl_Verify.AutoSize = true;
            this.lbl_Verify.Location = new System.Drawing.Point(9, 76);
            this.lbl_Verify.Name = "lbl_Verify";
            this.lbl_Verify.Size = new System.Drawing.Size(82, 13);
            this.lbl_Verify.TabIndex = 1;
            this.lbl_Verify.Text = "Verify Password";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(9, 16);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(81, 13);
            this.lbl_Password.TabIndex = 0;
            this.lbl_Password.Text = "Enter Password";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.Location = new System.Drawing.Point(106, 162);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 1;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(187, 162);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // PassForm
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(274, 198);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.grp_Password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 170);
            this.Name = "PassForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Archive Password";
            this.grp_Password.ResumeLayout(false);
            this.grp_Password.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        internal System.Windows.Forms.TextBox txt_Verify;
        internal System.Windows.Forms.Label lbl_Verify;
    }
}