using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTest_LopDangNhap
{
    [TestClass]
    public class Test_LopDangNhap
    {
        DangNhap dangNhap = null;
        [TestMethod]
        public void TestDangNhapHopLe()
        {
            dangNhap = new DangNhap("Admin", "Admin");
            NguoiChoi nguoiChoi = dangNhap.ThucHienDangNhap();
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, NguoiChoi.TonTai(nguoiChoi));
        }

        [TestMethod]
        public void TestDangNhapKhongHopLe1()
        {
            // dang nhap voi tai khoan va mat khau de trong
            dangNhap = new DangNhap("", "");
            NguoiChoi nguoiChoi = dangNhap.ThucHienDangNhap();
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, NguoiChoi.TonTai(nguoiChoi));
        }

        [TestMethod]
        public void TestDangNhapKhongHopLe2()
        {
            // dang nhap voi tai khoan va mat khau chua dang ky
            dangNhap = new DangNhap("khanh", "khanh69");
            NguoiChoi nguoiChoi = dangNhap.ThucHienDangNhap();
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, NguoiChoi.TonTai(nguoiChoi));
        }

        [TestMethod]
        public void TestDangNhapKhongHopLe3()
        {
            // tai khoan co trong csdl nhung mat khau de trong
            dangNhap = new DangNhap("us1", "");
            NguoiChoi nguoiChoi = dangNhap.ThucHienDangNhap();
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, NguoiChoi.TonTai(nguoiChoi));
        }
    }
}
