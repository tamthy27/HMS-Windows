namespace QuanLyKhachSan.KSForm
{
    partial class FormNewHoaDon
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiamGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTongCong = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTienDichVu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienPhong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.SP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter();
            this.tableAdapterManager = new QuanLyKhachSan.KHACHSANDataSetTableAdapters.TableAdapterManager();
            this.colMACTPhieuThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPhieuThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(469, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xuất hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtGiamGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtTongCong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTienDichVu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTienPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 139);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.AutoSize = true;
            this.txtGiamGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.ForeColor = System.Drawing.Color.Maroon;
            this.txtGiamGia.Location = new System.Drawing.Point(167, 70);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(20, 21);
            this.txtGiamGia.TabIndex = 25;
            this.txtGiamGia.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giảm giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 10);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // txtTongCong
            // 
            this.txtTongCong.AutoSize = true;
            this.txtTongCong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongCong.ForeColor = System.Drawing.Color.Maroon;
            this.txtTongCong.Location = new System.Drawing.Point(167, 102);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.Size = new System.Drawing.Size(20, 21);
            this.txtTongCong.TabIndex = 22;
            this.txtTongCong.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tổng cộng:";
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.AutoSize = true;
            this.txtTienDichVu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDichVu.ForeColor = System.Drawing.Color.Maroon;
            this.txtTienDichVu.Location = new System.Drawing.Point(167, 44);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.Size = new System.Drawing.Size(20, 21);
            this.txtTienDichVu.TabIndex = 20;
            this.txtTienDichVu.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tiền dịch vụ:";
            // 
            // txtTienPhong
            // 
            this.txtTienPhong.AutoSize = true;
            this.txtTienPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienPhong.ForeColor = System.Drawing.Color.Maroon;
            this.txtTienPhong.Location = new System.Drawing.Point(167, 17);
            this.txtTienPhong.Name = "txtTienPhong";
            this.txtTienPhong.Size = new System.Drawing.Size(20, 21);
            this.txtTienPhong.TabIndex = 18;
            this.txtTienPhong.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tiền phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 225);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl
            // 
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.DataSource = this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource;
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.Location = new System.Drawing.Point(0, 16);
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.MainView = this.gridView1;
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.Name = "sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl";
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.Size = new System.Drawing.Size(541, 206);
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.TabIndex = 1;
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource
            // 
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource.DataMember = "SP_GETCHITIETPHIEUTHUECHUATHANHTOAN";
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource.DataSource = this.kHACHSANDataSet;
            // 
            // kHACHSANDataSet
            // 
            this.kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            this.kHACHSANDataSet.EnforceConstraints = false;
            this.kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMACTPhieuThue,
            this.colMAPhieuThue,
            this.colMAPhong,
            this.colGiamGia,
            this.colNgayDen,
            this.colNgayDi,
            this.colThanhToan,
            this.colDonGia});
            this.gridView1.GridControl = this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(541, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // sP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter
            // 
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTHOADONTableAdapter = null;
            this.tableAdapterManager.CTKHACHTHUETableAdapter = null;
            this.tableAdapterManager.CTPHIEUDATTableAdapter = null;
            this.tableAdapterManager.CTPHIEUTHUETableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.GIADICHVUTableAdapter = null;
            this.tableAdapterManager.GIAPHONGTableAdapter = null;
            this.tableAdapterManager.HANGPHONGTableAdapter = null;
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
            // colMACTPhieuThue
            // 
            this.colMACTPhieuThue.FieldName = "MACTPhieuThue";
            this.colMACTPhieuThue.Name = "colMACTPhieuThue";
            this.colMACTPhieuThue.Visible = true;
            this.colMACTPhieuThue.VisibleIndex = 1;
            // 
            // colMAPhieuThue
            // 
            this.colMAPhieuThue.FieldName = "MAPhieuThue";
            this.colMAPhieuThue.Name = "colMAPhieuThue";
            this.colMAPhieuThue.Visible = true;
            this.colMAPhieuThue.VisibleIndex = 2;
            // 
            // colMAPhong
            // 
            this.colMAPhong.FieldName = "MAPhong";
            this.colMAPhong.Name = "colMAPhong";
            this.colMAPhong.Visible = true;
            this.colMAPhong.VisibleIndex = 3;
            // 
            // colGiamGia
            // 
            this.colGiamGia.FieldName = "GiamGia";
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Visible = true;
            this.colGiamGia.VisibleIndex = 4;
            // 
            // colNgayDen
            // 
            this.colNgayDen.FieldName = "NgayDen";
            this.colNgayDen.Name = "colNgayDen";
            this.colNgayDen.Visible = true;
            this.colNgayDen.VisibleIndex = 5;
            // 
            // colNgayDi
            // 
            this.colNgayDi.FieldName = "NgayDi";
            this.colNgayDi.Name = "colNgayDi";
            this.colNgayDi.Visible = true;
            this.colNgayDi.VisibleIndex = 6;
            // 
            // colThanhToan
            // 
            this.colThanhToan.FieldName = "ThanhToan";
            this.colThanhToan.Name = "colThanhToan";
            this.colThanhToan.Visible = true;
            this.colThanhToan.VisibleIndex = 7;
            // 
            // colDonGia
            // 
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 8;
            // 
            // FormNewHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewHoaDon";
            this.Text = "Thêm mới hóa đơn";
            this.Load += new System.EventHandler(this.FormNewHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KHACHSANDataSet kHACHSANDataSet;
        private System.Windows.Forms.BindingSource sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource;
        private KHACHSANDataSetTableAdapters.SP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter sP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter;
        private KHACHSANDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_GETCHITIETPHIEUTHUECHUATHANHTOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label txtGiamGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtTongCong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtTienDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTienPhong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACTPhieuThue;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhieuThue;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDi;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
    }
}