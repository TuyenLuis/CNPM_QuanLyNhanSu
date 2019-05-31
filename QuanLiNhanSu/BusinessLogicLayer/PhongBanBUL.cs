using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhanSu.DataTransferObject;
using QuanLiNhanSu.DataAccessLayer;

namespace QuanLiNhanSu.BusinessLogicLayer
{
    public class PhongBanBUL
    {
        public static List<PhongBanDTO> LoadPhongBan()
        {
            return PhongBanDAL.Instance.LoadPhongBan();
        }

        public static bool ThemPhongBan(PhongBanDTO phongBan)
        {
            return PhongBanDAL.Instance.ThemPhongBan(phongBan);
        }

        public static bool CapNhatPhongBan(PhongBanDTO phongBan)
        {
            return PhongBanDAL.Instance.CapNhatPhongBan(phongBan);
        }

        public static bool XoaPhongBan(long maPhongBan)
        {
            return PhongBanDAL.Instance.XoaPhongBan(maPhongBan);
        }
    }
}
