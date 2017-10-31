using WMPLib;

namespace Main
{
    public class NhacNen
    {
        private WindowsMediaPlayer wmp = null;

        public void GanDuongDanFileNhac(string DuongDanFileNhac)
        {
            wmp.URL = DuongDanFileNhac;
        }

        public bool ChuaCoNhacNen()
        {
            return string.IsNullOrEmpty(wmp.URL);
        }

        public NhacNen()
        {
            wmp = new WindowsMediaPlayer();
        }

        public void PhatNhac()
        {
            wmp.controls.play();
        }

        public void DungChoiNhac()
        {
            wmp.controls.stop();
        }

        public void TamDungChoiNhac()
        {
            wmp.controls.pause();
        }

        public void DoiNhac(string DuongDanFileNhac)
        {
            wmp.URL = DuongDanFileNhac;
        }
    }
}
