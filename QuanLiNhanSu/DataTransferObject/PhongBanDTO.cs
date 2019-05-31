using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLiNhanSu.DataTransferObject
{
    public class PhongBanDTO
    {
        public long MaPB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> SoNhanVien { get; set; }
        public string GhiChu { get; set; }

        public PhongBanDTO()
        {
            MaPB = 0;
            TenPB = "";
            SoNhanVien = 0;
            GhiChu = "";
        }

        public PhongBanDTO(DataRow dr)
        {
            MaPB = (long)dr["MAPB"];
            TenPB = dr["TENPB"] == null ? "" : dr["TENPB"].ToString();
            SoNhanVien = dr["SONHANVIEN"] == null ? 0 : (int)dr["SONHANVIEN"];
            GhiChu = dr["GHICHU"] == null ? "" : dr["GHICHU"].ToString();
        }
    }
}
