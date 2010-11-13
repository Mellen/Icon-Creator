using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IconCreator
{
    public partial class frmIcons : Form
    {
        ImageToIcon.ImageToIcons iconConverter;
        public frmIcons()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconConverter = new ImageToIcon.ImageToIcons(ofdImage.FileName);

                GroupBox gb1 = groupBox1;
                this.splitter.Panel1.Controls.Clear();
                this.splitter.Panel1.Controls.Add(gb1);
                picMain.Image = iconConverter.BackingImage;
                groupBox1.Visible = true;
            }
        }

        private void chk16_CheckedChanged(object sender, EventArgs e)
        {
            PictureBox img16;
            if (chk16.Checked)
            {
                img16 = new PictureBox();
                img16.Width = 16;
                img16.Height = 16;
                img16.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
                img16.Dock = DockStyle.Left;
                img16.Image = iconConverter.Icon16.ToBitmap();
            }
            else
            {
                img16 = (from p in splitter.Panel1.Controls.OfType<PictureBox>()
                         where p.Name == "img16"
                         select p).First();
                splitter.Panel1.Controls.Remove(img16);                
            }
        }
    }
}
