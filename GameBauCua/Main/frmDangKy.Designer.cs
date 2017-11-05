namespace Main
{
    partial class frmDangKy
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picDangNhap = new System.Windows.Forms.PictureBox();
            this.picDangKy = new System.Windows.Forms.PictureBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttipDangNhap = new System.Windows.Forms.ToolTip(this.components);
            this.ttipThongTinBatBuoc = new System.Windows.Forms.ToolTip(this.components);
            this.ctxMenuDangKy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuQuayLai = new System.Windows.Forms.ToolStripMenuItem();
            this.ttipTDNMK = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ctxMenuDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Brown;
            this.groupBox1.Controls.Add(this.picDangNhap);
            this.groupBox1.Controls.Add(this.picDangKy);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(783, 484);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // picDangNhap
            // 
            this.picDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDangNhap.Image = global::Main.Properties.Resources._4717;
            this.picDangNhap.Location = new System.Drawing.Point(213, 389);
            this.picDangNhap.Name = "picDangNhap";
            this.picDangNhap.Size = new System.Drawing.Size(225, 85);
            this.picDangNhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDangNhap.TabIndex = 6;
            this.picDangNhap.TabStop = false;
            this.ttipDangNhap.SetToolTip(this.picDangNhap, "Nhấn để trở về màn hình đăng nhập");
            this.picDangNhap.Click += new System.EventHandler(this.picDangNhap_Click);
            // 
            // picDangKy
            // 
            this.picDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDangKy.Image = global::Main.Properties.Resources._989;
            this.picDangKy.Location = new System.Drawing.Point(445, 390);
            this.picDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.picDangKy.Name = "picDangKy";
            this.picDangKy.Size = new System.Drawing.Size(225, 85);
            this.picDangKy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDangKy.TabIndex = 5;
            this.picDangKy.TabStop = false;
            this.picDangKy.Click += new System.EventHandler(this.picDangKy_Click);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.ForeColor = System.Drawing.Color.Yellow;
            this.rdNu.Location = new System.Drawing.Point(473, 245);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(65, 33);
            this.rdNu.TabIndex = 3;
            this.rdNu.Tag = "Sex";
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.ForeColor = System.Drawing.Color.Yellow;
            this.rdNam.Location = new System.Drawing.Point(267, 245);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(85, 33);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Tag = "Sex";
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(251, 140);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.MaxLength = 12;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.ShortcutsEnabled = false;
            this.txtTenDangNhap.Size = new System.Drawing.Size(419, 34);
            this.txtTenDangNhap.TabIndex = 0;
            this.ttipTDNMK.SetToolTip(this.txtTenDangNhap, "Từ 6-12 ký tự (bao gồm chữ, số và dấu “_”; không chứa các ký tự đặc biệt). Có phâ" +
        "n biệt chữ hoa và chữ thường.");
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(251, 348);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDienThoai.MaxLength = 12;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ShortcutsEnabled = false;
            this.txtSoDienThoai.Size = new System.Drawing.Size(419, 34);
            this.txtSoDienThoai.TabIndex = 5;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(251, 294);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MaxLength = 100;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ShortcutsEnabled = false;
            this.txtDiaChi.Size = new System.Drawing.Size(419, 35);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(251, 193);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.MaxLength = 12;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.ShortcutsEnabled = false;
            this.txtMatKhau.Size = new System.Drawing.Size(419, 34);
            this.txtMatKhau.TabIndex = 1;
            this.ttipTDNMK.SetToolTip(this.txtMatKhau, "Từ 6-12 ký tự (bao gồm chữ, số và dấu “_”; không chứa các ký tự đặc biệt). Có phâ" +
        "n biệt chữ hoa và chữ thường.");
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(25, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(25, 300);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(25, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(25, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu(*):";
            this.ttipThongTinBatBuoc.SetToolTip(this.label3, "Đây là thông tin bắt buộc không được bỏ trống");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(25, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập(*) :";
            this.ttipThongTinBatBuoc.SetToolTip(this.label2, "Đây là thông tin bắt buộc không được bỏ trống");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(253, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(167, 625);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(439, 67);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhóm Thiếu Nữ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Brown;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(75, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(665, 91);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bầu Cua Tôm Cá";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Main.Properties.Resources._6787;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1313, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ttipDangNhap
            // 
            this.ttipDangNhap.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipDangNhap.ToolTipTitle = "Đăng nhập";
            // 
            // ttipThongTinBatBuoc
            // 
            this.ttipThongTinBatBuoc.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttipThongTinBatBuoc.ToolTipTitle = "Thông tin bắt buộc";
            // 
            // ctxMenuDangKy
            // 
            this.ctxMenuDangKy.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuDangKy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuayLai});
            this.ctxMenuDangKy.Name = "ctxMenuDangKy";
            this.ctxMenuDangKy.Size = new System.Drawing.Size(133, 28);
            // 
            // menuQuayLai
            // 
            this.menuQuayLai.Name = "menuQuayLai";
            this.menuQuayLai.Size = new System.Drawing.Size(132, 24);
            this.menuQuayLai.Text = "Quay lại";
            this.menuQuayLai.Click += new System.EventHandler(this.menuQuayLai_Click);
            // 
            // ttipTDNMK
            // 
            this.ttipTDNMK.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 720);
            this.ContextMenuStrip = this.ctxMenuDangKy;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangKy";
            this.Text = "Đăng ký tài khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ctxMenuDangKy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picDangKy;
        private System.Windows.Forms.PictureBox picDangNhap;
        private System.Windows.Forms.ToolTip ttipDangNhap;
        private System.Windows.Forms.ToolTip ttipThongTinBatBuoc;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDangKy;
        private System.Windows.Forms.ToolStripMenuItem menuQuayLai;
        private System.Windows.Forms.ToolTip ttipTDNMK;
    }
}