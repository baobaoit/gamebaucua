using System.Data;
using System.Data.SqlClient;

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
                throw ex;
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
