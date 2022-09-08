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

        private void CheckedChanged(object sender, EventArgs e)
        {
            PictureBox img;
            string name;
            int width;
            int height;
            CheckBox chk = sender as CheckBox;
            string sizeStr = chk.Name.Substring(3);
            name = "img" + sizeStr;
            width = height = int.Parse(sizeStr);
            if (chk.Checked)
            {
                img = CreateBox(name, width, height, iconConverter.GetIconBySize(width).ToBitmap());
                splitter.Panel1.Controls.Add(img);
            }
            else
            {
                img = (from p in splitter.Panel1.Controls.OfType<PictureBox>()
                         where p.Name == name
                         select p).First();
                splitter.Panel1.Controls.Remove(img);
            }
        }

        private PictureBox CreateBox(string name, int width, int height, Image image)
        {
            PictureBox box = new PictureBox();
            box.Width = width;
            box.Height = height;
            box.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            box.Dock = DockStyle.Left;
            box.Image = image;
            box.Name = name;
            return box;
        }
    }
}
