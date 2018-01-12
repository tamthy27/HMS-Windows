namespace QuanLyKhachSan.KSForm
{
    partial class FormKhuyenMai
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
            System.Windows.Forms.Label maDichVuLabel;
            System.Windows.Forms.Label giamGiaLabel1;
            System.Windows.Forms.Label maHangPhongLabel;
            System.Windows.Forms.Label giamGiaLabel;
            System.Windows.Forms.Label mAKhuyenMaiLabel;
            System.Windows.Forms.Label tenKhuyenMaiLabel;
            System.Windows.Forms.Label ngayApDungLabel;
            System.Windows.Forms.Label ngayKetThucLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhuyenMai));
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
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.kIEUPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.KIEUPHONGTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.kIEUPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hANGPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter();
            this.khuyenMaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khuyenMaiTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.KhuyenMaiTableAdapter();
            this.cTKM_DICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTKM_DICHVUTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.CTKM_DICHVUTableAdapter();
            this.cTKM_HANGPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTKM_HANGPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.CTKM_HANGPHONGTableAdapter();
            this.hANGPHONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.KHACHHANGTableAdapter();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dICHVUTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.DICHVUTableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.khuyenMaiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuyenMai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayApDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mAKhuyenMaiTextEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.tenKhuyenMaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayApDungDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngayKetThucDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cTKM_DICHVUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhuyenMai2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGia1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maDichVuComboBox = new System.Windows.Forms.ComboBox();
            this.maKhuyenMaiTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.giamGiaSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTKM_HANGPHONGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhuyenMai1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maHangPhongComboBox = new System.Windows.Forms.ComboBox();
            this.maKhuyenMaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.giamGiaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            maDichVuLabel = new System.Windows.Forms.Label();
            giamGiaLabel1 = new System.Windows.Forms.Label();
            maHangPhongLabel = new System.Windows.Forms.Label();
            giamGiaLabel = new System.Windows.Forms.Label();
            mAKhuyenMaiLabel = new System.Windows.Forms.Label();
            tenKhuyenMaiLabel = new System.Windows.Forms.Label();
            ngayApDungLabel = new System.Windows.Forms.Label();
            ngayKetThucLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kIEUPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_DICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_HANGPHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAKhuyenMaiTextEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhuyenMaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_DICHVUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKhuyenMaiTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaSpinEdit1.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_HANGPHONGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKhuyenMaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaSpinEdit.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // maDichVuLabel
            // 
            maDichVuLabel.AutoSize = true;
            maDichVuLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDichVuLabel.ForeColor = System.Drawing.Color.Maroon;
            maDichVuLabel.Location = new System.Drawing.Point(6, 31);
            maDichVuLabel.Name = "maDichVuLabel";
            maDichVuLabel.Size = new System.Drawing.Size(74, 17);
            maDichVuLabel.TabIndex = 2;
            maDichVuLabel.Text = "Mã dịch vụ";
            // 
            // giamGiaLabel1
            // 
            giamGiaLabel1.AutoSize = true;
            giamGiaLabel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giamGiaLabel1.ForeColor = System.Drawing.Color.Maroon;
            giamGiaLabel1.Location = new System.Drawing.Point(193, 32);
            giamGiaLabel1.Name = "giamGiaLabel1";
            giamGiaLabel1.Size = new System.Drawing.Size(63, 17);
            giamGiaLabel1.TabIndex = 4;
            giamGiaLabel1.Text = "Giảm giá:";
            // 
            // maHangPhongLabel
            // 
            maHangPhongLabel.AutoSize = true;
            maHangPhongLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHangPhongLabel.ForeColor = System.Drawing.Color.DarkRed;
            maHangPhongLabel.Location = new System.Drawing.Point(3, 35);
            maHangPhongLabel.Name = "maHangPhongLabel";
            maHangPhongLabel.Size = new System.Drawing.Size(93, 15);
            maHangPhongLabel.TabIndex = 2;
            maHangPhongLabel.Text = "Mã hạng phòng";
            // 
            // giamGiaLabel
            // 
            giamGiaLabel.AutoSize = true;
            giamGiaLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giamGiaLabel.ForeColor = System.Drawing.Color.DarkRed;
            giamGiaLabel.Location = new System.Drawing.Point(250, 35);
            giamGiaLabel.Name = "giamGiaLabel";
            giamGiaLabel.Size = new System.Drawing.Size(55, 15);
            giamGiaLabel.TabIndex = 4;
            giamGiaLabel.Text = "Giảm giá:";
            // 
            // mAKhuyenMaiLabel
            // 
            mAKhuyenMaiLabel.AutoSize = true;
            mAKhuyenMaiLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKhuyenMaiLabel.ForeColor = System.Drawing.Color.Maroon;
            mAKhuyenMaiLabel.Location = new System.Drawing.Point(12, 20);
            mAKhuyenMaiLabel.Name = "mAKhuyenMaiLabel";
            mAKhuyenMaiLabel.Size = new System.Drawing.Size(127, 21);
            mAKhuyenMaiLabel.TabIndex = 0;
            mAKhuyenMaiLabel.Text = "Mã khuyến mãi:";
            // 
            // tenKhuyenMaiLabel
            // 
            tenKhuyenMaiLabel.AutoSize = true;
            tenKhuyenMaiLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenKhuyenMaiLabel.ForeColor = System.Drawing.Color.Maroon;
            tenKhuyenMaiLabel.Location = new System.Drawing.Point(271, 21);
            tenKhuyenMaiLabel.Name = "tenKhuyenMaiLabel";
            tenKhuyenMaiLabel.Size = new System.Drawing.Size(102, 21);
            tenKhuyenMaiLabel.TabIndex = 2;
            tenKhuyenMaiLabel.Text = "Khuyến mãi:";
            // 
            // ngayApDungLabel
            // 
            ngayApDungLabel.AutoSize = true;
            ngayApDungLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayApDungLabel.ForeColor = System.Drawing.Color.Maroon;
            ngayApDungLabel.Location = new System.Drawing.Point(55, 52);
            ngayApDungLabel.Name = "ngayApDungLabel";
            ngayApDungLabel.Size = new System.Drawing.Size(118, 21);
            ngayApDungLabel.TabIndex = 4;
            ngayApDungLabel.Text = "Ngày áp dụng:";
            // 
            // ngayKetThucLabel
            // 
            ngayKetThucLabel.AutoSize = true;
            ngayKetThucLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayKetThucLabel.ForeColor = System.Drawing.Color.Maroon;
            ngayKetThucLabel.Location = new System.Drawing.Point(357, 52);
            ngayKetThucLabel.Name = "ngayKetThucLabel";
            ngayKetThucLabel.Size = new System.Drawing.Size(117, 21);
            ngayKetThucLabel.TabIndex = 6;
            ngayKetThucLabel.Text = "Ngày kết thúc:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(865, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 721);
            this.barDockControlBottom.Size = new System.Drawing.Size(865, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 681);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(865, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 681);
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
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
            this.barManager2.MaxItemId = 11;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.FloatLocation = new System.Drawing.Point(258, 126);
            this.bar3.FloatSize = new System.Drawing.Size(0, 50);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 6;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(865, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 721);
            this.barDockControl2.Size = new System.Drawing.Size(865, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Size = new System.Drawing.Size(0, 681);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(865, 40);
            this.barDockControl4.Size = new System.Drawing.Size(0, 681);
            // 
            // btnUndo
            // 
            this.btnUndo.Id = 9;
            this.btnUndo.Name = "btnUndo";
            // 
            // btnRedo
            // 
            this.btnRedo.Id = 10;
            this.btnRedo.Name = "btnRedo";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
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
            this.tableAdapterManager.KIEUPHONGTableAdapter = this.kIEUPHONGTableAdapter;
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
            // kIEUPHONGTableAdapter
            // 
            this.kIEUPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kIEUPHONGBindingSource
            // 
            this.kIEUPHONGBindingSource.DataMember = "KIEUPHONG";
            this.kIEUPHONGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // hANGPHONGBindingSource
            // 
            this.hANGPHONGBindingSource.DataMember = "FK_HANGPHONG_KIEUPHONG";
            this.hANGPHONGBindingSource.DataSource = this.kIEUPHONGBindingSource;
            // 
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // khuyenMaiBindingSource
            // 
            this.khuyenMaiBindingSource.DataMember = "KhuyenMai";
            this.khuyenMaiBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // khuyenMaiTableAdapter
            // 
            this.khuyenMaiTableAdapter.ClearBeforeFill = true;
            // 
            // cTKM_DICHVUBindingSource
            // 
            this.cTKM_DICHVUBindingSource.DataMember = "FK_CTKM_DICHVU_KhuyenMai";
            this.cTKM_DICHVUBindingSource.DataSource = this.khuyenMaiBindingSource;
            // 
            // cTKM_DICHVUTableAdapter
            // 
            this.cTKM_DICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // cTKM_HANGPHONGBindingSource
            // 
            this.cTKM_HANGPHONGBindingSource.DataMember = "FK_CTKM_HANGPHONG_KhuyenMai";
            this.cTKM_HANGPHONGBindingSource.DataSource = this.khuyenMaiBindingSource;
            // 
            // cTKM_HANGPHONGTableAdapter
            // 
            this.cTKM_HANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // hANGPHONGBindingSource1
            // 
            this.hANGPHONGBindingSource1.DataMember = "HANGPHONG";
            this.hANGPHONGBindingSource1.DataSource = this.kHACHSANDataSet;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.khuyenMaiGridControl);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(865, 358);
            this.panel6.TabIndex = 55;
            // 
            // khuyenMaiGridControl
            // 
            this.khuyenMaiGridControl.DataSource = this.khuyenMaiBindingSource;
            this.khuyenMaiGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khuyenMaiGridControl.Location = new System.Drawing.Point(0, 93);
            this.khuyenMaiGridControl.MainView = this.gridView1;
            this.khuyenMaiGridControl.MenuManager = this.barManager1;
            this.khuyenMaiGridControl.Name = "khuyenMaiGridControl";
            this.khuyenMaiGridControl.Size = new System.Drawing.Size(865, 227);
            this.khuyenMaiGridControl.TabIndex = 46;
            this.khuyenMaiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKhuyenMai,
            this.colTenKhuyenMai,
            this.colNgayApDung,
            this.colNgayKetThuc});
            this.gridView1.GridControl = this.khuyenMaiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm khuyến mãi mới";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colMAKhuyenMai
            // 
            this.colMAKhuyenMai.Caption = "Mã khuyến mãi";
            this.colMAKhuyenMai.FieldName = "MAKhuyenMai";
            this.colMAKhuyenMai.Name = "colMAKhuyenMai";
            this.colMAKhuyenMai.Visible = true;
            this.colMAKhuyenMai.VisibleIndex = 0;
            // 
            // colTenKhuyenMai
            // 
            this.colTenKhuyenMai.Caption = "Tên khuyến mãi";
            this.colTenKhuyenMai.FieldName = "TenKhuyenMai";
            this.colTenKhuyenMai.Name = "colTenKhuyenMai";
            this.colTenKhuyenMai.Visible = true;
            this.colTenKhuyenMai.VisibleIndex = 1;
            // 
            // colNgayApDung
            // 
            this.colNgayApDung.Caption = "Ngày áp dụng";
            this.colNgayApDung.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayApDung.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayApDung.FieldName = "NgayApDung";
            this.colNgayApDung.Name = "colNgayApDung";
            this.colNgayApDung.Visible = true;
            this.colNgayApDung.VisibleIndex = 2;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.Caption = "Ngày kết thúc";
            this.colNgayKetThuc.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayKetThuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayKetThuc.FieldName = "NgayKetThuc";
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.Visible = true;
            this.colNgayKetThuc.VisibleIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(mAKhuyenMaiLabel);
            this.groupBox3.Controls.Add(this.mAKhuyenMaiTextEdit2);
            this.groupBox3.Controls.Add(tenKhuyenMaiLabel);
            this.groupBox3.Controls.Add(this.tenKhuyenMaiTextEdit);
            this.groupBox3.Controls.Add(ngayApDungLabel);
            this.groupBox3.Controls.Add(this.ngayApDungDateEdit);
            this.groupBox3.Controls.Add(ngayKetThucLabel);
            this.groupBox3.Controls.Add(this.ngayKetThucDateEdit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(865, 93);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khuyến mãi";
            // 
            // mAKhuyenMaiTextEdit2
            // 
            this.mAKhuyenMaiTextEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuyenMaiBindingSource, "MAKhuyenMai", true));
            this.mAKhuyenMaiTextEdit2.Location = new System.Drawing.Point(147, 22);
            this.mAKhuyenMaiTextEdit2.MenuManager = this.barManager1;
            this.mAKhuyenMaiTextEdit2.Name = "mAKhuyenMaiTextEdit2";
            this.mAKhuyenMaiTextEdit2.Properties.MaxLength = 10;
            this.mAKhuyenMaiTextEdit2.Size = new System.Drawing.Size(100, 20);
            this.mAKhuyenMaiTextEdit2.TabIndex = 1;
            this.mAKhuyenMaiTextEdit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mAKhuyenMaiTextEdit2_KeyPress);
            this.mAKhuyenMaiTextEdit2.Leave += new System.EventHandler(this.mAKhuyenMaiTextEdit2_Leave);
            // 
            // tenKhuyenMaiTextEdit
            // 
            this.tenKhuyenMaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuyenMaiBindingSource, "TenKhuyenMai", true));
            this.tenKhuyenMaiTextEdit.Location = new System.Drawing.Point(379, 23);
            this.tenKhuyenMaiTextEdit.MenuManager = this.barManager1;
            this.tenKhuyenMaiTextEdit.Name = "tenKhuyenMaiTextEdit";
            this.tenKhuyenMaiTextEdit.Properties.MaxLength = 50;
            this.tenKhuyenMaiTextEdit.Size = new System.Drawing.Size(269, 20);
            this.tenKhuyenMaiTextEdit.TabIndex = 3;
            this.tenKhuyenMaiTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tenKhuyenMaiTextEdit_KeyPress);
            this.tenKhuyenMaiTextEdit.Leave += new System.EventHandler(this.tenKhuyenMaiTextEdit_Leave);
            // 
            // ngayApDungDateEdit
            // 
            this.ngayApDungDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuyenMaiBindingSource, "NgayApDung", true));
            this.ngayApDungDateEdit.EditValue = null;
            this.ngayApDungDateEdit.Location = new System.Drawing.Point(179, 53);
            this.ngayApDungDateEdit.MenuManager = this.barManager1;
            this.ngayApDungDateEdit.Name = "ngayApDungDateEdit";
            this.ngayApDungDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayApDungDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayApDungDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngayApDungDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayApDungDateEdit.Properties.MinValue = new System.DateTime(2017, 10, 31, 0, 55, 42, 0);
            this.ngayApDungDateEdit.Size = new System.Drawing.Size(126, 20);
            this.ngayApDungDateEdit.TabIndex = 5;
            this.ngayApDungDateEdit.EditValueChanged += new System.EventHandler(this.ngayApDungDateEdit_EditValueChanged);
            // 
            // ngayKetThucDateEdit
            // 
            this.ngayKetThucDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khuyenMaiBindingSource, "NgayKetThuc", true));
            this.ngayKetThucDateEdit.EditValue = null;
            this.ngayKetThucDateEdit.Location = new System.Drawing.Point(480, 54);
            this.ngayKetThucDateEdit.MenuManager = this.barManager1;
            this.ngayKetThucDateEdit.Name = "ngayKetThucDateEdit";
            this.ngayKetThucDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThucDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayKetThucDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngayKetThucDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayKetThucDateEdit.Properties.MinValue = new System.DateTime(2017, 10, 31, 2, 25, 22, 0);
            this.ngayKetThucDateEdit.Size = new System.Drawing.Size(140, 20);
            this.ngayKetThucDateEdit.TabIndex = 7;
            this.ngayKetThucDateEdit.EditValueChanged += new System.EventHandler(this.ngayKetThucDateEdit_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 340);
            this.panel1.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.cTKM_DICHVUGridControl);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(455, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 340);
            this.panel3.TabIndex = 1;
            // 
            // cTKM_DICHVUGridControl
            // 
            this.cTKM_DICHVUGridControl.DataSource = this.cTKM_DICHVUBindingSource;
            this.cTKM_DICHVUGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTKM_DICHVUGridControl.Location = new System.Drawing.Point(0, 133);
            this.cTKM_DICHVUGridControl.MainView = this.gridView3;
            this.cTKM_DICHVUGridControl.MenuManager = this.barManager1;
            this.cTKM_DICHVUGridControl.Name = "cTKM_DICHVUGridControl";
            this.cTKM_DICHVUGridControl.Size = new System.Drawing.Size(441, 204);
            this.cTKM_DICHVUGridControl.TabIndex = 5;
            this.cTKM_DICHVUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhuyenMai2,
            this.colMaDichVu,
            this.colGiamGia1});
            this.gridView3.GridControl = this.cTKM_DICHVUGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsBehavior.ReadOnly = true;
            this.gridView3.OptionsFind.AlwaysVisible = true;
            // 
            // colMaKhuyenMai2
            // 
            this.colMaKhuyenMai2.Caption = "Mã khuyến mãi";
            this.colMaKhuyenMai2.FieldName = "MaKhuyenMai";
            this.colMaKhuyenMai2.Name = "colMaKhuyenMai2";
            this.colMaKhuyenMai2.Visible = true;
            this.colMaKhuyenMai2.VisibleIndex = 0;
            // 
            // colMaDichVu
            // 
            this.colMaDichVu.Caption = "Mã dịch vụ";
            this.colMaDichVu.FieldName = "MaDichVu";
            this.colMaDichVu.Name = "colMaDichVu";
            this.colMaDichVu.Visible = true;
            this.colMaDichVu.VisibleIndex = 1;
            // 
            // colGiamGia1
            // 
            this.colGiamGia1.Caption = "Giảm giá";
            this.colGiamGia1.FieldName = "GiamGia";
            this.colGiamGia1.Name = "colGiamGia1";
            this.colGiamGia1.Visible = true;
            this.colGiamGia1.VisibleIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.maDichVuComboBox);
            this.groupBox2.Controls.Add(this.maKhuyenMaiTextEdit1);
            this.groupBox2.Controls.Add(maDichVuLabel);
            this.groupBox2.Controls.Add(giamGiaLabel1);
            this.groupBox2.Controls.Add(this.giamGiaSpinEdit1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(0, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 70);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dịch vụ";
            // 
            // maDichVuComboBox
            // 
            this.maDichVuComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cTKM_DICHVUBindingSource, "MaDichVu", true));
            this.maDichVuComboBox.DataSource = this.dICHVUBindingSource;
            this.maDichVuComboBox.DisplayMember = "TenDichVu";
            this.maDichVuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maDichVuComboBox.FormattingEnabled = true;
            this.maDichVuComboBox.Location = new System.Drawing.Point(86, 29);
            this.maDichVuComboBox.Name = "maDichVuComboBox";
            this.maDichVuComboBox.Size = new System.Drawing.Size(101, 21);
            this.maDichVuComboBox.TabIndex = 6;
            this.maDichVuComboBox.ValueMember = "MADichVu";
            // 
            // maKhuyenMaiTextEdit1
            // 
            this.maKhuyenMaiTextEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTKM_DICHVUBindingSource, "MaKhuyenMai", true));
            this.maKhuyenMaiTextEdit1.Location = new System.Drawing.Point(301, 6);
            this.maKhuyenMaiTextEdit1.MenuManager = this.barManager1;
            this.maKhuyenMaiTextEdit1.Name = "maKhuyenMaiTextEdit1";
            this.maKhuyenMaiTextEdit1.Size = new System.Drawing.Size(58, 20);
            this.maKhuyenMaiTextEdit1.TabIndex = 1;
            this.maKhuyenMaiTextEdit1.Visible = false;
            // 
            // giamGiaSpinEdit1
            // 
            this.giamGiaSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTKM_DICHVUBindingSource, "GiamGia", true));
            this.giamGiaSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giamGiaSpinEdit1.Location = new System.Drawing.Point(260, 31);
            this.giamGiaSpinEdit1.MenuManager = this.barManager1;
            this.giamGiaSpinEdit1.Name = "giamGiaSpinEdit1";
            this.giamGiaSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giamGiaSpinEdit1.Properties.MaxLength = 3;
            this.giamGiaSpinEdit1.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.giamGiaSpinEdit1.Size = new System.Drawing.Size(100, 20);
            this.giamGiaSpinEdit1.TabIndex = 5;
            this.giamGiaSpinEdit1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giamGiaSpinEdit1_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(441, 63);
            this.panel5.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkRed;
            this.button6.Location = new System.Drawing.Point(331, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 39);
            this.button6.TabIndex = 4;
            this.button6.Text = "Lưu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkRed;
            this.button7.Location = new System.Drawing.Point(253, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 39);
            this.button7.TabIndex = 3;
            this.button7.Text = "Hủy";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkRed;
            this.button8.Location = new System.Drawing.Point(3, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 38);
            this.button8.TabIndex = 0;
            this.button8.Text = "Thêm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.DarkRed;
            this.button9.Location = new System.Drawing.Point(168, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 38);
            this.button9.TabIndex = 2;
            this.button9.Text = "Xóa";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.DarkRed;
            this.button10.Location = new System.Drawing.Point(82, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(78, 40);
            this.button10.TabIndex = 1;
            this.button10.Text = "Chỉnh sửa";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.cTKM_HANGPHONGGridControl);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 340);
            this.panel2.TabIndex = 0;
            // 
            // cTKM_HANGPHONGGridControl
            // 
            this.cTKM_HANGPHONGGridControl.DataSource = this.cTKM_HANGPHONGBindingSource;
            this.cTKM_HANGPHONGGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTKM_HANGPHONGGridControl.Location = new System.Drawing.Point(0, 135);
            this.cTKM_HANGPHONGGridControl.MainView = this.gridView2;
            this.cTKM_HANGPHONGGridControl.MenuManager = this.barManager1;
            this.cTKM_HANGPHONGGridControl.Name = "cTKM_HANGPHONGGridControl";
            this.cTKM_HANGPHONGGridControl.Size = new System.Drawing.Size(455, 202);
            this.cTKM_HANGPHONGGridControl.TabIndex = 4;
            this.cTKM_HANGPHONGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhuyenMai1,
            this.colMaHangPhong,
            this.colGiamGia});
            this.gridView2.GridControl = this.cTKM_HANGPHONGGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // colMaKhuyenMai1
            // 
            this.colMaKhuyenMai1.Caption = "Mã khuyến mãi";
            this.colMaKhuyenMai1.FieldName = "MaKhuyenMai";
            this.colMaKhuyenMai1.Name = "colMaKhuyenMai1";
            this.colMaKhuyenMai1.Visible = true;
            this.colMaKhuyenMai1.VisibleIndex = 0;
            // 
            // colMaHangPhong
            // 
            this.colMaHangPhong.Caption = "Mã hạng phòng";
            this.colMaHangPhong.FieldName = "MaHangPhong";
            this.colMaHangPhong.Name = "colMaHangPhong";
            this.colMaHangPhong.Visible = true;
            this.colMaHangPhong.VisibleIndex = 1;
            // 
            // colGiamGia
            // 
            this.colGiamGia.Caption = "Giảm giá";
            this.colGiamGia.FieldName = "GiamGia";
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Visible = true;
            this.colGiamGia.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.maHangPhongComboBox);
            this.groupBox1.Controls.Add(this.maKhuyenMaiTextEdit);
            this.groupBox1.Controls.Add(maHangPhongLabel);
            this.groupBox1.Controls.Add(giamGiaLabel);
            this.groupBox1.Controls.Add(this.giamGiaSpinEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hạng Phòng";
            // 
            // maHangPhongComboBox
            // 
            this.maHangPhongComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cTKM_HANGPHONGBindingSource, "MaHangPhong", true));
            this.maHangPhongComboBox.DataSource = this.hANGPHONGBindingSource1;
            this.maHangPhongComboBox.DisplayMember = "HangPhong";
            this.maHangPhongComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.maHangPhongComboBox.FormattingEnabled = true;
            this.maHangPhongComboBox.Location = new System.Drawing.Point(101, 32);
            this.maHangPhongComboBox.Name = "maHangPhongComboBox";
            this.maHangPhongComboBox.Size = new System.Drawing.Size(121, 21);
            this.maHangPhongComboBox.TabIndex = 6;
            this.maHangPhongComboBox.ValueMember = "MAHangPhong";
            // 
            // maKhuyenMaiTextEdit
            // 
            this.maKhuyenMaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTKM_HANGPHONGBindingSource, "MaKhuyenMai", true));
            this.maKhuyenMaiTextEdit.Location = new System.Drawing.Point(374, 7);
            this.maKhuyenMaiTextEdit.MenuManager = this.barManager1;
            this.maKhuyenMaiTextEdit.Name = "maKhuyenMaiTextEdit";
            this.maKhuyenMaiTextEdit.Size = new System.Drawing.Size(53, 20);
            this.maKhuyenMaiTextEdit.TabIndex = 1;
            this.maKhuyenMaiTextEdit.Visible = false;
            // 
            // giamGiaSpinEdit
            // 
            this.giamGiaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTKM_HANGPHONGBindingSource, "GiamGia", true));
            this.giamGiaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.giamGiaSpinEdit.Location = new System.Drawing.Point(309, 33);
            this.giamGiaSpinEdit.MenuManager = this.barManager1;
            this.giamGiaSpinEdit.Name = "giamGiaSpinEdit";
            this.giamGiaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.giamGiaSpinEdit.Properties.MaxLength = 3;
            this.giamGiaSpinEdit.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.giamGiaSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.giamGiaSpinEdit.TabIndex = 5;
            this.giamGiaSpinEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.giamGiaSpinEdit_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 63);
            this.panel4.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkRed;
            this.button5.Location = new System.Drawing.Point(344, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Lưu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkRed;
            this.button4.Location = new System.Drawing.Point(253, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 39);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(168, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(82, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chỉnh sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.DarkRed;
            this.btnQuayLai.Location = new System.Drawing.Point(601, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(143, 23);
            this.btnQuayLai.TabIndex = 57;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Visible = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.ForeColor = System.Drawing.Color.DarkRed;
            this.btnChiTiet.Location = new System.Drawing.Point(601, 8);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(143, 23);
            this.btnChiTiet.TabIndex = 58;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // FormKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 721);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormKhuyenMai";
            this.Text = "Kiểu phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKhuyenMai_FormClosing);
            this.Load += new System.EventHandler(this.FormKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kIEUPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_DICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_HANGPHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khuyenMaiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mAKhuyenMaiTextEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenKhuyenMaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayApDungDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayKetThucDateEdit.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_DICHVUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKhuyenMaiTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaSpinEdit1.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTKM_HANGPHONGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maKhuyenMaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giamGiaSpinEdit.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.BindingSource kIEUPHONGBindingSource;
        private KHACHSANDataSet kHACHSANDataSet;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KHACHSANDataSetTableAdapters.KIEUPHONGTableAdapter kIEUPHONGTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.BindingSource hANGPHONGBindingSource;
        private KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
        private System.Windows.Forms.BindingSource khuyenMaiBindingSource;
        private KHACHSANDataSetTableAdapters.KhuyenMaiTableAdapter khuyenMaiTableAdapter;
        private System.Windows.Forms.BindingSource cTKM_DICHVUBindingSource;
        private KHACHSANDataSetTableAdapters.CTKM_DICHVUTableAdapter cTKM_DICHVUTableAdapter;
        private System.Windows.Forms.BindingSource cTKM_HANGPHONGBindingSource;
        private KHACHSANDataSetTableAdapters.CTKM_HANGPHONGTableAdapter cTKM_HANGPHONGTableAdapter;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private KHACHSANDataSetTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource hANGPHONGBindingSource1;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private KHACHSANDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl cTKM_DICHVUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhuyenMai2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGia1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox maDichVuComboBox;
        private DevExpress.XtraEditors.TextEdit maKhuyenMaiTextEdit1;
        private DevExpress.XtraEditors.SpinEdit giamGiaSpinEdit1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl cTKM_HANGPHONGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhuyenMai1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox maHangPhongComboBox;
        private DevExpress.XtraEditors.TextEdit maKhuyenMaiTextEdit;
        private DevExpress.XtraEditors.SpinEdit giamGiaSpinEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl khuyenMaiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuyenMai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayApDung;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKetThuc;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit mAKhuyenMaiTextEdit2;
        private DevExpress.XtraEditors.TextEdit tenKhuyenMaiTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayApDungDateEdit;
        private DevExpress.XtraEditors.DateEdit ngayKetThucDateEdit;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnChiTiet;
    }
}