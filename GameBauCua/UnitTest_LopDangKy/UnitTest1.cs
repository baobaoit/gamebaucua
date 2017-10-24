using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTest_LopDangKy
{
    [TestClass]
    public class UnitTest1
    {
        DangKy dangKy = null;
        XoaTaiKhoan xoaTaiKhoan = new XoaTaiKhoan();
        string TenTaiKhoan = "us3";
        [TestMethod]
        public void TestDangKyHopLe1()
        {
            // hop le 1: chi can ten tai khoan va mat khau
            string MatKhau = "us3";
            dangKy = new DangKy(TenTaiKhoan, MatKhau, "", "", "");
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
            xoaTaiKhoan.Xoa(TenTaiKhoan);
        }

        [TestMethod]
        public void TestDangKyHopLe2()
        {
            // hop le 2: dang ky day du thong tin
            bool MongMuon = true;
            dangKy = new DangKy(TenTaiKhoan, "us3", "Nam", "Khong biet", "097");
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
            xoaTaiKhoan.Xoa(TenTaiKhoan);
        }

        [TestMethod]
        public void TestDangKyHopLe3()
        {
            // hop le 3: trung mat khau
            dangKy = new DangKy(TenTaiKhoan, "Admin", "gt", "dc", "sdt");
            bool MongMuon = true;
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
            xoaTaiKhoan.Xoa(TenTaiKhoan);
        }

        [TestMethod]
        public void TestDangKyKhongHopLe1()
        {
            // khong hop le 1: bo trong hoan toan
            dangKy = new DangKy("", "", "", "", "");
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
        }

        [TestMethod]
        public void TestDangKyKhongHopLe2()
        {
            // khong hop le 2: bo trong tai khoan
            dangKy = new DangKy("", "mk", "gt", "dc", "sdt");
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
        }

        [TestMethod]
        public void TestDangKyKhongHopLe3()
        {
            // khong hop le 3: bo trong mat khau
            dangKy = new DangKy(TenTaiKhoan, "", "gt", "dc", "sdt");
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
        }

        [TestMethod]
        public void TestDangKyKhongHopLe4()
        {
            // khong hop le 4: trung ten tai khoan
            dangKy = new DangKy("Admin", "mk", "gt", "dc", "sdt");
            bool MongMuon = false;
            Assert.AreEqual(MongMuon, dangKy.ThucHienDangKy());
        }
    }
}
