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
using QuanLyKhachSan.KSForm;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormHOADON : Form
    {
        public FormHOADON()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormHOADON_Load(object sender, EventArgs e)
        {
            this.cTHOADONTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.hOADONTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTHOADON' table. You can move, or remove it, as needed.
            this.cTHOADONTableAdapter.Fill(this.kHACHSANDataSet.CTHOADON);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.kHACHSANDataSet.HOADON);

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.cTHOADONTableAdapter.Fill(this.kHACHSANDataSet.CTHOADON);
            this.hOADONTableAdapter.Fill(this.kHACHSANDataSet.HOADON);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hOADONBindingSource.Count > 0)
            {
                DataRowView drv = (DataRowView)this.hOADONBindingSource.Current;
             
                    Form frm = this.CheckExists(typeof(FormInHoaDonThuong));
                    if (frm != null) frm.Activate();
                    else
                    {
                        String mhd = drv[0].ToString();
                    FormInHoaDonThuong f = new FormInHoaDonThuong(mhd);
                        f.Show();
                    }
            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào");

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                String sql = "select * from CTPHIEUTHUE where CTPHIEUTHUE.ThanhToan = 0";
                int dr = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr).Rows.Count;
                if (dr != 0)
                {
                    Form frm = this.CheckExists(typeof(FormPTtoHD));
                    if (frm != null) frm.Activate();
                    else
                    {
                        FormPTtoHD f = new FormPTtoHD(this);
                        f.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Hiện tại chưa có phòng được thuê!");

                }
            }
            catch
            {

            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public void Reload()
        {
            this.cTHOADONTableAdapter.Fill(this.kHACHSANDataSet.CTHOADON);
            this.hOADONTableAdapter.Fill(this.kHACHSANDataSet.HOADON);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hOADONBindingSource.Count > 0)
            {
                DataRowView drv = (DataRowView)this.hOADONBindingSource.Current;                         
                    Form frm = this.CheckExists(typeof(FormHoaDonDo));
                if (frm != null) frm.Activate();
                else
                {
                    String mhd = drv[7].ToString();
                    if (string.IsNullOrEmpty(mhd))
                    {
                        FormHoaDonDo f = new FormHoaDonDo(mhd);
                        f.Show();
                    }
                    else
                    {
                        FormInHoaDon f = new FormInHoaDon(mhd);
                        f.Show();
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Không có hóa đơn nào");

            }
        }
    }
}
