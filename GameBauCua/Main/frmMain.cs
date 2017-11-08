using System;
using System.Data.SqlClient;
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
            Choi = new ChoiGame(Convert.ToInt32(frmDangNhap.User.Diem));
            //dat hinh dai dien
            picHinhDaiDien.Image = (frmDangNhap.User.GioiTinh == "Nữ") ? Properties.Resources.nu : Properties.Resources.nam;
            //dat ten tai khoan
            lblTenNguoiChoi.Text = "Tên người chơi: " + frmDangNhap.User.TenTaiKhoan;
            //dat diem cho nguoi choi
            if (frmDangNhap.User.Diem == "0")
                MessageBox.Show("Chương trình xin tặng bạn 500 điểm để chơi game.\nChúc bạn chơi game vui vẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblDiem.Text = "Điểm: " + Choi.Diem.ToString();
            #endregion
        }

        private void txtDatNai_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Xử lý chỉ cho nhập ký tự số và phím điều khiển
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true; 
            #endregion
        }

        private void XuLyTienCuocKhongHopLe(ref TextBox TienCuoc)
        {
            #region Xử lý ô đặt cược bị bỏ trống
            if (string.IsNullOrEmpty(TienCuoc.Text))
                TienCuoc.Text = "0"; 
            #endregion
        }

        private void DatLaiTienCuoc(ref TextBox TienCuoc)
        {
            if (TienCuoc.Text != "0")
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

            #region Đưa các giá trị đặt cược vào mảng
            int[] TienDatCuoc =
            {
                Convert.ToInt32(txtDatNai.Text),
                Convert.ToInt32(txtDatBau.Text),
                Convert.ToInt32(txtDatGa.Text),
                Convert.ToInt32(txtDatCa.Text),
                Convert.ToInt32(txtDatCua.Text),
                Convert.ToInt32(txtDatTom.Text)
            };
            #endregion

            Choi.Xoc();
            if (Choi.Mo(TienDatCuoc).Equals(0))
            {
                MessageBox.Show("Số tiền đặt cược không được vượt quá số tài khoản hiện có!\nHoặc bạn chưa đặt tiền cược!\nVui lòng điều chỉnh lại tiền đặt cược!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #region Hiện form Đếm ngược
            using (frmDemNguoc DemNguoc = new frmDemNguoc())
            {
                DemNguoc.ShowDialog();
            }
            #endregion

            #region Hiện kết quả quay hình lên form
            picKetQua1.Image = Choi.HinhKetQua(1);
            picKetQua2.Image = Choi.HinhKetQua(2);
            picKetQua3.Image = Choi.HinhKetQua(3);
            #endregion

            if (MessageBox.Show(Choi.ThongBao, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
            {
                #region Đặt lại các ô đặt cược về 0
                DatLaiTienCuoc(ref txtDatNai);
                DatLaiTienCuoc(ref txtDatBau);
                DatLaiTienCuoc(ref txtDatGa);
                DatLaiTienCuoc(ref txtDatCa);
                DatLaiTienCuoc(ref txtDatCua);
                DatLaiTienCuoc(ref txtDatTom);
                #endregion
            }

            lblDiem.Text = "Điểm: " + Choi.Diem.ToString();

            #region Xử lý khi người chơi hết điểm
            if (Choi.Diem.Equals(0))
            {
                if (MessageBox.Show("Tài khoản của bạn đã hết!\nBạn có muốn nhận 500 điểm để chơi lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    Choi.Diem = 500;
                    lblDiem.Text = "Điểm: " + Choi.Diem.ToString();
                }
                else
                    Close();
            }
            #endregion
        }

        private void CapNhatDiemNguoiChoi()
        {
            try
            {
                frmDangNhap.User.Diem = Choi.Diem.ToString();
                new CapNhatDiem(frmDangNhap.User.TenTaiKhoan, frmDangNhap.User.Diem).CapNhat();
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

        private void picHinhDaiDien_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Cập nhật điểm của người chơi vào CSDL khi người chơi đóng form
            CapNhatDiemNguoiChoi();
            #endregion
        }

        private void menuChonNhac_Click(object sender, EventArgs e)
        {
            frmGiaoDienChoiGame.ChonFileNhacNen();
        }

        private void menuPhatNhac_Click(object sender, EventArgs e)
        {
            frmGiaoDienChoiGame.NHAC_NEN.PhatNhac();
        }

        private void menuTamDung_Click(object sender, EventArgs e)
        {
            frmGiaoDienChoiGame.NHAC_NEN.TamDungChoiNhac();
        }
    }
}
