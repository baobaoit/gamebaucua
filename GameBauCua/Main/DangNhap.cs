namespace Main
{
    public class DangNhap : LayDuLieuNguoiChoi
    {
        public DangNhap(string TenTaiKhoan, string MatKhau)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
        }

        public NguoiChoi ThucHienDangNhap()
        {
            if (TenTaiKhoan == string.Empty && MatKhau == string.Empty)
                return null;

            NguoiChoi User = LayDuLieu();
            if (NguoiChoi.TonTai(User))
                return User;
            return null;
        }
    }
}
