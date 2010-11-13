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
                if (iconConverter == null)
                {
                    UnbindConverter(iconConverter);
                }

                iconConverter = new ImageToIcon.ImageToIcons(ofdImage.FileName);

                BindConverter(iconConverter);

                GroupBox gb1 = groupBox1;
                this.splitter.Panel1.Controls.Clear();
                this.splitter.Panel1.Controls.Add(gb1);
                picMain.ImageLocation = ofdImage.FileName;
                groupBox1.Visible = true;
            }
        }

        private void BindConverter(ImageToIcon.ImageToIcons iconConverter)
        {
            throw new NotImplementedException();
        }

        private void UnbindConverter(ImageToIcon.ImageToIcons iconConverter)
        {
            throw new NotImplementedException();
        }
    }
}
