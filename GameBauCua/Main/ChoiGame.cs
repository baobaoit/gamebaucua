using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public class ChoiGame
    {
        public int Diem { get; set; }
        public int TaiKhoan { get; set; }
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
        public Bitmap HinhKetQua(int i) => HinhBauCua[i];
        public int KetQuaXoc(int i) => KetQua[i];
        private Random SinhSoNgauNhien;

        public ChoiGame()
        {
            Diem = 0;
            TaiKhoan = 1000;
            SinhSoNgauNhien = new Random();
        }

        public void XocBauCua(int[] TienDatCuoc)
        {
            KetQua[0] = SinhSoNgauNhien.Next(6);
            KetQua[1] = SinhSoNgauNhien.Next(6);
            KetQua[2] = SinhSoNgauNhien.Next(6);

            int TongTienDatCuoc = TienDatCuoc.Sum();

            if (TongTienDatCuoc > TaiKhoan || TongTienDatCuoc == 0)
            {
                MessageBox.Show("Số tiền đặt cược không được vượt quá số tài khoản hiện có!\nHoặc bạn chưa đặt tiền cược!\nVui lòng điều chỉnh lại tiền đặt cược!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else //TongTienDatCuoc <= TaiKhoan
            {
                int[] KetQuaXoc = new int[6];

                //dem so luong xuat hien cua tung ket qua
                KetQuaXoc[KetQua[0]]++;
                KetQuaXoc[KetQua[1]]++;
                KetQuaXoc[KetQua[2]]++;

                //tru tien cuoc vao diem
                TaiKhoan -= TongTienDatCuoc;

                //tinh diem
                foreach (int ketqua in KetQua)
                {
                    if (!TienDatCuoc[ketqua].Equals(0))
                    {
                        Diem += (KetQuaXoc[ketqua] == 1) ? 10 : (KetQuaXoc[ketqua] == 2) ? 50 : 100;
                        TaiKhoan += (TienDatCuoc[ketqua] * KetQuaXoc[ketqua]);
                    }
                }
            }
        }
    }
}
