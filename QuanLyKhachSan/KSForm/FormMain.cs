using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyKhachSan.DatabaseUtil;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static FormMain fm;
        public FormMain()
        {
            InitializeComponent();
            fm = this;
            if(DataUtil.bophan.Equals("ADMIN"))
            {
                ribbonPage4.Visible = ribbonPageGroup14.Visible =false;
            }
            else if (DataUtil.bophan.Equals( "LETAN"))
            {
                ribbonPageGroup6.Visible = ribbonPage3.Visible = rbBuong.Visible= ribbonPageGroup17.Visible =false;
                Form frm = this.CheckExists(typeof(FormSoDoPhong));
                if (frm != null) frm.Activate();
                else
                {
                    FormSoDoPhong f = new FormSoDoPhong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            else if (DataUtil.bophan.Equals("BUONG"))
            {
                
              ribbonPageGroup6.Visible = ribbonPage3.Visible = rbLeTan.Visible = ribbonPage5.Visible= ribbonPageGroup17.Visible = false;
                Form frm = this.CheckExists(typeof(FormCheckPhong));
                if (frm != null) frm.Activate();
                else
                {
                    FormCheckPhong f = new FormCheckPhong();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

          private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            this.Close();
            FormLogin frmDangNhap = new FormLogin();
            frmDangNhap.Show();
        }
        private void btnRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormRegister));
            if (frm != null) frm.Activate();
            else
            {
                FormRegister f = new FormRegister();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
          
        }
        
        private void btnTypeRoom_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKieuPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormKieuPhong f = new FormKieuPhong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        
        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {
                FormDoiMatKhau f = new FormDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }           
        }
       
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLoaiPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormLoaiPhong f = new FormLoaiPhong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

         
        private void btnHangPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormHangPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormHangPhong f = new FormHangPhong();
                f.MdiParent = this;
                f.Show();
            }
        }
      
        private void btnGiaPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiaPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaPhong f = new FormGiaPhong();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void btnPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormPhong f = new FormPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLoaiDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormLoaiDichVu));
            if (frm != null) frm.Activate();
            else
            {
                FormLoaiDichVu f = new FormLoaiDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }
      
        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }
       
        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                FormKhachHang f = new FormKhachHang();
                f.MdiParent = this;
                f.Show();
            }

        }
        
        private void btnThuePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormThuePhong));
            if (frm != null) frm.Activate();
            else
            {
                FormThuePhong f = new FormThuePhong();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void btnDatPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDatPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormDatPhong f = new FormDatPhong();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void btnSoDoPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSoDoPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormSoDoPhong f = new FormSoDoPhong();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void btnCheckStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormCheckPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormCheckPhong f = new FormCheckPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDichVu));
            if (frm != null) frm.Activate();
            else
            {
                if (DataUtil.bophan.Equals("LETAN"))
                {
                    FormDichVu f = new FormDichVu();
                    f.MdiParent = this;
                    f.Show();
                }
                else
                {
                    FormDichVu f = new FormDichVu(false);
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void btnDMDICHVU_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDMDichVu));
            if (frm != null) frm.Activate();
            else
            {
                FormDMDichVu f = new FormDMDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

     
        private void btnGiaDichVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiaDichVu));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaDichVu f = new FormGiaDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTinhTrangPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTinhTrangPhong));
            if (frm != null) frm.Activate();
            else
            {
                FormTinhTrangPhong f = new FormTinhTrangPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTang));
            if (frm != null) frm.Activate();
            else
            {
                FormTang f = new FormTang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBaoCaoDoanhThu));
            if (frm != null) frm.Activate();
            else
            {
                //int t = DateTime.Now.Year;
                FormBaoCaoDoanhThu f = new FormBaoCaoDoanhThu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormHOADON));
            if (frm != null) frm.Activate();
            else
            {
                FormHOADON f = new FormHOADON();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void setInformation(String a)
        {
            toolStripStatusLabel1.Text = a;
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormImportKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                FormImportKhachHang f = new FormImportKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBackUpRestore));
            if (frm != null) frm.Activate();
            else
            {
                FormBackUpRestore f = new FormBackUpRestore(frm);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKhuyenMai));
            if (frm != null) frm.Activate();
            else
            {
                FormKhuyenMai f = new FormKhuyenMai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBaoCaoCheckIn));
            if (frm != null) frm.Activate();
            else
            {
                FormBaoCaoCheckIn f = new FormBaoCaoCheckIn();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDanhSachcPhieuDat));
            if (frm != null) frm.Activate();
            else
            {
                FormDanhSachcPhieuDat f = new FormDanhSachcPhieuDat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBaoCaoTanSuat));
            if (frm != null) frm.Activate();
            else
            {
                FormBaoCaoTanSuat f = new FormBaoCaoTanSuat();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormInBaoGia));
            if (frm != null) frm.Activate();
            else
            {
                FormInBaoGia f = new FormInBaoGia();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}