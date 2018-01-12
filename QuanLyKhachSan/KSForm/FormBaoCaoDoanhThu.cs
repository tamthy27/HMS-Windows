using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Report;
using QuanLyKhachSan.DatabaseUtil;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        private string nam;
        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();

            //CRThongKeDoanhThuTheoNam rp = new CRThongKeDoanhThuTheoNam();
            //crystalReportViewer1.ReportSource = rp;
        }
        public FormBaoCaoDoanhThu(string nam)
        {
            InitializeComponent();
            this.nam = nam;
          
        }
        private DataTable getdatatable (DataTable dt)
        {
            foreach(DataRow dr in dt.Rows)
            {
                for (int i = 1; i<dr.ItemArray.Length ;i++)
                {
                    if(dr[i].ToString().Equals("")||dr[i]==null)
                    {
                        dr[i] = 0;
                    }
                }
            }
            return dt;
        }

        private void namtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void namtxt_Leave(object sender, EventArgs e)
        {
            if (namtxt.Text == null & namtxt.Text.Trim().Length ==4 )
            {
                MessageBox.Show("Năm không được để trống và phải có 4 ký tự");
                namtxt.Focus();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (namtxt.Text!=null&&!namtxt.Text.Trim().Equals("")) {
                this.nam = namtxt.Text.ToString().Trim();
                if (checkBox2.Checked)
                {
                    String sql = "exec SP_THONGKEDOANHTHU " + nam;
                    DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                    if (dt.Rows.Count > 0)
                    {
                        dt = getdatatable(dt);
                        CRThongKeDoanhThuTheoNam rp = new CRThongKeDoanhThuTheoNam();
                        //rp.SetParameterValue("nam", nam);
                        rp.SetDataSource(dt);
                        rp.SetParameterValue(0, nam);

                        crystalReportViewer1.ReportSource = rp;
                    }
                    else
                    {
                        MessageBox.Show("Năm khách sạn không hoạt động! Hãy chọn năm khác");
                        namtxt.Focus();
                        return;
                    }
                }
                else
                {
                    String sql = "exec SP_THONGKEDOANHTHUQUY " + nam;
                    DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                    if (dt.Rows.Count > 0)
                    {
                        dt = getdatatable(dt);
                        rpTHONGKEDOANHTHUQUY rp = new rpTHONGKEDOANHTHUQUY();
                        //rp.SetParameterValue("nam", nam);
                        rp.SetDataSource(dt);
                        rp.SetParameterValue(0, nam);
                        crystalReportViewer1.ReportSource = rp;
                    }
                    else
                    {
                        MessageBox.Show("Năm khách sạn không hoạt động! Hãy chọn năm khác");
                        namtxt.Focus();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Năm không được để trống");
                namtxt.Focus();
                return;
            }
        }
    }
}
