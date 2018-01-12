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
    public partial class FormInHoaDon : Form
    {
        private string mhd;

        public FormInHoaDon()
        {
            InitializeComponent();
        }

        public FormInHoaDon(string mhd)
        {
            InitializeComponent();
            this.mhd = mhd;
            rpHOADONDO rp = new rpHOADONDO();
            DataTable dt = new DataTable();
            try
            {
                dt = DataUtil.ExecSqlDataTable("EXEC SP_INHOADONDO '" + mhd + "'", DataUtil.connstr);
            }
            catch
            { }
            int no = 0;
            for(int t =0; t<dt.Rows.Count; t++)
            {
                no = no + (int)(dt.Rows)[t][6];
            }
            String number = no.ToString();
            String word = ChuyenSo(number);
            rp.SetDataSource(dt);
            rp.SetParameterValue("WordNumber", word);
        //    rp.SetParameterValue("MaHoaDon", mhd);
            crystalReportViewer1.ReportSource = rp;
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            this.hOADONTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.kHACHSANDataSet.HOADON);

        }


        private string ChuyenSo(string number)
        {
            string[] dv = { "", "mươi", "trăm", "nghìn", "triệu", "tỉ" };
            string[] cs = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3) doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0') doc += "lẻ ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3) doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0) k = 0;
                                    else k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int)number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }


                //Doc don vi lon
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

            return DataUtil.xoaKhoangTrang(DinhDang(doc));
        }
        private string DinhDang(string s)
        {        
            string temp2 = "";
            temp2 += char.ToUpper(s[0]);
            for (int i = 1; i < s.Length; i++)
                temp2 += s[i];
            s = temp2;
            return s;
        }

        //private void mAHDComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    inHoaDon rp = new inHoaDon();
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        dt = DataUtil.ExecSqlDataTable("EXEC SP_INHOADON '"+mAHDComboBox.SelectedValue+"'", DataUtil.connstr);
        //    }
        //    catch
        //    { }
        //    rp.SetDataSource(dt);
        //    rp.SetParameterValue("MaHoaDon", mAHDComboBox.SelectedText.ToString().Trim());
        //    crystalReportViewer1.ReportSource = rp;
        //}
    }
}
