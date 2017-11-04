using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Main;
using System.Collections.Generic;

namespace UnitTest_LopChoiGame
{
    [TestClass]
    public class Test_LopChoiGame
    {
        ChoiGame choiGame;
        int[] TienDatCuoc;
        [TestMethod]
        public void TestDatCuoc1Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 501;
            TienDatCuoc = new int[]
            {
                Nai, 0, 0, 0, 0, 0
            };
            int MongMuon = 0;
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc1Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500;
            TienDatCuoc = new int[]
            {
                Nai, 0, 0, 0, 0, 0
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc1Con_p3()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1;
            TienDatCuoc = new int[]
            {
                Nai, 0, 0, 0, 0, 0
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc2Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500, Bau = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, 0, 0, 0, 0
            };
            int MongMuon = 0;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc2Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 499, Bau = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, 0, 0, 0, 0
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc3Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, 0, 0, 0
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 2);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc3Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 499, Bau = 1, Ga = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, 0, 0, 0
            };
            int MongMuon = 0;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }
        [TestMethod]
        public void TestDatCuoc4Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 497, Bau = 1, Ga = 1, Ca = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, 0, 0
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc4Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 499, Bau = 1, Ga = 1, Ca = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, 0, 0
            };
            int MongMuon = 0;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc5Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 496, Bau = 1, Ga = 1, Ca = 1, Cua = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, 0
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc5Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 499, Bau = 1, Ga = 1, Ca = 1, Cua = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, 0
            };
            int MongMuon = 0;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc6Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 495, Bau = 1, Ga = 1, Ca = 1, Cua = 1, Tom = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 1;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestDatCuoc6Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 499, Bau = 1, Ga = 1, Ca = 1, Cua = 1, Tom = 1;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 0;
            choiGame.Xoc(0, 1, 1);
            Assert.AreEqual(MongMuon, choiGame.Mo(TienDatCuoc));
        }

        [TestMethod]
        public void TestXoc1Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500, Bau = 0, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 0;
            choiGame.Xoc(1, 1, 1); // khong trung
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc1Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500, Bau = 0, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 1000;
            choiGame.Xoc(0, 1, 1); // trung 1 cai
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc1Con_p3()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500, Bau = 0, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 1500;
            choiGame.Xoc(0, 0, 1); // trung 2 cai
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc1Con_p4()
        {
            choiGame = new ChoiGame(500);
            int Nai = 500, Bau = 0, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 2000;
            choiGame.Xoc(0, 0, 0); // trung 3 cai
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc2Con_p1()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 498;
            choiGame.Xoc(4, 2, 3); // khong ra con nao
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc2Con_p2()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 500;
            choiGame.Xoc(0, 2, 3); // ra 1 trong 2 con
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc2Con_p3()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 502;
            choiGame.Xoc(0, 1, 2); // ra ca 2 con
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc2Con_p4()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 503;
            choiGame.Xoc(0, 1, 1); // ra 1 nai 2 bau
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc2Con_p5()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 501;
            choiGame.Xoc(0, 0, 2); // ra 2 nai (hoac bau)
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }

        [TestMethod]
        public void TestXoc2Con_p6()
        {
            choiGame = new ChoiGame(500);
            int Nai = 1, Bau = 1, Ga = 0, Ca = 0, Cua = 0, Tom = 0;
            TienDatCuoc = new int[]
            {
                Nai, Bau, Ga, Ca, Cua, Tom
            };
            int MongMuon = 502;
            choiGame.Xoc(0, 0, 0); // ra 3 nai (hoac bau)
            choiGame.Mo(TienDatCuoc);
            Assert.AreEqual(MongMuon, choiGame.Diem);
        }
    }
}
