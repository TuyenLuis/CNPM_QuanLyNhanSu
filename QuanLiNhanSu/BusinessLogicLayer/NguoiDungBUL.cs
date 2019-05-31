using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhanSu.DataAccessLayer;

namespace QuanLiNhanSu.BusinessLogicLayer
{
    public class NguoiDungBUL
    {
        public static bool DangNhap(string tenDangNhap, string matKhau, bool luuThongTinDN)
        {
            return NguoiDungDAL.Instance.DangNhap(tenDangNhap, MD5Hash(matKhau), luuThongTinDN);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
