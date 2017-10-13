using System.Data.SqlClient;
using System.Data;

namespace Main
{
    class DangKy : KetNoiCSDL
    {
        public bool ThucHienDangKy(string TenTaiKhoan, string MatKhau, string GioiTinh, string DiaChi, string SoDienThoai)
        {
            TenTaiKhoan = TenTaiKhoan.Trim();
            MatKhau = MatKhau.Trim();
            GioiTinh = GioiTinh.Trim();
            DiaChi = DiaChi.Trim();
            SoDienThoai = SoDienThoai.Trim();
            bool DangKyThanhCong = false; // trang thai dang ky

            if (TenTaiKhoan == string.Empty || MatKhau == string.Empty)
                return false;

            MoKetNoi();

            try
            {
                SqlCommand cmd = new SqlCommand("DangKy", KetNoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", MatKhau));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SoDienThoai", SoDienThoai));

                DangKyThanhCong = cmd.ExecuteNonQuery() != 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DongKetNoi();
            }

            return DangKyThanhCong;
        }
    }
}
