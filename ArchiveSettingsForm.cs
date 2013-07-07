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
    public partial class ArchiveSettingsForm : Form
    {
        public ArchiveSettingsForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Stealth;
            this.ShowIcon = true;
            GetValuesFromSettings();
        }

        #region Settings Enumerators

        // Compression level enumerator
        public static Ionic.Zlib.CompressionLevel GetLevel(int value)
        {
            switch (value)
            {
                case 9:
                    return Ionic.Zlib.CompressionLevel.Level9;
                case 8:
                    return Ionic.Zlib.CompressionLevel.Level8;
                case 7:
                    return Ionic.Zlib.CompressionLevel.Level7;
                case 6:
                    return Ionic.Zlib.CompressionLevel.Level6;
                case 5:
                    return Ionic.Zlib.CompressionLevel.Level5;
                case 4:
                    return Ionic.Zlib.CompressionLevel.Level4;
                case 3:
                    return Ionic.Zlib.CompressionLevel.Level3;
                case 2:
                    return Ionic.Zlib.CompressionLevel.Level2;
                case 1:
                    return Ionic.Zlib.CompressionLevel.Level1;
                case 0:
                    return Ionic.Zlib.CompressionLevel.None;
                default:
                    return Ionic.Zlib.CompressionLevel.Default;
            }
        }

        // Compression method enumerator
        public static Ionic.Zip.CompressionMethod GetMethod(string value)
        {
            switch (value)
            {
                case "BZip2":
                    return Ionic.Zip.CompressionMethod.BZip2;
                case "None":
                    return Ionic.Zip.CompressionMethod.None;
                case "Deflate":
                default:
                    return Ionic.Zip.CompressionMethod.Deflate;
            }
        }

        // Compression strategy enumerator
        public static Ionic.Zlib.CompressionStrategy GetStrategy(string value)
        {
            switch (value)
            {
                case "Filtered":
                    return Ionic.Zlib.CompressionStrategy.Filtered;
                case "Huffman Only":
                    return Ionic.Zlib.CompressionStrategy.HuffmanOnly;
                case "Default":
                default:
                    return Ionic.Zlib.CompressionStrategy.Default;
            }
        }

        // 64-Bit option enumerator
        public static Ionic.Zip.Zip64Option Get64Option(string value)
        {
            switch (value)
            {
                case "Always":
                    return Ionic.Zip.Zip64Option.Always;
                case "Never":
                    return Ionic.Zip.Zip64Option.Never;
                case "As Needed":
                    return Ionic.Zip.Zip64Option.AsNecessary;
                default:
                    return Ionic.Zip.Zip64Option.Default;
            }
        }

        // Encryption algorithm type enumerator
        public static Ionic.Zip.EncryptionAlgorithm GetEncryption(string value)
        {
            switch (value)
            {
                case "None":
                    return Ionic.Zip.EncryptionAlgorithm.None;
                case "Unsupported":
                    return Ionic.Zip.EncryptionAlgorithm.Unsupported;
                case "WinZipAes128":
                    return Ionic.Zip.EncryptionAlgorithm.WinZipAes128;
                case "WinZipAes256":
                    return Ionic.Zip.EncryptionAlgorithm.WinZipAes256;
                case "PkzipWeak":
                default:
                    return Ionic.Zip.EncryptionAlgorithm.PkzipWeak;
            }
        }

        #endregion

        private void GetValuesFromSettings()
        {
            // Archive Tab
            trk_CompressionLevel.Value = Settings.Default.COMPRESSION_LEVEL;
            txt_Method.Text = Settings.Default.COMPRESSION_METHOD;
            txt_Strategy.Text = Settings.Default.COMPRESSION_STRATEGY;
            txt_BufferIO.Text = Settings.Default.IO_BUFFER_SIZE.ToString();
            txt_BufferCodec.Text = Settings.Default.CODEC_BUFFER_SIZE.ToString();
            chk_useMemory.Checked = Settings.Default.MEMORY_ARCHIVE;
            chk_openComplete.Checked = Settings.Default.OPEN_ON_COMPLETION;
            chk_alert.Checked = Settings.Default.ALERT_ON_COMPLETION;
            txt_64Bit.Text = Settings.Default.USE_ZIP64;

            //Encryption Tab
            num_PassChar.Value = Settings.Default.PASSWORD_FORMAT.Count(c => c == '*');
            chk_CharMask.Checked = Settings.Default.PASSWORD_MASK;
            chk_Validate.Checked = Settings.Default.PASSWORD_VALIDATE;
            if (Settings.Default.PASSWORD_FORMAT.Contains('a')) chk_lcase.Checked = true;
            if (Settings.Default.PASSWORD_FORMAT.Contains('A')) chk_ucase.Checked = true;
            if (Settings.Default.PASSWORD_FORMAT.Contains('0')) chk_Numeric.Checked = true;
            if (Settings.Default.PASSWORD_FORMAT.Contains('!')) chk_Symbol.Checked = true;
            chk_UseEncryption.Checked = Settings.Default.ENCRYPT_ARCHIVE;
            txt_Algorithm.Text = Settings.Default.ENCRYPTION_ALGORITHM;

        }

        private void SaveValuesToSettings()
        {
            // Archive Tab
            Settings.Default.COMPRESSION_LEVEL = trk_CompressionLevel.Value;
            Settings.Default.COMPRESSION_METHOD = txt_Method.Text;
            Settings.Default.COMPRESSION_STRATEGY = txt_Strategy.Text;
            Settings.Default.IO_BUFFER_SIZE = Convert.ToInt32(txt_BufferIO.Text);
            Settings.Default.CODEC_BUFFER_SIZE = Convert.ToInt32(txt_BufferCodec.Text);
            Settings.Default.MEMORY_ARCHIVE = chk_useMemory.Checked;
            Settings.Default.OPEN_ON_COMPLETION = chk_openComplete.Checked;
            Settings.Default.ALERT_ON_COMPLETION = chk_alert.Checked;
            Settings.Default.USE_ZIP64 = txt_64Bit.Text;

            //Encryption Tab
            Settings.Default.PASSWORD_MASK = chk_CharMask.Checked;
            Settings.Default.PASSWORD_VALIDATE = chk_Validate.Checked;
            string passformat = new string('*', Convert.ToInt32(num_PassChar.Value));
            if (chk_lcase.Checked) passformat += "a";
            if (chk_ucase.Checked) passformat += "A";
            if (chk_Numeric.Checked) passformat += "0";
            if (chk_Symbol.Checked) passformat += "!";
            Settings.Default.PASSWORD_FORMAT = passformat;
            Settings.Default.ENCRYPT_ARCHIVE = chk_UseEncryption.Checked;
            Settings.Default.ENCRYPTION_ALGORITHM = txt_Algorithm.Text;

        }

        // Got this here: http://rajeshkm.blogspot.com/2006/07/how-to-change-color-of-tab-control-in.html
        // Allows us to set the background color of the tab control, since it's normally transparent
        private void ChangeTabColor(object sender, DrawItemEventArgs e)
        {
            Font TabFont;
            Brush BackBrush = new SolidBrush(this.BackColor); //Set background color
            Brush ForeBrush = new SolidBrush(Color.Black);//Set foreground color

            TabFont = new Font(e.Font, FontStyle.Regular);

            string TabName = this.tab_Master.TabPages[e.Index].Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.FillRectangle(BackBrush, e.Bounds);
            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString(TabName, TabFont, ForeBrush, r, sf);

            //Dispose objects
            sf.Dispose();
            if (e.Index == this.tab_Master.SelectedIndex)
            {
                TabFont.Dispose();
                BackBrush.Dispose();
            }
            else
            {
                BackBrush.Dispose();
                ForeBrush.Dispose();
            }
        }

        // Change the compression level label when track bar is moved
        private void trk_CompressionLevel_ValueChanged(object sender, System.EventArgs e)
        {
            lbl_currentlevel.Text = GetLevel(trk_CompressionLevel.Value).ToString();
        }

        // When OK button is pressed
        private void btn_OK_Click(object sender, EventArgs e)
        {
            SaveValuesToSettings();
            this.Close();
        }

        // When Apply button is pressed
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            SaveValuesToSettings();
        }

    }

}
