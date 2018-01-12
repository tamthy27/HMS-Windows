using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DatabaseUtil;


namespace QuanLyKhachSan.KSForm
{
    public partial class FormDatPhong : Form
    {
        public static DataTable dtREDOPHIEUDAT = new DataTable();
        public static DataTable dtUNDOPHIEUDAT = new DataTable();
        int vitri1 = 0;
        String Action1 = "";
        public static DataTable dtREDOCTPHIEUDAT = new DataTable();
        public static DataTable dtUNDOCTPHIEUDAT = new DataTable();
        int vitri = 0;
        String Action = "";
        public static DataTable readyroom = new DataTable();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static Random random = new Random();


        public FormDatPhong()
        {
            InitializeComponent();
            if (readyroom.Columns.Count < 1)
            {
                readyroom.Columns.Add("mahangphong", typeof(string));
                readyroom.Columns.Add("soluong", typeof(double));
                readyroom.PrimaryKey = new DataColumn[]
               {
               readyroom.Columns[0]
               };
            }
            if (dtUNDOPHIEUDAT.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOPHIEUDAT.Columns.Add("MAPHIEUDAT", typeof(string));
                dtUNDOPHIEUDAT.Columns.Add("CNMDKH", typeof(string));
                dtUNDOPHIEUDAT.Columns.Add("MaNV", typeof(string));
                dtUNDOPHIEUDAT.Columns.Add("Ngayden", typeof(DateTime));
                dtUNDOPHIEUDAT.Columns.Add("ngaydi", typeof(DateTime));
                dtUNDOPHIEUDAT.Columns.Add("ngaydat", typeof(DateTime));
                dtUNDOPHIEUDAT.Columns.Add("trangthaiphieu", typeof(string));
                dtUNDOPHIEUDAT.Columns.Add("tiencoc", typeof(double));
                dtUNDOCTPHIEUDAT.Columns.Add("mahuy", typeof(string));
                dtUNDOPHIEUDAT.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOPHIEUDAT.Columns.Add("MAPHIEUDAT", typeof(string));
                dtREDOPHIEUDAT.Columns.Add("CNMDKH", typeof(string));
                dtREDOPHIEUDAT.Columns.Add("MaNV", typeof(string));
                dtREDOPHIEUDAT.Columns.Add("Ngayden", typeof(DateTime));
                dtREDOPHIEUDAT.Columns.Add("ngaydi", typeof(DateTime));
                dtREDOPHIEUDAT.Columns.Add("ngaydat", typeof(DateTime));
                dtREDOPHIEUDAT.Columns.Add("trangthaiphieu", typeof(string));
                dtREDOPHIEUDAT.Columns.Add("tiencoc", typeof(double));
                dtREDOPHIEUDAT.Columns.Add("mahuy", typeof(string));
                dtREDOPHIEUDAT.Columns.Add("ACTION", typeof(string));
            }
            if (dtUNDOCTPHIEUDAT.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOCTPHIEUDAT.Columns.Add("mAPHIEUDAT", typeof(string));
                dtUNDOCTPHIEUDAT.Columns.Add("MACTPHIEUDAT", typeof(string));
                dtUNDOCTPHIEUDAT.Columns.Add("SL", typeof(double));
                dtUNDOCTPHIEUDAT.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOCTPHIEUDAT.Columns.Add("mAPHIEUDAT", typeof(string));
                dtREDOCTPHIEUDAT.Columns.Add("MACTPHIEUDAT", typeof(string));
                dtREDOCTPHIEUDAT.Columns.Add("SL", typeof(double));
                dtREDOCTPHIEUDAT.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;
            }

            btnGhi.Enabled = btnHuy.Enabled = false;
            soLuongSpinEdit.Properties.MinValue = 0;

        }

        private void pHIEUDATBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            this.sP_APPSOLUONGCOTHEDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            this.tINHTRANGPHIEUTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.TINHTRANGPHIEU' table. You can move, or remove it, as needed.
            this.tINHTRANGPHIEUTableAdapter.Fill(this.kHACHSANDataSet.TINHTRANGPHIEU);

