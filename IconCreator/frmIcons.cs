using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
                this.splitter.Panel1.Controls.Add(gb1);
                picMain.Image = iconConverter.BackingImage;
                groupBox1.Visible = true;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            int[] sizes = { 16, 24, 32, 48, 64, 128, 256 };
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
    }
}
