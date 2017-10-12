using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    class XemDiem : KetNoiCSDL
    {
        private string TenTaiKhoan = string.Empty;

        public XemDiem(string TenTaiKhoan)
        {
            this.TenTaiKhoan = TenTaiKhoan;
        }

        public void ThucThiXemDiem()
        {
            MoKetNoi();

            try
            {
                SqlCommand cmd = new SqlCommand("XemDiem", KetNoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenTaiKhoan", TenTaiKhoan));
                SqlDataReader DocDuLieu = cmd.ExecuteReader();

                string Diem = "0";

                while (DocDuLieu.Read())
                {
                    Diem = DocDuLieu.GetString(0);
                }

                MessageBox.Show(string.Format("Điểm của {0}: {1}", TenTaiKhoan, Diem));
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
