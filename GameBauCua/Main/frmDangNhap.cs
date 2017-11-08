using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    public partial class frmDangNhap : Form
    {
        public static NguoiChoi User = null; //su dung chung cho tat ca cac form
        public frmDangNhap()
        {
            InitializeComponent();

            try
            {
                BaoMat_EM.EncryptConnectionString(Application.StartupPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                User = new DangNhap(txtTenDangNhap.Text, txtMatKhau.Text).ThucHienDangNhap();
                if (NguoiChoi.TonTai(User))
                {
                    if (MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
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
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData.Equals(Keys.Enter))
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
            if (MessageBox.Show("Bạn muốn thoát chương trình chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
