using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    class CapNhatDiem : KetNoiCSDL
    {
        public void CapNhat()
        {
            MoKetNoi();

            try
            {
                SqlCommand cmd = new SqlCommand("CapNhatDiem", KetNoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", frmDangNhap.User.TenTaiKhoan));
                cmd.Parameters.Add(new SqlParameter("@DiemCapNhat", frmDangNhap.User.Diem));
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khác.\n" + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
