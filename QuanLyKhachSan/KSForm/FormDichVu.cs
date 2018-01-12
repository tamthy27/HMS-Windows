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
using DevExpress.XtraBars;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormDichVu : Form
    {
        //public static DataTable dtREDOKHSDDV = new DataTable();
        //public static DataTable dtUNDOKHSDDV = new DataTable();
        int vitri = 0;
        //String Action = "";
        double gia = 0;
        static Boolean buong = false;
        public FormDichVu()
        {
            InitializeComponent();

            btnGhi.Enabled = btnHuy.Enabled = false;
          //  ngaySuDungDateEdit.Properties.MaxValue = DateTime.Now;
            //DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            //DateTime ngayden = (DateTime)dr[1];
            //DateTime ngaydi = (DateTime)dr[2];
            //ngaySuDungDateEdit.Properties.MinValue = ngayden;
            //ngaySuDungDateEdit.Properties.MaxValue = ngaydi;

        }
        public FormDichVu(Boolean a)
        {
            InitializeComponent();

            btnGhi.Enabled = btnHuy.Enabled = false;
            barButtonItem1.Visibility= BarItemVisibility.Never;
            //  ngaySuDungDateEdit.Properties.MaxValue = DateTime.Now;
            //DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            //DateTime ngayden = (DateTime)dr[1];
            //DateTime ngaydi = (DateTime)dr[2];
            //ngaySuDungDateEdit.Properties.MinValue = ngayden;
            //ngaySuDungDateEdit.Properties.MaxValue = ngaydi;

        }

        private void cTPHIEUTHUEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTPHIEUTHUEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            this.kHSDDVTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTPHIEUTHUETableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.KHSDDV' table. You can move, or remove it, as needed.
            this.kHSDDVTableAdapter.Fill(this.kHACHSANDataSet.KHSDDV);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTPHIEUTHUE' table. You can move, or remove it, as needed.
            this.cTPHIEUTHUETableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUTHUE);
            this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
            if (cTPHIEUTHUEBindingSource.Count <= 0)
            {
                btnThem.Enabled = false;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = kHSDDVBindingSource.Position;
            kHSDDVBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            maDVComboBox.Enabled = true;
            mACTPhieuThueTextEdit1.Text = maCTPhieuThueTextEdit.Text;
            //Action = "DELETE";
            groupBox9.Enabled = true;
            maDVComboBox.Enabled = ngaySuDungDateEdit.Enabled = true;
            cTPHIEUTHUEGridControl.Enabled = false;
            maDVComboBox.SelectedIndex = 0;
            DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            DateTime ngayden = (DateTime)dr[4];
            DateTime ngaydi = (DateTime)dr[5];
            ngaySuDungDateEdit.Properties.MinValue = ngayden;
            ngaySuDungDateEdit.Properties.MaxValue = ngaydi;

        }


        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (maDVComboBox.Enabled == true)
            {

                if (maDVComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mAHangPhongTextEdit.Focus();
                    return;
                }
                if (ngaySuDungDateEdit.DateTime == null)
                {
                    MessageBox.Show("ngày sử dụng dụng không được trống!", "", MessageBoxButtons.OK);
                    ngaySuDungDateEdit.Focus();
                    return;
                }
                if (sLSpinEdit.Value < 0)
                {
                    MessageBox.Show("số lượng phải lớn hơn 0!", "", MessageBoxButtons.OK);
                    sLSpinEdit.Focus();
                    return;
                }
                try
                {
                    
                    DataRowView drv = (DataRowView)kHSDDVBindingSource.Current;
                    gia = getDonGia(maDVComboBox.SelectedValue, ngaySuDungDateEdit.DateTime);
                    drv[2] = ngaySuDungDateEdit.DateTime;
                    drv[4] = gia;
                    drv[5] = false;
                    drv[3] = sLSpinEdit.Value;
                    //drv[1] = maDVComboBox.SelectedValue;
                    kHSDDVBindingSource.ResetCurrentItem();
                    this.kHSDDVTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.kHSDDVTableAdapter.Update(this.kHACHSANDataSet.KHSDDV);
                    cTPHIEUTHUEGridControl.Enabled = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Dịch Vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (maDVComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mAHangPhongTextEdit.Focus();
                    return;
                }
                if (ngaySuDungDateEdit.DateTime == null)
                {
                    MessageBox.Show("ngày sử dụng dụng không được trống!", "", MessageBoxButtons.OK);
                    ngaySuDungDateEdit.Focus();
                    return;
                }
                if (sLSpinEdit.Value < 0)
                {
                    MessageBox.Show("số lượng phải lớn hơn 0!", "", MessageBoxButtons.OK);
                    sLSpinEdit.Focus();
                    return;
                }
                try
                {
                    DataRowView drv = (DataRowView)kHSDDVBindingSource.Current;
                    gia = getDonGia(maDVComboBox.SelectedValue, ngaySuDungDateEdit.DateTime);
                    drv[4] = gia;
                    drv[5] = false;
                    kHSDDVBindingSource.EndEdit();
                    kHSDDVBindingSource.ResetCurrentItem();
                    this.kHSDDVTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.kHSDDVTableAdapter.Update(this.kHACHSANDataSet.KHSDDV);
                    cTPHIEUTHUEGridControl.Enabled = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi dịch vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
  
                    return;
                }
            }
            kHSDDVGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            groupBox9.Enabled = false;
        }

        private double getDonGia(object selectedValue, DateTime dateTime)
        {

            try
            {
                Double gia = 0;
                String sql = "select top 1 GIADICHVU.GiaDichVu from GIADICHVU where GiaDichVu.MADV= '" + selectedValue + "' and GiaDichVu.NgayApDung<= '" + dateTime + "' order by GiaDichVu.NgayApDung desc";
                DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                DataRow dr = dt.Rows[0];
                gia = double.Parse(dr[0].ToString());
                return gia;
            }
            catch
            {
                return 0;

            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHSDDVBindingSource.Count > 0)
            {
             
       
                DataRowView drv = (DataRowView)kHSDDVBindingSource.Current;
      
                vitri = kHSDDVBindingSource.Position;
                groupBox9.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                maDVComboBox.Enabled = ngaySuDungDateEdit.Enabled = false;
                kHSDDVGridControl.Enabled = false;

                cTPHIEUTHUEGridControl.Enabled = false;
                DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
                DateTime ngayden = (DateTime)dr[4];
                DateTime ngaydi = (DateTime)dr[5];
                ngaySuDungDateEdit.Properties.MinValue = ngayden;
                ngaySuDungDateEdit.Properties.MaxValue = ngaydi;

            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

        private void updatetable()
        {
            this.kHSDDVTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kHSDDVTableAdapter.Update(this.kHACHSANDataSet);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHSDDVBindingSource.Count > 0)
            {
                try
                {
                    DataRowView drv = (DataRowView)kHSDDVBindingSource.Current;
                    if (!bool.Parse(drv.Row[5].ToString()))
                    {
                        DialogResult dlResult = MessageBox.Show("Bạn muốn xóa dịch vụ có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        Console.WriteLine("dialogResult" + dlResult);
                        if (dlResult == DialogResult.OK)
                        {
                            //Action = "INSERT";

                            kHSDDVBindingSource.RemoveCurrent();
                            updatetable();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dịch vụ đã thanh toán, không thể xóa","Lỗi");
                    }
                }
                catch
                {
                    MessageBox.Show("không thực hiện được thao tác xóa", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

      

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'kHACHSANDataSet.LOAIKHSDDV' table. You can move, or remove it, as needed.
                this.cTPHIEUTHUETableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUTHUE);
                // TODO: This line of code loads data into the 'kHACHSANDataSet.KHSDDV' table. You can move, or remove it, as needed.
                this.kHSDDVTableAdapter.Fill(this.kHACHSANDataSet.KHSDDV);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

      



        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
   
            kHSDDVBindingSource.CancelEdit();
            if (btnThem.Enabled == false) kHSDDVBindingSource.Position = vitri;
            kHSDDVGridControl.Enabled = true;
            groupBox9.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            cTPHIEUTHUEGridControl.Enabled = true;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormThanhToanDichVu));
            if (frm != null) frm.Activate();
            else
            {
                FormThanhToanDichVu f = new FormThanhToanDichVu();
                f.Show();
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            //DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            //DateTime ngayden = (DateTime) dr[1];
            //DateTime ngaydi = (DateTime) dr[2];
            //ngaySuDungDateEdit.Properties.MinValue = ngayden;
            //ngaySuDungDateEdit.Properties.MaxValue = ngaydi;

        }
    }
}
