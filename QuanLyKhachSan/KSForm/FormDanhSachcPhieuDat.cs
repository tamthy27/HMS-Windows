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
    public partial class FormDanhSachcPhieuDat : Form
    {
        public FormDanhSachcPhieuDat()
        {
            InitializeComponent();
        }

        private void FormDanhSachcPhieuDat_Load(object sender, EventArgs e)
        {
            this.sP_GETTHONGTINDATPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.SP_GETTHONGTINDATPHONG' table. You can move, or remove it, as needed.
            this.sP_GETTHONGTINDATPHONGTableAdapter.Fill(this.kHACHSANDataSet.SP_GETTHONGTINDATPHONG);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormINDANHSACHPHIEUDAT));
            if (frm != null) frm.Activate();
            else
            {
                FormINDANHSACHPHIEUDAT f = new FormINDANHSACHPHIEUDAT();
                f.Show();
            }
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
    }
}
