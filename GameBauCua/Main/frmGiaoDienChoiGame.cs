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
    public partial class frmGiaoDienChoiGame : Form
    {
        private string TenTaiKhoan = string.Empty;
        public frmGiaoDienChoiGame(string TenTaiKhoan)
        {
            InitializeComponent();

            this.TenTaiKhoan = TenTaiKhoan;
        }

        private void picXemDiem_Click(object sender, EventArgs e)
        {
            new XemDiem(TenTaiKhoan).ThucThiXemDiem();  
        }
    }
}
