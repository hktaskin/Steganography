using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
 */

namespace Steganography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Fields

        Random rnd = new Random();

        #endregion

        #region Methods

        Bitmap RandomizeBitmap(string bitmapFile)
        {
            Bitmap b = new Bitmap(bitmapFile);
            Bitmap r = new Bitmap(b);

            unchecked
            {
                for (int i = 0; i < r.Width; i++)
                    for (int j = 0; j < r.Height; j++)
                        r.SetPixel(i, j, Color.FromArgb(rnd.Next() & (int)0xFFFFFFFF));
            }

            return r;
        }

        #endregion

        #region Form Events

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide is selected
            rdbHide.Checked = true;

            // Assign Tags for the browse buttons
            btnInputBrowse.Tag = txtInput;
            btnOutputBrowse.Tag = txtOutput;
            btnDataBrowse.Tag = txtData;

            // Fill hide levels 1, 2 and 4
            for (int i = 0; i < 3; i++)
                cmbHideLevel.Items.Add(1 << i);
            cmbHideLevel.SelectedIndex = 1;
        }

        private void Browse(object sender, EventArgs e)
        {
            Button b = sender as Button;
            TextBox t = b.Tag as TextBox;

            OpenFileDialog ofd = new OpenFileDialog();
            SaveFileDialog sfd = new SaveFileDialog();

            if (t.Name == "txtInput")
            {
                // ofd
                ofd.Filter = "Bitmap Files (*.bmp)|*.bmp";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                t.Text = ofd.FileName;
            }
            else if (t.Name == "txtOutput")
            {
                if (rdbHide.Checked)
                {
                    // sfd
                    sfd.Filter = "Bitmap Files (*.bmp)|*.bmp";
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                    t.Text = sfd.FileName;
                }
                else
                {
                    // ofd
                    ofd.Filter = "Bitmap Files (*.bmp)|*.bmp";
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                    t.Text = ofd.FileName;
                }

            }
            else if (t.Name == "txtData")
            {
                if (rdbHide.Checked)
                {
                    // ofd
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                    t.Text = ofd.FileName;
                }
                else
                {
                    // sfd
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;
                    t.Text = sfd.FileName;
                }
            }
        }

        private void btnHideOrExtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbHide.Checked)
                {
                    // Hide
                    BitmapSteganography.HideDataInBitmap(txtInput.Text, txtOutput.Text, txtData.Text, int.Parse(cmbHideLevel.SelectedItem.ToString()));
                    MessageBox.Show("Hiding has been completed!");
                }
                else
                {
                    // Extract
                    BitmapSteganography.ExtractDataFromBitmap(txtOutput.Text, txtData.Text, int.Parse(cmbHideLevel.SelectedItem.ToString()));
                    MessageBox.Show("Extracting has been completed!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void rdbHide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHide.Checked)
            {
                lblIn.Enabled = true;
                txtInput.Enabled = true;
                btnInputBrowse.Enabled = true;
                btnHideOrExtract.Text = "Hide";
            }
            else
            {
                lblIn.Enabled = false;
                txtInput.Enabled = false;
                btnInputBrowse.Enabled = false;
                btnHideOrExtract.Text = "Extract";
            }
        }

        private void btnToggleMSB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Files (*.bmp)|*.bmp";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            string outname = ofd.FileName + ".MSBtoggles.bmp";

            BitmapSteganography.ToggleMSBInBitmap(ofd.FileName, outname);

            MessageBox.Show("Toggling MSBs have been completed!");
        }

        private void btnToggleLSB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Files (*.bmp)|*.bmp";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            string outname = ofd.FileName + ".LSBtoggles.bmp";

            BitmapSteganography.ToggleLSBInBitmap(ofd.FileName, outname);

            MessageBox.Show("Toggling LSBs have been completed!");
        } 

        private void btnGenFile_Click(object sender, EventArgs e)
        {
            int len = (int)nupFilebytes.Value;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Binary Files (*.bin)|*.bin";
            sfd.FileName = string.Format("Random_{0}_bytes.bin",len);
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            if (File.Exists(sfd.FileName))
                File.Delete(sfd.FileName);

            FileStream fw = File.OpenWrite(sfd.FileName);

            for (int i = 0; i < len; i++)
                fw.WriteByte((byte)rnd.Next(256));

            fw.Close();

            MessageBox.Show(string.Format("Generation {0} bytes of random file has been completed!",len));
            
        }

        #endregion
        
    }
}
