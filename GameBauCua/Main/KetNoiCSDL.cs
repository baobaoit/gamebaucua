using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Main
{
    class KetNoiCSDL
    {
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
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (ConfigurationErrorsException ex)
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
