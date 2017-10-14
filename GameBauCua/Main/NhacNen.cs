using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;

namespace Main
{
    class NhacNen
    {
        private WindowsMediaPlayer wmp = null;

        public NhacNen(string DuongDanFileNhac)
        {
            wmp = new WindowsMediaPlayer();
            wmp.URL = DuongDanFileNhac;
        }

        public void ChoiNhac()
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
