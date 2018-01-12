namespace QuanLyKhachSan.KSForm
{
    partial class FormBaoCaoCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCaoCheckIn));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.sP_GETTHONGTINCHECKINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GETTHONGTINCHECKINTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_GETTHONGTINCHECKINTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.sP_GETTHONGTINCHECKINGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPhieuThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPhieuDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETTHONGTINCHECKINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETTHONGTINCHECKINGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "In Danh Sách";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(452, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Size = new System.Drawing.Size(452, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(452, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_GETTHONGTINCHECKINBindingSource
            // 
            this.sP_GETTHONGTINCHECKINBindingSource.DataMember = "SP_GETTHONGTINCHECKIN";
            this.sP_GETTHONGTINCHECKINBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // sP_GETTHONGTINCHECKINTableAdapter
            // 
            this.sP_GETTHONGTINCHECKINTableAdapter.ClearBeforeFill = true;
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
            // sP_GETTHONGTINCHECKINGridControl
            // 
            this.sP_GETTHONGTINCHECKINGridControl.DataSource = this.sP_GETTHONGTINCHECKINBindingSource;
            this.sP_GETTHONGTINCHECKINGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_GETTHONGTINCHECKINGridControl.Location = new System.Drawing.Point(0, 40);
            this.sP_GETTHONGTINCHECKINGridControl.MainView = this.gridView1;
            this.sP_GETTHONGTINCHECKINGridControl.MenuManager = this.barManager1;
            this.sP_GETTHONGTINCHECKINGridControl.Name = "sP_GETTHONGTINCHECKINGridControl";
            this.sP_GETTHONGTINCHECKINGridControl.Size = new System.Drawing.Size(452, 398);
            this.sP_GETTHONGTINCHECKINGridControl.TabIndex = 5;
            this.sP_GETTHONGTINCHECKINGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPhieuThue,
            this.colMAPhieuDat,
            this.colMAPhong,
            this.colNgayDen,
            this.colNgayDi,
            this.colDonGia});
            this.gridView1.GridControl = this.sP_GETTHONGTINCHECKINGridControl;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.KeepGroupExpandedOnSorting = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMAPhieuThue, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMAPhieuThue
            // 
            this.colMAPhieuThue.Caption = "Mã phiếu thuê";
            this.colMAPhieuThue.FieldName = "MAPhieuThue";
            this.colMAPhieuThue.Name = "colMAPhieuThue";
            this.colMAPhieuThue.Visible = true;
            this.colMAPhieuThue.VisibleIndex = 0;
            // 
            // colMAPhieuDat
            // 
            this.colMAPhieuDat.Caption = "Mã phiếu đặt";
            this.colMAPhieuDat.FieldName = "MAPhieuDat";
            this.colMAPhieuDat.Name = "colMAPhieuDat";
            this.colMAPhieuDat.Visible = true;
            this.colMAPhieuDat.VisibleIndex = 0;
            // 
            // colMAPhong
            // 
            this.colMAPhong.Caption = "Mã phòng";
            this.colMAPhong.FieldName = "MAPhong";
            this.colMAPhong.Name = "colMAPhong";
            this.colMAPhong.Visible = true;
            this.colMAPhong.VisibleIndex = 1;
            // 
            // colNgayDen
            // 
            this.colNgayDen.Caption = "Ngày đến";
            this.colNgayDen.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayDen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayDen.FieldName = "NgayDen";
            this.colNgayDen.Name = "colNgayDen";
            this.colNgayDen.Visible = true;
            this.colNgayDen.VisibleIndex = 2;
            // 
            // colNgayDi
            // 
            this.colNgayDi.Caption = "Ngày đi";
            this.colNgayDi.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayDi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayDi.FieldName = "NgayDi";
            this.colNgayDi.Name = "colNgayDi";
            this.colNgayDi.Visible = true;
            this.colNgayDi.VisibleIndex = 3;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 4;
            // 
            // FormBaoCaoCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 438);
            this.Controls.Add(this.sP_GETTHONGTINCHECKINGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBaoCaoCheckIn";
            this.Text = "FormBaoCaoCheckIn";
            this.Load += new System.EventHandler(this.FormBaoCaoCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETTHONGTINCHECKINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETTHONGTINCHECKINGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource sP_GETTHONGTINCHECKINBindingSource;
        private KHACHSANDataSet kHACHSANDataSet;
        private KHACHSANDataSetTableAdapters.SP_GETTHONGTINCHECKINTableAdapter sP_GETTHONGTINCHECKINTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_GETTHONGTINCHECKINGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhieuThue;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhieuDat;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDi;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
    }
}