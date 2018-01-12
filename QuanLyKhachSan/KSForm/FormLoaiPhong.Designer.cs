namespace QuanLyKhachSan.KSForm
{
    partial class FormLoaiPhong
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
            System.Windows.Forms.Label mALoaiPhongLabel;
            System.Windows.Forms.Label tenLoaiPhongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiPhong));
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
            this.lOAIPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAIPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.LOAIPHONGTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mALoaiPhongTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenLoaiPhongTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lOAIPHONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hANGPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter();
            mALoaiPhongLabel = new System.Windows.Forms.Label();
            tenLoaiPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALoaiPhongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLoaiPhongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALoaiPhongLabel
            // 
            mALoaiPhongLabel.AutoSize = true;
            mALoaiPhongLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALoaiPhongLabel.ForeColor = System.Drawing.Color.Maroon;
            mALoaiPhongLabel.Location = new System.Drawing.Point(6, 23);
            mALoaiPhongLabel.Name = "mALoaiPhongLabel";
            mALoaiPhongLabel.Size = new System.Drawing.Size(145, 23);
            mALoaiPhongLabel.TabIndex = 0;
            mALoaiPhongLabel.Text = "Mã loại phòng:";
            // 
            // tenLoaiPhongLabel
            // 
            tenLoaiPhongLabel.AutoSize = true;
            tenLoaiPhongLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenLoaiPhongLabel.ForeColor = System.Drawing.Color.Maroon;
            tenLoaiPhongLabel.Location = new System.Drawing.Point(325, 24);
            tenLoaiPhongLabel.Name = "tenLoaiPhongLabel";
            tenLoaiPhongLabel.Size = new System.Drawing.Size(122, 23);
            tenLoaiPhongLabel.TabIndex = 2;
            tenLoaiPhongLabel.Text = " Loại phòng:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 587);
            this.barDockControlBottom.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(748, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 547);
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
            this.barDockControl1.Size = new System.Drawing.Size(748, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 587);
            this.barDockControl2.Size = new System.Drawing.Size(748, 23);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 547);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(748, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 547);
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
            // lOAIPHONGBindingSource
            // 
            this.lOAIPHONGBindingSource.DataMember = "LOAIPHONG";
            this.lOAIPHONGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // lOAIPHONGTableAdapter
            // 
            this.lOAIPHONGTableAdapter.ClearBeforeFill = true;
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
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(mALoaiPhongLabel);
            this.groupBox1.Controls.Add(this.mALoaiPhongTextEdit);
            this.groupBox1.Controls.Add(tenLoaiPhongLabel);
            this.groupBox1.Controls.Add(this.tenLoaiPhongTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 66);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // mALoaiPhongTextEdit
            // 
            this.mALoaiPhongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIPHONGBindingSource, "MALoaiPhong", true));
            this.mALoaiPhongTextEdit.Location = new System.Drawing.Point(165, 27);
            this.mALoaiPhongTextEdit.MenuManager = this.barManager1;
            this.mALoaiPhongTextEdit.Name = "mALoaiPhongTextEdit";
            this.mALoaiPhongTextEdit.Properties.MaxLength = 10;
            this.mALoaiPhongTextEdit.Size = new System.Drawing.Size(152, 20);
            this.mALoaiPhongTextEdit.TabIndex = 1;
            this.mALoaiPhongTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mALoaiPhongTextEdit_KeyPress);
            this.mALoaiPhongTextEdit.Leave += new System.EventHandler(this.mALoaiPhongTextEdit_Leave);
            // 
            // tenLoaiPhongTextEdit
            // 
            this.tenLoaiPhongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOAIPHONGBindingSource, "TenLoaiPhong", true));
            this.tenLoaiPhongTextEdit.Location = new System.Drawing.Point(453, 27);
            this.tenLoaiPhongTextEdit.MenuManager = this.barManager1;
            this.tenLoaiPhongTextEdit.Name = "tenLoaiPhongTextEdit";
            this.tenLoaiPhongTextEdit.Properties.MaxLength = 50;
            this.tenLoaiPhongTextEdit.Size = new System.Drawing.Size(289, 20);
            this.tenLoaiPhongTextEdit.TabIndex = 3;
            this.tenLoaiPhongTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenLoaiPhongTextEdit_KeyPress);
            this.tenLoaiPhongTextEdit.Leave += new System.EventHandler(this.tenLoaiPhongTextEdit_Leave);
            // 
            // lOAIPHONGGridControl
            // 
            this.lOAIPHONGGridControl.DataSource = this.lOAIPHONGBindingSource;
            this.lOAIPHONGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOAIPHONGGridControl.Location = new System.Drawing.Point(0, 106);
            this.lOAIPHONGGridControl.MainView = this.gridView1;
            this.lOAIPHONGGridControl.MenuManager = this.barManager1;
            this.lOAIPHONGGridControl.Name = "lOAIPHONGGridControl";
            this.lOAIPHONGGridControl.Size = new System.Drawing.Size(748, 220);
            this.lOAIPHONGGridControl.TabIndex = 37;
            this.lOAIPHONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALoaiPhong,
            this.colTenLoaiPhong});
            this.gridView1.GridControl = this.lOAIPHONGGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colMALoaiPhong
            // 
            this.colMALoaiPhong.Caption = "Mã loại phòng";
            this.colMALoaiPhong.FieldName = "MALoaiPhong";
            this.colMALoaiPhong.Name = "colMALoaiPhong";
            this.colMALoaiPhong.Visible = true;
            this.colMALoaiPhong.VisibleIndex = 0;
            // 
            // colTenLoaiPhong
            // 
            this.colTenLoaiPhong.Caption = "Loại phòng";
            this.colTenLoaiPhong.FieldName = "TenLoaiPhong";
            this.colTenLoaiPhong.Name = "colTenLoaiPhong";
            this.colTenLoaiPhong.Visible = true;
            this.colTenLoaiPhong.VisibleIndex = 1;
            // 
            // hANGPHONGBindingSource
            // 
            this.hANGPHONGBindingSource.DataMember = "FK_HANGPHONG_LOAIPHONG";
            this.hANGPHONGBindingSource.DataSource = this.lOAIPHONGBindingSource;
            // 
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // FormLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 610);
            this.Controls.Add(this.lOAIPHONGGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormLoaiPhong";
            this.Text = "Loại phòng";
            this.Load += new System.EventHandler(this.FormLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mALoaiPhongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLoaiPhongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIPHONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource lOAIPHONGBindingSource;
        private KHACHSANDataSet kHACHSANDataSet;
        private KHACHSANDataSetTableAdapters.LOAIPHONGTableAdapter lOAIPHONGTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit mALoaiPhongTextEdit;
        private DevExpress.XtraEditors.TextEdit tenLoaiPhongTextEdit;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraGrid.GridControl lOAIPHONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiPhong;
        private System.Windows.Forms.BindingSource hANGPHONGBindingSource;
        private KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
    }
}