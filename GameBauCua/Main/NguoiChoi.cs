namespace Main
{
    public class NguoiChoi
    {
        #region Thuộc tính
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Diem { get; set; } 
        #endregion

        public NguoiChoi(string TenTaiKhoan, string MatKhau, string GioiTinh = "", string DiaChi = "", string SoDienThoai = "", string Diem = "0")
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.Diem = Diem;
        }

        public static bool TonTai(NguoiChoi nguoiChoi)
        {
            return nguoiChoi != null;
        }
    }
}
