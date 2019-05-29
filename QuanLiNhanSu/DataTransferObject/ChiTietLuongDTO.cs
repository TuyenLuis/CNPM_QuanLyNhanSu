using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class ChiTietLuongDTO
    {
        public long MaLuongCB { get; set; }
        public Nullable<DateTime> NgayBatDau { get; set; }
        public Nullable<DateTime> NgayKetThuc { get; set; }
        public Nullable<double> Luong { get; set; }
        public Nullable<double> TienBaoHiem { get; set; }
        public Nullable<double> DangPhi { get; set; }
        public Nullable<double> PhuPhi { get; set; }
        public Nullable<DateTime> NgayNhanLuong { get; set; }
        public long MaNV { get; set; }
        public long MaHSLuong { get; set; }
    }
}
