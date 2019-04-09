﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLiNhanSu.GUI
{
    public partial class ucPhongBan : UserControl
    {
        public ucPhongBan()
        {
            InitializeComponent();
        }

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
    }
}