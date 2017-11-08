using System;
using System.Drawing;
using System.Linq;

namespace Main
{
    public class ChoiGame
    {
        #region Thuộc tính
        public int Diem { get; set; }
        private int[] KetQua = new int[3];
        private Bitmap[] HinhBauCua =
        {
            Properties.Resources._0, //Nai
            Properties.Resources._1, //Bau
            Properties.Resources._2, //Ga
            Properties.Resources._3, //Ca
            Properties.Resources._4, //Cua
            Properties.Resources._5 //Tom
        };
        private string[] Ten =
        {
            "Nai",
            "Bầu",
            "Gà",
            "Cá",
            "Cua",
            "Tôm"
        };
        public string ThongBao { get; set; }

        private Random SinhSoNgauNhien;
        #endregion

        public ChoiGame(int DiemNguoiChoi)
        {
            Diem = (DiemNguoiChoi == 0) ? 500 : DiemNguoiChoi;
            SinhSoNgauNhien = new Random();
        }

        public Bitmap HinhKetQua(int i)
        {
            return HinhBauCua[KetQua[i - 1]];
        }

        public void Xoc()
        {
            #region Lắc bầu cua
            KetQua[0] = SinhSoNgauNhien.Next(6);
            KetQua[1] = SinhSoNgauNhien.Next(6);
            KetQua[2] = SinhSoNgauNhien.Next(6);
            #endregion
        }

        /// <summary>
        /// Dung de ra ket qua nhu mong muon - ham su dung cho Test
        /// </summary>
        /// <param name="KetQua1"></param>
        /// <param name="KetQua2"></param>
        /// <param name="KetQua3"></param>
        public void Xoc(int KetQua1, int KetQua2, int KetQua3)
        {
            KetQua[0] = KetQua1;
            KetQua[1] = KetQua2;
            KetQua[2] = KetQua3;
        }

        public int Mo(int[] TienDatCuoc)
        {
            int TongTienDatCuoc = TienDatCuoc.Sum();

            if (TongTienDatCuoc > Diem || TongTienDatCuoc.Equals(0))
            {
                return 0;
            }
            else //TongTienDatCuoc <= TaiKhoan
            {
                int[] KetQuaXoc = new int[6];

                #region Đếm số lượng xuất hiện của từng kết quả
                KetQuaXoc[KetQua[0]]++;
                KetQuaXoc[KetQua[1]]++;
                KetQuaXoc[KetQua[2]]++; 
                #endregion

                bool CoDatCuoc = false, CoQuayTrung = false;
                ThongBao = "";
                int TongDiemTru = 0, TongDiemCong = 0;
                for (int i = 0; i < KetQuaXoc.Length; i++)
                {
                    CoDatCuoc = TienDatCuoc[i] != 0;
                    if (CoDatCuoc)
                    {
                        CoQuayTrung = KetQuaXoc[i] != 0;
                        if (CoQuayTrung)
                        {
                            int DiemThuong = (TienDatCuoc[i] * KetQuaXoc[i]);
                            TongDiemCong += DiemThuong;
                            Diem += DiemThuong;
                            ThongBao += string.Format("Bạn nhận được (+{0} điểm) từ đặt {1}.\n", DiemThuong, Ten[i]);
                        }
                        else //khong quay trung
                        {
                            int DiemTru = TienDatCuoc[i];
                            TongDiemTru += DiemTru;
                            Diem -= DiemTru;
                            ThongBao += string.Format("Bạn bị mất (-{0} điểm) từ đặt {1}.\n", DiemTru, Ten[i]);
                        }
                    }
                }
                int Tong = TongDiemCong - TongDiemTru;
                ThongBao += string.Format("\nTổng điểm: {0}{1} điểm.", (Tong > 0) ? "+" : "", Tong);
            }
            return 1;
        }
    }
}
