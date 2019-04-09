namespace QuanLiNhanSu.GUI
{
    partial class frmTrinhDoHocVan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrinhDoHocVan));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listViewExTonGiao = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.itemThoat = new DevComponents.DotNetBar.ButtonX();
            this.itemLuu = new DevComponents.DotNetBar.ButtonX();
            this.itemXoa = new DevComponents.DotNetBar.ButtonX();
            this.itemBoQua = new DevComponents.DotNetBar.ButtonX();
            this.itemThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.txtTENTDHV = new System.Windows.Forms.TextBox();
            this.txtMATDHV = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel3);
            this.splitContainer1.Panel2.Controls.Add(this.groupPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 319);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.listViewExTonGiao);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(290, 319);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "Danh Sách Trình Độ Học Vấn";
            // 
            // listViewExTonGiao
            // 
            // 
            // 
            // 
            this.listViewExTonGiao.Border.Class = "ListViewBorder";
            this.listViewExTonGiao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewExTonGiao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewExTonGiao.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewExTonGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExTonGiao.FullRowSelect = true;
            this.listViewExTonGiao.GridLines = true;
            this.listViewExTonGiao.Location = new System.Drawing.Point(0, 0);
            this.listViewExTonGiao.MultiSelect = false;
            this.listViewExTonGiao.Name = "listViewExTonGiao";
            this.listViewExTonGiao.Size = new System.Drawing.Size(284, 298);
            this.listViewExTonGiao.TabIndex = 2;
            this.listViewExTonGiao.UseCompatibleStateImageBehavior = false;
            this.listViewExTonGiao.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã TĐHV";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Trình Độ";
            this.columnHeader2.Width = 238;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.itemThoat);
            this.groupPanel3.Controls.Add(this.itemLuu);
            this.groupPanel3.Controls.Add(this.itemXoa);
            this.groupPanel3.Controls.Add(this.itemBoQua);
            this.groupPanel3.Controls.Add(this.itemThemMoi);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel3.Location = new System.Drawing.Point(0, 244);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(506, 75);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 2;
            // 
            // itemThoat
            // 
            this.itemThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemThoat.Location = new System.Drawing.Point(423, 23);
            this.itemThoat.Name = "itemThoat";
            this.itemThoat.Size = new System.Drawing.Size(56, 26);
            this.itemThoat.TabIndex = 5;
            this.itemThoat.Text = "Thoát";
            this.itemThoat.Click += new System.EventHandler(this.itemThoat_Click);
            // 
            // itemLuu
            // 
            this.itemLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemLuu.Location = new System.Drawing.Point(276, 23);
            this.itemLuu.Name = "itemLuu";
            this.itemLuu.Size = new System.Drawing.Size(59, 26);
            this.itemLuu.TabIndex = 3;
            this.itemLuu.Text = "Lưu Lại";
            // 
            // itemXoa
            // 
            this.itemXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemXoa.Location = new System.Drawing.Point(353, 23);
            this.itemXoa.Name = "itemXoa";
            this.itemXoa.Size = new System.Drawing.Size(59, 26);
            this.itemXoa.TabIndex = 4;
            this.itemXoa.Text = "Xóa";
            // 
            // itemBoQua
            // 
            this.itemBoQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemBoQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemBoQua.Location = new System.Drawing.Point(193, 23);
            this.itemBoQua.Name = "itemBoQua";
            this.itemBoQua.Size = new System.Drawing.Size(65, 26);
            this.itemBoQua.TabIndex = 1;
            this.itemBoQua.Text = "Bỏ Qua";
            // 
            // itemThemMoi
            // 
            this.itemThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemThemMoi.Location = new System.Drawing.Point(115, 22);
            this.itemThemMoi.Name = "itemThemMoi";
            this.itemThemMoi.Size = new System.Drawing.Size(69, 26);
            this.itemThemMoi.TabIndex = 2;
            this.itemThemMoi.Text = "Thêm Mới";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtGHICHU);
            this.groupPanel2.Controls.Add(this.txtTENTDHV);
            this.groupPanel2.Controls.Add(this.txtMATDHV);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(506, 319);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "Thông Tin";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(24, 56);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(114, 23);
            this.labelX3.TabIndex = 14;
            this.labelX3.Text = "Tên Trình Độ Học Vấn:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(24, 86);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Ghi Chú:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(114, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Mã Trình Độ Học Vấn:";
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGHICHU.Location = new System.Drawing.Point(155, 88);
            this.txtGHICHU.Multiline = true;
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGHICHU.Size = new System.Drawing.Size(324, 95);
            this.txtGHICHU.TabIndex = 11;
            // 
            // txtTENTDHV
            // 
            this.txtTENTDHV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTENTDHV.Location = new System.Drawing.Point(155, 56);
            this.txtTENTDHV.Name = "txtTENTDHV";
            this.txtTENTDHV.Size = new System.Drawing.Size(324, 20);
            this.txtTENTDHV.TabIndex = 9;
            // 
            // txtMATDHV
            // 
            this.txtMATDHV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMATDHV.Location = new System.Drawing.Point(155, 24);
            this.txtMATDHV.Name = "txtMATDHV";
            this.txtMATDHV.ReadOnly = true;
            this.txtMATDHV.Size = new System.Drawing.Size(324, 20);
            this.txtMATDHV.TabIndex = 7;
            // 
            // frmTrinhDoHocVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrinhDoHocVan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Độ Học Vấn";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewExTonGiao;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX itemThoat;
        private DevComponents.DotNetBar.ButtonX itemLuu;
        private DevComponents.DotNetBar.ButtonX itemXoa;
        private DevComponents.DotNetBar.ButtonX itemBoQua;
        private DevComponents.DotNetBar.ButtonX itemThemMoi;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.TextBox txtTENTDHV;
        private System.Windows.Forms.TextBox txtMATDHV;
    }
}