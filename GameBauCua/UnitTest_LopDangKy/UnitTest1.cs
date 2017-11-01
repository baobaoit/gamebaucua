using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTest_LopDangKy
{
    [TestClass]
    public class UnitTest1
    {
        #region Test mật khẩu
        [TestMethod]
        public void TestDangKyMatKhauHopLe1()
        {
            // mat khau co 6 ky tu
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("Nhile2"));
        }

        [TestMethod]
        public void TestDangKyMatKhauHopLe2()
        {
            // mat khau co 12 ky tu
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("NhihuuLe1234"));
        }

        [TestMethod]
        public void TestDangKyMatKhauHopLe3()
        {
            // mat khau co 7 ky tu
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("N123456"));
        }

        [TestMethod]
        public void TestDangKyMatKhauKhongHopLe1()
        {
            // mat khau co 5 ky tu
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("nhile"));
        }

        [TestMethod]
        public void TestDangKyMatKhauKhongHopLe2()
        {
            // mat khau co 13 ky tu
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("nhihuule12345"));
        }

        [TestMethod]
        public void TestDangKyMatKhauKhongHopLe3()
        {
            // mat khau co 6 ky tu, trong do co ky tu dac biet
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("nhi,. "));
        }
        #endregion

        #region Test tài khoản
        [TestMethod]
        public void TestDangKyTaiKhoanHopLe1()
        {
            // tai khoan co toi thieu 6 ky tu
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("nhile123"));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanHopLe2()
        {
            // tai khoan co 8 ky tu
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("nhi123"));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanHopLe3()
        {
            // tai khoan co 12 ky tu
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("Lê_Hữu_Nhị_2"));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanKhongHopLe1()
        {
            // nhap ten tai khoan 5 ky tu
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("NhiLe"));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanKhongHopLe2()
        {
            // nhap ten tai khoan 13 ky tu
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("NhiHuuLe12345"));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanKhongHopLe3()
        {
            // nhap ten tai khoan 6 ky tu, co ky tu dac biet
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("nhi@,."));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanKhongHopLe4()
        {
            // nhap ten tai khoan 6 ky tu, khoang trang o vi tri dau tien
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra(" HuuLe"));
        }

        [TestMethod]
        public void TestDangKyTaiKhoanKhongHopLe5()
        {
            // nhap ten tai khoan 6 ky tu, trong do co 2 khoang trang lien tiep
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, DangKy.KiemTra("Nhi  2"));
        } 
        #endregion
    }
}
