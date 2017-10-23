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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void picDangKy_Click(object sender, EventArgs e)
        {
            string GioiTinh = "Nam";
            if (rdNu.Checked)
                GioiTinh = "Nữ";
            
            if (new DangKy(txtTenDangNhap.Text, txtMatKhau.Text, GioiTinh, txtDiaChi.Text, txtSoDienThoai.Text).ThucHienDangKy())
            {
                if (MessageBox.Show("Bạn đã đăng ký tài khoản thành công.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    Close();
            }
            else
                MessageBox.Show("Tên tài khoàn và mật khẩu không được để trống!\nHoặc tên tài khoản đã tồn tại vui lòng sử dụng tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            #region Ẩn thanh TitleBar và Sửa lỗi hiển thị thanh màu trắng ở dưới chương trình
            Hide();
            Text = "";
            ControlBox = false;
            Show();
            #endregion
        }

        private void picDangNhap_Click(object sender, EventArgs e) => Close();
    }
}
