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
    public partial class FormInDanhSachPhieuThue : Form
    {
        public FormInDanhSachPhieuThue()
        {
            InitializeComponent();
            rpDANHSACHPHIEUTHUE rp = new rpDANHSACHPHIEUTHUE();
            DataTable dt = new DataTable();
            try
            {
                dt = DataUtil.ExecSqlDataTable("EXEC SP_GETTHONGTINCHECKIN", DataUtil.connstr);
            }
            catch
            { }
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
