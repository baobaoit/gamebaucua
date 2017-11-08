using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Main
{
    public partial class frmGioiThieu : Form
    {
        private bool BatFormMain = false;
        public frmGioiThieu()
        {
            InitializeComponent();
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {
            #region Tạo 2 hình và khởi động timer
            TaoHaiPictureBox();
            timer1.Start(); 
            #endregion
        }

        private void TaoHaiPictureBox()
        {
            //pic1
            Controls.Add(TaoPictureBox.Tao("pic1", Properties.Resources._1, new Size(69, 69), 5, ClientRectangle.Height / 3));
            //pic2
            Controls.Add(TaoPictureBox.Tao("pic2", Properties.Resources._2, new Size(69, 69), ClientRectangle.Width - 74, ClientRectangle.Height / 3));
        }

        private void FrmIntro_Paint(object sender, PaintEventArgs e)
        {
            #region Vẽ lên form giới thiệu
            //to nen
            HatchBrush CoToNen = new HatchBrush(HatchStyle.Wave, Color.Red, Color.White);
            e.Graphics.FillRectangle(CoToNen, ClientRectangle);

            int dx = 4, dy = 3;
            Rectangle KhungHCN = new Rectangle(dx, dy, ClientRectangle.Width, ClientRectangle.Height);
            string GioiThieu = "Game Bầu Cua Tôm Cá\nNhóm Thiếu Nữ";
            Font font = new Font("Arial", 28, FontStyle.Bold);
            StringFormat DinhDangChu = new StringFormat
            {
                //canh giua
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            //ve bong cua chu
            e.Graphics.DrawString(GioiThieu, font, new SolidBrush(Color.Brown), KhungHCN, DinhDangChu);
            KhungHCN.X -= dx;
            KhungHCN.Y -= dy;
            //ve chu
            e.Graphics.DrawString(GioiThieu, font, new SolidBrush(Color.Blue), KhungHCN, DinhDangChu);
            //ve vien
            Pen pen = new Pen(Color.Red, 10);
            e.Graphics.DrawRectangle(pen, ClientRectangle); 
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Xử lý khi 2 hình chạm nhau
            int dx = 10; //toc do di chuyen cua 2 hinh
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
            #endregion

            if (BatFormMain)
            {
                timer1.Stop(); //dung timer
                using (frmMain Main = new frmMain())
                {
                    Hide();
                    Main.ShowDialog();
                    Close();
                }
            }
        }
    }
}
