using System;
using System.Data;
using System.Data.SqlClient;

namespace Main
{
    public class CapNhatDiem : KetNoiCSDL
    {
        public CapNhatDiem(string TenTaiKhoan, string Diem)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.Diem = Diem;
        }
        public void CapNhat()
        {
            MoKetNoi();

            try
            {
                SqlCommand cmd = new SqlCommand("CapNhatDiem", KetNoi)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", TenTaiKhoan));
                cmd.Parameters.Add(new SqlParameter("@DiemCapNhat", Diem));
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
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
