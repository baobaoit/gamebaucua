using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Main
{
    public class KetNoiCSDL
    {
        #region Thuộc tính của người chơi
        protected string TenTaiKhoan = string.Empty, MatKhau = string.Empty, GioiTinh = string.Empty, DiaChi = string.Empty, SoDienThoai = string.Empty, Diem = string.Empty; 
        #endregion
        protected SqlConnection KetNoi = null;
        public KetNoiCSDL()
        {
            string ChuoiKetNoi = ConfigurationManager.ConnectionStrings["QLTaiKhoan"].ConnectionString;
            KetNoi = new SqlConnection(ChuoiKetNoi);
        }

        protected void MoKetNoi()
        {
            try
            {
                if (KetNoi.State != ConnectionState.Open)
                {
                    KetNoi.Open();
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
        }

        protected void DongKetNoi()
        {
            if (KetNoi.State != ConnectionState.Closed)
            {
                KetNoi.Close();
            }
        }
    }
}
