using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class NhanVienDTO
    {
        public long MaNV { get; set; }
        public string HoTen { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string CMND { get; set; }
        public Nullable<DateTime> NgayCapCMND { get; set; }
        public string NoiCapCMND { get; set; }
        public string DanToc { get; set; }
        public string TonGiao { get; set; }
        public string QuocTich { get; set; }
        public string QueQuan { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string NoiOHienNay { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public Nullable<long> MaPB { get; set; }
        public Nullable<DateTime> NgayHopDong { get; set; }
        public Nullable<DateTime> NgayTuyenDung { get; set; }
        public Nullable<long> MaTDHV { get; set; }
        public Nullable<long> MaTDNN { get; set; }
        public Nullable<long> MaTDTH { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<long> MaCV { get; set; }
    }
}
