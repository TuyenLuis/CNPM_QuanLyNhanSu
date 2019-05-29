using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class HeSoLuongDTO
    {
        public long MaHSLuong { get; set; }
        public Nullable<long> MaNgachLuong { get; set; }
        public Nullable<long> MaBacLuong { get; set; }
        public Nullable<double> HSLuongNhanVien { get; set; }
    }
}
