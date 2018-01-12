namespace QuanLyKhachSan.KSForm
{
    partial class FormGiaHan
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
            System.Windows.Forms.Label mAPhieuDatLabel;
            System.Windows.Forms.Label ngayDenLabel;
            System.Windows.Forms.Label ngayDiLabel;
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.sP_APPSOLUONGCOTHEDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_APPSOLUONGCOTHEDATTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_APPSOLUONGCOTHEDATTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.pHIEUDATTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.PHIEUDATTableAdapter();
            this.sP_APPSOLUONGCOTHEDATGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ngayDiDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.pHIEUDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngayDenDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.mAPhieuDatComboBox = new System.Windows.Forms.ComboBox();
            this.sPPHIEUDATCOTHEGIAHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sP_GetCTPhieuDatGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_GetCTPhieuDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPhieuDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHangPhong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTPHIEUDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTPHIEUDATTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.CTPHIEUDATTableAdapter();
            this.sP_PHIEUDATCOTHEGIAHANGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_PHIEUDATCOTHEGIAHANGTableAdapter();
            this.sP_GetCTPhieuDatTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_GetCTPhieuDatTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.maphieudatToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maphieudatToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            mAPhieuDatLabel = new System.Windows.Forms.Label();
            ngayDenLabel = new System.Windows.Forms.Label();
            ngayDiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_APPSOLUONGCOTHEDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_APPSOLUONGCOTHEDATGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDiDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDiDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDenDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDenDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPHIEUDATCOTHEGIAHANGBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetCTPhieuDatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetCTPhieuDatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUDATBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPhieuDatLabel
            // 
            mAPhieuDatLabel.AutoSize = true;
            mAPhieuDatLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPhieuDatLabel.ForeColor = System.Drawing.Color.Maroon;
            mAPhieuDatLabel.Location = new System.Drawing.Point(6, 16);
            mAPhieuDatLabel.Name = "mAPhieuDatLabel";
            mAPhieuDatLabel.Size = new System.Drawing.Size(96, 19);
            mAPhieuDatLabel.TabIndex = 0;
            mAPhieuDatLabel.Text = "Mã Phiếu Đặt:";
            // 
            // ngayDenLabel
            // 
            ngayDenLabel.AutoSize = true;
            ngayDenLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayDenLabel.ForeColor = System.Drawing.Color.Maroon;
            ngayDenLabel.Location = new System.Drawing.Point(252, 16);
            ngayDenLabel.Name = "ngayDenLabel";
            ngayDenLabel.Size = new System.Drawing.Size(71, 19);
            ngayDenLabel.TabIndex = 2;
            ngayDenLabel.Text = "Ngày đến:";
            // 
            // ngayDiLabel
            // 
            ngayDiLabel.AutoSize = true;
            ngayDiLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayDiLabel.ForeColor = System.Drawing.Color.Maroon;
            ngayDiLabel.Location = new System.Drawing.Point(487, 16);
            ngayDiLabel.Name = "ngayDiLabel";
            ngayDiLabel.Size = new System.Drawing.Size(60, 19);
            ngayDiLabel.TabIndex = 4;
            ngayDiLabel.Text = "Ngày đi:";
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_APPSOLUONGCOTHEDATBindingSource
            // 
            this.sP_APPSOLUONGCOTHEDATBindingSource.DataMember = "SP_APPSOLUONGCOTHEDAT";
            this.sP_APPSOLUONGCOTHEDATBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // sP_APPSOLUONGCOTHEDATTableAdapter
            // 
            this.sP_APPSOLUONGCOTHEDATTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KIEUPHONGTableAdapter = null;
            this.tableAdapterManager.LOAIDICHVUTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATTableAdapter = this.pHIEUDATTableAdapter;
            this.tableAdapterManager.PHIEUTHUETableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TANGTableAdapter = null;
            this.tableAdapterManager.TINHTRANGPHIEUTableAdapter = null;
            this.tableAdapterManager.TINHTRANGPHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHIEUDATTableAdapter
            // 
            this.pHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // sP_APPSOLUONGCOTHEDATGridControl
            // 
            this.sP_APPSOLUONGCOTHEDATGridControl.DataSource = this.sP_APPSOLUONGCOTHEDATBindingSource;
            this.sP_APPSOLUONGCOTHEDATGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sP_APPSOLUONGCOTHEDATGridControl.Location = new System.Drawing.Point(3, 16);
            this.sP_APPSOLUONGCOTHEDATGridControl.MainView = this.gridView1;
            this.sP_APPSOLUONGCOTHEDATGridControl.Name = "sP_APPSOLUONGCOTHEDATGridControl";
            this.sP_APPSOLUONGCOTHEDATGridControl.Size = new System.Drawing.Size(398, 373);
            this.sP_APPSOLUONGCOTHEDATGridControl.TabIndex = 2;
            this.sP_APPSOLUONGCOTHEDATGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHangPhong,
            this.colHangPhong,
            this.colsoluong});
            this.gridView1.GridControl = this.sP_APPSOLUONGCOTHEDATGridControl;
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
            // colHangPhong
            // 
            this.colHangPhong.Caption = "Hạng phòng";
            this.colHangPhong.FieldName = "HangPhong";
            this.colHangPhong.Name = "colHangPhong";
            this.colHangPhong.Visible = true;
            this.colHangPhong.VisibleIndex = 1;
            // 
            // colsoluong
            // 
            this.colsoluong.Caption = "Số lượng";
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(ngayDiLabel);
            this.groupBox1.Controls.Add(this.ngayDiDateEdit);
            this.groupBox1.Controls.Add(ngayDenLabel);
            this.groupBox1.Controls.Add(this.ngayDenDateEdit);
            this.groupBox1.Controls.Add(mAPhieuDatLabel);
            this.groupBox1.Controls.Add(this.mAPhieuDatComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(424, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gia hạn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ngayDiDateEdit
            // 
            this.ngayDiDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUDATBindingSource, "NgayDi", true));
            this.ngayDiDateEdit.EditValue = null;
            this.ngayDiDateEdit.Location = new System.Drawing.Point(553, 16);
            this.ngayDiDateEdit.Name = "ngayDiDateEdit";
            this.ngayDiDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDiDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDiDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngayDiDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayDiDateEdit.Size = new System.Drawing.Size(119, 20);
            this.ngayDiDateEdit.TabIndex = 5;
            this.ngayDiDateEdit.EditValueChanged += new System.EventHandler(this.ngayDiDateEdit_EditValueChanged);
            // 
            // pHIEUDATBindingSource
            // 
            this.pHIEUDATBindingSource.DataMember = "PHIEUDAT";
            this.pHIEUDATBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // ngayDenDateEdit
            // 
            this.ngayDenDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pHIEUDATBindingSource, "NgayDen", true));
            this.ngayDenDateEdit.EditValue = null;
            this.ngayDenDateEdit.Location = new System.Drawing.Point(329, 17);
            this.ngayDenDateEdit.Name = "ngayDenDateEdit";
            this.ngayDenDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDenDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDenDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngayDenDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayDenDateEdit.Size = new System.Drawing.Size(129, 20);
            this.ngayDenDateEdit.TabIndex = 3;
            this.ngayDenDateEdit.EditValueChanged += new System.EventHandler(this.ngayDenDateEdit_EditValueChanged);
            // 
            // mAPhieuDatComboBox
            // 
            this.mAPhieuDatComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pHIEUDATBindingSource, "MAPhieuDat", true));
            this.mAPhieuDatComboBox.DataSource = this.sPPHIEUDATCOTHEGIAHANGBindingSource;
            this.mAPhieuDatComboBox.DisplayMember = "MAPhieuDat";
            this.mAPhieuDatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mAPhieuDatComboBox.FormattingEnabled = true;
            this.mAPhieuDatComboBox.Location = new System.Drawing.Point(108, 15);
            this.mAPhieuDatComboBox.Name = "mAPhieuDatComboBox";
            this.mAPhieuDatComboBox.Size = new System.Drawing.Size(121, 21);
            this.mAPhieuDatComboBox.TabIndex = 1;
            this.mAPhieuDatComboBox.ValueMember = "MAPhieuDat";
            this.mAPhieuDatComboBox.SelectedIndexChanged += new System.EventHandler(this.mAPhieuDatComboBox_SelectedIndexChanged);
            this.mAPhieuDatComboBox.SelectionChangeCommitted += new System.EventHandler(this.mAPhieuDatComboBox_SelectionChangeCommitted);
            // 
            // sPPHIEUDATCOTHEGIAHANGBindingSource
            // 
            this.sPPHIEUDATCOTHEGIAHANGBindingSource.DataMember = "SP_PHIEUDATCOTHEGIAHANG";
            this.sPPHIEUDATCOTHEGIAHANGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sP_GetCTPhieuDatGridControl);
            this.groupBox2.Controls.Add(this.sP_APPSOLUONGCOTHEDATGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 392);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // sP_GetCTPhieuDatGridControl
            // 
            this.sP_GetCTPhieuDatGridControl.DataSource = this.sP_GetCTPhieuDatBindingSource;
            this.sP_GetCTPhieuDatGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sP_GetCTPhieuDatGridControl.Location = new System.Drawing.Point(401, 16);
            this.sP_GetCTPhieuDatGridControl.MainView = this.gridView2;
            this.sP_GetCTPhieuDatGridControl.Name = "sP_GetCTPhieuDatGridControl";
            this.sP_GetCTPhieuDatGridControl.Size = new System.Drawing.Size(436, 373);
            this.sP_GetCTPhieuDatGridControl.TabIndex = 2;
            this.sP_GetCTPhieuDatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sP_GetCTPhieuDatBindingSource
            // 
            this.sP_GetCTPhieuDatBindingSource.DataMember = "SP_GetCTPhieuDat";
            this.sP_GetCTPhieuDatBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPhieuDat,
            this.colMAHangPhong1,
            this.colSoLuong1});
            this.gridView2.GridControl = this.sP_GetCTPhieuDatGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            // 
            // colMAPhieuDat
            // 
            this.colMAPhieuDat.Caption = "Mã phiếu đặt";
            this.colMAPhieuDat.FieldName = "MAPhieuDat";
            this.colMAPhieuDat.Name = "colMAPhieuDat";
            this.colMAPhieuDat.Visible = true;
            this.colMAPhieuDat.VisibleIndex = 0;
            // 
            // colMAHangPhong1
            // 
            this.colMAHangPhong1.Caption = "Mã hạng phòng";
            this.colMAHangPhong1.FieldName = "MAHangPhong";
            this.colMAHangPhong1.Name = "colMAHangPhong1";
            this.colMAHangPhong1.Visible = true;
            this.colMAHangPhong1.VisibleIndex = 1;
            // 
            // colSoLuong1
            // 
            this.colSoLuong1.Caption = "Số lượng";
            this.colSoLuong1.FieldName = "SoLuong";
            this.colSoLuong1.Name = "colSoLuong1";
            this.colSoLuong1.Visible = true;
            this.colSoLuong1.VisibleIndex = 2;
            // 
            // cTPHIEUDATBindingSource
            // 
            this.cTPHIEUDATBindingSource.DataMember = "FK_CT_HANGPHONG_PHIEUDAT";
            this.cTPHIEUDATBindingSource.DataSource = this.pHIEUDATBindingSource;
            // 
            // cTPHIEUDATTableAdapter
            // 
            this.cTPHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // sP_PHIEUDATCOTHEGIAHANGTableAdapter
            // 
            this.sP_PHIEUDATCOTHEGIAHANGTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GetCTPhieuDatTableAdapter
            // 
            this.sP_GetCTPhieuDatTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maphieudatToolStripLabel,
            this.maphieudatToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 510);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(847, 25);
            this.fillToolStrip.TabIndex = 5;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // maphieudatToolStripLabel
            // 
            this.maphieudatToolStripLabel.Name = "maphieudatToolStripLabel";
            this.maphieudatToolStripLabel.Size = new System.Drawing.Size(74, 22);
            this.maphieudatToolStripLabel.Text = "maphieudat:";
            // 
            // maphieudatToolStripTextBox
            // 
            this.maphieudatToolStripTextBox.Name = "maphieudatToolStripTextBox";
            this.maphieudatToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(10, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày đi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(104, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(104, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 10;
            // 
            // FormGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGiaHan";
            this.Load += new System.EventHandler(this.FormGiaHan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_APPSOLUONGCOTHEDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_APPSOLUONGCOTHEDATGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDiDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDiDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDenDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDenDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPPHIEUDATCOTHEGIAHANGBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetCTPhieuDatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GetCTPhieuDatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUDATBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KHACHSANDataSet kHACHSANDataSet;
        private System.Windows.Forms.BindingSource sP_APPSOLUONGCOTHEDATBindingSource;
        private KHACHSANDataSetTableAdapters.SP_APPSOLUONGCOTHEDATTableAdapter sP_APPSOLUONGCOTHEDATTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_APPSOLUONGCOTHEDATGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private KHACHSANDataSetTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private System.Windows.Forms.BindingSource pHIEUDATBindingSource;
        private DevExpress.XtraEditors.DateEdit ngayDenDateEdit;
        private System.Windows.Forms.ComboBox mAPhieuDatComboBox;
        private DevExpress.XtraEditors.DateEdit ngayDiDateEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource cTPHIEUDATBindingSource;
        private KHACHSANDataSetTableAdapters.CTPHIEUDATTableAdapter cTPHIEUDATTableAdapter;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colHangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private System.Windows.Forms.BindingSource sPPHIEUDATCOTHEGIAHANGBindingSource;
        private KHACHSANDataSetTableAdapters.SP_PHIEUDATCOTHEGIAHANGTableAdapter sP_PHIEUDATCOTHEGIAHANGTableAdapter;
        private System.Windows.Forms.BindingSource sP_GetCTPhieuDatBindingSource;
        private KHACHSANDataSetTableAdapters.SP_GetCTPhieuDatTableAdapter sP_GetCTPhieuDatTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel maphieudatToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maphieudatToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl sP_GetCTPhieuDatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhieuDat;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHangPhong1;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}