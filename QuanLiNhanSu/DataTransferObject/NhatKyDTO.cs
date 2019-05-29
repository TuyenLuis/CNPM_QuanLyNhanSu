using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class NhatKyDTO
    {
        public long MaNK { get; set; }
        public Nullable<long> MaND { get; set; }
        public Nullable<DateTime> NgayDangNhap { get; set; }
    }
}
