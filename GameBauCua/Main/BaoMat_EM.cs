using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace Main
{
    /// <summary>
    /// Lop ma hoa MD5 dung de ma hoa mat khau nguoi dung
    /// </summary>
    public static class BaoMat_EM
    {
        #region Mã hóa MD5
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
        #endregion

        #region Phương thức lấy đường dẫn đến file thực thi
        public static string GetFile(string path)
        {
            // tim duong dan den file Main.exe
            string fileName = string.Empty;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                // lay phan duoi
                string typeOfFile = file.Substring(file.LastIndexOf(".") + 1);
                if (typeOfFile.Equals("exe"))
                {
                    fileName = file;
                    break;
                }
            }
            return fileName;
        }
        #endregion

        #region Phương thức mã hóa chuỗi kết nối
        public static void EncryptConnectionString(string path)
        {
            Configuration configuration = null;
            string fileName = GetFile(path);
            FileInfo fiConfig = new FileInfo(fileName + ".config");
            if (fiConfig.Attributes.Equals(FileAttributes.Hidden))
                return;
            try
            {
                // Open the configuration file and retrieve the connectionStrings section.
                configuration = ConfigurationManager.OpenExeConfiguration(fileName);
                ConnectionStringsSection configSection = configuration.GetSection("connectionStrings") as ConnectionStringsSection;
                if ((!(configSection.ElementInformation.IsLocked)) && (!(configSection.SectionInformation.IsLocked)))
                {
                    if (!configSection.SectionInformation.IsProtected)
                    {
                        //this line will encrypt the file
                        configSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    }
                    else
                    {
                        //this line will decrypt the file
                        configSection.SectionInformation.UnprotectSection();
                    }
                    //re-save the configuration file section
                    configSection.SectionInformation.ForceSave = true;
                    // Save the current configuration

                    configuration.Save();
                    //configFile.FilePath

                    fiConfig.Attributes = FileAttributes.Hidden;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
