using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class frmMain : Form
    {
        ChoiGame Choi = null;
                                        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            #region Ẩn thanh TitleBar và Sửa lỗi hiển thị thanh màu trắng ở dưới chương trình
            Hide();
            Text = "";
            ControlBox = false;
            Show();
            #endregion

            #region Khởi tạo chương trình
            Choi = new ChoiGame();
            //dat hinh dai dien
            if (frmDangNhap.User.GioiTinh == "Nam")
                picHinhDaiDien.Image = Properties.Resources.nam;
            else
                picHinhDaiDien.Image = Properties.Resources.nu;
            //dat ten tai khoan
            lblTenNguoiChoi.Text = "Tên người chơi: " + frmDangNhap.User.TenTaiKhoan;
            //dat diem cho nguoi choi
            lblDiem.Text = "Điểm: " + Choi.Diem.ToString();
            //dat tai khoan cho nguoi choi
            lblTaiKhoan.Text = "Tài khoản: " + Choi.TaiKhoan.ToString(); 
            #endregion
        }

        private void txtDatNai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void XuLyTienCuocKhongHopLe(ref TextBox TienCuoc)
        {
            if (string.IsNullOrEmpty(TienCuoc.Text))
                TienCuoc.Text = "0";
        }

        private void picXoc_Click(object sender, EventArgs e)
        {
            #region Xử lý các ô đặt cược bị để trống
            XuLyTienCuocKhongHopLe(ref txtDatNai);
            XuLyTienCuocKhongHopLe(ref txtDatBau);
            XuLyTienCuocKhongHopLe(ref txtDatGa);
            XuLyTienCuocKhongHopLe(ref txtDatCa);
            XuLyTienCuocKhongHopLe(ref txtDatCua);
            XuLyTienCuocKhongHopLe(ref txtDatTom); 
            #endregion

            int[] TienDatCuoc =
            {
                Convert.ToInt32(txtDatNai.Text),
                Convert.ToInt32(txtDatBau.Text),
                Convert.ToInt32(txtDatGa.Text),
                Convert.ToInt32(txtDatCa.Text),
                Convert.ToInt32(txtDatCua.Text),
                Convert.ToInt32(txtDatTom.Text),
            };
            if (Choi.XocBauCua(TienDatCuoc).Equals(0))
            {
                MessageBox.Show("Số tiền đặt cược không được vượt quá số tài khoản hiện có!\nHoặc bạn chưa đặt tiền cược!\nVui lòng điều chỉnh lại tiền đặt cược!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #region Hiện kết quả quay hình lên form
            picKetQua1.Image = Choi.HinhKetQua(1);
            picKetQua2.Image = Choi.HinhKetQua(2);
            picKetQua3.Image = Choi.HinhKetQua(3); 
            #endregion

            lblDiem.Text = "Điểm: " + Choi.Diem.ToString();
            lblTaiKhoan.Text = "Tài khoản: " + Choi.TaiKhoan.ToString();

            #region Cập nhật điểm của người chơi vào CSDL
            try
            {
                if (Choi.TaiKhoan.Equals(0))
                {
                    if (Convert.ToInt32(frmDangNhap.User.Diem) < Choi.Diem)
                    {
                        frmDangNhap.User.Diem = Choi.Diem.ToString();
                        new CapNhatDiem(frmDangNhap.User.TenTaiKhoan, frmDangNhap.User.Diem).CapNhat();
                    }
                    MessageBox.Show("Tài khoản của bạn đã hết!\nĐể chơi lại bấm vào nút Chơi ngay.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #endregion
        }

        private void picHinhDaiDien_Click(object sender, EventArgs e) => Close();

        private void menuDangXuat_Click(object sender, EventArgs e) => Close();
    }
}
