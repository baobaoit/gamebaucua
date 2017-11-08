using System;

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
            if (TenTaiKhoan.Equals(string.Empty) || MatKhau.Equals(string.Empty))
                return null;

            NguoiChoi User = LayDuLieu();
            if (!NguoiChoi.TonTai(User))
                throw new ArgumentException("Tài khoản chưa tồn tại.\nVui lòng đăng ký một tài khoản để chơi!");
            // ton tai tai khoan nhung nguoi dung nhap mat khau khong dung
            if (User.MatKhau != MatKhau.ToMD5())
                throw new ArgumentException("Mật khẩu không đúng.\nVui lòng kiểm tra lại!");
            return User;
        }
    }
}
