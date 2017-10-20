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
            XuLyTienCuocKhongHopLe(ref txtDatNai);
            XuLyTienCuocKhongHopLe(ref txtDatBau);
            XuLyTienCuocKhongHopLe(ref txtDatGa);
            XuLyTienCuocKhongHopLe(ref txtDatCa);
            XuLyTienCuocKhongHopLe(ref txtDatCua);
            XuLyTienCuocKhongHopLe(ref txtDatTom);

            int[] TienDatCuoc =
            {
                Convert.ToInt32(txtDatNai.Text),
                Convert.ToInt32(txtDatBau.Text),
                Convert.ToInt32(txtDatGa.Text),
                Convert.ToInt32(txtDatCa.Text),
                Convert.ToInt32(txtDatCua.Text),
                Convert.ToInt32(txtDatTom.Text),
            };
            Choi.XocBauCua(TienDatCuoc, ref picKetQua1, ref picKetQua2, ref picKetQua3);

            lblDiem.Text = "Điểm: " + Choi.Diem.ToString();
            lblTaiKhoan.Text = "Tài khoản: " + Choi.TaiKhoan.ToString();

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

        private void picHinhDaiDien_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
