using System;
using System.Windows.Forms;

namespace Main
{
    public partial class frmDangNhap : Form
    {
        public static NguoiChoi User = null; //su dung chung cho tat ca cac form
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Mo form dang ky
            using (frmDangKy frmDK = new frmDangKy())
            {
                Hide();
                frmDK.ShowDialog();
                Show();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void DangNhap()
        {
            if (new DangNhap(txtTenDangNhap.Text, txtMatKhau.Text).ThucHienDangNhap())
            {
                if (MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    using (frmGiaoDienChoiGame frmGDCG = new frmGiaoDienChoiGame())
                    {
                        Hide();
                        new frmGiaoDienChoiGame().ShowDialog();
                        Show();
                    }
                }
            }
            else
                MessageBox.Show("Bạn cần đăng ký hoặc đăng nhập tài khoản trước khi chơi!\nNhấn vào nút đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                DangNhap();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
