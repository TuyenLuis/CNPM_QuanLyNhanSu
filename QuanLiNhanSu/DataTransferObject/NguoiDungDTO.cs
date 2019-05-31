using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhanSu.DataTransferObject
{
    public class NguoiDungDTO
    {
        public long MaND { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GhiChu { get; set; }
        public string PhanQuyen { get; set; }
        public string PhongBan { get; set; }

        public NguoiDungDTO()
        {
            MaND = 0;
            TenDangNhap = "";
            MatKhau = "";
            HoTen = "";
            GhiChu = "";
            PhanQuyen = "";
            PhongBan = "";
        }

        public NguoiDungDTO(DataRow row)
        {
            MaND = (long)row["MAND"];
            TenDangNhap = row["TENDANGNHAP"] == null ? "" : row["TENDANGNHAP"].ToString();
            PhanQuyen = row["PHANQUYEN"] == null ? "" : row["PHANQUYEN"].ToString();
        }
    }

}
