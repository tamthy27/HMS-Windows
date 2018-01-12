namespace QuanLyKhachSan.KSForm
{
    partial class FormHOADON
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHOADON));
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hOADONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCTy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMASoThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cTHOADONGridControl = new DevExpress.XtraGrid.GridControl();
            this.cTHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACTPhieuThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTHOADONTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.CTHOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.HOADONTableAdapter = this.hOADONTableAdapter;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.hOADONGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 448);
            this.panel1.TabIndex = 0;
            // 
            // hOADONGridControl
            // 
            this.hOADONGridControl.DataSource = this.hOADONBindingSource;
            this.hOADONGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hOADONGridControl.Location = new System.Drawing.Point(0, 0);
            this.hOADONGridControl.MainView = this.gridView1;
            this.hOADONGridControl.MenuManager = this.barManager1;
            this.hOADONGridControl.Name = "hOADONGridControl";
            this.hOADONGridControl.Size = new System.Drawing.Size(446, 448);
            this.hOADONGridControl.TabIndex = 0;
            this.hOADONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD,
            this.colMANV,
            this.colNgayThanhToan,
            this.colTenCTy,
            this.colMASoThue});
            this.gridView1.GridControl = this.hOADONGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colMAHD
            // 
            this.colMAHD.Caption = "Mã hóa đơn";
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 1;
            // 
            // colNgayThanhToan
            // 
            this.colNgayThanhToan.Caption = "Ngày thanh toán";
            this.colNgayThanhToan.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayThanhToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayThanhToan.FieldName = "NgayThanhToan";
            this.colNgayThanhToan.Name = "colNgayThanhToan";
            this.colNgayThanhToan.Visible = true;
            this.colNgayThanhToan.VisibleIndex = 2;
            // 
            // colTenCTy
            // 
            this.colTenCTy.Caption = "Tên công ty";
            this.colTenCTy.FieldName = "TenCTy";
            this.colTenCTy.Name = "colTenCTy";
            this.colTenCTy.Visible = true;
            this.colTenCTy.VisibleIndex = 3;
            // 
            // colMASoThue
            // 
            this.colMASoThue.Caption = "Mã số thuế";
            this.colMASoThue.FieldName = "MASoThue";
            this.colMASoThue.Name = "colMASoThue";
            this.colMASoThue.Visible = true;
            this.colMASoThue.VisibleIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thanh toán";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In hóa đơn";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Reload";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xuất hóa đơn";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(906, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Size = new System.Drawing.Size(906, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(906, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cTHOADONGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(446, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 448);
            this.panel2.TabIndex = 1;
            // 
            // cTHOADONGridControl
            // 
            this.cTHOADONGridControl.DataSource = this.cTHOADONBindingSource;
            this.cTHOADONGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTHOADONGridControl.Location = new System.Drawing.Point(0, 0);
            this.cTHOADONGridControl.MainView = this.gridView2;
            this.cTHOADONGridControl.MenuManager = this.barManager1;
            this.cTHOADONGridControl.Name = "cTHOADONGridControl";
            this.cTHOADONGridControl.Size = new System.Drawing.Size(460, 448);
            this.cTHOADONGridControl.TabIndex = 0;
            this.cTHOADONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // cTHOADONBindingSource
            // 
            this.cTHOADONBindingSource.DataMember = "FK_CTHOADON_HOADON";
            this.cTHOADONBindingSource.DataSource = this.hOADONBindingSource;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD1,
            this.colMACTPhieuThue,
            this.colTienPhong,
            this.colTienDV,
            this.colGiamGia});
            this.gridView2.GridControl = this.cTHOADONGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // colMAHD1
            // 
            this.colMAHD1.Caption = "Mã hóa đơn";
            this.colMAHD1.FieldName = "MAHD";
            this.colMAHD1.Name = "colMAHD1";
            this.colMAHD1.Visible = true;
            this.colMAHD1.VisibleIndex = 0;
            // 
            // colMACTPhieuThue
            // 
            this.colMACTPhieuThue.Caption = "CT phiếu thuê";
            this.colMACTPhieuThue.FieldName = "MACTPhieuThue";
            this.colMACTPhieuThue.Name = "colMACTPhieuThue";
            this.colMACTPhieuThue.Visible = true;
            this.colMACTPhieuThue.VisibleIndex = 1;
            // 
            // colTienPhong
            // 
            this.colTienPhong.Caption = "Tiền phòng";
            this.colTienPhong.FieldName = "TienPhong";
            this.colTienPhong.Name = "colTienPhong";
            this.colTienPhong.Visible = true;
            this.colTienPhong.VisibleIndex = 2;
            // 
            // colTienDV
            // 
            this.colTienDV.Caption = "Tiền dịch vụ";
            this.colTienDV.FieldName = "TienDV";
            this.colTienDV.Name = "colTienDV";
            this.colTienDV.Visible = true;
            this.colTienDV.VisibleIndex = 3;
            // 
            // colGiamGia
            // 
            this.colGiamGia.Caption = "Giảm giá";
            this.colGiamGia.FieldName = "GiamGia";
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Visible = true;
            this.colGiamGia.VisibleIndex = 4;
            // 
            // cTHOADONTableAdapter
            // 
            this.cTHOADONTableAdapter.ClearBeforeFill = true;
            // 
            // FormHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormHOADON";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FormHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hOADONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KHACHSANDataSet kHACHSANDataSet;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private KHACHSANDataSetTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource cTHOADONBindingSource;
        private KHACHSANDataSetTableAdapters.CTHOADONTableAdapter cTHOADONTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.GridControl hOADONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCTy;
        private DevExpress.XtraGrid.Columns.GridColumn colMASoThue;
        private DevExpress.XtraGrid.GridControl cTHOADONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACTPhieuThue;
        private DevExpress.XtraGrid.Columns.GridColumn colTienPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTienDV;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGia;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}