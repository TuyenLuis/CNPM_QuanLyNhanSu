using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLiNhanSu.BusinessLogicLayer;


namespace QuanLiNhanSu.GUI
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            bool luuThongTinDN = chkLuuThongTinDangNhap.Checked;

            if (NguoiDungBUL.DangNhap(tenDangNhap, matKhau, luuThongTinDN))
            {
                this.Close();
            }
            else
            {
                MessageBoxEx.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo");
            }
        }
    }
}
