namespace IconCreator
{
    partial class frmIcons
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
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk256 = new System.Windows.Forms.CheckBox();
            this.chk128 = new System.Windows.Forms.CheckBox();
            this.ch64 = new System.Windows.Forms.CheckBox();
            this.chk48 = new System.Windows.Forms.CheckBox();
            this.chk32 = new System.Windows.Forms.CheckBox();
            this.chk24 = new System.Windows.Forms.CheckBox();
            this.chk16 = new System.Windows.Forms.CheckBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            this.splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.groupBox1);
            this.splitter.Panel1.Controls.Add(this.mnuMain);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.picMain);
            this.splitter.Size = new System.Drawing.Size(639, 582);
            this.splitter.SplitterDistance = 256;
            this.splitter.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk256);
            this.groupBox1.Controls.Add(this.chk128);
            this.groupBox1.Controls.Add(this.ch64);
            this.groupBox1.Controls.Add(this.chk48);
            this.groupBox1.Controls.Add(this.chk32);
            this.groupBox1.Controls.Add(this.chk24);
            this.groupBox1.Controls.Add(this.chk16);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 39);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon Resolutions";
            // 
            // chk256
            // 
            this.chk256.AutoSize = true;
            this.chk256.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk256.Location = new System.Drawing.Point(411, 16);
            this.chk256.Name = "chk256";
            this.chk256.Size = new System.Drawing.Size(73, 20);
            this.chk256.TabIndex = 6;
            this.chk256.Text = "256 x 256";
            this.chk256.UseVisualStyleBackColor = true;
            // 
            // chk128
            // 
            this.chk128.AutoSize = true;
            this.chk128.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk128.Location = new System.Drawing.Point(333, 16);
            this.chk128.Name = "chk128";
            this.chk128.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chk128.Size = new System.Drawing.Size(78, 20);
            this.chk128.TabIndex = 5;
            this.chk128.Text = "128 x 128";
            this.chk128.UseVisualStyleBackColor = true;
            // 
            // ch64
            // 
            this.ch64.AutoSize = true;
            this.ch64.Dock = System.Windows.Forms.DockStyle.Left;
            this.ch64.Location = new System.Drawing.Point(267, 16);
            this.ch64.Name = "ch64";
            this.ch64.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ch64.Size = new System.Drawing.Size(66, 20);
            this.ch64.TabIndex = 4;
            this.ch64.Text = "64 x 64";
            this.ch64.UseVisualStyleBackColor = true;
            // 
            // chk48
            // 
            this.chk48.AutoSize = true;
            this.chk48.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk48.Location = new System.Drawing.Point(201, 16);
            this.chk48.Name = "chk48";
            this.chk48.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chk48.Size = new System.Drawing.Size(66, 20);
            this.chk48.TabIndex = 3;
            this.chk48.Text = "48 x 48";
            this.chk48.UseVisualStyleBackColor = true;
            // 
            // chk32
            // 
            this.chk32.AutoSize = true;
            this.chk32.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk32.Location = new System.Drawing.Point(135, 16);
            this.chk32.Name = "chk32";
            this.chk32.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chk32.Size = new System.Drawing.Size(66, 20);
            this.chk32.TabIndex = 2;
            this.chk32.Text = "32 x 32";
            this.chk32.UseVisualStyleBackColor = true;
            // 
            // chk24
            // 
            this.chk24.AutoSize = true;
            this.chk24.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk24.Location = new System.Drawing.Point(69, 16);
            this.chk24.Name = "chk24";
            this.chk24.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chk24.Size = new System.Drawing.Size(66, 20);
            this.chk24.TabIndex = 1;
            this.chk24.Text = "24 x 24";
            this.chk24.UseVisualStyleBackColor = true;
            // 
            // chk16
            // 
            this.chk16.AutoSize = true;
            this.chk16.Dock = System.Windows.Forms.DockStyle.Left;
            this.chk16.Location = new System.Drawing.Point(3, 16);
            this.chk16.Name = "chk16";
            this.chk16.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.chk16.Size = new System.Drawing.Size(66, 20);
            this.chk16.TabIndex = 0;
            this.chk16.Text = "16 x 16";
            this.chk16.UseVisualStyleBackColor = true;
            this.chk16.CheckedChanged += new System.EventHandler(this.chk16_CheckedChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(639, 24);
            this.mnuMain.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.loadImageToolStripMenuItem.Text = "&Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
            // 
            // picMain
            // 
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(639, 322);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Bitmap|*.bmp|JPEG|*.jpg|GIF|*.gif|PNG|*.png";
            this.ofdImage.Title = "Select an image to turn into an icon";
            // 
            // frmIcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 582);
            this.Controls.Add(this.splitter);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmIcons";
            this.Text = "Form1";
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel1.PerformLayout();
            this.splitter.Panel2.ResumeLayout(false);
            this.splitter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk16;
        private System.Windows.Forms.CheckBox chk24;
        private System.Windows.Forms.CheckBox chk32;
        private System.Windows.Forms.CheckBox chk48;
        private System.Windows.Forms.CheckBox chk128;
        private System.Windows.Forms.CheckBox ch64;
        private System.Windows.Forms.CheckBox chk256;
    }
}

