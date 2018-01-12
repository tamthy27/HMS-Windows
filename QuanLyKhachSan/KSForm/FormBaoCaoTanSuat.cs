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
using QuanLyKhachSan.Report;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormBaoCaoTanSuat : Form
    {
        private string nam;
        public FormBaoCaoTanSuat()
        {
            InitializeComponent();
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            if (textEdit1.Text == null & textEdit1.Text.Trim().Length == 4)
            {
                MessageBox.Show("Năm không được để trống và phải có 4 ký tự");
                textEdit1.Focus();
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text != null && !textEdit1.Text.Trim().Equals(""))
            {
                this.nam = textEdit1.Text.ToString().Trim();
                if (checkBox1.Checked)
                {
                    String sql = "exec SP_THONGKETANSUAT " + nam;
                    DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                    if (dt.Rows.Count > 0)
                    {

                        dt = getdatatable(dt);
                        rpTHONGKETANSUAT rp = new rpTHONGKETANSUAT();
                        //rp.SetParameterValue("nam", nam);
                        rp.SetDataSource(dt);
                        rp.SetParameterValue(0, nam);

                        crystalReportViewer1.ReportSource = rp;
                    }
                    else
                    {
                        MessageBox.Show("Năm khách sạn không hoạt động! Hãy chọn năm khác");
                        textEdit1.Focus();
                        return;
                    }
                }
                else
                {
                    String sql = "exec SP_THONGKETANSUATQUY " + nam;
                    DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                    if (dt.Rows.Count > 0)
                    {
                        dt = getdatatable(dt);
                        rpTHONGKETANSUATQUY rp = new rpTHONGKETANSUATQUY();
                        //rp.SetParameterValue("nam", nam);
                        rp.SetDataSource(dt);
                        rp.SetParameterValue(0, nam);
                        crystalReportViewer1.ReportSource = rp;
                    }
                    else
                    {
                        MessageBox.Show("Năm khách sạn không hoạt động! Hãy chọn năm khác");
                        textEdit1.Focus();
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Năm không được để trống");
                textEdit1.Focus();
                return;
            }
        }
        private DataTable getdatatable(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 1; i < dr.ItemArray.Length; i++)
                {
                    if (dr[i].ToString().Equals("")||dr[i] == null)
                    {
                        dr[i] = 0;
                    }
                }
            }
            return dt;
        }
    }
}
