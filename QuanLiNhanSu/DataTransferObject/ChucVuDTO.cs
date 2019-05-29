using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class ChucVuDTO
    {
        public long MaCV { get; set; }
        public string TenCV { get; set; }
        public Nullable<double> HeSoCV { get; set; }
        public string GhiChu { get; set; }
    }
}
