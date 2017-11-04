using System;
using System.Data;
using System.Data.SqlClient;

namespace Main
{
    public class LayDuLieuNguoiChoi : KetNoiCSDL
    {
        protected NguoiChoi LayDuLieu()
        {
            NguoiChoi User = null;
            MoKetNoi();
            
            try
            {
                SqlCommand cmd = new SqlCommand("DangNhap", KetNoi)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));

                #region Đọc dữ liệu người dùng từ CSDL
                SqlDataReader DocDuLieu = cmd.ExecuteReader();
                string taikhoan, matkhau, gioitinh = "", diachi = "", sodienthoai = "", diem = "0";

                while (DocDuLieu.Read())
                {
                    taikhoan = DocDuLieu.GetString(0);
                    matkhau = DocDuLieu.GetString(1);

                    if (!DocDuLieu.IsDBNull(2)) //IsDBNull la kiem tra du lieu trong CSDL co phai la NULL ko
                        gioitinh = DocDuLieu.GetString(2);

                    if (!DocDuLieu.IsDBNull(3))
                        diachi = DocDuLieu.GetString(3);

                    if (!DocDuLieu.IsDBNull(4))
                        sodienthoai = DocDuLieu.GetString(4);

                    diem = DocDuLieu.GetString(5);

                    User = new NguoiChoi(taikhoan, matkhau, gioitinh, diachi, sodienthoai, diem);
                } 
                #endregion
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

            return User;
        }
    }
}
