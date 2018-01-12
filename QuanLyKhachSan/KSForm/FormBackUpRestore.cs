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
    public partial class FormBackUpRestore : Form
    {
        private class BK
        {
            private int position;
            private DateTime backupday;
            public BK(int position, DateTime date)
            {
                this.position = position;
                this.backupday = date;
            }
            public int Position
            {
                get { return position; }
                set { this.position = value; }
            }
            public DateTime Backupday
            {
                get { return this.backupday; }
                set { this.backupday = value; }
            }
        }
        private int[] arr;
        private static BindingList<BK> bk = new BindingList<BK>();
        private Form frm;
        private int vitri = 0;

        public FormBackUpRestore()
        {
            InitializeComponent();
        }

        public FormBackUpRestore(Form frm)
        {
            
            InitializeComponent();
            this.frm = frm;
        }

        private void FormBackUpRestore_Load(object sender, EventArgs e)
        {
            this.sP_STT_BACKUPTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.SP_STT_BACKUP' table. You can move, or remove it, as needed.
            this.sP_STT_BACKUPTableAdapter.Fill(this.kHACHSANDataSet.SP_STT_BACKUP);
            stList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            progressBar1.Visible = true;
            int half = progressBar1.Maximum / 2;
            while (progressBar1.Value < half)
            {
                progressBar1.PerformStep();
            }
            if (e.ColumnIndex.Equals(0))
            {
                int position = bk[bdsBackup.Position].Position;
                if (position == 0)
                {
                    bk[bdsBackup.Position].Position = 1;
                }
                //else
                //{
                //    bk[bdsBackup.Position].Position = 0;
                //}
                check(bdsBackup.Position);
            }
            int vt = bk[bdsBackup.Position].Position;
            vitri = vt;
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            progressBar1.Visible = false;
        }
        public void check(int vt)
        {
            for (int i = 0; i < bk.Count; i++)
            {
                if (i != vt)
                {
                    bk[i].Position = 0;
                }
            }
            this.bdsBackup.DataSource = bk;
            //gcBackup.DataSource = bk;
            //gvthay.DataSource = bdsBackup;
           // this.gvBackup.Refresh();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            try
            {
                string strLenh = "Use tempdb BACKUP DATABASE KHACHSAN TO DISK = 'D:\\backup\\filebackup.bak'";
                int res = DataUtil.ExecSqlNonQuery(strLenh);
                this.sP_STT_BACKUPTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.sP_STT_BACKUPTableAdapter.Fill(this.kHACHSANDataSet.SP_STT_BACKUP);
                bdsBackup.DataSource = this.kHACHSANDataSet.SP_STT_BACKUP;
                stList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void stList()
        {
            bk.Clear();
            arr = new int[bdsBackup.Count + 1];
            for (int i = 0; i < bdsBackup.Count; i++)
            {

                int position = int.Parse(((DataRowView)bdsBackup[i])["position"].ToString());
                DateTime backup_start_date = DateTime.Parse(((DataRowView)bdsBackup[i])["backupday"].ToString());
                arr[i] = position;
                bk.Add(new BK(position, backup_start_date));
            }
            bdsBackup.Position = 0;
            check(0);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            progressBar1.Visible = true;
            int half = progressBar1.Maximum / 2;
              while(progressBar1.Value<half)
            {
                progressBar1.PerformStep();
            }
  
            string strLenh = "EXEC SP_RESET";
            int res = DataUtil.ExecSqlNonQuery(strLenh);
            string strLenh_ = "Use master BACKUP DATABASE KHACHSAN TO DISK = 'D:\\backup\\filebackup.bak'";
            int res_ = DataUtil.ExecSqlNonQuery(strLenh_);
            this.sP_STT_BACKUPTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.sP_STT_BACKUPTableAdapter.Fill(this.kHACHSANDataSet.SP_STT_BACKUP);
            bdsBackup.DataSource = this.kHACHSANDataSet.SP_STT_BACKUP;
            stList();
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            progressBar1.Visible = false;

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            progressBar1.Visible = true;
            int half = progressBar1.Maximum / 2;
            for (int i = 0; i < half; i++)
            {
                progressBar1.PerformStep();
            }
            try
            {
                string strLenh = "Use master ALTER DATABASE KHACHSAN SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE KHACHSAN FROM DISK = 'D:\\backup\\filebackup.bak' WITH RECOVERY, REPLACE, FILE = " + arr[bdsBackup.Position] + " ALTER DATABASE KHACHSAN SET MULTI_USER";
                int res = DataUtil.ExecSqlNonQuery(strLenh);
                if (res == 0)
                {
                    for (int i = half; i < progressBar1.Maximum; i++)
                    {
                        progressBar1.PerformStep();
                    }
                    MessageBox.Show("Khôi phục dữ liệu thành công");
                }
                progressBar1.Visible = false;
                //frm.Hide();

                this.ParentForm.Close();
                FormLogin frmDangNhap = new FormLogin();
                frmDangNhap.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
