using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    class LayDuLieuNguoiChoi : KetNoiCSDL
    {
        public NguoiChoi User { get; set; }

        protected bool LayDuLieu(string TenTaiKhoan, string MatKhau)
        {
            MoKetNoi();

            // bo khoan trang du o dau va cuoi chuoi
            TenTaiKhoan = TenTaiKhoan.Trim();
            MatKhau = MatKhau.Trim();

            try
            {
                SqlCommand cmd = new SqlCommand("DangNhap", KetNoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", MatKhau));

                SqlDataReader DocDuLieu = cmd.ExecuteReader();
                string taikhoan, matkhau;

                while (DocDuLieu.Read())
                {
                    taikhoan = DocDuLieu.GetString(0);
                    matkhau = DocDuLieu.GetString(1);

                    User = new NguoiChoi(taikhoan, matkhau);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DongKetNoi();
            }

            return User != null;
        }
    }
}
