using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stealth_Compressor.Properties;

namespace Stealth_Compressor
{
    public partial class PassForm : Form
    {
        public string Password { get; private set; }
        private bool passValidate;

        public PassForm(bool validate)
        {
            InitializeComponent();
            if (!Settings.Default.PASSWORD_VALIDATE) validate = false;
            if (!Settings.Default.PASSWORD_MASK)
            {
                txt_Password.UseSystemPasswordChar = false;
                txt_Verify.UseSystemPasswordChar = false;
                validate = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                txt_Verify.UseSystemPasswordChar = true;
            }

            passValidate = validate;
            lbl_Verify.Visible = validate;
            txt_Verify.Visible = validate;
            if (!validate) this.Size = new Size(280, 170);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (passValidate)
            {
                if (txt_Password.Text.Length < Settings.Default.PASSWORD_FORMAT.Count(c => c == '*'))
                {
                    MessageBox.Show(this, string.Format("Password needs to be at least {0} characters!", 
                                                        Settings.Default.PASSWORD_FORMAT.Count(c => c == '*')), "Warning",
                                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Password.Clear();
                    txt_Verify.Clear();
                    txt_Password.Focus();
                    return;
                }

                if (txt_Verify.Text == txt_Password.Text)
                {
                    Password = txt_Password.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Passwords do not match!", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Verify.Clear();
                    txt_Verify.Focus();
                }
            }
            else
            {
                Password = txt_Password.Text;
                this.Close();
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
