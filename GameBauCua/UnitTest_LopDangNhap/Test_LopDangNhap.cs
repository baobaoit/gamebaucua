using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTest_LopDangNhap
{
    [TestClass]
    public class Test_LopDangNhap
    {
        private DangNhap dangNhap = null;
        [TestMethod]
        public void TestTenDangNhapTrong()
        {
            dangNhap = new DangNhap("", "123456");
            Assert.AreEqual(null, dangNhap.ThucHienDangNhap());
        }
        [TestMethod]
        public void TestMatKhauTrong()
        {
            dangNhap = new DangNhap("123456", "");
            Assert.AreEqual(null, dangNhap.ThucHienDangNhap());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTaiKhoanChuaTonTai()
        {
            dangNhap = new DangNhap("chuatontai", "123456");
            dangNhap.ThucHienDangNhap();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSaiMatKhau()
        {
            dangNhap = new DangNhap("gamebaucua", "123456");
            dangNhap.ThucHienDangNhap();
        }
        [TestMethod]
        public void TestDangNhapThanhCong()
        {
            dangNhap = new DangNhap("gamebaucua", "gamebaucua");
            Assert.AreNotEqual(null, dangNhap.ThucHienDangNhap());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTenDangNhapLaCauQuery()
        {
            dangNhap = new DangNhap("game OR 1=1", "gamebaucua");
            dangNhap.ThucHienDangNhap();
        }
    }
}
