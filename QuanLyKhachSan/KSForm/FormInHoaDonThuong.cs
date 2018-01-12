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
    public partial class FormInHoaDonThuong : Form
    {
        private string mhd;

        public FormInHoaDonThuong()
        {
            InitializeComponent();
        }

        public FormInHoaDonThuong(string mhd)
        {
            InitializeComponent();
            this.mhd = mhd;
            inHoaDon rp = new inHoaDon();
            DataTable dt = new DataTable();
            try
            {
                dt = DataUtil.ExecSqlDataTable("EXEC SP_INHOADON '" + mhd + "'", DataUtil.connstr);
            }
            catch
            { }
            rp.SetDataSource(dt);
            rp.SetParameterValue("MaHoaDon", mhd);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
