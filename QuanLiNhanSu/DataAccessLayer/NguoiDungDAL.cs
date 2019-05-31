using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhanSu.DataTransferObject;

namespace QuanLiNhanSu.DataAccessLayer
{
    public class NguoiDungDAL
    {
        private static NguoiDungDAL _instance;
        public static NguoiDungDAL Instance
        {
            get
            {
                if (_instance == null) _instance = new NguoiDungDAL();
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public bool DangNhap(string tenDangNhap, string matKhau, bool luuThongTinDN)
        {
            try
            {
                string query = string.Format("SELECT COUNT(*) AS SoLuong  FROM NGUOIDUNG WHERE TENDANGNHAP = '{0}' AND MATKHAU = '{1}'", tenDangNhap, matKhau);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if ((int)data.Rows[0]["SoLuong"] > 0)
                {
                    query = string.Format("SELECT * FROM NGUOIDUNG WHERE TENDANGNHAP = '{0}' AND MATKHAU = '{1}'", tenDangNhap, matKhau);
                    DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                    NguoiDungDTO KH = new NguoiDungDTO(dt.Rows[0]);
                    UserLogin.MaND = KH.MaND;
                    UserLogin.PhanQuyen = KH.PhanQuyen;
                    UserLogin.TenDangNhap = KH.TenDangNhap;
                    UserLogin.LuuThongTinDN = luuThongTinDN;

                    query = string.Format("INSERT INTO NHATKY VALUES ({0}, GETDATE())", KH.MaND);
                    DataProvider.Instance.ExecuteNonQuery(query);
                    return true;
                }
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
