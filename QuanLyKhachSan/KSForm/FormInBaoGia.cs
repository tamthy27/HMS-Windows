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
    public partial class FormInBaoGia : Form
    {
        public FormInBaoGia()
        {
            InitializeComponent();
            BangBaoGia rp = new BangBaoGia();
            DataTable dt = new DataTable();
            try
            {
                dt = DataUtil.ExecSqlDataTable("EXEC [SP_BANGGIA]", DataUtil.connstr);
            }
            catch
            { }
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
