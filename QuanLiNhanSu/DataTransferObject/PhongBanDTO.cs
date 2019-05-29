using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class PhongBanDTO
    {
        public long MaPB { get; set; }
        public string TenPB { get; set; }
        public Nullable<int> SoNhanVien { get; set; }
        public string GhiChu { get; set; }
    }
}
