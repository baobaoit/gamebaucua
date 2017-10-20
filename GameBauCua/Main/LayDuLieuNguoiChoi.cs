using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    class LayDuLieuNguoiChoi : KetNoiCSDL
    {
        protected bool LayDuLieu(string TenTaiKhoan, string MatKhau)
        {
            MoKetNoi();

            //bo khoan trang du o dau va cuoi chuoi
            TenTaiKhoan = TenTaiKhoan.Trim();
            MatKhau = MatKhau.Trim();

            try
            {
                SqlCommand cmd = new SqlCommand("DangNhap", KetNoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenDangNhap", TenTaiKhoan));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", MatKhau));

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

                    frmDangNhap.User = new NguoiChoi(taikhoan, matkhau, gioitinh, diachi, sodienthoai, diem);
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
            finally
            {
                DongKetNoi();
            }

            return frmDangNhap.User != null;
        }
    }
}
