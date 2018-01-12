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
    public partial class FormBaoCaoCheckIn : Form
    {
        public FormBaoCaoCheckIn()
        {
            InitializeComponent();
        }

        private void FormBaoCaoCheckIn_Load(object sender, EventArgs e)
        {
            this.sP_GETTHONGTINCHECKINTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.SP_GETTHONGTINCHECKIN' table. You can move, or remove it, as needed.
            this.sP_GETTHONGTINCHECKINTableAdapter.Fill(this.kHACHSANDataSet.SP_GETTHONGTINCHECKIN);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInDanhSachPhieuThue));
            if (frm != null) frm.Activate();
            else
            {
                FormInDanhSachPhieuThue f = new FormInDanhSachPhieuThue();
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
