namespace QuanLyKhachSan.KSForm
{
    partial class FormGiaPhong
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
            System.Windows.Forms.Label mAHangPhongLabel;
            System.Windows.Forms.Label ngayApDungLabel;
            System.Windows.Forms.Label giaHangPhongLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaPhong));
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
            this.gIAPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.GIAPHONGTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mAHangPhongComboBox = new System.Windows.Forms.ComboBox();
            this.hANGPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngayApDungDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.giaHangPhongSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.gIAPHONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayApDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hANGPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter();
            mAHangPhongLabel = new System.Windows.Forms.Label();
            ngayApDungLabel = new System.Windows.Forms.Label();
            giaHangPhongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAPHONGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaHangPhongSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAPHONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAHangPhongLabel
            // 
            mAHangPhongLabel.AutoSize = true;
            mAHangPhongLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAHangPhongLabel.ForeColor = System.Drawing.Color.Maroon;
            mAHangPhongLabel.Location = new System.Drawing.Point(2, 18);
            mAHangPhongLabel.Name = "mAHangPhongLabel";
            mAHangPhongLabel.Size = new System.Drawing.Size(114, 21);
            mAHangPhongLabel.TabIndex = 0;
            mAHangPhongLabel.Text = "Hạng phòng:";
            // 
            // ngayApDungLabel
            // 
            ngayApDungLabel.AutoSize = true;
            ngayApDungLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayApDungLabel.ForeColor = System.Drawing.Color.Maroon;
            ngayApDungLabel.Location = new System.Drawing.Point(283, 16);
            ngayApDungLabel.Name = "ngayApDungLabel";
            ngayApDungLabel.Size = new System.Drawing.Size(127, 21);
            ngayApDungLabel.TabIndex = 2;
            ngayApDungLabel.Text = "Ngày áp dụng:";
            // 
            // giaHangPhongLabel
            // 
            giaHangPhongLabel.AutoSize = true;
            giaHangPhongLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaHangPhongLabel.ForeColor = System.Drawing.Color.Maroon;
            giaHangPhongLabel.Location = new System.Drawing.Point(550, 14);
            giaHangPhongLabel.Name = "giaHangPhongLabel";
            giaHangPhongLabel.Size = new System.Drawing.Size(45, 21);
            giaHangPhongLabel.TabIndex = 4;
            giaHangPhongLabel.Text = "Giá:";
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 546);
            this.barDockControlBottom.Size = new System.Drawing.Size(748, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(748, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 506);
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
            this.barDockControl2.Location = new System.Drawing.Point(0, 546);
            this.barDockControl2.Size = new System.Drawing.Size(748, 23);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(748, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 506);
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
            // gIAPHONGBindingSource
            // 
            this.gIAPHONGBindingSource.DataMember = "GIAPHONG";
            this.gIAPHONGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // gIAPHONGTableAdapter
            // 
            this.gIAPHONGTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Controls.Add(this.mAHangPhongComboBox);
            this.groupBox1.Controls.Add(mAHangPhongLabel);
            this.groupBox1.Controls.Add(ngayApDungLabel);
            this.groupBox1.Controls.Add(this.ngayApDungDateEdit);
            this.groupBox1.Controls.Add(giaHangPhongLabel);
            this.groupBox1.Controls.Add(this.giaHangPhongSpinEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 58);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // mAHangPhongComboBox
            // 
            this.mAHangPhongComboBox.CausesValidation = false;
            this.mAHangPhongComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gIAPHONGBindingSource, "MAHangPhong", true));
            this.mAHangPhongComboBox.DataSource = this.hANGPHONGBindingSource;
            this.mAHangPhongComboBox.DisplayMember = "HangPhong";
            this.mAHangPhongComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mAHangPhongComboBox.FormattingEnabled = true;
            this.mAHangPhongComboBox.Location = new System.Drawing.Point(124, 18);
            this.mAHangPhongComboBox.MaxLength = 10;
            this.mAHangPhongComboBox.Name = "mAHangPhongComboBox";
            this.mAHangPhongComboBox.Size = new System.Drawing.Size(153, 21);
            this.mAHangPhongComboBox.TabIndex = 6;
            this.mAHangPhongComboBox.ValueMember = "MAHangPhong";
            this.mAHangPhongComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mAHangPhongComboBox_KeyPress);
            // 
            // hANGPHONGBindingSource
            // 
            this.hANGPHONGBindingSource.DataMember = "HANGPHONG";
            this.hANGPHONGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // ngayApDungDateEdit
            // 
            this.ngayApDungDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAPHONGBindingSource, "NgayApDung", true));
            this.ngayApDungDateEdit.EditValue = null;
            this.ngayApDungDateEdit.Location = new System.Drawing.Point(421, 16);
            this.ngayApDungDateEdit.MenuManager = this.barManager1;
            this.ngayApDungDateEdit.Name = "ngayApDungDateEdit";
            this.ngayApDungDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayApDungDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayApDungDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngayApDungDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayApDungDateEdit.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.ngayApDungDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayApDungDateEdit.Properties.MinValue = new System.DateTime(2017, 8, 12, 0, 0, 0, 0);
            this.ngayApDungDateEdit.Size = new System.Drawing.Size(123, 20);
            this.ngayApDungDateEdit.TabIndex = 3;
            // 
            // giaHangPhongSpinEdit
            // 
            this.giaHangPhongSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gIAPHONGBindingSource, "GiaHangPhong", true));
            this.giaHangPhongSpinEdit.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.giaHangPhongSpinEdit.Location = new System.Drawing.Point(601, 15);
            this.giaHangPhongSpinEdit.MenuManager = this.barManager1;
            this.giaHangPhongSpinEdit.Name = "giaHangPhongSpinEdit";
            this.giaHangPhongSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giaHangPhongSpinEdit.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.giaHangPhongSpinEdit.Properties.MaxLength = 8;
            this.giaHangPhongSpinEdit.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.giaHangPhongSpinEdit.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.giaHangPhongSpinEdit.Size = new System.Drawing.Size(141, 20);
            this.giaHangPhongSpinEdit.TabIndex = 5;
            this.giaHangPhongSpinEdit.EditValueChanged += new System.EventHandler(this.giaHangPhongSpinEdit_EditValueChanged);
            this.giaHangPhongSpinEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giaHangPhongSpinEdit_KeyPress);
            // 
            // gIAPHONGGridControl
            // 
            this.gIAPHONGGridControl.DataSource = this.gIAPHONGBindingSource;
            this.gIAPHONGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gIAPHONGGridControl.Location = new System.Drawing.Point(0, 98);
            this.gIAPHONGGridControl.MainView = this.gridView1;
            this.gIAPHONGGridControl.MenuManager = this.barManager1;
            this.gIAPHONGGridControl.Name = "gIAPHONGGridControl";
            this.gIAPHONGGridControl.Size = new System.Drawing.Size(748, 220);
            this.gIAPHONGGridControl.TabIndex = 36;
            this.gIAPHONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHangPhong,
            this.colNgayApDung,
            this.colGiaHangPhong});
            this.gridView1.GridControl = this.gIAPHONGGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colMAHangPhong
            // 
            this.colMAHangPhong.Caption = "Mã hạng phòng";
            this.colMAHangPhong.FieldName = "MAHangPhong";
            this.colMAHangPhong.Name = "colMAHangPhong";
            this.colMAHangPhong.Visible = true;
            this.colMAHangPhong.VisibleIndex = 0;
            // 
            // colNgayApDung
            // 
            this.colNgayApDung.Caption = "Ngày áp dụng";
            this.colNgayApDung.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayApDung.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayApDung.FieldName = "NgayApDung";
            this.colNgayApDung.Name = "colNgayApDung";
            this.colNgayApDung.Visible = true;
            this.colNgayApDung.VisibleIndex = 1;
            // 
            // colGiaHangPhong
            // 
            this.colGiaHangPhong.Caption = "Giá hạng phòng";
            this.colGiaHangPhong.FieldName = "GiaHangPhong";
            this.colGiaHangPhong.Name = "colGiaHangPhong";
            this.colGiaHangPhong.Visible = true;
            this.colGiaHangPhong.VisibleIndex = 2;
            // 
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // FormGiaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 569);
            this.Controls.Add(this.gIAPHONGGridControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormGiaPhong";
            this.Text = "Giá phòng";
            this.Load += new System.EventHandler(this.FormGiaPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAPHONGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaHangPhongSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAPHONGGridControl)).EndInit();
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
        private System.Windows.Forms.BindingSource gIAPHONGBindingSource;
        private KHACHSANDataSet kHACHSANDataSet;
        private KHACHSANDataSetTableAdapters.GIAPHONGTableAdapter gIAPHONGTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraGrid.GridControl gIAPHONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit ngayApDungDateEdit;
        private DevExpress.XtraEditors.SpinEdit giaHangPhongSpinEdit;
        private System.Windows.Forms.ComboBox mAHangPhongComboBox;
        private System.Windows.Forms.BindingSource hANGPHONGBindingSource;
        private KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApDung;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaHangPhong;
    }
}