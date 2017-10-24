namespace Main
{
    public class DangNhap : LayDuLieuNguoiChoi
    {
        public DangNhap(string TenTaiKhoan, string MatKhau)
        {
            this.TenTaiKhoan = TenTaiKhoan.Trim();
            this.MatKhau = MatKhau.Trim();
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
