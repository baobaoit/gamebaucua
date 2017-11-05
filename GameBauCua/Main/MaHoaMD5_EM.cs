using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Main
{
    /// <summary>
    /// Lop ma hoa MD5 dung de ma hoa mat khau nguoi dung
    /// </summary>
    public static class MaHoaMD5_EM
    {
        public static byte[] MaHoaDuLieu(string strObj)
        {
            byte[] hashedBytes;
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            UTF8Encoding encoder = new UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(strObj));
            return hashedBytes;
        }

        public static string ToMD5(this string strObj)
        {
            return BitConverter.ToString(MaHoaDuLieu(strObj)).Replace("-", "").ToLower();
        }
    }
}
