namespace QuanLiNhanSu.GUI
{
    partial class frmListNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListNhanVien));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvDanhSachNhanVien = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMANV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHOTEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNGAYSINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGIOITINH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDIENTHOAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tstbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.tstbtnCapNhat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvDanhSachNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 280);
            this.panel2.TabIndex = 71;
            // 
            // lvDanhSachNhanVien
            // 
            // 
            // 
            // 
            this.lvDanhSachNhanVien.Border.Class = "ListViewBorder";
            this.lvDanhSachNhanVien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMANV,
            this.colHOTEN,
            this.colNGAYSINH,
            this.colGIOITINH,
            this.colCMND,
            this.colDIENTHOAI});
            this.lvDanhSachNhanVien.DisabledBackColor = System.Drawing.Color.Empty;
            this.lvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDanhSachNhanVien.FullRowSelect = true;
            this.lvDanhSachNhanVien.GridLines = true;
            this.lvDanhSachNhanVien.Location = new System.Drawing.Point(0, 0);
            this.lvDanhSachNhanVien.Name = "lvDanhSachNhanVien";
            this.lvDanhSachNhanVien.Size = new System.Drawing.Size(800, 280);
            this.lvDanhSachNhanVien.TabIndex = 2;
            this.lvDanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachNhanVien.View = System.Windows.Forms.View.Details;
            // 
            // colMANV
            // 
            this.colMANV.Text = "MANV";
            this.colMANV.Width = 57;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Text = "Họ và Tên";
            this.colHOTEN.Width = 200;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Text = "Ngày Sinh";
            this.colNGAYSINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNGAYSINH.Width = 130;
            // 
            // colGIOITINH
            // 
            this.colGIOITINH.Text = "Giới Tính";
            this.colGIOITINH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGIOITINH.Width = 80;
            // 
            // colCMND
            // 
            this.colCMND.Text = "Số CMND";
            this.colCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCMND.Width = 150;
            // 
            // colDIENTHOAI
            // 
            this.colDIENTHOAI.Text = "Phòng Ban";
            this.colDIENTHOAI.Width = 181;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picHinhAnh.Location = new System.Drawing.Point(24, 12);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(113, 117);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHinhAnh.TabIndex = 69;
            this.picHinhAnh.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 145);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tstbtnThoat
            // 
            this.tstbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("tstbtnThoat.Image")));
            this.tstbtnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbtnThoat.Name = "tstbtnThoat";
            this.tstbtnThoat.Size = new System.Drawing.Size(61, 22);
            this.tstbtnThoat.Text = "Thoát";
            // 
            // tstbtnCapNhat
            // 
            this.tstbtnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("tstbtnCapNhat.Image")));
            this.tstbtnCapNhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbtnCapNhat.Name = "tstbtnCapNhat";
            this.tstbtnCapNhat.Size = new System.Drawing.Size(80, 22);
            this.tstbtnCapNhat.Text = "Cập Nhật";
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbtnThoat,
            this.tstbtnCapNhat});
            this.toolStrip.Location = new System.Drawing.Point(0, 145);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 70;
            this.toolStrip.Text = "toolStrip1";
            // 
            // frmListNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.picHinhAnh);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListNhanVien";
            this.Text = "Danh sách nhân viên";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Panel panel2;
        public DevComponents.DotNetBar.Controls.ListViewEx lvDanhSachNhanVien;
        private System.Windows.Forms.ColumnHeader colMANV;
        private System.Windows.Forms.ColumnHeader colHOTEN;
        private System.Windows.Forms.ColumnHeader colNGAYSINH;
        private System.Windows.Forms.ColumnHeader colGIOITINH;
        private System.Windows.Forms.ColumnHeader colCMND;
        private System.Windows.Forms.ColumnHeader colDIENTHOAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tstbtnThoat;
        private System.Windows.Forms.ToolStripButton tstbtnCapNhat;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}