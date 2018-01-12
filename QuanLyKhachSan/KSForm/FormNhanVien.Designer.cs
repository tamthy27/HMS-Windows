namespace QuanLyKhachSan.KSForm
{
    partial class FormNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hoNVLabel;
            System.Windows.Forms.Label tenNVLabel;
            System.Windows.Forms.Label luongNVLabel;
            System.Windows.Forms.Label ngaySinhNVLabel;
            System.Windows.Forms.Label gioiTinhNVLabel;
            System.Windows.Forms.Label diaChiNVLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label soDienThoaiNVLabel;
            System.Windows.Forms.Label maBPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.txtKieuPhong = new System.Windows.Forms.TextBox();
            this.txtMaKieuPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter1 = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.NHANVIENTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maBPComboBox = new System.Windows.Forms.ComboBox();
            this.mANVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.luongNVSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ngaySinhNVDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gioiTinhNVCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.diaChiNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soDienThoaiNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bOPHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOPHANTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.BOPHANTableAdapter();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.HOADONTableAdapter();
            this.pHIEUDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.PHIEUDATTableAdapter();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuongNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinhNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoDienThoaiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBP = new DevExpress.XtraGrid.Columns.GridColumn();
            mANVLabel = new System.Windows.Forms.Label();
            hoNVLabel = new System.Windows.Forms.Label();
            tenNVLabel = new System.Windows.Forms.Label();
            luongNVLabel = new System.Windows.Forms.Label();
            ngaySinhNVLabel = new System.Windows.Forms.Label();
            gioiTinhNVLabel = new System.Windows.Forms.Label();
            diaChiNVLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            soDienThoaiNVLabel = new System.Windows.Forms.Label();
            maBPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNVSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhNVDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhNVDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhNVCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDienThoaiNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOPHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.ForeColor = System.Drawing.Color.Maroon;
            mANVLabel.Location = new System.Drawing.Point(6, 11);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(71, 21);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV:";
            // 
            // hoNVLabel
            // 
            hoNVLabel.AutoSize = true;
            hoNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoNVLabel.ForeColor = System.Drawing.Color.Maroon;
            hoNVLabel.Location = new System.Drawing.Point(209, 9);
            hoNVLabel.Name = "hoNVLabel";
            hoNVLabel.Size = new System.Drawing.Size(39, 21);
            hoNVLabel.TabIndex = 2;
            hoNVLabel.Text = "Họ:";
            // 
            // tenNVLabel
            // 
            tenNVLabel.AutoSize = true;
            tenNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenNVLabel.ForeColor = System.Drawing.Color.Maroon;
            tenNVLabel.Location = new System.Drawing.Point(582, 9);
            tenNVLabel.Name = "tenNVLabel";
            tenNVLabel.Size = new System.Drawing.Size(45, 21);
            tenNVLabel.TabIndex = 4;
            tenNVLabel.Text = "Tên:";
            // 
            // luongNVLabel
            // 
            luongNVLabel.AutoSize = true;
            luongNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            luongNVLabel.ForeColor = System.Drawing.Color.Maroon;
            luongNVLabel.Location = new System.Drawing.Point(18, 37);
            luongNVLabel.Name = "luongNVLabel";
            luongNVLabel.Size = new System.Drawing.Size(67, 21);
            luongNVLabel.TabIndex = 6;
            luongNVLabel.Text = "Lương:";
            // 
            // ngaySinhNVLabel
            // 
            ngaySinhNVLabel.AutoSize = true;
            ngaySinhNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngaySinhNVLabel.ForeColor = System.Drawing.Color.Maroon;
            ngaySinhNVLabel.Location = new System.Drawing.Point(278, 34);
            ngaySinhNVLabel.Name = "ngaySinhNVLabel";
            ngaySinhNVLabel.Size = new System.Drawing.Size(97, 21);
            ngaySinhNVLabel.TabIndex = 8;
            ngaySinhNVLabel.Text = "Ngày Sinh:";
            // 
            // gioiTinhNVLabel
            // 
            gioiTinhNVLabel.AutoSize = true;
            gioiTinhNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gioiTinhNVLabel.ForeColor = System.Drawing.Color.Maroon;
            gioiTinhNVLabel.Location = new System.Drawing.Point(546, 60);
            gioiTinhNVLabel.Name = "gioiTinhNVLabel";
            gioiTinhNVLabel.Size = new System.Drawing.Size(91, 21);
            gioiTinhNVLabel.TabIndex = 10;
            gioiTinhNVLabel.Text = "Giới Tính:";
            // 
            // diaChiNVLabel
            // 
            diaChiNVLabel.AutoSize = true;
            diaChiNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiNVLabel.ForeColor = System.Drawing.Color.Maroon;
            diaChiNVLabel.Location = new System.Drawing.Point(12, 60);
            diaChiNVLabel.Name = "diaChiNVLabel";
            diaChiNVLabel.Size = new System.Drawing.Size(78, 21);
            diaChiNVLabel.TabIndex = 12;
            diaChiNVLabel.Text = "Địa Chỉ:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.ForeColor = System.Drawing.Color.Maroon;
            cMNDLabel.Location = new System.Drawing.Point(23, 85);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(72, 21);
            cMNDLabel.TabIndex = 14;
            cMNDLabel.Text = "CMND:";
            // 
            // soDienThoaiNVLabel
            // 
            soDienThoaiNVLabel.AutoSize = true;
            soDienThoaiNVLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soDienThoaiNVLabel.ForeColor = System.Drawing.Color.Maroon;
            soDienThoaiNVLabel.Location = new System.Drawing.Point(377, 85);
            soDienThoaiNVLabel.Name = "soDienThoaiNVLabel";
            soDienThoaiNVLabel.Size = new System.Drawing.Size(117, 21);
            soDienThoaiNVLabel.TabIndex = 16;
            soDienThoaiNVLabel.Text = "Số điện thoại:";
            // 
            // maBPLabel
            // 
            maBPLabel.AutoSize = true;
            maBPLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maBPLabel.ForeColor = System.Drawing.Color.Maroon;
            maBPLabel.Location = new System.Drawing.Point(559, 33);
            maBPLabel.Name = "maBPLabel";
            maBPLabel.Size = new System.Drawing.Size(82, 21);
            maBPLabel.TabIndex = 18;
            maBPLabel.Text = "Bộ phận:";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 40);
            this.barDockControlTop.Size = new System.Drawing.Size(850, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Size = new System.Drawing.Size(850, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(850, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnHieuChinh,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnRedo,
            this.btnReload,
            this.barButtonItem8,
            this.btnHuy});
            this.barManager2.MainMenu = this.bar3;
            this.barManager2.MaxItemId = 9;
            this.barManager2.StatusBar = this.bar4;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatSize = new System.Drawing.Size(0, 50);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRedo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu Chỉnh";
            this.btnHieuChinh.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHieuChinh.Glyph")));
            this.btnHieuChinh.Id = 1;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGhi.Glyph")));
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHuy.Glyph")));
            this.btnHuy.Id = 8;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 4;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnRedo.Glyph")));
            this.btnRedo.Id = 5;
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 6;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(850, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 467);
            this.barDockControl2.Size = new System.Drawing.Size(850, 23);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(850, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 427);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // txtKieuPhong
            // 
            this.txtKieuPhong.Location = new System.Drawing.Point(0, 0);
            this.txtKieuPhong.Name = "txtKieuPhong";
            this.txtKieuPhong.Size = new System.Drawing.Size(100, 20);
            this.txtKieuPhong.TabIndex = 0;
            // 
            // txtMaKieuPhong
            // 
            this.txtMaKieuPhong.Location = new System.Drawing.Point(0, 0);
            this.txtMaKieuPhong.Name = "txtMaKieuPhong";
            this.txtMaKieuPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaKieuPhong.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTHOADONTableAdapter = null;
            this.tableAdapterManager.CTKHACHTHUETableAdapter = null;
            this.tableAdapterManager.CTKM_DICHVUTableAdapter = null;
            this.tableAdapterManager.CTKM_HANGPHONGTableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.GIADICHVUTableAdapter = null;
            this.tableAdapterManager.GIAPHONGTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
            this.tableAdapterManager.HOADONDOTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHSDDVTableAdapter = null;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIDICHVUTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = null;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TANGTableAdapter = null;
            this.tableAdapterManager.TINHTRANGPHIEUTableAdapter = null;
            this.tableAdapterManager.TINHTRANGPHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENBindingSource1
            // 
            this.nHANVIENBindingSource1.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource1.DataSource = this.kHACHSANDataSet;
            // 
            // nHANVIENTableAdapter1
            // 
            this.nHANVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.maBPComboBox);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.mANVTextEdit);
            this.groupBox1.Controls.Add(hoNVLabel);
            this.groupBox1.Controls.Add(this.hoNVTextEdit);
            this.groupBox1.Controls.Add(tenNVLabel);
            this.groupBox1.Controls.Add(this.tenNVTextEdit);
            this.groupBox1.Controls.Add(luongNVLabel);
            this.groupBox1.Controls.Add(this.luongNVSpinEdit);
            this.groupBox1.Controls.Add(ngaySinhNVLabel);
            this.groupBox1.Controls.Add(this.ngaySinhNVDateEdit);
            this.groupBox1.Controls.Add(gioiTinhNVLabel);
            this.groupBox1.Controls.Add(this.gioiTinhNVCheckEdit);
            this.groupBox1.Controls.Add(diaChiNVLabel);
            this.groupBox1.Controls.Add(this.diaChiNVTextEdit);
            this.groupBox1.Controls.Add(cMNDLabel);
            this.groupBox1.Controls.Add(this.cMNDTextEdit);
            this.groupBox1.Controls.Add(soDienThoaiNVLabel);
            this.groupBox1.Controls.Add(this.soDienThoaiNVTextEdit);
            this.groupBox1.Controls.Add(maBPLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 127);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // maBPComboBox
            // 
            this.maBPComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nHANVIENBindingSource, "MaBP", true));
            this.maBPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maBPComboBox.FormattingEnabled = true;
            this.maBPComboBox.Location = new System.Drawing.Point(647, 34);
            this.maBPComboBox.Name = "maBPComboBox";
            this.maBPComboBox.Size = new System.Drawing.Size(169, 21);
            this.maBPComboBox.TabIndex = 22;
            this.maBPComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maBPComboBox_KeyPress_1);
            // 
            // mANVTextEdit
            // 
            this.mANVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "MANV", true));
            this.mANVTextEdit.Location = new System.Drawing.Point(83, 12);
            this.mANVTextEdit.MenuManager = this.barManager1;
            this.mANVTextEdit.Name = "mANVTextEdit";
            this.mANVTextEdit.Properties.MaxLength = 10;
            this.mANVTextEdit.Size = new System.Drawing.Size(81, 20);
            this.mANVTextEdit.TabIndex = 1;
            this.mANVTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mANVTextEdit_KeyPress);
            this.mANVTextEdit.Leave += new System.EventHandler(this.mANVTextEdit_Leave);
            // 
            // hoNVTextEdit
            // 
            this.hoNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "HoNV", true));
            this.hoNVTextEdit.Location = new System.Drawing.Point(254, 11);
            this.hoNVTextEdit.MenuManager = this.barManager1;
            this.hoNVTextEdit.Name = "hoNVTextEdit";
            this.hoNVTextEdit.Properties.MaxLength = 50;
            this.hoNVTextEdit.Size = new System.Drawing.Size(282, 20);
            this.hoNVTextEdit.TabIndex = 3;
            this.hoNVTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoNVTextEdit_KeyPress);
            this.hoNVTextEdit.Leave += new System.EventHandler(this.hoNVTextEdit_Leave);
            // 
            // tenNVTextEdit
            // 
            this.tenNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "TenNV", true));
            this.tenNVTextEdit.Location = new System.Drawing.Point(633, 11);
            this.tenNVTextEdit.MenuManager = this.barManager1;
            this.tenNVTextEdit.Name = "tenNVTextEdit";
            this.tenNVTextEdit.Properties.MaxLength = 20;
            this.tenNVTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenNVTextEdit.TabIndex = 5;
            this.tenNVTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenNVTextEdit_KeyPress);
            this.tenNVTextEdit.Leave += new System.EventHandler(this.tenNVTextEdit_Leave);
            // 
            // luongNVSpinEdit
            // 
            this.luongNVSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "LuongNV", true));
            this.luongNVSpinEdit.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.luongNVSpinEdit.Location = new System.Drawing.Point(119, 37);
            this.luongNVSpinEdit.MenuManager = this.barManager1;
            this.luongNVSpinEdit.Name = "luongNVSpinEdit";
            this.luongNVSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luongNVSpinEdit.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.luongNVSpinEdit.Properties.MaxValue = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.luongNVSpinEdit.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.luongNVSpinEdit.Size = new System.Drawing.Size(124, 20);
            this.luongNVSpinEdit.TabIndex = 7;
            // 
            // ngaySinhNVDateEdit
            // 
            this.ngaySinhNVDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "NgaySinhNV", true));
            this.ngaySinhNVDateEdit.EditValue = null;
            this.ngaySinhNVDateEdit.Location = new System.Drawing.Point(381, 34);
            this.ngaySinhNVDateEdit.MenuManager = this.barManager1;
            this.ngaySinhNVDateEdit.Name = "ngaySinhNVDateEdit";
            this.ngaySinhNVDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhNVDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhNVDateEdit.Properties.MaxValue = new System.DateTime(2017, 8, 3, 0, 0, 0, 0);
            this.ngaySinhNVDateEdit.Size = new System.Drawing.Size(172, 20);
            this.ngaySinhNVDateEdit.TabIndex = 9;
            // 
            // gioiTinhNVCheckEdit
            // 
            this.gioiTinhNVCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "GioiTinhNV", true));
            this.gioiTinhNVCheckEdit.Location = new System.Drawing.Point(670, 57);
            this.gioiTinhNVCheckEdit.MenuManager = this.barManager1;
            this.gioiTinhNVCheckEdit.Name = "gioiTinhNVCheckEdit";
            this.gioiTinhNVCheckEdit.Properties.Caption = "NỮ";
            this.gioiTinhNVCheckEdit.Size = new System.Drawing.Size(63, 19);
            this.gioiTinhNVCheckEdit.TabIndex = 11;
            // 
            // diaChiNVTextEdit
            // 
            this.diaChiNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DiaChiNV", true));
            this.diaChiNVTextEdit.Location = new System.Drawing.Point(124, 62);
            this.diaChiNVTextEdit.MenuManager = this.barManager1;
            this.diaChiNVTextEdit.Name = "diaChiNVTextEdit";
            this.diaChiNVTextEdit.Properties.MaxLength = 100;
            this.diaChiNVTextEdit.Size = new System.Drawing.Size(345, 20);
            this.diaChiNVTextEdit.TabIndex = 13;
            this.diaChiNVTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diaChiNVTextEdit_KeyPress);
            this.diaChiNVTextEdit.Leave += new System.EventHandler(this.diaChiNVTextEdit_Leave);
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(101, 87);
            this.cMNDTextEdit.MenuManager = this.barManager1;
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Properties.MaxLength = 12;
            this.cMNDTextEdit.Size = new System.Drawing.Size(210, 20);
            this.cMNDTextEdit.TabIndex = 15;
            this.cMNDTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cMNDTextEdit_KeyPress);
            this.cMNDTextEdit.Leave += new System.EventHandler(this.cMNDTextEdit_Leave);
            // 
            // soDienThoaiNVTextEdit
            // 
            this.soDienThoaiNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "SoDienThoaiNV", true));
            this.soDienThoaiNVTextEdit.Location = new System.Drawing.Point(507, 88);
            this.soDienThoaiNVTextEdit.MenuManager = this.barManager1;
            this.soDienThoaiNVTextEdit.Name = "soDienThoaiNVTextEdit";
            this.soDienThoaiNVTextEdit.Properties.MaxLength = 11;
            this.soDienThoaiNVTextEdit.Size = new System.Drawing.Size(186, 20);
            this.soDienThoaiNVTextEdit.TabIndex = 17;
            this.soDienThoaiNVTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soDienThoaiNVTextEdit_KeyPress);
            this.soDienThoaiNVTextEdit.Leave += new System.EventHandler(this.soDienThoaiNVTextEdit_Leave);
            // 
            // bOPHANBindingSource
            // 
            this.bOPHANBindingSource.DataMember = "BOPHAN";
            this.bOPHANBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // bOPHANTableAdapter
            // 
            this.bOPHANTableAdapter.ClearBeforeFill = true;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "FK_HOADON_NHANVIEN";
            this.hOADONBindingSource.DataSource = this.nHANVIENBindingSource;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // pHIEUDATBindingSource
            // 
            this.pHIEUDATBindingSource.DataMember = "FK_PHIEUDAT_NHANVIEN";
            this.pHIEUDATBindingSource.DataSource = this.nHANVIENBindingSource;
            // 
            // pHIEUDATTableAdapter
            // 
            this.pHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(0, 167);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.MenuManager = this.barManager1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(850, 220);
            this.nHANVIENGridControl.TabIndex = 54;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHoNV,
            this.colTenNV,
            this.colLuongNV,
            this.colNgaySinhNV,
            this.colGioiTinhNV,
            this.colDiaChiNV,
            this.colCMND,
            this.colSoDienThoaiNV,
            this.colMaBP});
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHoNV
            // 
            this.colHoNV.Caption = "Họ";
            this.colHoNV.FieldName = "HoNV";
            this.colHoNV.Name = "colHoNV";
            this.colHoNV.Visible = true;
            this.colHoNV.VisibleIndex = 1;
            // 
            // colTenNV
            // 
            this.colTenNV.Caption = "Tên";
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 2;
            // 
            // colLuongNV
            // 
            this.colLuongNV.Caption = "Lương";
            this.colLuongNV.FieldName = "LuongNV";
            this.colLuongNV.Name = "colLuongNV";
            this.colLuongNV.Visible = true;
            this.colLuongNV.VisibleIndex = 3;
            // 
            // colNgaySinhNV
            // 
            this.colNgaySinhNV.Caption = "Ngày sinh";
            this.colNgaySinhNV.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgaySinhNV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgaySinhNV.FieldName = "NgaySinhNV";
            this.colNgaySinhNV.Name = "colNgaySinhNV";
            this.colNgaySinhNV.Visible = true;
            this.colNgaySinhNV.VisibleIndex = 4;
            // 
            // colGioiTinhNV
            // 
            this.colGioiTinhNV.Caption = "Giới tính";
            this.colGioiTinhNV.FieldName = "GioiTinhNV";
            this.colGioiTinhNV.Name = "colGioiTinhNV";
            this.colGioiTinhNV.Visible = true;
            this.colGioiTinhNV.VisibleIndex = 5;
            // 
            // colDiaChiNV
            // 
            this.colDiaChiNV.Caption = "Địa chỉ ";
            this.colDiaChiNV.FieldName = "DiaChiNV";
            this.colDiaChiNV.Name = "colDiaChiNV";
            this.colDiaChiNV.Visible = true;
            this.colDiaChiNV.VisibleIndex = 6;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 7;
            // 
            // colSoDienThoaiNV
            // 
            this.colSoDienThoaiNV.Caption = "Điện thoại";
            this.colSoDienThoaiNV.FieldName = "SoDienThoaiNV";
            this.colSoDienThoaiNV.Name = "colSoDienThoaiNV";
            this.colSoDienThoaiNV.Visible = true;
            this.colSoDienThoaiNV.VisibleIndex = 8;
            // 
            // colMaBP
            // 
            this.colMaBP.Caption = "Bộ phận";
            this.colMaBP.FieldName = "MaBP";
            this.colMaBP.Name = "colMaBP";
            this.colMaBP.Visible = true;
            this.colMaBP.VisibleIndex = 9;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 490);
            this.Controls.Add(this.nHANVIENGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mANVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongNVSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhNVDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhNVDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhNVCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDienThoaiNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOPHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKieuPhong;
        private System.Windows.Forms.TextBox txtMaKieuPhong;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private KHACHSANDataSet kHACHSANDataSet;
        private KHACHSANDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private KHACHSANDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit mANVTextEdit;
        private DevExpress.XtraEditors.TextEdit hoNVTextEdit;
        private DevExpress.XtraEditors.TextEdit tenNVTextEdit;
        private DevExpress.XtraEditors.SpinEdit luongNVSpinEdit;
        private DevExpress.XtraEditors.DateEdit ngaySinhNVDateEdit;
        private DevExpress.XtraEditors.CheckEdit gioiTinhNVCheckEdit;
        private DevExpress.XtraEditors.TextEdit diaChiNVTextEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit soDienThoaiNVTextEdit;
        private System.Windows.Forms.BindingSource bOPHANBindingSource;
        private KHACHSANDataSetTableAdapters.BOPHANTableAdapter bOPHANTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private KHACHSANDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUDATBindingSource;
        private KHACHSANDataSetTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox maBPComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colLuongNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinhNV;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinhNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSoDienThoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBP;
    }
}