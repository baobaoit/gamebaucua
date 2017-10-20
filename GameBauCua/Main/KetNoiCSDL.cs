using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Main
{
    class KetNoiCSDL
    {
        protected string TenTaiKhoan = string.Empty, MatKhau = string.Empty, GioiTinh = string.Empty, DiaChi = string.Empty, SoDienThoai = string.Empty, Diem = string.Empty;
        protected SqlConnection KetNoi = null;
        public KetNoiCSDL()
        {
            string ChuoiKetNoi = ConfigurationManager.ConnectionStrings["QLTaiKhoan"].ConnectionString;
            KetNoi = new SqlConnection(ChuoiKetNoi);
        }

        protected void MoKetNoi()
        {
            try
            {
                if (KetNoi.State != ConnectionState.Open)
                {
                    KetNoi.Open();
                }
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

        protected void DongKetNoi()
        {
            if (KetNoi.State != ConnectionState.Closed)
            {
                KetNoi.Close();
            }
        }
    }
}
