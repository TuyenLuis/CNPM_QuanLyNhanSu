using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhanSu.DataTransferObject;

namespace QuanLiNhanSu.DataAccessLayer
{
    public class PhongBanDAL
    {
        private static PhongBanDAL _instance;
        public static PhongBanDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhongBanDAL();
                }
                return _instance;
            }
            private set
            {
                _instance = value;
            }
        }

        public List<PhongBanDTO> LoadPhongBan()
        {
            try
            {
                List<PhongBanDTO> listPhongBan = new List<PhongBanDTO>();
                string query = "SELECT MAPB, TENPB, SONHANVIEN, GHICHU FROM PHONGBAN";

                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    PhongBanDTO phongBan = new PhongBanDTO(item);
                    listPhongBan.Add(phongBan);
                }

                return listPhongBan;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool ThemPhongBan(PhongBanDTO phongBan)
        {
            try
            {
                string query = string.Format("INSERT INTO PHONGBAN ( TENPB, SONHANVIEN, GHICHU ) VALUES (N'{0}', 0, N'{1}')", phongBan.TenPB, phongBan.GhiChu);
                int ketQua = DataProvider.Instance.ExecuteNonQuery(query);
                return ketQua > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool CapNhatPhongBan(PhongBanDTO phongBan)
        {
            try
            {
                string query = string.Format("UPDATE PHONGBAN SET TENPB = {0}, GHICHU = {1} WHERE MAPB = {2}", phongBan.TenPB, phongBan.GhiChu, phongBan.MaPB);
                int ketQua = DataProvider.Instance.ExecuteNonQuery(query);
                return ketQua > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool XoaPhongBan(long maPhongBan)
        {
            try
            {
                int kq = DataProvider.Instance.ExecuteNonQuery("prc_XoaPhongBan @MAPB", new object[] { maPhongBan });
                return kq > 0;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
