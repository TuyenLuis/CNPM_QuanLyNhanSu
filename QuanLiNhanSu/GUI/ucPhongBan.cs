using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLiNhanSu.BusinessLogicLayer;
using QuanLiNhanSu.DataTransferObject;

namespace QuanLiNhanSu.GUI
{
    public partial class ucPhongBan : UserControl
    {
        public ucPhongBan()
        {
            InitializeComponent();
        }

        private List<PhongBanDTO> listPhongBan = new List<PhongBanDTO>();

        private void itemThoat_Click(object sender, EventArgs e)
        {
            foreach (TabItem tabItem in frm_Main.FrmMain.TabContainer.Tabs)
            {
                if (tabItem.Name == "tabPhongBan")
                {
                    frm_Main.FrmMain.TabContainer.Tabs.Remove(tabItem);
                    frm_Main.FrmMain.TabContainer.Controls.Remove(tabItem.AttachedControl);
                    frm_Main.FrmMain.TabContainer.RecalcLayout();
                    return;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadPhongBan();
        }

        private void LoadPhongBan()
        {
            listPhongBan = PhongBanBUL.LoadPhongBan();
            if (listPhongBan != null)
            {
                lvPhongBan.Items.Clear();
                foreach (PhongBanDTO phongBan in listPhongBan)
                {
                    ListViewItem listViewItem = new ListViewItem(phongBan.MaPB.ToString());
                    listViewItem.SubItems.Add(phongBan.TenPB);
                    listViewItem.SubItems.Add(phongBan.SoNhanVien.ToString());
                    listViewItem.SubItems.Add(phongBan.GhiChu);

                    lvPhongBan.Items.Add(listViewItem);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearLayout();
        }

        private void ClearLayout()
        {
            txtMaPB.Text = "";
            txtGhiChu.Text = "";
            txtSoNhanVien.Text = "0";
            txtTenPB.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvPhongBan.SelectedItems.Count == 0)
            {
                MessageBoxEx.Show("Bạn phải chọn 1 phòng ban để xóa", "Thông báo");
            }
            else
            {
                long maPhongBan = txtMaPB.Text == "" ? 0 : long.Parse(txtMaPB.Text);
                if (maPhongBan == 0)
                {
                    MessageBoxEx.Show("Không thể xóa phòng ban này", "Thông báo");
                }
                else
                {
                    DialogResult res = MessageBoxEx.Show("Bạn có chắc chắn muốn xóa phòng ban này", "Thông báo", MessageBoxButtons.OKCancel);
                    if (res == DialogResult.OK)
                    {
                        if (PhongBanBUL.XoaPhongBan(maPhongBan))
                        {
                            MessageBoxEx.Show("Xóa phòng ban thành công", "Thông báo");
                            LoadPhongBan();
                            ClearLayout();
                        }
                        else
                        {
                            MessageBoxEx.Show("Xóa phòng ban thất bại", "Thông báo");
                            LoadPhongBan();
                        }
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhongBanDTO phongBan = new PhongBanDTO();
            phongBan.MaPB = txtMaPB.Text == "" ? 0 : long.Parse(txtMaPB.Text);
            phongBan.TenPB = txtTenPB.Text;
            phongBan.SoNhanVien = txtSoNhanVien.Text == "" ? 0 : int.Parse(txtSoNhanVien.Text);
            phongBan.GhiChu = txtGhiChu.Text;

            if (phongBan.MaPB == 0)
            {
                if (PhongBanBUL.ThemPhongBan(phongBan))
                {
                    MessageBoxEx.Show("Thêm mới phòng ban thành công", "Thông báo");
                    LoadPhongBan();
                }
                else
                {
                    MessageBoxEx.Show("Thêm mới phòng ban thất bại", "Thông báo");
                    LoadPhongBan();
                }
            }
            else
            {
                if (PhongBanBUL.CapNhatPhongBan(phongBan))
                {
                    MessageBoxEx.Show("Cập nhật phòng ban thành công", "Thông báo");
                    LoadPhongBan();
                }
                else
                {
                    MessageBoxEx.Show("Cập nhật phòng ban thất bại", "Thông báo");
                    LoadPhongBan();
                }
            }
        }

        private void lvPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPhongBan.SelectedItems.Count > 0)
            {
                ListViewItem lvItem = lvPhongBan.SelectedItems[0];
                txtMaPB.Text = lvItem.SubItems[0].Text;
                txtTenPB.Text = lvItem.SubItems[1].Text;
                txtSoNhanVien.Text = lvItem.SubItems[2].Text;
                txtGhiChu.Text = lvItem.SubItems[3].Text;
            }
        }
    }
}
