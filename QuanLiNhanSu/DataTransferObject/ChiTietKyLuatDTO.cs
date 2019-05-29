using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class ChiTietKyLuatDTO
    {
        public long MaNV { get; set; }
        public long MaKT { get; set; }
        public string SoQuyetDinh { get; set; }
        public Nullable<DateTime> NgayQuyetDinh { get; set; }
        public string CoQuanKL { get; set; }
        public string HinhThucKL { get; set; }
        public string LyDo { get; set; }
        public string NguoiKy { get; set; }
        public string GhiChu { get; set; }
    }
}
