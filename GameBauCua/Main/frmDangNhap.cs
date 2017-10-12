using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Mo form dang ky
            Hide();
            new frmDangKy().ShowDialog();
            Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (new DangNhap(txtTenDangNhap.Text, txtMatKhau.Text).ThucHienDangNhap())
                if (MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Hide();
                    new frmGiaoDienChoiGame(txtTenDangNhap.Text).ShowDialog();
                    Show();
                }
            else
                MessageBox.Show("Bạn cần đăng ký tài khoản trước khi chơi!\nNhấn vào nút đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
