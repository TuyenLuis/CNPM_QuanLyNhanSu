﻿using System;
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
    public partial class frmChucVu : DevComponents.DotNetBar.Office2007Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void itemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
