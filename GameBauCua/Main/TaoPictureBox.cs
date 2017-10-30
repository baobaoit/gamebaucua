using System.Drawing;
using System.Windows.Forms;

namespace Main
{
    public class TaoPictureBox
    {
        public static PictureBox Tao(string TenPictureBox, Bitmap HinhAnh, Size KichThuocPictureBox, int x, int y)
        {
            PictureBox pic = new PictureBox
            {
                Name = TenPictureBox,
                Image = HinhAnh,
                Size = KichThuocPictureBox,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(x, y)
            };
            return pic;
        }
    }
}
