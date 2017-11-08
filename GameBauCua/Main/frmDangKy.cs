using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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

            try
            {
                #region Kiểm tra Tên đăng nhập và Mật khẩu hợp lệ
                if (!txtTenDangNhap.Text.HopLe())
                    throw new ArgumentException("Tên đăng nhập không hợp lệ.\nVui lòng kiểm tra lại!");

                if (!txtMatKhau.Text.HopLe())
                    throw new ArgumentException("Mật khẩu không hợp lệ.\nVui lòng kiểm tra lại!"); 
                #endregion

                if (new DangKy(txtTenDangNhap.Text, txtMatKhau.Text, GioiTinh, txtDiaChi.Text, txtSoDienThoai.Text).ThucHienDangKy())
                {
                    if (MessageBox.Show("Bạn đã đăng ký tài khoản thành công.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                        Close();
                }
                else
                    MessageBox.Show("Tên tài khoàn và mật khẩu không được để trống!\nHoặc tên tài khoản đã tồn tại vui lòng sử dụng tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void picDangNhap_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }

    public static class KiemTraChuoi
    {
        public static bool HopLe(this string input)
        {
            // kiem tra toi thieu 6 ky tu khong
            if (input.Length < 6 || input.Length > 12)
                return false; // dung kiem tra luon
            #region Tên tài khoản có tối thiểu 6 ký tự
            // khong phai la ky tu chu, ky tu so, _
            Regex regex = new Regex(@"\W");
            if (regex.IsMatch(input))
                return false;
            #endregion

            return true;
        }
    }
}
