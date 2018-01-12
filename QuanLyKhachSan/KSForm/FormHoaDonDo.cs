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
    public partial class FormHoaDonDo : Form
    {
        private string mhd;
        List<string> macthd = new List<string>();
        List<string> mahd = new List<string>();

        public FormHoaDonDo()
        {
            InitializeComponent();
        }

        public FormHoaDonDo(string mhd)
        {
            InitializeComponent();
            this.mhd = mhd;
            //if (string.IsNullOrEmpty(mhd))
            //{
                String tencongty = "";
                String masothue = "";
                
                textEdit1.Text = tencongty;
                textEdit2.Text = masothue;
            //}
            //else
            //{
            //    Form frm = this.CheckExists(typeof(FormInHoaDon));
            //    if (frm != null) frm.Activate();
            //    else
            //    {
            //        FormInHoaDon f = new FormInHoaDon(mhd);
            //        f.Show();
            //    }
            //}

        }

        private void FormHoaDonDo_Load(object sender, EventArgs e)
        {
            this.sP_HOADONCHUAXUATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.sP_HOADONCHUAXUATTableAdapter.Fill(this.kHACHSANDataSet.SP_HOADONCHUAXUAT);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEdit1.Text.Trim() == "" || textEdit2.Text.Trim() == "" || textEdit1.Text == null || textEdit2.Text == null)
                {
                    MessageBox.Show("Tên công ty hoặc mã số thuế còn thiếu");
                    return;
                }
                else
                {
                    textEdit1.Text = DataUtil.xoaKhoangTrang(textEdit1.Text);
                    textEdit2.Text = DataUtil.xoaKhoangTrang(textEdit2.Text);
                }
                String tenconty = textEdit1.Text;
                string masothue = textEdit2.Text;
                GetListCTHD();
                DataUtil.AddHoaDonDo(DataUtil.username, DateTime.Today, macthd, mahd, textEdit1.Text, textEdit2.Text);             
                MessageBox.Show("Đã xuất hóa đơn");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Xuất hóa đơn thất bại");

            }

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        
        private void GetListCTHD ()
        {
            try
            {
                for (int i = 0; i < mahd.Count; i++)
                {
                    String temp = mahd[i].ToString();
                    String sql = "select CTHOADON.MACTHD from CTHOADON where CTHOADON.MAHD = '" + temp + "'";
                    DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                    foreach (DataRow dr in dt.Rows)
                    {
                        macthd.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message);
                return; }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            if (dr != null && gridView1.IsRowSelected(gridView1.GetFocusedDataSourceRowIndex()))
            {
                String mhd = dr[0].ToString();
                mahd.Add(mhd);
            }
            if (dr != null && !gridView1.IsRowSelected(gridView1.GetFocusedDataSourceRowIndex()))
            {
                String mhd = dr[0].ToString();
                mahd.Remove(mhd);
            }
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void textEdit1_Leave(object sender, EventArgs e)
        {
            textEdit1.Text = DataUtil.xoaKhoangTrang(textEdit1.Text);

        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textEdit2_Leave(object sender, EventArgs e)
        {
            if (textEdit2.Text != null && textEdit2.Text.Trim().Length <= 9)
            {
                MessageBox.Show("Độ dài mã số thuế phải lớn hơn 9");
                textEdit2.Focus();
            }
        }
    }
}
