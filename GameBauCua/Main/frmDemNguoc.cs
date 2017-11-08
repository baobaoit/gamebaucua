using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Main
{
    public partial class frmDemNguoc : Form
    {
        private bool BatFormMain = false;
        private int DemNguoc = 3;
        public frmDemNguoc()
        {
            InitializeComponent();
        }

        private void frmDemNguoc_Load(object sender, EventArgs e)
        {
            #region Khởi động timer
            timer1.Start();
            #endregion
        }


        private void frmDemNguoc_Paint(object sender, PaintEventArgs e)
        {
            #region Vẽ lên form đếm ngược
            //to nen
            HatchBrush CoToNen = new HatchBrush(HatchStyle.LargeCheckerBoard, Color.Red, Color.White);
            e.Graphics.FillRectangle(CoToNen, ClientRectangle);

            int dx = 4, dy = 3;
            Rectangle KhungHCN = new Rectangle(dx, dy, ClientRectangle.Width, ClientRectangle.Height);
            Font font = new Font("Arial", 85, FontStyle.Bold);
            StringFormat DinhDangChu = new StringFormat
            {
                //canh giua
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var VietThongBao = (DemNguoc == 0) ? "Mở!" : DemNguoc.ToString();
            //ve bong cua chu
            e.Graphics.DrawString(VietThongBao, font, new SolidBrush(Color.Brown), KhungHCN, DinhDangChu);
            KhungHCN.X -= dx;
            KhungHCN.Y -= dy;
            //ve chu
            e.Graphics.DrawString(VietThongBao, font, new SolidBrush(Color.Blue), KhungHCN, DinhDangChu);
            //ve vien
            Pen pen = new Pen(Color.Red, 10);
            e.Graphics.DrawRectangle(pen, ClientRectangle);
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Xử lý đếm ngược thời gian
            DemNguoc--;
            Invalidate();
            if (DemNguoc.Equals(-1))
            {
                BatFormMain = true;
            }
            #endregion

            if (BatFormMain)
            {
                timer1.Stop(); //dung timer
                Close();
            }
        }
    }
}
