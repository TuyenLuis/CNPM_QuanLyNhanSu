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

namespace QuanLiNhanSu.GUI
{
    public partial class frm_Main : DevComponents.DotNetBar.Office2007Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        public static frm_Main _frmMain;
        public static frm_Main FrmMain
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new frm_Main();
                }
                return _frmMain;
            }
        }

        public Panel PanelContainer
        {
            get
            {
                return panelContainer;
            }
            set
            {
                panelContainer = value;
            }
        }

        public DevComponents.DotNetBar.TabControl TabContainer
        {
            get
            {
                return tabContainer;
            }
            set
            {
                tabContainer = value;
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            _frmMain = this;
            //CreateTabDefault();
            if (Common.frmDangNhap == null || Common.frmDangNhap.IsDisposed)
            {
                Common.frmDangNhap = new frmDangNhap();
            }
            Common.frmDangNhap.ShowDialog();
        }

        private void buttonItemTopChuyenSangTaiKhoanKhac_Click(object sender, EventArgs e)
        {
            toolHienThi.Text = "Chương trình đã đăng xuất....Bạn phải đăng nhập bằng 1 tài khoản khác.";
            ribbonTabItemQuanTriHeThong.Enabled = false;
            ribbonTabItemQuanLyNhanSu.Enabled = false;
            ribbonTabItemTimKiemThongKe.Enabled = false;
            ribbonTabItemTroGiup.Enabled = false;

            buttonItemTopChuyenSangTaiKhoanKhac.Enabled = false;
            buttonItemTopDoiMatKhau.Enabled = false;
            buttonItemTopPhanQuyenNguoiDung.Enabled = false;
            buttonItemTopHoSoNhanVien.Enabled = false;
            buttonItemTopDanhSachPhongBan.Enabled = false;
            buttonItemTopDanhSachDanhMuc.Enabled = false;
            buttonItemTopBangLuongNhanVien.Enabled = false;
            buttonItemTopNgach.Enabled = false;
            buttonItemTopBac.Enabled = false;
            buttonItemTopHeSoLuong.Enabled = false;
            buttonItemTopTimKiemNhanVien.Enabled = false;
            buttonItemTopThongKeNhanVien.Enabled = false;
            buttonItemTopThongKeNhanVienTren40Tuoi.Enabled = false;
            buttonItemTopHDSuDung.Enabled = false;
            buttonItemTopLienHe.Enabled = false;
        }

        private void buttonItemTopDangNhap_Click(object sender, EventArgs e)
        {
            RemoveAllTabItems();
            if (Common.frmDangNhap == null || Common.frmDangNhap.IsDisposed)
            {
                Common.frmDangNhap = new frmDangNhap();
            }
            Common.frmDangNhap.ShowDialog();
        }

        private void buttonItemTopDoiMatKhau_Click(object sender, EventArgs e)
        {
            RemoveAllTabItems();
            if (Common.frmDoiMatKhau == null || Common.frmDoiMatKhau.IsDisposed)
            {
                Common.frmDoiMatKhau = new frmDoiMatKhau();
            }
            Common.frmDoiMatKhau.ShowDialog();
        }

        private void buttonItemTopPhanQuyenNguoiDung_Click(object sender, EventArgs e)
        {
            foreach (TabItem tabItem in TabContainer.Tabs)
            {
                if (tabItem.Name == "tabNguoiDung")
                {
                    TabContainer.SelectedTab = tabItem;
                    return;
                }
            }
            if (Common.ucNguoiDung == null || Common.ucNguoiDung.IsDisposed)
            {
                Common.ucNguoiDung = new ucNguoiDung();
            }

            TabItem tabNguoiDung = TabContainer.CreateTab("Quản Lí Người Dùng");
            tabNguoiDung.Name = "tabNguoiDung";
            TabContainer.SelectedTab = tabNguoiDung;
            
            TabControlPanel panel = (TabControlPanel)tabNguoiDung.AttachedControl;
            panel.BringToFront();
            panel.Controls.Add(Common.ucNguoiDung);
            Common.ucNguoiDung.Dock = DockStyle.Fill;
            Common.ucNguoiDung.BringToFront();
        }

        private void RemoveAllTabItems()
        {
            TabContainer.Tabs.Clear();
        }

        private void buttonItemTopHoSoNhanVien_Click(object sender, EventArgs e)
        {
            foreach (TabItem tabItem in TabContainer.Tabs)
            {
                if (tabItem.Name == "tabListNhanVien")
                {
                    TabContainer.SelectedTab = tabItem;
                    return;
                }
            }
            if (Common.ucListNhanVien == null || Common.ucListNhanVien.IsDisposed)
            {
                Common.ucListNhanVien = new ucListNhanVien();
            }

            TabItem tabListNhanVien = TabContainer.CreateTab("Danh sách nhân viên");
            tabListNhanVien.Name = "tabListNhanVien";
            TabContainer.SelectedTab = tabListNhanVien;

            TabControlPanel panel = (TabControlPanel)tabListNhanVien.AttachedControl;
            panel.BringToFront();
            panel.Controls.Add(Common.ucListNhanVien);
            Common.ucListNhanVien.Dock = DockStyle.Fill;
            Common.ucListNhanVien.BringToFront();
        }

        private void buttonItemTopDanhSachPhongBan_Click(object sender, EventArgs e)
        {
            foreach (TabItem tabItem in TabContainer.Tabs)
            {
                if (tabItem.Name == "tabPhongBan")
                {
                    TabContainer.SelectedTab = tabItem;
                    return;
                }
            }
            if (Common.ucPhongBan == null || Common.ucPhongBan.IsDisposed)
            {
                Common.ucPhongBan = new ucPhongBan();
            }

            TabItem tabPhongBan = TabContainer.CreateTab("Danh sách phòng ban");
            tabPhongBan.Name = "tabPhongBan";
            TabContainer.SelectedTab = tabPhongBan;

            TabControlPanel panel = (TabControlPanel)tabPhongBan.AttachedControl;
            panel.BringToFront();
            panel.Controls.Add(Common.ucPhongBan);
            Common.ucPhongBan.Dock = DockStyle.Fill;
            Common.ucPhongBan.BringToFront();
        }

        private void buttonItemTop_Click(object sender, EventArgs e)
        {
            ButtonItem btnItem = sender as ButtonItem;
            string btnItemTag = btnItem.Tag.ToString();
            switch (btnItemTag)
            {
                case "TrinhDoHocVan":
                    if (Common.frmTrinhDoHocVan == null || Common.frmTrinhDoHocVan.IsDisposed)
                    {
                        Common.frmTrinhDoHocVan = new frmTrinhDoHocVan();
                    }
                    Common.frmTrinhDoHocVan.ShowDialog();
                    break;
                case "TrinhDoTinHoc":
                    if (Common.frmTrinhDoTinHoc == null || Common.frmTrinhDoTinHoc.IsDisposed)
                    {
                        Common.frmTrinhDoTinHoc = new frmTrinhDoTinHoc();
                    }
                    Common.frmTrinhDoTinHoc.ShowDialog();
                    break;
                case "TrinhDoNgoaiNgu":
                    if(Common.frmTrinhDoNgoaiNgu == null || Common.frmTrinhDoNgoaiNgu.IsDisposed)
                    {
                        Common.frmTrinhDoNgoaiNgu = new frmTrinhDoNgoaiNgu();
                    }
                    Common.frmTrinhDoNgoaiNgu.ShowDialog();
                    break;
                case "ChucVu":
                    if (Common.frmChucVu == null || Common.frmChucVu.IsDisposed)
                    {
                        Common.frmChucVu = new frmChucVu();
                    }
                    Common.frmChucVu.ShowDialog();
                    break;
                case "NgachLuong":
                    if (Common.frmNgach == null || Common.frmNgach.IsDisposed)
                    {
                        Common.frmNgach = new frmNgach();
                    }
                    Common.frmNgach.ShowDialog();
                    break;
                case "BacLuong":
                    if (Common.frmBac == null || Common.frmBac.IsDisposed)
                    {
                        Common.frmBac = new frmBac();
                    }
                    Common.frmBac.ShowDialog();
                    break;
                case "HeSoLuong":
                    if (Common.frmHeSoLuong == null || Common.frmHeSoLuong.IsDisposed)
                    {
                        Common.frmHeSoLuong = new frmHeSoLuong();
                    }
                    Common.frmHeSoLuong.ShowDialog();
                    break;
            }
        }

        private void buttonItemMenuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBoxEx.Show("Bạn có chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonItemTopBangLuongNhanVien_Click(object sender, EventArgs e)
        {
            foreach (TabItem tabItem in TabContainer.Tabs)
            {
                if (tabItem.Name == "tabLuongNhanVien")
                {
                    TabContainer.SelectedTab = tabItem;
                    return;
                }
            }
            if (Common.ucLuongNhanVien == null || Common.ucLuongNhanVien.IsDisposed)
            {
                Common.ucLuongNhanVien = new ucLuongNhanVien();
            }

            TabItem tabLuongNhanVien = TabContainer.CreateTab("Lương nhân viên");
            tabLuongNhanVien.Name = "tabLuongNhanVien";
            TabContainer.SelectedTab = tabLuongNhanVien;

            TabControlPanel panel = (TabControlPanel)tabLuongNhanVien.AttachedControl;
            panel.BringToFront();
            panel.Controls.Add(Common.ucLuongNhanVien);
            Common.ucLuongNhanVien.Dock = DockStyle.Fill;
            Common.ucLuongNhanVien.BringToFront();
        }

        private void buttonItemTopTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            foreach (TabItem tabItem in TabContainer.Tabs)
            {
                if (tabItem.Name == "tabTraCuuNhanVien")
                {
                    TabContainer.SelectedTab = tabItem;
                    return;
                }
            }
            if (Common.ucTraCuuNhanVien == null || Common.ucTraCuuNhanVien.IsDisposed)
            {
                Common.ucTraCuuNhanVien = new ucTraCuuNhanVien();
            }

            TabItem tabTraCuuNhanVien = TabContainer.CreateTab("Tra cứu nhân viên");
            tabTraCuuNhanVien.Name = "tabTraCuuNhanVien";
            TabContainer.SelectedTab = tabTraCuuNhanVien;

            TabControlPanel panel = (TabControlPanel)tabTraCuuNhanVien.AttachedControl;
            panel.BringToFront();
            panel.Controls.Add(Common.ucTraCuuNhanVien);
            Common.ucTraCuuNhanVien.Dock = DockStyle.Fill;
            Common.ucTraCuuNhanVien.BringToFront();
        }
    }
}
