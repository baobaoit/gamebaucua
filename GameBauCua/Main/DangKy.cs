using System.Data.SqlClient;
using System.Data;
using System;

namespace Main
{
    public class DangKy : KetNoiCSDL
    {
        public DangKy(string TenTaiKhoan, string MatKhau, string GioiTinh, string DiaChi, string SoDienThoai)
        {
            this.TenTaiKhoan = TenTaiKhoan.Trim();
            this.MatKhau = MatKhau.Trim();
            this.GioiTinh = GioiTinh.Trim();
            this.DiaChi = DiaChi.Trim();
            this.SoDienThoai = SoDienThoai.Trim();
        }

        private bool CoTheDangKy()
        {
            bool CoThe = false;

            MoKetNoi();

            try
            {
                //kiem tra tai khoan co trong CSDL chua
                SqlCommand cmdTaiKhoanHopLe = new SqlCommand("KiemTraTaiKhoanHopLe", KetNoi)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmdTaiKhoanHopLe.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                string TaiKhoanTrongCSDL = string.Empty;
                using (SqlDataReader readerDocTaiKhoan = cmdTaiKhoanHopLe.ExecuteReader())
                {
                    while (readerDocTaiKhoan.Read())
                    {
                        if (!readerDocTaiKhoan.IsDBNull(0))
                            TaiKhoanTrongCSDL = readerDocTaiKhoan.GetString(0);
                    }
                }
                /*
                 * Neu tai khoan co trong he thong => != string.Empty => Ko the dang ky voi ten tai khoan nay
                 * Neu tai khoan ko co trong he thong => == string.Empty => Co the dang ky voi ten tai khoan nay
                 */
                CoThe = TaiKhoanTrongCSDL == string.Empty;
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

            if (TenTaiKhoan == string.Empty || MatKhau == string.Empty)
                return false;

            try
            {
                if (!CoTheDangKy()) //tai khoan da co trong CSDL
                {
                    return false;
                }
                else //tai khoan chua co trong CSDL
                {
                    MoKetNoi();

                    SqlCommand cmdDangKy = new SqlCommand("DangKy", KetNoi)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmdDangKy.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                    cmdDangKy.Parameters.Add(new SqlParameter("@MatKhau", MatKhau));
                    cmdDangKy.Parameters.Add(new SqlParameter("@GioiTinh", GioiTinh));
                    cmdDangKy.Parameters.Add(new SqlParameter("@DiaChi", DiaChi));
                    cmdDangKy.Parameters.Add(new SqlParameter("@SoDienThoai", SoDienThoai));

                    DangKyThanhCong = cmdDangKy.ExecuteNonQuery() == 1; 
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
