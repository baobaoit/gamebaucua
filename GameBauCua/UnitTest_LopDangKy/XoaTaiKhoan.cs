using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_LopDangKy
{
    class XoaTaiKhoan
    {
        private SqlConnection connection = null;
        public XoaTaiKhoan()
        {
            string ChuoiKetNoi = ConfigurationManager.ConnectionStrings["QLTaiKhoan"].ConnectionString;
            connection = new SqlConnection(ChuoiKetNoi);
        }

        public bool Xoa(string TenTaiKhoan)
        {
            connection.Open();
            int SoDongThucHien = 0;

            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap", connection);
                command.Parameters.AddWithValue("@TenDangNhap", TenTaiKhoan);
                SoDongThucHien = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return !SoDongThucHien.Equals(0);
        }
    }
}
