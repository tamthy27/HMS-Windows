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
    public partial class FormNewHoaDon : Form
    {
        int giaphong = 0;
        int giadichvu = 0;
        int tiengiamgia = 0;
        int tongcong = 0;
        DataTable dt;
        public FormNewHoaDon()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("Phong", typeof(string));
            dt.Columns.Add("MaCTPhieuThue", typeof(string));
            dt.Columns.Add("TienThuePhong", typeof(double));
            dt.Columns.Add("TienDichVu", typeof(double));
            dt.Columns.Add("GiamGia", typeof(double));
            dt.PrimaryKey = new DataColumn[]
           {
               dt.Columns[2]
           };
            dataGridView1.DataSource = dt;
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            DataRowView drv = (DataRowView)sP_GETCHITIETPHIEUTHUECHUATHANHTOANBindingSource.Current;
            if (dr != null && gridView1.IsRowSelected(gridView1.GetFocusedDataSourceRowIndex()))
            {            
                DataTable tienphong = DataUtil.ExecSqlDataTable("EXEC	SP_TINHTIENPHONGCTPHIEUTHUE @MACTPHIEUTHUE = '" + drv.Row[0] + "'", DataUtil.connstr);
                DataTable tiendichvu = DataUtil.ExecSqlDataTable("exEc [SP_TINHTIENDICHVUCTPHIEUTHUE] @MACTPHIEUTHUE = '" +drv.Row[0]+"'", DataUtil.connstr);
                DataTable giamgia = DataUtil.ExecSqlDataTable("EXEC	SP_TINHTIENGIAMGIACTPHIEUTHUE @MACTPHIEUTHUE = '" + drv.Row[0] + "'", DataUtil.connstr);
                if(tienphong!=null)
                {
                    try
                    {
                        giaphong += int.Parse(tienphong.Rows[0][0].ToString());                       

                    }
                    catch
                    {
                        Console.WriteLine("Lỗi int giaphong");
                    }
                    txtTienPhong.Text = giaphong.ToString();
                }
                if (tiendichvu != null)
                {
                    try
                    {
                        giadichvu += int.Parse(tiendichvu.Rows[0][0].ToString());
                    }
                    catch
                    {
                        Console.WriteLine("Lỗi int giadichvu");
                    }
                    txtTienDichVu.Text = giadichvu.ToString();
                }
                if (giamgia != null)
                {
                    try
                    {
                        tiengiamgia += int.Parse(giamgia.Rows[0][0].ToString());
                    }
                    catch
                    {
                        Console.WriteLine("Lỗi int giamgia");
                    }
                    txtGiamGia.Text = tiengiamgia.ToString();
                }
                int stt = dt.Rows.Count + 1;
                dt.NewRow();
                dt.Rows.Add(stt.ToString(),drv.Row[2].ToString(),drv.Row[1].ToString(),tienphong,tiendichvu,tiengiamgia);
                tongcong = giaphong + giadichvu - tiengiamgia;
                txtTongCong.Text = tongcong.ToString();
            }
            if (dr != null && !gridView1.IsRowSelected(gridView1.GetFocusedDataSourceRowIndex()))
            {
                DataRow r = dt.Rows.Find(dr[0].ToString());
                dt.Rows.Remove(r);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FormNewHoaDon_Load(object sender, EventArgs e)
        {
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.sP_GETCHITIETPHIEUTHUECHUATHANHTOANTableAdapter.Fill(this.kHACHSANDataSet.SP_GETCHITIETPHIEUTHUECHUATHANHTOAN);
        }
    }
}
