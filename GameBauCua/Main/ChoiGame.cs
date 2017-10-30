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

        public ChoiGame()
        {
            int DiemNguoiChoi = Convert.ToInt32(frmDangNhap.User.Diem);
            Diem = (DiemNguoiChoi == 0) ? 500 : DiemNguoiChoi;
            SinhSoNgauNhien = new Random();
        }

        public Bitmap HinhKetQua(int i) => HinhBauCua[KetQua[i - 1]];

        public int XocBauCua(int[] TienDatCuoc)
        {
            #region Lắc bầu cua
            KetQua[0] = SinhSoNgauNhien.Next(6);
            KetQua[1] = SinhSoNgauNhien.Next(6);
            KetQua[2] = SinhSoNgauNhien.Next(6); 
            #endregion

            int TongTienDatCuoc = TienDatCuoc.Sum();

            if (TongTienDatCuoc > Diem || TongTienDatCuoc == 0)
            {
                return 0;
            }
            else //TongTienDatCuoc <= TaiKhoan
            {
                int[] KetQuaXoc = new int[6];

                //dem so luong xuat hien cua tung ket qua
                KetQuaXoc[KetQua[0]]++;
                KetQuaXoc[KetQua[1]]++;
                KetQuaXoc[KetQua[2]]++;

                bool CoDatCuoc = false, CoQuayTrung = false;
                ThongBao = "";
                for (int i = 0; i < KetQuaXoc.Length; i++)
                {
                    CoDatCuoc = TienDatCuoc[i] != 0;
                    CoQuayTrung = KetQuaXoc[i] != 0;

                    if (CoDatCuoc)
                    {
                        if (CoQuayTrung)
                        {
                            int TienThuong = (TienDatCuoc[i] * KetQuaXoc[i]);
                            Diem += TienThuong;
                            ThongBao += string.Format("Bạn nhận được (+{0} điểm) từ đặt {1}\n", TienThuong, Ten[i]);
                        }
                        else //khong quay trung
                        {
                            int TruTien = TienDatCuoc[i];
                            Diem -= TruTien;
                            ThongBao += string.Format("Bạn bị mất (-{0} điểm) từ đặt {1}\n", TruTien, Ten[i]);
                        }
                    }
                }
            }
            return 1;
        }
    }
}
