using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;

namespace UnitTest_LopChoiGame
{
    [TestClass]
    public class Test_LopChoiGame
    {
        ChoiGame choiGame;
        int[] TienDatCuoc;

        [TestMethod]
        public void TestTongDiemDatCuoc_LonHonDiemNguoiChoi()
        {
            choiGame = new ChoiGame(500);
            int Nai = 501;
            TienDatCuoc = new int[]
            {
                Nai, 0, 0, 0, 0, 0
            };
            Assert.AreEqual(0, choiGame.Mo(TienDatCuoc));
        }
        [TestMethod]
        public void TestTongDiemDatCuoc_Bang0()
        {
            choiGame = new ChoiGame(500);
            TienDatCuoc = new int[6];
            Assert.AreEqual(0, choiGame.Mo(TienDatCuoc));
        }
        [TestMethod]
        public void TestPhuongThucMo()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500;
            TienDatCuoc = new int[]
            {
                Nai, 0, 0, 0, 0, 0
            };
            choiGame.Xoc(0, 1, 2); // cho xuat hien 1 con Nai
            Assert.AreEqual(1, choiGame.Mo(TienDatCuoc));
        }
        [TestMethod]
        public void TestPhuongThucMo_QuayTrungVaKhongQuayTrung()
        {
            choiGame = new ChoiGame(500);
            int Nai = 499, Bau = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, 0, 0, 0, 0
            };
            choiGame.Xoc(0, 2, 3); // quay trung Nai, khong quay trung bau
            Assert.AreEqual(1, choiGame.Mo(TienDatCuoc));
        }
    }
}
