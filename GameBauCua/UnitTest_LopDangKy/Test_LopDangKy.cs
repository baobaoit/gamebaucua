using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTest_LopDangKy
{
    [TestClass]
    public class Test_LopDangKy
    {
        private DangKy dangKy = null;
        #region Test hàm khởi tạo
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHamKhoiTao_TenTaiKhoanTrong()
        {
            dangKy = new DangKy("", "123456");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHamKhoiTao_MatKhauTrong()
        {
            dangKy = new DangKy("123456", "");
        }
        [TestMethod]
        public void TestHamKhoiTao_ThanhCong()
        {
            dangKy = new DangKy("baobao", "baobao");
            Assert.IsNotNull(dangKy);
        }
        #endregion

        #region Test thực hiện đăng ký
        [TestMethod]
        public void TestThucHienDangKy_KhongTheDangKy()
        {
            // tai khoan da ton tai trong csdl roi
            dangKy = new DangKy("gamebaucua", "gamebaucua");
            Assert.IsFalse(dangKy.ThucHienDangKy());
        }
        [TestMethod]
        public void TestThucHienDangKy_DangKyThanhCong()
        {
            dangKy = new DangKy("gamebaucua1", "gamebaucua");
            Assert.IsTrue(dangKy.ThucHienDangKy());
            new XoaTaiKhoan().Xoa("gamebaucua1");
        }
        #endregion
    }

    public class XoaTaiKhoan : KetNoiCSDL
    {
        public bool Xoa(string TenTaiKhoan)
        {
            bool KetQua = false;
            MoKetNoi();

            try
            {
                System.Data.SqlClient.SqlCommand cmdXoa = new System.Data.SqlClient.SqlCommand()
                {
                    CommandText = "DELETE FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap",
                    Connection = KetNoi
                };
                cmdXoa.Parameters.AddWithValue("@TenDangNhap", TenTaiKhoan);
                KetQua = cmdXoa.ExecuteNonQuery().Equals(1);
            }
            finally
            {
                DongKetNoi();
            }
            return KetQua;
        }
    }
}
