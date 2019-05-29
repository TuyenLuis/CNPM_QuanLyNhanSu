using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class NghiViecDTO
    {
        public long MaNghiViec { get; set; }
        public Nullable<long> MaNV { get; set; }
        public string SoQuyetDinh { get; set; }
        public Nullable<DateTime> NgayQuyetDinh { get; set; }
        public string NguoiKy { get; set; }
        public string ChucVu { get; set; }
        public Nullable<DateTime> NgayThoiViec { get; set; }
        public string LyDo { get; set; }
    }
}
