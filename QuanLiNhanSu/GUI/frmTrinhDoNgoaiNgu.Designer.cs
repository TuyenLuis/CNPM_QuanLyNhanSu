namespace QuanLiNhanSu.GUI
{
    partial class frmTrinhDoNgoaiNgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrinhDoNgoaiNgu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.listViewExDanToc = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.itemThoat = new DevComponents.DotNetBar.ButtonX();
            this.itemLuu = new DevComponents.DotNetBar.ButtonX();
            this.itemXoa = new DevComponents.DotNetBar.ButtonX();
            this.itemBoQua = new DevComponents.DotNetBar.ButtonX();
            this.itemThemMoi = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtTenTDNN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaTDNN = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.listViewExDanToc);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(296, 319);
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
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Danh Sách TĐ Ngoại Ngữ";
            // 
            // listViewExDanToc
            // 
            // 
            // 
            // 
            this.listViewExDanToc.Border.Class = "ListViewBorder";
            this.listViewExDanToc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.listViewExDanToc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewExDanToc.DisabledBackColor = System.Drawing.Color.Empty;
            this.listViewExDanToc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExDanToc.FullRowSelect = true;
            this.listViewExDanToc.GridLines = true;
            this.listViewExDanToc.Location = new System.Drawing.Point(0, 0);
            this.listViewExDanToc.MultiSelect = false;
            this.listViewExDanToc.Name = "listViewExDanToc";
            this.listViewExDanToc.Size = new System.Drawing.Size(290, 298);
            this.listViewExDanToc.TabIndex = 2;
            this.listViewExDanToc.UseCompatibleStateImageBehavior = false;
            this.listViewExDanToc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã TĐNN";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên TĐNN";
            this.columnHeader2.Width = 185;
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
            this.groupPanel3.Location = new System.Drawing.Point(0, 238);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(500, 81);
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
            this.groupPanel3.TabIndex = 1;
            // 
            // itemThoat
            // 
            this.itemThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemThoat.Location = new System.Drawing.Point(404, 21);
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
            this.itemLuu.Location = new System.Drawing.Point(257, 21);
            this.itemLuu.Name = "itemLuu";
            this.itemLuu.Size = new System.Drawing.Size(59, 26);
            this.itemLuu.TabIndex = 3;
            this.itemLuu.Text = "Lưu Lại";
            // 
            // itemXoa
            // 
            this.itemXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemXoa.Location = new System.Drawing.Point(334, 21);
            this.itemXoa.Name = "itemXoa";
            this.itemXoa.Size = new System.Drawing.Size(59, 26);
            this.itemXoa.TabIndex = 4;
            this.itemXoa.Text = "Xóa";
            // 
            // itemBoQua
            // 
            this.itemBoQua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemBoQua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemBoQua.Location = new System.Drawing.Point(174, 21);
            this.itemBoQua.Name = "itemBoQua";
            this.itemBoQua.Size = new System.Drawing.Size(65, 26);
            this.itemBoQua.TabIndex = 1;
            this.itemBoQua.Text = "Bỏ Qua";
            // 
            // itemThemMoi
            // 
            this.itemThemMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.itemThemMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.itemThemMoi.Location = new System.Drawing.Point(96, 20);
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
            this.groupPanel2.Controls.Add(this.labelX2);
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.txtTenTDNN);
            this.groupPanel2.Controls.Add(this.txtMaTDNN);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Location = new System.Drawing.Point(0, 0);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(500, 319);
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
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "Thông Tin";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 60);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(97, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên TĐ Ngoại Ngữ:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 22);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Mã TĐ Ngoại Ngữ:";
            // 
            // txtTenTDNN
            // 
            // 
            // 
            // 
            this.txtTenTDNN.Border.Class = "TextBoxBorder";
            this.txtTenTDNN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenTDNN.Location = new System.Drawing.Point(143, 60);
            this.txtTenTDNN.Name = "txtTenTDNN";
            this.txtTenTDNN.Size = new System.Drawing.Size(313, 20);
            this.txtTenTDNN.TabIndex = 1;
            // 
            // txtMaTDNN
            // 
            // 
            // 
            // 
            this.txtMaTDNN.Border.Class = "TextBoxBorder";
            this.txtMaTDNN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaTDNN.Enabled = false;
            this.txtMaTDNN.Location = new System.Drawing.Point(143, 22);
            this.txtMaTDNN.Name = "txtMaTDNN";
            this.txtMaTDNN.Size = new System.Drawing.Size(313, 20);
            this.txtMaTDNN.TabIndex = 0;
            // 
            // frmTrinhDoNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrinhDoNgoaiNgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trình Độ Ngoại Ngữ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewExDanToc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX itemThoat;
        private DevComponents.DotNetBar.ButtonX itemLuu;
        private DevComponents.DotNetBar.ButtonX itemXoa;
        private DevComponents.DotNetBar.ButtonX itemBoQua;
        private DevComponents.DotNetBar.ButtonX itemThemMoi;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenTDNN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaTDNN;
    }
}