using System;
using System.Windows.Forms;
using System.IO;

namespace Main
{
    public partial class frmGiaoDienChoiGame : Form
    {
        public static NhacNen NHAC_NEN = new NhacNen();
        public static string DuongDanFileNhac = string.Empty;

        public frmGiaoDienChoiGame()
        {
            InitializeComponent();
        }

        private void picXemDiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Điểm của {0}: {1}", frmDangNhap.User.TenTaiKhoan, frmDangNhap.User.Diem), "Xem điểm");
        }

        private void frmGiaoDienChoiGame_Load(object sender, EventArgs e)
        {
            #region Ẩn thanh TitleBar và Sửa lỗi hiển thị thanh màu trắng ở dưới chương trình
            Hide();
            Text = "";
            ControlBox = false;
            Show();
            #endregion
            ChuanBiNhacNen();
        }

        private void ChuanBiNhacNen()
        {
            DuongDanFileNhac = Application.StartupPath + @"\Nhac\"; //duong dan thu muc Nhac cua game
            #region Chuẩn bị nhạc nền cho chương trình
            if (Directory.Exists(DuongDanFileNhac)) //kiem tra thu muc Nhac co ton tai khong
            {
                /*
                 * neu ton tai thu muc Nhac
                 * kiem tra file nhac_nen.mp3 (file nhac nen mac dinh cua tro choi) co ton tai khong
                 */
                if (File.Exists(DuongDanFileNhac + "nhac_nen.mp3"))
                {
                    NHAC_NEN.GanDuongDanFileNhac(DuongDanFileNhac + "nhac_nen.mp3");
                }
                else //thu muc Nhac rong, khong tim thay file nhac_nen.mp3
                {
                    //lay tat ca file nhac co trong thu muc Nhac
                    string[] DanhSachFileNhac = Directory.GetFiles(DuongDanFileNhac);

                    //phat hien co file nhac
                    if (DanhSachFileNhac.Length > 0)
                    {
                        //su dung file nhac dau tien trong danh sach lam nhac nen
                        NHAC_NEN.GanDuongDanFileNhac(DanhSachFileNhac[0]);
                    }
                    else //thu muc Nhac rong, khong co file nhac mp3 nao
                    {
                        MessageBox.Show("Danh sách nhạc trống vui lòng sao chép file nhạc MP3 vào đường dẫn sau:\n" + DuongDanFileNhac + "\nSau đó đăng nhập lại!", "Không có file nhạc nền", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (!NHAC_NEN.ChuaCoNhacNen())
                    NHAC_NEN.PhatNhac();
            }
            else //thu muc Nhac bi xoa
            {
                if (MessageBox.Show("Không tìm thấy file nhạc\nVui lòng chép 1 file nhạc MP3 bỏ vào thư mục Nhac của chương trình.\nTại đường dẫn sau: " + Application.StartupPath + "\nVà đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //tao thu muc Nhac
                    Directory.CreateDirectory(DuongDanFileNhac);
                }
            } 
            #endregion
        }

        private void frmGiaoDienChoiGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!NHAC_NEN.ChuaCoNhacNen())
            {
                NHAC_NEN.DungChoiNhac();
            }
        }

        private void picChoiNgay_Click(object sender, EventArgs e)
        {
            using (frmGioiThieu frmGT = new frmGioiThieu())
            {
                Hide();
                /*
                 * hien form gioi thieu roi moi vao tro choi
                 */
                frmGT.ShowDialog();
                Show();
            }
        }

        public static void ChonFileNhacNen()
        {
            using (OpenFileDialog ChonNhacNen = new OpenFileDialog())
            {
                ChonNhacNen.Filter = "MP3 File|*.mp3";
                ChonNhacNen.Title = "Chọn nhạc nền";
                ChonNhacNen.InitialDirectory = DuongDanFileNhac;
                if (ChonNhacNen.ShowDialog().Equals(DialogResult.OK))
                {
                    DuongDanFileNhac = ChonNhacNen.FileName;
                    NHAC_NEN.DoiNhac(DuongDanFileNhac);
                    
                }
            }
        }

        private void picCaiDat_Click(object sender, EventArgs e)
        {
            ChonFileNhacNen();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
