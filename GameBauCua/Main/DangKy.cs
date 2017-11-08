using System.Data.SqlClient;
using System.Data;
using System;

namespace Main
{
    public class DangKy : KetNoiCSDL
    {
        public DangKy(string TenTaiKhoan, string MatKhau, string GioiTinh = "Nam", string DiaChi = "", string SoDienThoai = "")
        {
            if (TenTaiKhoan.Equals(string.Empty))
                throw new ArgumentException("Tên tài khoản không được để trống!");

            if (MatKhau.Equals(string.Empty))
                throw new ArgumentException("Mật khẩu không được để trống!");

            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
        }

        private bool CoTheDangKy()
        {
            bool CoThe = false;

            MoKetNoi();

            try
            {
                // kiem tra tai khoan co trong CSDL chua
                SqlCommand cmdTaiKhoanHopLe = new SqlCommand("KiemTraTaiKhoanHopLe", KetNoi)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdTaiKhoanHopLe.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                string TaiKhoanTrongCSDL = string.Empty;
                using (SqlDataReader DocTaiKhoan = cmdTaiKhoanHopLe.ExecuteReader())
                {
                    while (DocTaiKhoan.Read())
                    {
                        if (!DocTaiKhoan.IsDBNull(0))
                            TaiKhoanTrongCSDL = DocTaiKhoan.GetString(0);
                    }
                }
                /*
                 * Neu tai khoan co trong he thong => != string.Empty => Ko the dang ky voi ten tai khoan nay
                 * Neu tai khoan ko co trong he thong => == string.Empty => Co the dang ky voi ten tai khoan nay
                 */
                CoThe = TaiKhoanTrongCSDL.Equals(string.Empty);
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

            return CoThe;
        }

        public bool ThucHienDangKy()
        {
            bool DangKyThanhCong = false;
            
            try
            {
                if (!CoTheDangKy()) // tai khoan da co trong CSDL
                {
                    return false;
                }
                else // tai khoan chua co trong CSDL
                {
                    MoKetNoi();

                    SqlCommand cmdDangKy = new SqlCommand("DangKy", KetNoi)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdDangKy.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                    cmdDangKy.Parameters.Add(new SqlParameter("@MatKhau", MatKhau.ToMD5()));
                    cmdDangKy.Parameters.Add(new SqlParameter("@GioiTinh", GioiTinh));
                    cmdDangKy.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
                    cmdDangKy.Parameters.Add(new SqlParameter("@SoDienThoai", SoDienThoai));

                    DangKyThanhCong = cmdDangKy.ExecuteNonQuery().Equals(1); 
                }
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

            return DangKyThanhCong;
        }
    }
}
