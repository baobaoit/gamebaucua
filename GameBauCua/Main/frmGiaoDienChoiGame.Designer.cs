namespace Main
{
    partial class frmGiaoDienChoiGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienChoiGame));
            this.picCaiDat = new System.Windows.Forms.PictureBox();
            this.picXemDiem = new System.Windows.Forms.PictureBox();
            this.picChoiNgay = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCaiDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXemDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picCaiDat
            // 
            this.picCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("picCaiDat.Image")));
            this.picCaiDat.Location = new System.Drawing.Point(1339, 572);
            this.picCaiDat.Margin = new System.Windows.Forms.Padding(4);
            this.picCaiDat.Name = "picCaiDat";
            this.picCaiDat.Size = new System.Drawing.Size(259, 86);
            this.picCaiDat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaiDat.TabIndex = 4;
            this.picCaiDat.TabStop = false;
            this.picCaiDat.Click += new System.EventHandler(this.picCaiDat_Click);
            // 
            // picXemDiem
            // 
            this.picXemDiem.Image = global::Main.Properties.Resources.w;
            this.picXemDiem.Location = new System.Drawing.Point(1339, 470);
            this.picXemDiem.Margin = new System.Windows.Forms.Padding(4);
            this.picXemDiem.Name = "picXemDiem";
            this.picXemDiem.Size = new System.Drawing.Size(265, 87);
            this.picXemDiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picXemDiem.TabIndex = 3;
            this.picXemDiem.TabStop = false;
            this.picXemDiem.Click += new System.EventHandler(this.picXemDiem_Click);
            // 
            // picChoiNgay
            // 
            this.picChoiNgay.Image = global::Main.Properties.Resources._653;
            this.picChoiNgay.Location = new System.Drawing.Point(1273, 320);
            this.picChoiNgay.Margin = new System.Windows.Forms.Padding(4);
            this.picChoiNgay.Name = "picChoiNgay";
            this.picChoiNgay.Size = new System.Drawing.Size(396, 129);
            this.picChoiNgay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoiNgay.TabIndex = 2;
            this.picChoiNgay.TabStop = false;
            this.picChoiNgay.Click += new System.EventHandler(this.picChoiNgay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Main.Properties.Resources._212;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1816, 869);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiaoDienChoiGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 869);
            this.Controls.Add(this.picCaiDat);
            this.Controls.Add(this.picXemDiem);
            this.Controls.Add(this.picChoiNgay);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoDienChoiGame";
            this.Text = "Bầu Cua Tôm Cá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGiaoDienChoiGame_FormClosed);
            this.Load += new System.EventHandler(this.frmGiaoDienChoiGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCaiDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXemDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoiNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picChoiNgay;
        private System.Windows.Forms.PictureBox picXemDiem;
        private System.Windows.Forms.PictureBox picCaiDat;
    }
}