namespace QuanLyKhachSan.KSForm
{
    partial class FormDPtoTP
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
            System.Windows.Forms.Label hangPhongLabel;
            System.Windows.Forms.Label ngayDenLabel1;
            System.Windows.Forms.Label ngayDiLabel1;
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.pHIEUDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.PHIEUDATTableAdapter();
            this.sP_SelectReadyRoom_HangPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_SelectReadyRoom_HangPhongTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_SelectReadyRoom_HangPhongTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.hANGPHONGTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter();
            this.hANGPHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soLuongPhongCoTheThueGridControl = new DevExpress.XtraGrid.GridControl();
            this.soLuongPhongCoTheThueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHangPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ngaydi = new DevExpress.XtraEditors.DateEdit();
            this.ngayden = new DevExpress.XtraEditors.DateEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sP_SelectReadyRoomGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_SelectReadyRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHangPhong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.soLuongPhongCoTheThueTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SoLuongPhongCoTheThueTableAdapter();
            this.sP_SelectReadyRoomTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_SelectReadyRoomTableAdapter();
            hangPhongLabel = new System.Windows.Forms.Label();
            ngayDenLabel1 = new System.Windows.Forms.Label();
            ngayDiLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SelectReadyRoom_HangPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongPhongCoTheThueGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongPhongCoTheThueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaydi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaydi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayden.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayden.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SelectReadyRoomGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SelectReadyRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hangPhongLabel
            // 
            hangPhongLabel.AutoSize = true;
            hangPhongLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hangPhongLabel.ForeColor = System.Drawing.Color.DarkRed;
            hangPhongLabel.Location = new System.Drawing.Point(99, 56);
            hangPhongLabel.Name = "hangPhongLabel";
            hangPhongLabel.Size = new System.Drawing.Size(114, 21);
            hangPhongLabel.TabIndex = 27;
            hangPhongLabel.Text = "Hạng phòng:";
            hangPhongLabel.Visible = false;
            // 
            // ngayDenLabel1
            // 
            ngayDenLabel1.AutoSize = true;
            ngayDenLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayDenLabel1.ForeColor = System.Drawing.Color.Maroon;
            ngayDenLabel1.Location = new System.Drawing.Point(7, 18);
            ngayDenLabel1.Name = "ngayDenLabel1";
            ngayDenLabel1.Size = new System.Drawing.Size(90, 21);
            ngayDenLabel1.TabIndex = 24;
            ngayDenLabel1.Text = "Ngày đến:";
            // 
            // ngayDiLabel1
            // 
            ngayDiLabel1.AutoSize = true;
            ngayDiLabel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayDiLabel1.ForeColor = System.Drawing.Color.Maroon;
            ngayDiLabel1.Location = new System.Drawing.Point(267, 16);
            ngayDiLabel1.Name = "ngayDiLabel1";
            ngayDiLabel1.Size = new System.Drawing.Size(77, 21);
            ngayDiLabel1.TabIndex = 25;
            ngayDiLabel1.Text = "Ngày đi:";
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUDATBindingSource
            // 
            this.pHIEUDATBindingSource.DataMember = "PHIEUDAT";
            this.pHIEUDATBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // pHIEUDATTableAdapter
            // 
            this.pHIEUDATTableAdapter.ClearBeforeFill = true;
            // 
            // sP_SelectReadyRoom_HangPhongBindingSource
            // 
            this.sP_SelectReadyRoom_HangPhongBindingSource.DataMember = "SP_SelectReadyRoom_HangPhong";
            this.sP_SelectReadyRoom_HangPhongBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // sP_SelectReadyRoom_HangPhongTableAdapter
            // 
            this.sP_SelectReadyRoom_HangPhongTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.HANGPHONGTableAdapter = this.hANGPHONGTableAdapter;
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
            // hANGPHONGTableAdapter
            // 
            this.hANGPHONGTableAdapter.ClearBeforeFill = true;
            // 
            // hANGPHONGBindingSource
            // 
            this.hANGPHONGBindingSource.DataMember = "HANGPHONG";
            this.hANGPHONGBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.soLuongPhongCoTheThueGridControl);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 204);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // soLuongPhongCoTheThueGridControl
            // 
            this.soLuongPhongCoTheThueGridControl.DataSource = this.soLuongPhongCoTheThueBindingSource;
            this.soLuongPhongCoTheThueGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soLuongPhongCoTheThueGridControl.Location = new System.Drawing.Point(3, 16);
            this.soLuongPhongCoTheThueGridControl.MainView = this.gridView2;
            this.soLuongPhongCoTheThueGridControl.Name = "soLuongPhongCoTheThueGridControl";
            this.soLuongPhongCoTheThueGridControl.Size = new System.Drawing.Size(318, 185);
            this.soLuongPhongCoTheThueGridControl.TabIndex = 23;
            this.soLuongPhongCoTheThueGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // soLuongPhongCoTheThueBindingSource
            // 
            this.soLuongPhongCoTheThueBindingSource.DataMember = "SoLuongPhongCoTheThue";
            this.soLuongPhongCoTheThueBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // gridView2
            // 
            this.gridView2.ActiveFilterString = "[soluong] > 0";
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHangPhong,
            this.colHangPhong,
            this.colsoluong});
            this.gridView2.GridControl = this.soLuongPhongCoTheThueGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(hangPhongLabel);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(ngayDenLabel1);
            this.groupBox3.Controls.Add(ngayDiLabel1);
            this.groupBox3.Controls.Add(this.ngaydi);
            this.groupBox3.Controls.Add(this.ngayden);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(321, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 185);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(152, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.CausesValidation = false;
            this.comboBox1.DataSource = this.hANGPHONGBindingSource;
            this.comboBox1.DisplayMember = "HangPhong";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(240, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "MAHangPhong";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ngaydi
            // 
            this.ngaydi.EditValue = null;
            this.ngaydi.Location = new System.Drawing.Point(350, 18);
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaydi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaydi.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngaydi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngaydi.Size = new System.Drawing.Size(166, 20);
            this.ngaydi.TabIndex = 23;
            this.ngaydi.DateTimeChanged += new System.EventHandler(this.ngaydi_EditValueChanged);
            // 
            // ngayden
            // 
            this.ngayden.EditValue = null;
            this.ngayden.Enabled = false;
            this.ngayden.Location = new System.Drawing.Point(103, 19);
            this.ngayden.Name = "ngayden";
            this.ngayden.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayden.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayden.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.ngayden.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ngayden.Properties.MinValue = new System.DateTime(2017, 8, 7, 11, 24, 30, 0);
            this.ngayden.Size = new System.Drawing.Size(158, 20);
            this.ngayden.TabIndex = 22;
            this.ngayden.DateTimeChanged += new System.EventHandler(this.ngayden_DateTimeChanged);
            this.ngayden.EditValueChanged += new System.EventHandler(this.ngayden_EditValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sP_SelectReadyRoomGridControl);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 257);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // sP_SelectReadyRoomGridControl
            // 
            this.sP_SelectReadyRoomGridControl.DataSource = this.sP_SelectReadyRoomBindingSource;
            this.sP_SelectReadyRoomGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sP_SelectReadyRoomGridControl.Location = new System.Drawing.Point(0, 16);
            this.sP_SelectReadyRoomGridControl.MainView = this.gridView1;
            this.sP_SelectReadyRoomGridControl.Name = "sP_SelectReadyRoomGridControl";
            this.sP_SelectReadyRoomGridControl.Size = new System.Drawing.Size(519, 238);
            this.sP_SelectReadyRoomGridControl.TabIndex = 16;
            this.sP_SelectReadyRoomGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_SelectReadyRoomBindingSource
            // 
            this.sP_SelectReadyRoomBindingSource.DataMember = "SP_SelectReadyRoom";
            this.sP_SelectReadyRoomBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHangPhong1,
            this.colMAPhong,
            this.colTang});
            this.gridView1.GridControl = this.sP_SelectReadyRoomGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colHangPhong1
            // 
            this.colHangPhong1.Caption = "Hạng Phòng";
            this.colHangPhong1.FieldName = "HangPhong";
            this.colHangPhong1.Name = "colHangPhong1";
            this.colHangPhong1.Visible = true;
            this.colHangPhong1.VisibleIndex = 2;
            // 
            // colMAPhong
            // 
            this.colMAPhong.Caption = "Phòng";
            this.colMAPhong.FieldName = "MAPhong";
            this.colMAPhong.Name = "colMAPhong";
            this.colMAPhong.Visible = true;
            this.colMAPhong.VisibleIndex = 1;
            // 
            // colTang
            // 
            this.colTang.Caption = "Tầng";
            this.colTang.FieldName = "Tang";
            this.colTang.Name = "colTang";
            this.colTang.Visible = true;
            this.colTang.VisibleIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(519, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 238);
            this.dataGridView1.TabIndex = 16;
            // 
            // soLuongPhongCoTheThueTableAdapter
            // 
            this.soLuongPhongCoTheThueTableAdapter.ClearBeforeFill = true;
            // 
            // sP_SelectReadyRoomTableAdapter
            // 
            this.sP_SelectReadyRoomTableAdapter.ClearBeforeFill = true;
            // 
            // FormDPtoTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDPtoTP";
            this.Text = "Xuất phiếu thuê";
            this.Load += new System.EventHandler(this.FormChildTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SelectReadyRoom_HangPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hANGPHONGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soLuongPhongCoTheThueGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongPhongCoTheThueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaydi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaydi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayden.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayden.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_SelectReadyRoomGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SelectReadyRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KHACHSANDataSet kHACHSANDataSet;
        private System.Windows.Forms.BindingSource pHIEUDATBindingSource;
        private KHACHSANDataSetTableAdapters.PHIEUDATTableAdapter pHIEUDATTableAdapter;
        private System.Windows.Forms.BindingSource sP_SelectReadyRoom_HangPhongBindingSource;
        private KHACHSANDataSetTableAdapters.SP_SelectReadyRoom_HangPhongTableAdapter sP_SelectReadyRoom_HangPhongTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KHACHSANDataSetTableAdapters.HANGPHONGTableAdapter hANGPHONGTableAdapter;
        private System.Windows.Forms.BindingSource hANGPHONGBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource soLuongPhongCoTheThueBindingSource;
        private KHACHSANDataSetTableAdapters.SoLuongPhongCoTheThueTableAdapter soLuongPhongCoTheThueTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.DateEdit ngaydi;
        private DevExpress.XtraEditors.DateEdit ngayden;
        private DevExpress.XtraGrid.GridControl soLuongPhongCoTheThueGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colHangPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private System.Windows.Forms.BindingSource sP_SelectReadyRoomBindingSource;
        private KHACHSANDataSetTableAdapters.SP_SelectReadyRoomTableAdapter sP_SelectReadyRoomTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_SelectReadyRoomGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colHangPhong1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTang;
    }
}