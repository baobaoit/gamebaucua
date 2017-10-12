using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Main
{
    class NguoiChoi
    {
        // thuoc tinh
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NguoiChoi(string TenTaiKhoan, string MatKhau, string GioiTinh = "", string DiaChi = "", string SoDienThoai = "")
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
        }
    }
}
