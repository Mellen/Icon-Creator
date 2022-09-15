using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IconCreator
{
    public partial class frmIcons : Form
    {
        ImageToIcon.ImageToIcons iconConverter = null;
        public frmIcons()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == DialogResult.OK)
            {
                iconConverter = new ImageToIcon.ImageToIcons(ofdImage.FileName);

                GroupBox gb1 = groupBox1;
                this.splitter.Panel1.Controls.Add(gb1);
                picMain.Image = iconConverter.BackingImage;
                groupBox1.Visible = true;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            string sizeStr = chk.Name.Substring(3);
            PictureBox img = GetBox(sizeStr); ;
            int width = int.Parse(sizeStr);
            if (chk.Checked)
            {
                img.Image = iconConverter.GetIconBySize(width).ToBitmap();
            }
            else
            {
                img.Image = null;
            }
        }

        private PictureBox GetBox(string size)
        {
            PictureBox img = (from p in tableImageHolder.Controls.OfType<PictureBox>()
                              where p.Name == "box" + size
                              select p).First();

            return img;
        }

        private void saveNewIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (iconConverter != null && sfdIcon.ShowDialog() == DialogResult.OK)
            {
                bool[] use = new bool[]{ false, false, false, false, false, false, false };
                int[] sizes = new int[] { 16, 24, 32, 48, 64, 128, 256 };

                var sizeOptions = from chk in groupBox1.Controls.OfType<CheckBox>() select new { chk.Name, chk.Checked };

                foreach (var sizeCheck in sizeOptions)
                {
                    if (sizeCheck.Checked)
                    {
                        string sizeStr = sizeCheck.Name.Substring(3);
                        int width = int.Parse(sizeStr);
                        int useIndex = Array.IndexOf(sizes, width);
                        use[useIndex] = true;
                    }
                }

                iconConverter.Save(sfdIcon.FileName, use[0], use[1], use[2], use[3], use[4], use[5], use[6]);
            }
        }
    }
}
