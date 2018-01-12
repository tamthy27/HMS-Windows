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
    public partial class FormGiaHan : Form
    {
        public FormGiaHan()
        {
            InitializeComponent();
            ngayDenDateEdit.Properties.MinValue = DateTime.Now;
            ngayDiDateEdit.Properties.MinValue = ngayDenDateEdit.DateTime;
            String sql = "select PHIEUDAT.MAPhieuDat from PHIEUDAT where PHIEUDAT.TrangThaiPhieuDat in ( 1, 2,4)";
            int dr = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr).Rows.Count;
            if (dr <= 0)
            {
                sP_GetCTPhieuDatGridControl.Enabled = false;
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_APPSOLUONGCOTHEDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;

                this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDenDateEdit.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDiDateEdit.DateTime, typeof(System.DateTime))))), mAPhieuDatComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormGiaHan_Load(object sender, EventArgs e)
        {
            this.sP_PHIEUDATCOTHEGIAHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.SP_PHIEUDATCOTHEGIAHANG' table. You can move, or remove it, as needed.
            this.sP_PHIEUDATCOTHEGIAHANGTableAdapter.Fill(this.kHACHSANDataSet.SP_PHIEUDATCOTHEGIAHANG);

            this.sP_APPSOLUONGCOTHEDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTPHIEUDAT' table. You can move, or remove it, as needed.
            this.cTPHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.PHIEUDAT' table. You can move, or remove it, as needed.
            this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
            ngayDenDateEdit.Properties.MinValue = DateTime.Now;
            ngayDiDateEdit.Properties.MinValue = ngayDenDateEdit.DateTime;

        }

        private void mAPhieuDatComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);
            this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDenDateEdit.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDiDateEdit.DateTime, typeof(System.DateTime))))), mAPhieuDatComboBox.SelectedValue.ToString());
        }

        private void ngayDenDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            ngayDiDateEdit.Properties.MinValue = ngayDenDateEdit.DateTime.AddDays(1);
            try
            {
                if (mAPhieuDatComboBox.SelectedValue != null)
                {
                    this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDenDateEdit.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDiDateEdit.DateTime, typeof(System.DateTime))))), mAPhieuDatComboBox.SelectedValue.ToString());
                }
                else
                {
                    //String sql = "";
                    //DataTable dt = DataUtil.ExecSqlDataTable(sql,DataUtil.connstr);
                    this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, ngayDenDateEdit.DateTime, ngayDiDateEdit.DateTime, "NULL");
                }
            }
            catch
            {

            }

        }

        private void ngayDiDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (mAPhieuDatComboBox.SelectedValue != null)
                {
                    this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDenDateEdit.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayDiDateEdit.DateTime, typeof(System.DateTime))))), mAPhieuDatComboBox.SelectedValue.ToString());
                }
                else
                {
                    //String sql = "";
                    //DataTable dt = DataUtil.ExecSqlDataTable(sql,DataUtil.connstr);
                    this.sP_APPSOLUONGCOTHEDATTableAdapter.Fill(this.kHACHSANDataSet.SP_APPSOLUONGCOTHEDAT,ngayDenDateEdit.DateTime,ngayDiDateEdit.DateTime,"NULL");
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean temp = true;
            BindingSource bs1 = (BindingSource)gridView2.DataSource;
            DataTable drv = ((DataSet)bs1.DataSource).Tables[bs1.DataMember];
            DataView dt1 = new DataView(drv);
            BindingSource bs = (BindingSource)gridView1.DataSource;
            DataTable drv1 = ((DataSet)bs.DataSource).Tables[bs.DataMember];
            //for (int i = 0; i < gridView2.DataRowCount - 1; i++)
            //{
            //  DataRow dr = (DataRow) gridView2.GetRow(i);

            // DataRow dr = DirectCast(System.Data.DataRowView, System.Data.DataRow).row
            foreach (DataRowView dr1 in dt1)
            {
                DataRow dr = dr1.Row;
                String mahangphong = dr[1].ToString();
                int sl = int.Parse(dr[2].ToString());
                DataRow[] drtemp = drv1.Select("MAHangPhong = '" + mahangphong + "'");
                if (drtemp.Length!=0)
                { int sltemp = int.Parse(drtemp[0][2].ToString());
                    if (sltemp<sl)
                    {
                        temp = false;
                        MessageBox.Show("Gia hạn thất bại");
                        return;
                    }
                }
                else
                {
                    temp = false;
                    MessageBox.Show("Gia hạn thất bại");
                    return;
                }                
            }

            String sql = "UPDATE [dbo].[PHIEUDAT] SET [NgayDen] = '"+ngayDenDateEdit.DateTime+"',[NgayDi] = '"+ngayDiDateEdit.DateTime+"'  WHERE PHIEUDAT.MAPhieuDat ='"+mAPhieuDatComboBox.SelectedValue+"'";
            bool t = DataUtil.ExecQueryString(sql);
            String sql1 = "update PHIEUDAT set TrangThaiPhieuDat = 2 where MAPhieuDat = 'online18' and TrangThaiPhieuDat =1 ";
            bool t1 = DataUtil.ExecQueryString(sql1);

            if (t&&t1)
            {   
                
                MessageBox.Show("Gia hạn thành công");
            }
            else
            {
                MessageBox.Show("Gia hạn thất bại");

            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_GetCTPhieuDatTableAdapter.Connection.ConnectionString = DataUtil.connstr;

                this.sP_GetCTPhieuDatTableAdapter.Fill(this.kHACHSANDataSet.SP_GetCTPhieuDat, mAPhieuDatComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
               
            }

        }

        private void mAPhieuDatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                fillToolStripButton_Click_1(sender, e);
               
            try
            {
                String sql = "select ngayden, NgayDi from PHIEUDAT where MAPhieuDat = '" + mAPhieuDatComboBox.SelectedValue.ToString() + "'";
                DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                String ngayden = dt.Rows[0][0].ToString();
                String ngaydi = dt.Rows[0][1].ToString(); ;
                label3.Text = ngayden;
                label4.Text = ngaydi;
            }
            catch
            {

            }
        }
    }
}
