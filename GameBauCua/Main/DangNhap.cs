namespace Main
{
    class DangNhap : LayDuLieuNguoiChoi
    {
        private string TenTaiKhoan = string.Empty, MatKhau = string.Empty;

        public DangNhap(string TenTaiKhoan, string MatKhau)
        {
            this.TenTaiKhoan = TenTaiKhoan.Trim();
            this.MatKhau = MatKhau.Trim();
        }

        public bool ThucHienDangNhap()
        {
            if (TenTaiKhoan == string.Empty && MatKhau == string.Empty)
                return false;

            if (LayDuLieu(TenTaiKhoan, MatKhau))
                return true;
            return false;
        }
    }
}
