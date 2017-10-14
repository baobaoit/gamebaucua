using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Main
{
    public partial class frmGiaoDienChoiGame : Form
    {
        private string TenTaiKhoan = string.Empty;
        private NhacNen NHAC_NEN = null;
        private string DuongDanFileNhac = string.Empty;

        public frmGiaoDienChoiGame(string TenTaiKhoan)
        {
            InitializeComponent();

            this.TenTaiKhoan = TenTaiKhoan;
        }

        private void picXemDiem_Click(object sender, EventArgs e)
        {
            new XemDiem(TenTaiKhoan).ThucThiXemDiem();  
        }

        private void frmGiaoDienChoiGame_Load(object sender, EventArgs e)
        {
            DuongDanFileNhac = Application.StartupPath + @"\Nhac\";
            if (Directory.Exists(DuongDanFileNhac))
            {
                NHAC_NEN = new NhacNen(DuongDanFileNhac + "nhac_nen.mp3");
                NHAC_NEN.ChoiNhac();
            }
            else
            {
                if (MessageBox.Show("Không tìm thấy file nhạc\nVui lòng chép 1 file nhạc MP3 bỏ vào thư mục Nhac của chương trình.\nVà đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Directory.CreateDirectory(DuongDanFileNhac);
                }
            }
        }

        private void frmGiaoDienChoiGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (NHAC_NEN != null)
            {
                NHAC_NEN.DungChoiNhac();
            }
        }

        private void picChoiNgay_Click(object sender, EventArgs e)
        {
            Hide();
            new frmIntro(Application.StartupPath).ShowDialog();
            Show();
        }

        private void picCaiDat_Click(object sender, EventArgs e)
        {
            OpenFileDialog ChonNhacNen = new OpenFileDialog();
            using (ChonNhacNen)
            {
                ChonNhacNen.Filter = "MP3 File|*.mp3";
                ChonNhacNen.Title = "Chọn nhạc nền";
                if (ChonNhacNen.ShowDialog() == DialogResult.OK)
                {
                    DuongDanFileNhac = ChonNhacNen.FileName;
                    NHAC_NEN.DoiNhac(DuongDanFileNhac);                    
                }
            }
        }
    }
}
