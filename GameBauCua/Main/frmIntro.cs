using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Main
{
    public partial class frmIntro : Form
    {
        private string DuongDanHinh = string.Empty;
        bool BatFormMain = false;
        public frmIntro(string DuongDanChuongTrinh)
        {
            InitializeComponent();
            DuongDanHinh = DuongDanChuongTrinh;
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            DuongDanHinh = DuongDanHinh + @"\Hinh\";

            TaoHaiPictureBox();
            timer1.Start();
        }

        private void TaoPictureBox(string TenPictureBox, string DuongDanHinhAnh, int KichThuocPictureBox, int x, int y)
        {
            PictureBox pic = new PictureBox();
            pic.Name = TenPictureBox;
            pic.Image = Image.FromFile(DuongDanHinhAnh);
            pic.Size = new Size(KichThuocPictureBox, KichThuocPictureBox);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Location = new Point(x, y);
            Controls.Add(pic);
        }

        private void TaoHaiPictureBox()
        {
            //pic1
            TaoPictureBox("pic1", DuongDanHinh + "1.png", 69, 5, ClientRectangle.Height / 3);
            //pic2
            TaoPictureBox("pic2", DuongDanHinh + "2.png", 69, ClientRectangle.Width - 74, ClientRectangle.Height / 3);
        }

        private void FrmIntro_Paint(object sender, PaintEventArgs e)
        {
            //to nen
            HatchBrush CoToNen = new HatchBrush(HatchStyle.Wave, Color.Red, Color.White);
            e.Graphics.FillRectangle(CoToNen, ClientRectangle);
            
            int dx = 4, dy = 3;
            Rectangle KhungHCN = new Rectangle(dx, dy, ClientRectangle.Width, ClientRectangle.Height);
            string GioiThieu = "Game Bầu Cua Tôm Cá\nNhóm Thiếu Nữ";
            Font font = new Font("Arial", 28, FontStyle.Bold);
            StringFormat DinhDangChu = new StringFormat();
            //canh giua
            DinhDangChu.Alignment = StringAlignment.Center;
            DinhDangChu.LineAlignment = StringAlignment.Center;
            //ve bong cua chu
            e.Graphics.DrawString(GioiThieu, font, new SolidBrush(Color.Brown), KhungHCN, DinhDangChu);
            KhungHCN.X -= dx;
            KhungHCN.Y -= dy;
            //ve chu
            e.Graphics.DrawString(GioiThieu, font, new SolidBrush(Color.Blue), KhungHCN, DinhDangChu);
            //ve vien
            Pen pen = new Pen(Color.Red, 10);
            e.Graphics.DrawRectangle(pen, ClientRectangle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dx = 5; //toc do di chuyen cua 2 hinh
            //tim 2 hinh trong mang Control cua form
            Control[] pic1 = Controls.Find("pic1", false);
            Control[] pic2 = Controls.Find("pic2", false);
            //di chuyen 2 hinh ve gan nhau
            pic1[0].Left += dx;
            pic2[0].Left -= dx;
            //2 hinh dung nhau
            if (pic1[0].Bounds.IntersectsWith(pic2[0].Bounds))
            {
                BatFormMain = true;
            }

            if (BatFormMain)
            {
                timer1.Stop(); //dung timer
                Hide();
                new frmMain().ShowDialog();
                Close();
            }
        }
    }
}