            this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTPHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);
            this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
            this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);
            this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
            if (pHIEUDATBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = btnChiTiet.Enabled = false;
            }
            ngayDenDateEdit.Properties.MinValue = DateTime.Today.AddDays(1);
                        //    fillToolStripButton_Click_1(sender, e);

        }

        private void pHIEUDATBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }
        private void updatetable()
        {
            this.cTPHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTPHIEUDATTableAdapter.Update(this.kHACHSANDataSet);
        }
        private void updatetablePhieuDat()
        {
            try
            {
                this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.pHIEUDATTableAdapter.Update(this.kHACHSANDataSet);
            }
            catch
            {
                MessageBox.Show("Error xóa phiếu đặt phòng", " tồn tại chi tiết đặt phòng thuộc phiếu", MessageBoxButtons.OK);

            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
          
                panel3.Visible = btnQuayLai.Visible = false;
                btnChiTiet.Visible = true;
                panel1.Visible = true;
                if (btnChiTiet.Visible == true)
                {
                    try
                    {
                    mAPhieuDatTextEdit2.Text = mAPhieuDatTextEdit1.Text; 
                        dtREDOPHIEUDAT.Clear();
                        dtUNDOPHIEUDAT.Clear();
                        btnRedo.Enabled = btnUndo.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    try
                    {
                    mAPhieuDatTextEdit2.Text = mAPhieuDatTextEdit1.Text;
                    dtREDOPHIEUDAT.Clear();
                        dtUNDOPHIEUDAT.Clear();
                        btnRedo.Enabled = btnUndo.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            


        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (pHIEUDATBindingSource.Count>0)
            {
                panel3.Visible = btnQuayLai.Visible = true;
                btnChiTiet.Visible = false;
                panel1.Visible = false;
                DataRow dt = kHACHSANDataSet.KHACHHANG.Rows.Find(cNMDKHComboBox.SelectedValue);
                if (dt != null)
                {
                    cMND_PASSPORTTextEdit.Text = dt[0].ToString();
                    mAPhieuDatTextEdit2.Text = mAPhieuDatTextEdit.Text;
                }
                if (mAPhieuDatTextEdit1.Text.Trim() == "") mAPhieuDatTextEdit1.Text = mAPhieuDatTextEdit2.Text;
                String sql = "Exec [SP_GETSOLUONGPHONG] '" + ngayDenDateEdit.DateTime + "', '" + ngayDiDateEdit.DateTime + "','" + mAPhieuDatTextEdit1.Text + "'";

                if (!(cTPHIEUDATBindingSource.Count > 0))
                {
                    sql = "Exec [SP_GETSOLUONGPHONG] '" + ngayDenDateEdit.DateTime + "', '" + ngayDiDateEdit.DateTime + "',NULL";
                    this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDenDateEdit.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDiDateEdit.DateTime, typeof(System.DateTime))))), "NULL");

                }
                else
                {
                    this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDenDateEdit.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDiDateEdit.DateTime, typeof(System.DateTime))))), mAPhieuDatTextEdit1.Text);

                }
                readyroom = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                readyroom.PrimaryKey = new DataColumn[]
                {
                         readyroom.Columns[0]
                 };
            }
            else
            {
                btnChiTiet.Enabled = false;
                MessageBox.Show("Không tồn tại phiếu đặt nào!");
            }

        }
    

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(SubKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                SubKhachHang f = new SubKhachHang(this);
                f.Show();
            }
        }

        public void reloadKH(String a)
        {
            kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
            cMND_PASSPORTTextEdit.Text = a;
        }
             
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChiTiet.Visible == true)
            {
                vitri1 = pHIEUDATBindingSource.Position;
                pHIEUDATBindingSource.AddNew();
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                pHIEUDATGridControl.Enabled = false;
                sP_GetCTPhieuDatGridControl.Enabled = false;
                mAPhieuDatTextEdit2.Enabled = true;
                Action1 = "DELETE";
                mANVTextEdit.Text = mANVTextEdit1.Text = DataUtil.username;
                ngayDatDateEdit.DateTime = DateTime.Now;
                panel2.Enabled = true;
                cNMDKHComboBox.SelectedItem = null;
                trangThaiPhieuDatComboBox.SelectedIndex = 1;
                tienCocSpinEdit.Value = 1000;
                btnChiTiet.Enabled = false;
                

            }
            else
            {
                if (pHIEUDATBindingSource.Count>0)
                {
                    vitri = cTPHIEUDATBindingSource.Position;
                    cTPHIEUDATBindingSource.AddNew();
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                    btnGhi.Enabled = btnHuy.Enabled = true;
                    cTPHIEUDATGridControl.Enabled = false;
                    mAHangPhongComboBox.Enabled = true;
                    mAHangPhongComboBox.SelectedItem = null;
                    Action = "DELETE";
                    groupBox3.Enabled = true;
                    btnQuayLai.Enabled = false;
                }

            }
        }
        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int dr = DataUtil.ExecSqlDataTable("Select * from Phieuthue where maphieudat ='" + mAPhieuDatTextEdit2.Text.Trim() + "'", DataUtil.connstr).Rows.Count;
            if (dr == 0)
            {
                if (btnChiTiet.Visible == true)
                {
                    if (pHIEUDATBindingSource.Count > 0)
                    {
                        Action1 = "UPDATE";
                        //dtUNDOPHIEUDAT.RejectChanges();
                        //DataRowView drv = (DataRowView)pHIEUDATBindingSource.Current;
                        //dtUNDOPHIEUDAT.NewRow();
                        //dtUNDOPHIEUDAT.Rows.Add(drv.Row[0].ToString(), cNMDKHComboBox.SelectedValue, mANVTextEdit.Text, ngayDenDateEdit.DateTime, ngayDiDateEdit.DateTime, ngayDatDateEdit.DateTime, '1', tienCocSpinEdit.Value, maHuyTextEdit.Text,Action1);
                        //dtUNDOPHIEUDAT.AcceptChanges();
                        vitri1 = pHIEUDATBindingSource.Position;
                        panel2.Enabled = true;
                        btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnChiTiet.Enabled = false;
                        btnGhi.Enabled = btnHuy.Enabled = true;
                        mAPhieuDatTextEdit2.Enabled = false;
                        mANVTextEdit.Text = mANVTextEdit1.Text = DataUtil.username;
                        pHIEUDATGridControl.Enabled = false;
                        sP_GetCTPhieuDatGridControl.Enabled = false;
                        dtUNDOPHIEUDAT.RejectChanges();
                        //trangThaiPhieuDatComboBox.Enabled = true;
                        if(cTPHIEUDATBindingSource.Count>0)
                        {
                            ngayDenDateEdit.Enabled = false;
                            ngayDiDateEdit.Enabled = false;
                        }

                        String sql = "Exec [SP_GETSOLUONGPHONG] '" + ngayDenDateEdit.DateTime + "', '" + ngayDiDateEdit.DateTime + "','" + mAPhieuDatTextEdit2.Text + "'";
                        readyroom = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                        readyroom.PrimaryKey = new DataColumn[]
                        {
                         readyroom.Columns[0]
                         };

                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại phiếu đặt nào!");
                    }
                }
                else
                {
                    if (cTPHIEUDATBindingSource.Count > 0)
                    {
                        Action = "UPDATE";
                        //dtUNDOCTPHIEUDAT.RejectChanges();
                        //DataRowView drv = (DataRowView)cTPHIEUDATBindingSource.Current;
                        //dtUNDOCTPHIEUDAT.NewRow();
                        //dtUNDOCTPHIEUDAT.Rows.Add(drv.Row[0].ToString(), drv.Row[1], drv.Row[2], Action);
                        //dtUNDOCTPHIEUDAT.AcceptChanges();
                        vitri = cTPHIEUDATBindingSource.Position;
                        groupBox3.Enabled = true;
                        btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnQuayLai.Enabled = false;
                        btnGhi.Enabled = btnHuy.Enabled = true;
                        mAHangPhongComboBox.Enabled = true;
                        soLuongSpinEdit.Enabled = true;
                        cTPHIEUDATGridControl.Enabled = false;
                        dtUNDOCTPHIEUDAT.RejectChanges();
                        DataRow dr1 = readyroom.Rows.Find(mAHangPhongComboBox.SelectedValue);
                        try
                        {
                            int t = int.Parse(dr1[1].ToString());
                            if (t > 0)
                            {
                                soLuongSpinEdit.Enabled = true;
                                soLuongSpinEdit.Properties.MaxValue = t;
                            }
                            else
                            {
                                soLuongSpinEdit.Enabled = false;
                            }
                        }
                        catch
                        {
                            soLuongSpinEdit.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại danh mục nào!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Phiếu đặt đã được xuất phiếu thuê.Đề nghị không thao tác trên phiếu");
            }

        }
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChiTiet.Visible == true)
            {
                if (mAPhieuDatTextEdit2.Enabled == true)
                {

                    if (mAPhieuDatTextEdit2.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã phiếu đặt không được thiếu!", "", MessageBoxButtons.OK);
                        mAPhieuDatTextEdit2.Focus();
                        return;
                    }
                    else
                    {
                        mAPhieuDatTextEdit2.Text = mAPhieuDatTextEdit2.Text.ToUpper();
                    }
                    if (ngayDenDateEdit.Text.Trim() == "")
                    {
                        MessageBox.Show("Ngày đến không được trống!", "", MessageBoxButtons.OK);
                        ngayDenDateEdit.Focus();
                        return;
                    }
                    if (ngayDiDateEdit.Text.Trim() == "")
                    {
                        MessageBox.Show("Ngày đến không được trống!", "", MessageBoxButtons.OK);
                        ngayDiDateEdit.Focus();
                        return;
                    }
                    if (tienCocSpinEdit.Value < 0)
                    {
                        MessageBox.Show("Tiền cọc không hợp lệ", "", MessageBoxButtons.OK);
                        tienCocSpinEdit.Focus();
                        return;
                    }
                    if (cNMDKHComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Chứng minh nhân dân không được trống!", "", MessageBoxButtons.OK);
                        cNMDKHComboBox.Focus();
                        return;
                    }
                    //if(ngayDenDateEdit.DateTime<=ngayDiDateEdit.DateTime)
                    //{
                    //    MessageBox.Show("Ngày đến hoặc ngày đi không hợp lệ!", "", MessageBoxButtons.OK);
                    //    ngayDenDateEdit.Focus();
                    //    return;
                    //}
                    try
                    {
                        dtUNDOPHIEUDAT.RejectChanges();
                        String mahuy = RandomString();
                        String trangthaiphieu = trangThaiPhieuDatComboBox.SelectedValue.ToString();
                        DataRowView drv = (DataRowView)pHIEUDATBindingSource.Current;
                        drv.Row[1] = cNMDKHComboBox.SelectedValue.ToString();
                        drv.Row[7] = trangthaiphieu;
                        drv.Row[8]= mahuy;
                        //dtUNDOPHIEUDAT.NewRow();
                        //dtUNDOPHIEUDAT.Rows.Add(drv.Row[0].ToString(), cNMDKHComboBox.SelectedValue, mANVTextEdit.Text, ngayDenDateEdit.DateTime, ngayDiDateEdit.DateTime, ngayDatDateEdit.DateTime, '1', tienCocSpinEdit.Value,maHuyTextEdit.Text,Action1);
                        //dtUNDOPHIEUDAT.AcceptChanges();
                        pHIEUDATBindingSource.EndEdit();
                        pHIEUDATBindingSource.ResetCurrentItem();
                        this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                        this.pHIEUDATTableAdapter.Update(this.kHACHSANDataSet.PHIEUDAT);
                     
                        String sql = "Exec [SP_GETSOLUONGPHONG] '" + ngayDenDateEdit.DateTime + "', '" + ngayDiDateEdit.DateTime + "',null";
                        readyroom = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                        readyroom.PrimaryKey = new DataColumn[]
                        {
                            readyroom.Columns[0]
                         };
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi phiếu đặt.\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
                //update
                else
                {
                    if (ngayDenDateEdit.Text.Trim() == "")
                    {
                        MessageBox.Show("Ngày đến không được trống!", "", MessageBoxButtons.OK);
                        ngayDenDateEdit.Focus();
                        return;
                    }
                    if (ngayDiDateEdit.Text.Trim() == "")
                    {
                        MessageBox.Show("Ngày đến không được trống!", "", MessageBoxButtons.OK);
                        ngayDiDateEdit.Focus();
                        return;
                    }
                    if (tienCocSpinEdit.Value < 0)
                    {
                        MessageBox.Show("Tiền cọc không hợp lệ", "", MessageBoxButtons.OK);
                        tienCocSpinEdit.Focus();
                        return;
                    }
                    if (cNMDKHComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Chứng minh nhân dân không được trống!", "", MessageBoxButtons.OK);
                        cNMDKHComboBox.Focus();
                        return;
                    }
                    if (mAPhieuDatTextEdit2.Text.Trim() == "")
                    {
                        MessageBox.Show("Mã phiếu đặt không được thiếu!", "", MessageBoxButtons.OK);
                        mAPhieuDatTextEdit2.Focus();
                        return;
                    }
                    //if (ngayDenDateEdit.DateTime < ngayDiDateEdit.DateTime)
                    //{
                    //    MessageBox.Show("Ngày đến hoặc ngày đi không hợp lệ!", "", MessageBoxButtons.OK);
                    //    ngayDenDateEdit.Focus();
                    //    return;
                    //}
                    if(trangThaiPhieuDatComboBox.SelectedValue.ToString().Equals("2"))
                    {
                        if(!checkhople())
                        { 
                            MessageBox.Show("Xác nhận thất bại! Hãy kiểm tra lại số lượng phòng");
                            btnHuy_ItemClick(sender,e);
                            return;
                        }
                    }
                    try
                    {
                        String trangthaiphieu = trangThaiPhieuDatComboBox.SelectedValue.ToString();
                        String nv = DataUtil.username;
                        DataRowView drv = (DataRowView)pHIEUDATBindingSource.Current;                       
                        drv.Row[1] = cNMDKHComboBox.SelectedValue;
                        drv.Row[6] = tienCocSpinEdit.Value;
                       // drv[2] = nv;
                        drv.Row[7] = trangthaiphieu;
                        pHIEUDATBindingSource.EndEdit();
                        pHIEUDATBindingSource.ResetCurrentItem();
                        this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                        this.pHIEUDATTableAdapter.Update(this.kHACHSANDataSet.PHIEUDAT);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                        dtUNDOPHIEUDAT.Rows.RemoveAt(dtUNDOPHIEUDAT.Rows.Count - 1);
                        return;
                    }
                }
                ngayDenDateEdit.Enabled = true;
                ngayDiDateEdit.Enabled = true;
                btnChiTiet.Enabled = true;
                pHIEUDATGridControl.Enabled = true;
                sP_GetCTPhieuDatGridControl.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnChiTiet.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                btnUndo.Enabled = true;
                panel2.Enabled = false;
                mAPhieuDatTextEdit.Text = mAPhieuDatTextEdit2.Text;
              
            }
            else
            {
                if (mAHangPhongComboBox.Enabled == true)
                {
                    if (mAHangPhongComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Mã Hạng phòng không được thiếu!", "", MessageBoxButtons.OK);
                        mAHangPhongComboBox.Focus();
                        return;
                    }
                    DataRow dr = readyroom.Rows.Find(mAHangPhongComboBox.SelectedValue);
                    try
                    {
                        int t = int.Parse(dr[1].ToString());
                        if (soLuongSpinEdit.Value <= 0 || soLuongSpinEdit.Value > t)
                        {
                            MessageBox.Show("Số lượng phòng không hợp lệ", "", MessageBoxButtons.OK);
                            soLuongSpinEdit.Focus();
                            return;
                        }
                    }
                    catch
                    {
                        soLuongSpinEdit.Enabled = false;
                    }
                    try
                    {


                        dtUNDOCTPHIEUDAT.RejectChanges();
                        DataRowView drv = (DataRowView)cTPHIEUDATBindingSource.Current;
                        //dtUNDOCTPHIEUDAT.NewRow();
                        //dtUNDOCTPHIEUDAT.Rows.Add(drv.Row[0].ToString(), drv.Row[1], drv.Row[2], Action);
                        //dtUNDOCTPHIEUDAT.AcceptChanges();
                        cTPHIEUDATBindingSource.EndEdit();
                        cTPHIEUDATBindingSource.ResetCurrentItem();
                        this.cTPHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                        this.cTPHIEUDATTableAdapter.Update(this.kHACHSANDataSet.CTPHIEUDAT);
                     

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hạng phòng đã được đặt. Hãy chỉnh sửa chi tiết phiếu", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                //update
                else
                {
                    if (soLuongSpinEdit.Value <= 0)
                    {
                        MessageBox.Show("Số lượng phòng không hợp lệ", "", MessageBoxButtons.OK);
                        soLuongSpinEdit.Focus();
                        return;
                    }
                    if (mAHangPhongComboBox.SelectedValue == null)
                    {
                        MessageBox.Show("Mã Hạng phòng không được thiếu!", "", MessageBoxButtons.OK);
                        mAHangPhongComboBox.Focus();
                        return;
                    }
                    try
                    {

                        cTPHIEUDATBindingSource.EndEdit();
                        cTPHIEUDATBindingSource.ResetCurrentItem();
                        this.cTPHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                        this.cTPHIEUDATTableAdapter.Update(this.kHACHSANDataSet.CTPHIEUDAT);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi Phiếu đặt.\n" + ex.Message, "", MessageBoxButtons.OK);
                        dtUNDOCTPHIEUDAT.Rows.RemoveAt(dtUNDOCTPHIEUDAT.Rows.Count - 1);
                        return;
                    }
                }
                btnQuayLai.Enabled = true;
                cTPHIEUDATGridControl.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnQuayLai.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                btnUndo.Enabled = true;
                groupBox3.Enabled = false;
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChiTiet.Visible == true)
            {
                //if (mAPhieuDatTextEdit2.Enabled == false)
                //{
                //    dtUNDOPHIEUDAT.RejectChanges();
                //    dtUNDOPHIEUDAT.Rows.RemoveAt(dtUNDOPHIEUDAT.Rows.Count - 1);
                //    dtUNDOPHIEUDAT.AcceptChanges();
                //}
                pHIEUDATBindingSource.CancelEdit();
                if (btnThem.Enabled == false) pHIEUDATBindingSource.Position = vitri1;
                pHIEUDATGridControl.Enabled = true;
                sP_GetCTPhieuDatGridControl.Enabled = true;
                ngayDenDateEdit.Enabled = true;
                ngayDiDateEdit.Enabled = true;
                panel2.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                btnChiTiet.Enabled = true;

            }
            else
            {
                //if (mAHangPhongComboBox.Enabled == false)
                //{
                //    dtUNDOCTPHIEUDAT.RejectChanges();
                //    dtUNDOCTPHIEUDAT.Rows.RemoveAt(dtUNDOCTPHIEUDAT.Rows.Count - 1);
                //    dtUNDOCTPHIEUDAT.AcceptChanges();
                //}
                cTPHIEUDATBindingSource.CancelEdit();
                if (btnThem.Enabled == false) cTPHIEUDATBindingSource.Position = vitri;
                cTPHIEUDATGridControl.Enabled = true;
                groupBox3.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
                btnQuayLai.Enabled = true;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAPhieuDatTextEdit1.Text.Trim() == "") mAPhieuDatTextEdit1.Text = mAPhieuDatTextEdit2.Text;
            String sql = "Select * from Phieuthue where maphieudat = '" + mAPhieuDatTextEdit1.Text + "'";
            int dr = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr).Rows.Count;
            if (dr == 0)
            {
                if (btnChiTiet.Visible == true)
                {
                    if (pHIEUDATBindingSource.Count > 0)
                    {
                        if (cTPHIEUDATBindingSource.Count == 0)
                        {
                            DataRowView drv = (DataRowView)pHIEUDATBindingSource.Current;
                            DialogResult dlResult = MessageBox.Show("Bạn muốn xóa phiếu đặt có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dlResult == DialogResult.OK)
                            {
                                Action1 = "INSERT";
                                //dtUNDOPHIEUDAT.NewRow();
                                //dtUNDOPHIEUDAT.Rows.Add(drv.Row[0].ToString(), cNMDKHComboBox.SelectedValue, mANVTextEdit.Text, ngayDenDateEdit.DateTime, ngayDiDateEdit.DateTime, ngayDatDateEdit.DateTime, '1', tienCocSpinEdit.Value, Action1);
                                //dtUNDOPHIEUDAT.AcceptChanges();
                                pHIEUDATBindingSource.RemoveCurrent();
                                updatetablePhieuDat();
                                btnUndo.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được xóa phiếu khi còn chi tiết trong phiếu", "", MessageBoxButtons.OK);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại phiếu đặt nào!");
                    }
                }
                else
                {
                    //if (gridView2.DataRowCount > 0)
                    //{
                    if (cTPHIEUDATBindingSource.Count > 0)
                    {
                        DataRowView drv = (DataRowView)cTPHIEUDATBindingSource.Current;
                        DialogResult dlResult = MessageBox.Show("Bạn muốn xóa chi tiết có mã phiếu :" + drv.Row[0].ToString() + ", mã hạng phòng" + drv.Row[1].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        Console.WriteLine("dialogResult" + dlResult);
                        if (dlResult == DialogResult.OK)
                        {
                            Action = "INSERT";
                            cTPHIEUDATBindingSource.RemoveCurrent();
                            updatetable();
                            btnUndo.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại danh mục nào!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Phiếu đặt đã được xuất phiếu thuê.Đề nghị không thao tác trên phiếu");
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChiTiet.Visible == true)
            {
                if (dtUNDOPHIEUDAT.Rows.Count - 1 >= 0)
                {
                    DataRow dr = dtUNDOPHIEUDAT.Rows[dtUNDOPHIEUDAT.Rows.Count - 1];
                    String temp = dr[8].ToString();
                    if (temp.Equals("DELETE"))
                    {
                        try
                        {
                            string sql = "DELETE FROM PHIEUDAT WHERE [MAPhieuDat] ='" + dr[0].ToString() + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.PHIEUDAT.RejectChanges();
                                DataRow dt = kHACHSANDataSet.PHIEUDAT.Rows.Find(dr[0].ToString());
                                kHACHSANDataSet.PHIEUDAT.Rows.Remove(dt);
                                kHACHSANDataSet.PHIEUDAT.AcceptChanges();
                                dtREDOPHIEUDAT.RejectChanges();
                                dtREDOPHIEUDAT.NewRow();
                                dtREDOPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], "INSERT");
                                dtREDOPHIEUDAT.AcceptChanges();
                                dtUNDOPHIEUDAT.RejectChanges();
                                dtUNDOPHIEUDAT.Rows.RemoveAt(dtUNDOPHIEUDAT.Rows.Count - 1);
                                dtUNDOPHIEUDAT.AcceptChanges();
                                updatetablePhieuDat();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }

                    }
                    else if (temp.Equals("UPDATE"))
                    {
                        try
                        {
                            string sql = "  UPDATE[dbo].[PHIEUDAT]SET[MAPhieuDat] = '" + dr[0] + "',[CNMDKH] = '" + dr[1] + "',[MANV] = '" + dr[2] + "',[NgayDen] = '" + dr[3] + "',[NgayDi] = '" + dr[4] + "',[NgayDat] = '" + dr[5] + "',[TrangThaiPhieudat] = '" + dr[6] + "',[TienCoc] = '" + dr[7] + "' WHERE '" + dr[0] + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.PHIEUDAT.RejectChanges();
                                DataRow dt = kHACHSANDataSet.PHIEUDAT.Rows.Find(dr[0].ToString());
                                dtREDOPHIEUDAT.RejectChanges();
                                dtREDOPHIEUDAT.NewRow();
                                dtREDOPHIEUDAT.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], dt[4], dt[5], dt[6], dt[7], "UPDATE");
                                dt[1] = dr[1];
                                dt[2] = dr[2];
                                dt[3] = dr[3];
                                dt[4] = dr[4];
                                dt[5] = dr[5];
                                dt[6] = dr[6];
                                dt[7] = dr[7];
                                kHACHSANDataSet.PHIEUDAT.AcceptChanges(); dtREDOPHIEUDAT.AcceptChanges();
                                dtUNDOPHIEUDAT.RejectChanges();
                                dtUNDOPHIEUDAT.Rows.RemoveAt(dtREDOPHIEUDAT.Rows.Count - 1);
                                dtUNDOPHIEUDAT.AcceptChanges();
                                updatetablePhieuDat();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    else if (temp.Equals("INSERT"))
                    {
                        try
                        {
                            string sql = "INSERT INTO [PHIEUDAT]([MAPhieuDat],[CNMDKH],[MANV],[NgayDen],[NgayDi],[NgayDat],[TrangThaiPhieudat],[TienCoc])VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "'," + 1 + "," + dr[7] + ")";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.PHIEUDAT.RejectChanges();
                                kHACHSANDataSet.PHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
                                kHACHSANDataSet.PHIEUDAT.AcceptChanges();
                                dtREDOPHIEUDAT.RejectChanges();
                                dtREDOPHIEUDAT.NewRow();
                                dtREDOPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], "DELETE");
                                dtREDOPHIEUDAT.AcceptChanges();
                                dtUNDOPHIEUDAT.RejectChanges();
                                dtUNDOPHIEUDAT.Rows.RemoveAt(dtREDOPHIEUDAT.Rows.Count - 1);
                                dtUNDOPHIEUDAT.AcceptChanges();
                                updatetablePhieuDat();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    if (btnThem.Enabled == false) pHIEUDATBindingSource.Position = vitri1;
                    btnRedo.Enabled = true;
                    if (dtUNDOPHIEUDAT.Rows.Count - 1 < 0)
                    {
                        btnUndo.Enabled = false;

                    }
                }
                pHIEUDATGridControl.Enabled = true;
                sP_GetCTPhieuDatGridControl.Enabled = true;
                panel2.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            else
            {
                if (dtUNDOCTPHIEUDAT.Rows.Count - 1 >= 0)
                {
                    DataRow dr = dtUNDOCTPHIEUDAT.Rows[dtUNDOCTPHIEUDAT.Rows.Count - 1];
                    String temp = dr[3].ToString();
                    if (temp.Equals("DELETE"))
                    {
                        try
                        {
                            string sql = "DELETE FROM CTPHIEUDAT WHERE  MAPhieuDat = '" + dr[0] + "' and MAHangPhong = '" + dr[1] + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.CTPHIEUDAT.RejectChanges();
                                object[] findTheseVals = new object[2];
                                findTheseVals[0] = dr[0].ToString();
                                findTheseVals[1] = dr[1].ToString();
                                DataRow dt = kHACHSANDataSet.CTPHIEUDAT.Rows.Find(findTheseVals);
                                kHACHSANDataSet.CTPHIEUDAT.Rows.Remove(dt);
                                kHACHSANDataSet.CTPHIEUDAT.AcceptChanges();
                                dtREDOCTPHIEUDAT.RejectChanges();
                                dtREDOCTPHIEUDAT.NewRow();
                                dtREDOCTPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "INSERT");
                                dtREDOCTPHIEUDAT.AcceptChanges();
                                dtUNDOCTPHIEUDAT.RejectChanges();
                                dtUNDOCTPHIEUDAT.Rows.RemoveAt(dtUNDOCTPHIEUDAT.Rows.Count - 1);
                                dtUNDOCTPHIEUDAT.AcceptChanges();
                                updatetable();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }

                    }
                    else if (temp.Equals("UPDATE"))
                    {
                        try
                        {
                            string sql = "UPDATE CTPHIEUDAT SET MAHangPhong ='" + dr[1].ToString() + "',Soluong ='" + dr[2] + "'WHERE MAPhieuDat = '" + dr[0] + "' and MAHangPhong = '" + dr[1] + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.CTPHIEUDAT.RejectChanges();
                                object[] findTheseVals = new object[2];
                                findTheseVals[0] = dr[0].ToString();
                                findTheseVals[1] = dr[1].ToString();
                                DataRow dt = kHACHSANDataSet.CTPHIEUDAT.Rows.Find(findTheseVals);
                                dtREDOCTPHIEUDAT.RejectChanges();
                                dtREDOCTPHIEUDAT.NewRow();
                                dtREDOCTPHIEUDAT.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2], "UPDATE");
                                dt[1] = dr[1];
                                dt[2] = dr[2];
                                kHACHSANDataSet.CTPHIEUDAT.AcceptChanges(); dtREDOCTPHIEUDAT.AcceptChanges();
                                dtUNDOCTPHIEUDAT.RejectChanges();
                                dtUNDOCTPHIEUDAT.Rows.RemoveAt(dtREDOCTPHIEUDAT.Rows.Count - 1);
                                dtUNDOCTPHIEUDAT.AcceptChanges();
                                updatetable();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    else if (temp.Equals("INSERT"))
                    {
                        try
                        {
                            string sql = "INSERT INTO [CTPHIEUDAT]([MAPhieuDat],[MAHangPhong],[SoLuong])VALUES('" + dr[0].ToString() + "','" + dr[1].ToString() + "'," + dr[2] + ")";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.CTPHIEUDAT.RejectChanges();
                                kHACHSANDataSet.CTPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2]);
                                kHACHSANDataSet.CTPHIEUDAT.AcceptChanges();
                                dtREDOCTPHIEUDAT.RejectChanges();
                                dtREDOCTPHIEUDAT.NewRow();
                                dtREDOCTPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], "DELETE");
                                dtREDOCTPHIEUDAT.AcceptChanges();
                                dtUNDOCTPHIEUDAT.RejectChanges();
                                dtUNDOCTPHIEUDAT.Rows.RemoveAt(dtREDOCTPHIEUDAT.Rows.Count - 1);
                                dtUNDOCTPHIEUDAT.AcceptChanges();
                                updatetable();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    if (btnThem.Enabled == false) cTPHIEUDATBindingSource.Position = vitri;
                    btnRedo.Enabled = true;
                    if (dtUNDOCTPHIEUDAT.Rows.Count - 1 < 0)
                    {
                        btnUndo.Enabled = false;

                    }
                }

                cTPHIEUDATGridControl.Enabled = true;
                groupBox3.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChiTiet.Visible == true)
            {
                if (dtREDOPHIEUDAT.Rows.Count - 1 >= 0)
                {
                    DataRow dr = dtREDOPHIEUDAT.Rows[dtREDOPHIEUDAT.Rows.Count - 1];
                    String temp = dr[8].ToString();
                    if (temp.Equals("DELETE"))
                    {
                        try
                        {
                            string sql = "DELETE FROM PHIEUDAT WHERE [MAPhieuDat] ='" + dr[0].ToString() + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.PHIEUDAT.RejectChanges();
                                DataRow dt = kHACHSANDataSet.PHIEUDAT.Rows.Find(dr[0].ToString());
                                kHACHSANDataSet.PHIEUDAT.Rows.Remove(dt);
                                kHACHSANDataSet.PHIEUDAT.AcceptChanges();
                                dtUNDOPHIEUDAT.RejectChanges();
                                dtUNDOPHIEUDAT.NewRow();
                                dtUNDOPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], "INSERT");
                                dtUNDOPHIEUDAT.AcceptChanges();
                                dtREDOPHIEUDAT.RejectChanges();
                                dtREDOPHIEUDAT.Rows.RemoveAt(dtREDOPHIEUDAT.Rows.Count - 1);
                                dtREDOPHIEUDAT.AcceptChanges();
                                updatetablePhieuDat();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    else if (temp.Equals("UPDATE"))
                    {
                        try
                        {
                            string sql = "  UPDATE[dbo].[PHIEUDAT]SET[MAPhieuDat] = '" + dr[0] + "',[CNMDKH] = '" + dr[1] + "',[MANV] = '" + dr[2] + "',[NgayDen] = '" + dr[3] + "',[NgayDi] = '" + dr[4] + "',[NgayDat] = '" + dr[5] + "',[TrangThaiPhieu] = '" + dr[6] + "',[TienCoc] = '" + dr[7] + "' WHERE '" + dr[0] + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.PHIEUDAT.RejectChanges();
                                DataRow dt = kHACHSANDataSet.PHIEUDAT.Rows.Find(dr[0].ToString());
                                dtUNDOPHIEUDAT.RejectChanges();
                                dtUNDOPHIEUDAT.NewRow();
                                dtUNDOPHIEUDAT.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], dt[4], dt[5], dt[6], dt[7], "UPDATE");
                                dtUNDOPHIEUDAT.AcceptChanges();
                                dt[1] = dr[1];
                                dt[2] = dr[2];
                                dt[3] = dr[3];
                                dt[4] = dr[4];
                                dt[5] = dr[5];
                                dt[6] = dr[6];
                                dt[7] = dr[7];
                                kHACHSANDataSet.PHIEUDAT.AcceptChanges();
                                dtREDOPHIEUDAT.RejectChanges();
                                dtREDOPHIEUDAT.Rows.RemoveAt(dtREDOPHIEUDAT.Rows.Count - 1);
                                dtREDOPHIEUDAT.AcceptChanges();
                                updatetablePhieuDat();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    else if (temp.Equals("INSERT"))
                    {
                        try
                        {
                            string sql = "INSERT INTO [PHIEUDAT]([MAPhieuDat],[CNMDKH],[MANV],[NgayDen],[NgayDi],[NgayDat],[TrangThaiPhieu],[TienCoc])VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "',N'" + dr[6] + "','" + dr[7] + "')";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.PHIEUDAT.RejectChanges();
                                kHACHSANDataSet.PHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6], dr[7]);
                                kHACHSANDataSet.PHIEUDAT.AcceptChanges();
                                dtUNDOPHIEUDAT.RejectChanges();
                                dtUNDOPHIEUDAT.NewRow();
                                dtUNDOPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], "DELETE");
                                dtUNDOPHIEUDAT.AcceptChanges();
                                dtREDOPHIEUDAT.RejectChanges();
                                dtREDOPHIEUDAT.Rows.RemoveAt(dtREDOPHIEUDAT.Rows.Count - 1);
                                dtREDOPHIEUDAT.AcceptChanges();
                                updatetablePhieuDat();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    if (btnThem.Enabled == false) pHIEUDATBindingSource.Position = vitri1;
                    btnUndo.Enabled = true;
                    if (dtREDOPHIEUDAT.Rows.Count - 1 < 0)
                    {
                        btnRedo.Enabled = false;

                    }
                }

                pHIEUDATGridControl.Enabled = true;
                sP_GetCTPhieuDatGridControl.Enabled = true;
                panel2.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            else
            {
                if (dtREDOCTPHIEUDAT.Rows.Count - 1 >= 0)
                {
                    DataRow dr = dtREDOCTPHIEUDAT.Rows[dtREDOCTPHIEUDAT.Rows.Count - 1];
                    String temp = dr[3].ToString();
                    if (temp.Equals("DELETE"))
                    {
                        try
                        {
                            string sql = "DELETE FROM CTPHIEUDAT  WHERE MAPhieuDat = '" + dr[0] + "' and MAHangPhong = '" + dr[1] + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.CTPHIEUDAT.RejectChanges();
                                object[] findTheseVals = new object[2];
                                findTheseVals[0] = dr[0].ToString();
                                findTheseVals[1] = dr[1].ToString();
                                DataRow dt = kHACHSANDataSet.CTPHIEUDAT.Rows.Find(findTheseVals); kHACHSANDataSet.CTPHIEUDAT.Rows.Remove(dt);
                                kHACHSANDataSet.CTPHIEUDAT.AcceptChanges();
                                dtUNDOCTPHIEUDAT.RejectChanges();
                                dtUNDOCTPHIEUDAT.NewRow();
                                dtUNDOCTPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], "INSERT");
                                dtUNDOCTPHIEUDAT.AcceptChanges();
                                dtREDOCTPHIEUDAT.RejectChanges();
                                dtREDOCTPHIEUDAT.Rows.RemoveAt(dtREDOCTPHIEUDAT.Rows.Count - 1);
                                dtREDOCTPHIEUDAT.AcceptChanges();
                                updatetable();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    else if (temp.Equals("UPDATE"))
                    {
                        try
                        {
                            string sql = "UPDATE CTPHIEUDAT SET MAHangPhong ='" + dr[1].ToString() + "',Soluong ='" + dr[2] + "'WHERE MAPhieuDat = '" + dr[0] + "' and MAHangPhong = '" + dr[1] + "'";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.CTPHIEUDAT.RejectChanges();
                                object[] findTheseVals = new object[2];
                                findTheseVals[0] = dr[0].ToString();
                                findTheseVals[1] = dr[1].ToString();
                                DataRow dt = kHACHSANDataSet.CTPHIEUDAT.Rows.Find(findTheseVals); dtUNDOCTPHIEUDAT.RejectChanges();
                                dtUNDOCTPHIEUDAT.NewRow();
                                dtUNDOCTPHIEUDAT.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2], "UPDATE");
                                dtUNDOCTPHIEUDAT.AcceptChanges();
                                dt[1] = dr[1];
                                dt[2] = dr[2];
                                dt[3] = dr[3];
                                kHACHSANDataSet.CTPHIEUDAT.AcceptChanges();
                                dtREDOCTPHIEUDAT.RejectChanges();
                                dtREDOCTPHIEUDAT.Rows.RemoveAt(dtREDOCTPHIEUDAT.Rows.Count - 1);
                                dtREDOCTPHIEUDAT.AcceptChanges();
                                updatetable();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    else if (temp.Equals("INSERT"))
                    {
                        try
                        {
                            string sql = "INSERT INTO [CTPHIEUDAT]([MAPhieuDat],[MAHangPhong],[SoLuong])VALUES('" + dr[0].ToString() + "','" + dr[1].ToString() + "'," + dr[2] + ")";
                            if (DataUtil.ExecQueryString(sql))
                            {
                                kHACHSANDataSet.CTPHIEUDAT.RejectChanges();
                                kHACHSANDataSet.CTPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2]);
                                kHACHSANDataSet.CTPHIEUDAT.AcceptChanges();
                                dtUNDOCTPHIEUDAT.RejectChanges();
                                dtUNDOCTPHIEUDAT.NewRow();
                                dtUNDOCTPHIEUDAT.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], "DELETE");
                                dtUNDOCTPHIEUDAT.AcceptChanges();
                                dtREDOCTPHIEUDAT.RejectChanges();
                                dtREDOCTPHIEUDAT.Rows.RemoveAt(dtREDOCTPHIEUDAT.Rows.Count - 1);
                                dtREDOCTPHIEUDAT.AcceptChanges();
                                updatetable();
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                        }
                    }
                    if (btnThem.Enabled == false) cTPHIEUDATBindingSource.Position = vitri;
                    btnUndo.Enabled = true;
                    if (dtREDOCTPHIEUDAT.Rows.Count - 1 < 0)
                    {
                        btnRedo.Enabled = false;

                    }
                }

                cTPHIEUDATGridControl.Enabled = true;
                groupBox3.Enabled = false;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChiTiet.Visible == true)
            {
                try
                {

                    this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
                    this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
                    this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);
                    dtREDOPHIEUDAT.Clear();
                    dtUNDOPHIEUDAT.Clear();
                    btnRedo.Enabled = btnUndo.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                try
                {
                    this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);
                    this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
                    this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
                    dtREDOPHIEUDAT.Clear();
                    dtUNDOPHIEUDAT.Clear();
                    btnRedo.Enabled = btnUndo.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnPhieuThue_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pHIEUDATBindingSource.Count > 0)
            {
                if(mAPhieuDatTextEdit1.Text.Trim()=="") mAPhieuDatTextEdit1.Text = mAPhieuDatTextEdit2.Text;
                String sql = "Select * from Phieuthue where maphieudat ='" + mAPhieuDatTextEdit1.Text + "'";
                int dr = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr).Rows.Count;
                if (dr == 0)
                {
                    Form frm = this.CheckExists(typeof(FormDPtoTP));
                    if (frm != null) frm.Activate();
                    else
                    {
                        if (mAPhieuDatTextEdit1.Text == "") mAPhieuDatTextEdit1.Text = mAPhieuDatTextEdit2.Text;
                        DateTime ngaydi = ngayDiDateEdit1.DateTime;
                        if (ngayDiDateEdit1.DateTime <= DateTime.Today) ngaydi = DateTime.Today.AddDays(1);
                        FormDPtoTP f = new FormDPtoTP(mAPhieuDatTextEdit1.Text, DateTime.Today, ngaydi);
                        DataRowView drv = (DataRowView)pHIEUDATBindingSource.Current;
                        drv.Row[7] = "2";
                        pHIEUDATBindingSource.EndEdit();
                        pHIEUDATBindingSource.ResetCurrentItem();
                        this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                        this.pHIEUDATTableAdapter.Update(this.kHACHSANDataSet.PHIEUDAT);
                        f.Show();

                    }
                }
                else
                {
                    MessageBox.Show("Phiếu đặt đã được xuất phiếu thuê. \n Nếu bạn muốn thêm phòng.\n Hãy sửa phiếu thuê");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại phiếu đặt nào!");
            }
        }

        private void ngayDenDateEdit_TextChanged(object sender, EventArgs e)
        {
            DateTime yesterday = ngayDenDateEdit.DateTime;
            ngayDiDateEdit.Properties.MinValue = ngayDiDateEdit1.Properties.MinValue = yesterday.AddDays(1);
        }

        private void ngayDenDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            ngayDiDateEdit.Properties.MinValue = ngayDenDateEdit.DateTime.AddDays(1);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormChiTietDat));
            if (frm != null) frm.Activate();
            else
            {
                FormChiTietDat f = new FormChiTietDat();
                f.Show();
            }
        }

        private void mAHangPhongComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow dr = readyroom.Rows.Find(mAHangPhongComboBox.SelectedValue);
            try
            {
                int t = int.Parse(dr[1].ToString());
                if (t > 0)
                {
                    soLuongSpinEdit.Enabled = true;
                    soLuongSpinEdit.Properties.MaxValue = t;
                }
                else
                {
                    soLuongSpinEdit.Enabled = false;
                }
            }
            catch
            {
                soLuongSpinEdit.Enabled = false;
            }
        }
        public string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 20)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void pHIEUDATBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void pHIEUDATBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUDATBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void tienCocSpinEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (tienCocSpinEdit.Value < 0) tienCocSpinEdit.Value = 0;
        }

        private void tienCocSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (tienCocSpinEdit.Value < 0) tienCocSpinEdit.Value = 0;

        }

        private void soLuongSpinEdit_ValueChanged(object sender, EventArgs e)
        {
            if (soLuongSpinEdit.Value < 0) soLuongSpinEdit.Value = 0;

        }

        private void tienCocSpinEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (tienCocSpinEdit.Value < 0) tienCocSpinEdit.Value = 0;
        }

        private void soLuongSpinEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (soLuongSpinEdit.Value < 0) soLuongSpinEdit.Value = 0;
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            String sql = "Exec [SP_GETSOLUONGPHONG] '" + ngayDenDateEdit.DateTime + "', '" + ngayDiDateEdit.DateTime + "','" + mAPhieuDatTextEdit2.Text + "'";
            readyroom = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
            readyroom.PrimaryKey = new DataColumn[]
            {
                         readyroom.Columns[0]
             };
            
            fillToolStripButton_Click_1(sender, e);
        }

        private void FormDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            String sqlCmd = "select MAPhieuDat from PHIEUDAT except select MAPhieuDat from CTPHIEUDAT";
            DataTable da = DataUtil.ExecSqlDataTable(sqlCmd, DataUtil.connstr);
            if (da.Rows.Count > 0)
            {
                MessageBox.Show("Có " + da.Rows.Count + " phiếu đặt chưa có chi tiết phiếu đặt, Hãy thêm chi tiết cho phiếu hoặc xóa phiếu rồi đóng form ", "Xác nhận");
                e.Cancel = true;
            }
        }

        private void mAPhieuDatTextEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void mAPhieuDatTextEdit2_Leave(object sender, EventArgs e)
        {
            if (mAPhieuDatTextEdit2.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu đặt không được trống");
                mAPhieuDatTextEdit2.Focus();
            }
            else
            {
                mAPhieuDatTextEdit2.Text = mAPhieuDatTextEdit2.Text.ToUpper();

            }
        }

        private Boolean checkhople()
        {

            try
            {
               // BindingSource bs1 = (BindingSource)cTPHIEUDATBindingSource.DataSource;

                // BindingSource bs1 = (BindingSource)gridView3.DataSource;
                //DataSet ds = (bs1.DataSource as DataSet);                
                //DataTable drv = (bs1.DataSource as DataSet).Tables[bs1.DataMember];
                // DataTable drv = ds.Tables[bs1.DataMember];
                //  DataTable drv = ((DataTable)bs1.DataSource);
                BindingSource bs1 = (BindingSource)gridView3.DataSource;
                DataTable drv = ((DataSet)bs1.DataSource).Tables[bs1.DataMember];
              //  DataView dt1 = new DataView(drv);
                drv.AcceptChanges();
                DataView dt1 = new DataView(drv);
                DataTable drv1 = readyroom;
                foreach (DataRowView dr1 in dt1)
                {
                    DataRow dr = dr1.Row;
                    String mahangphong = dr[1].ToString();
                    int sl = int.Parse(dr[2].ToString());
                    DataRow[] drtemp = drv1.Select("MAHangPhong = '" + mahangphong + "'");
                    if (drtemp.Length != 0)
                    {
                        int sltemp = int.Parse(drtemp[0][1].ToString());
                        if (sltemp < sl)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.sP_GetCTPhieuDatTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            this.sP_GetCTPhieuDatTableAdapter.Fill(this.kHACHSANDataSet.SP_GetCTPhieuDat, mAPhieuDatTextEdit2.Text.ToString());
        }

        private void mAPhieuDatTextEdit2_EditValueChanged(object sender, EventArgs e)
        {

            if (cTPHIEUDATBindingSource.Count > 0)
            {
                if (mAPhieuDatTextEdit2!=null)
                {
                    //String sql = "Exec [SP_GETSOLUONGPHONG] '" + ngayDenDateEdit.DateTime + "', '" + ngayDiDateEdit.DateTime + "','" + mAPhieuDatTextEdit2.Text + "'";
                    //readyroom = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                    //readyroom.PrimaryKey = new DataColumn[]
                    //{
                    //     readyroom.Columns[0]
                    // };
                    fillToolStripButton_Click_1(sender, e);
                }
            }
        }
    }
}

