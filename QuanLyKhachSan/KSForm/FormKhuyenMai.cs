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
    public partial class FormKhuyenMai : Form
    {

        int vitri1 = 0;
        int vitri2 = 0;
        int vitri3 = 0;
        public FormKhuyenMai()
        {
            InitializeComponent();
            btnGhi.Enabled = btnHuy.Enabled = false;


        }

        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTKM_HANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTKM_DICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.khuyenMaiTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
            this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
            this.cTKM_HANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.CTKM_HANGPHONG);
            this.cTKM_DICHVUTableAdapter.Fill(this.kHACHSANDataSet.CTKM_DICHVU);
            this.khuyenMaiTableAdapter.Fill(this.kHACHSANDataSet.KhuyenMai);
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            ngayApDungDateEdit.DateTime = DateTime.Now;
            ngayApDungDateEdit.Properties.MinValue = DateTime.Now;
            ngayKetThucDateEdit.Properties.MinValue = ngayApDungDateEdit.DateTime.AddDays(1);


        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri1 = khuyenMaiBindingSource.Position;
            khuyenMaiBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            khuyenMaiGridControl.Enabled = false;
            groupBox3.Enabled = true;
            btnChiTiet.Enabled = false;
            mAKhuyenMaiTextEdit2.Enabled = true;
            ngayApDungDateEdit.DateTime = DateTime.Now;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAKhuyenMaiTextEdit2.Enabled == true)
            {
                if (mAKhuyenMaiTextEdit2.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu thuê không được thiếu!", "", MessageBoxButtons.OK);
                    maKhuyenMaiTextEdit.Focus();
                    return;
                }
                else
                {
                    mAKhuyenMaiTextEdit2.Text = mAKhuyenMaiTextEdit2.Text.ToUpper();
                }
                tenKhuyenMaiTextEdit.Text = DataUtil.xoaKhoangTrang(tenKhuyenMaiTextEdit.Text);
                if (tenKhuyenMaiTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("khuyến mãi không được trống!", "", MessageBoxButtons.OK);
                    tenKhuyenMaiTextEdit.Focus();
                    return;
                }
                if (ngayApDungDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày áp dụng không được trống!", "", MessageBoxButtons.OK);
                    ngayApDungDateEdit.Focus();
                    return;
                }
                if (ngayKetThucDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày kết thúc không được trống!", "", MessageBoxButtons.OK);
                    ngayKetThucDateEdit.Focus();
                    return;
                }
                try
                {
                   
                    DataRowView drv = (DataRowView)khuyenMaiBindingSource.Current;

                    khuyenMaiBindingSource.EndEdit();
                    khuyenMaiBindingSource.ResetCurrentItem();
                    this.khuyenMaiTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.khuyenMaiTableAdapter.Update(this.kHACHSANDataSet.KhuyenMai);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khuyến mãi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mAKhuyenMaiTextEdit2.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phiếu thuê không được thiếu!", "", MessageBoxButtons.OK);
                    mAKhuyenMaiTextEdit2.Focus();
                    return;
                }
                else
                {
                    mAKhuyenMaiTextEdit2.Text = mAKhuyenMaiTextEdit2.Text.ToUpper();
                }
                tenKhuyenMaiTextEdit.Text = DataUtil.xoaKhoangTrang(tenKhuyenMaiTextEdit.Text);
                if (tenKhuyenMaiTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("khuyến mãi không được trống!", "", MessageBoxButtons.OK);
                    tenKhuyenMaiTextEdit.Focus();
                    return;
                }
                if (ngayApDungDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày áp dụng không được trống!", "", MessageBoxButtons.OK);
                    ngayApDungDateEdit.Focus();
                    return;
                }
                if (ngayKetThucDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày kết thúc không được trống!", "", MessageBoxButtons.OK);
                    ngayKetThucDateEdit.Focus();
                    return;
                }
                try
                {
                    khuyenMaiBindingSource.EndEdit();
                    khuyenMaiBindingSource.ResetCurrentItem();
                    this.khuyenMaiTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.khuyenMaiTableAdapter.Update(this.kHACHSANDataSet.KhuyenMai);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            btnChiTiet.Enabled = true;
            khuyenMaiGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnChiTiet.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnChiTiet.Enabled = true;
            groupBox3.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri1 = khuyenMaiBindingSource.Position;
            groupBox3.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = btnChiTiet.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            khuyenMaiGridControl.Enabled = false;
            mAKhuyenMaiTextEdit2.Enabled = false;


        }
        private void updatetable()
        {
            this.kIEUPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kIEUPHONGTableAdapter.Update(this.kHACHSANDataSet.KIEUPHONG);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (khuyenMaiBindingSource.Count > 0)
            {
                if (cTKM_HANGPHONGBindingSource.Count == 0 && cTKM_DICHVUBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)khuyenMaiBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa khuyến mãi có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlResult == DialogResult.OK)
                    {                      
                        khuyenMaiBindingSource.RemoveCurrent();
                        khuyenMaiBindingSource.EndEdit();
                        updatekhuyenmai();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện thao tác xóa!");

                }
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");

            }
        }

        private void updatekhuyenmai()
        {
            try
            {
                this.khuyenMaiTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.khuyenMaiTableAdapter.Update(this.kHACHSANDataSet.KhuyenMai);
            }
            catch
            {

            }
        }
        private void updatekMhangphong()
        {
            try
            {
                this.cTKM_HANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.cTKM_HANGPHONGTableAdapter.Update(this.kHACHSANDataSet.CTKM_HANGPHONG);
            }
            catch
            {

            }
        }
        private void updatekmdichvu()
        {
            try
            {
                this.cTKM_DICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.cTKM_DICHVUTableAdapter.Update(this.kHACHSANDataSet.CTKM_DICHVU);
            }
            catch
            {

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.cTKM_HANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.cTKM_DICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.khuyenMaiTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
                this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
                this.cTKM_HANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.CTKM_HANGPHONG);
                this.cTKM_DICHVUTableAdapter.Fill(this.kHACHSANDataSet.CTKM_DICHVU);
                this.khuyenMaiTableAdapter.Fill(this.kHACHSANDataSet.KhuyenMai);
                this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        

        private void kIEUPHONGGridControl_ControlAdded(object sender, ControlEventArgs e)
        {
            DataTable dt = new DataTable();
            //  dtUNDOKIEUPHONG.Push(dt);

        }


        private void kIEUPHONGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kIEUPHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);


        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khuyenMaiBindingSource.CancelEdit();
            if (btnThem.Enabled == false) khuyenMaiBindingSource.Position = vitri1;
            khuyenMaiGridControl.Enabled = true;
            groupBox3.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnChiTiet.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void giamGiaSpinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            panel1.Visible = btnQuayLai.Visible = false;
            panel6.Visible = btnChiTiet.Visible = true;
            buttonbar_start();

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (khuyenMaiBindingSource.Count > 0)
            {

                panel1.Visible = btnQuayLai.Visible = true;
                panel6.Visible = btnChiTiet.Visible = false;
                buttonbar_end();
            }
            else
            {
                MessageBox.Show("Không tồn tại khuyến mãi");

            }
        }

        private void ngayKetThucDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ngayApDungDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            ngayKetThucDateEdit.Properties.MinValue = ngayApDungDateEdit.DateTime.AddDays(1);
            ngayKetThucDateEdit.DateTime = ngayApDungDateEdit.DateTime.AddDays(1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            vitri2 = cTKM_HANGPHONGBindingSource.Position;
            cTKM_HANGPHONGBindingSource.AddNew();
            button1.Enabled = button2.Enabled = button3.Enabled  = false;
            button4.Enabled = button5.Enabled = true;
            cTKM_HANGPHONGGridControl.Enabled = false;
            groupBox1.Enabled = true;
            btnQuayLai.Enabled = false;
            giamGiaSpinEdit.Value = 0;
            maHangPhongComboBox.Enabled = true;
        }

        private void buttonbar_end()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = false;
            button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = false;
        }

        private void buttonbar_start()
        {
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            vitri2 = cTKM_HANGPHONGBindingSource.Position;
            button1.Enabled = button2.Enabled = button3.Enabled = false;
            button4.Enabled = button5.Enabled = true;
            cTKM_HANGPHONGGridControl.Enabled = false;
            groupBox1.Enabled = true;
            btnQuayLai.Enabled = false;
            maHangPhongComboBox.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cTKM_HANGPHONGBindingSource.Count > 0)
            {
               
                    DataRowView drv = (DataRowView)cTKM_HANGPHONGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa chi tiết khuyến mãi có mã hàng phòng là "+drv[1] +" ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlResult == DialogResult.OK)
                    {
                        cTKM_HANGPHONGBindingSource.RemoveCurrent();
                        cTKM_HANGPHONGBindingSource.EndEdit();
                        updatekMhangphong();
                    }
                
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cTKM_HANGPHONGBindingSource.CancelEdit();
            if (button1.Enabled == false) cTKM_HANGPHONGBindingSource.Position = vitri2;
            cTKM_HANGPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            button2.Enabled = button3.Enabled = button1.Enabled = true;
            button4.Enabled = button5.Enabled = false;
            btnQuayLai.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (maHangPhongComboBox.Enabled == true)
            {
                if (maHangPhongComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã hạng phòng không được thiếu!", "", MessageBoxButtons.OK);
                    maHangPhongComboBox.Focus();
                    return;
                }
                if(giamGiaSpinEdit.Value<=0|| giamGiaSpinEdit.Value>100||giamGiaSpinEdit.Value==null)
                {
                    MessageBox.Show("Giảm giá không hợp lệ!", "", MessageBoxButtons.OK);
                    giamGiaSpinEdit.Focus();
                    return;
                }
         
                try
                {

                    DataRowView drv = (DataRowView)cTKM_HANGPHONGBindingSource.Current;
                    cTKM_HANGPHONGBindingSource.EndEdit();
                    cTKM_HANGPHONGBindingSource.ResetCurrentItem();
                    this.cTKM_HANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.cTKM_HANGPHONGTableAdapter.Update(this.kHACHSANDataSet.CTKM_HANGPHONG);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khuyến mãi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (maHangPhongComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã hạng phòng không được thiếu!", "", MessageBoxButtons.OK);
                    maHangPhongComboBox.Focus();
                    return;
                }
                if (giamGiaSpinEdit.Value <= 0 || giamGiaSpinEdit.Value > 100 || giamGiaSpinEdit.Value == null)
                {
                    MessageBox.Show("Giảm giá không hợp lệ!", "", MessageBoxButtons.OK);
                    giamGiaSpinEdit.Focus();
                    return;
                }
                try
                {
                    DataRowView drv = (DataRowView)cTKM_HANGPHONGBindingSource.Current;
                    cTKM_HANGPHONGBindingSource.EndEdit();
                    cTKM_HANGPHONGBindingSource.ResetCurrentItem();
                    this.cTKM_HANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.cTKM_HANGPHONGTableAdapter.Update(this.kHACHSANDataSet.CTKM_HANGPHONG);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            btnQuayLai.Enabled = true;
            cTKM_HANGPHONGGridControl.Enabled = true;
            button1.Enabled = button2.Enabled = button3.Enabled =true;
            button5.Enabled = button4.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vitri3 = cTKM_DICHVUBindingSource.Position;
            cTKM_DICHVUBindingSource.AddNew();
            button8.Enabled = button9.Enabled = button10.Enabled = false;
            button6.Enabled = button7.Enabled= true;
            cTKM_DICHVUGridControl.Enabled = false;
            groupBox2.Enabled = true;
            btnQuayLai.Enabled = false;
            giamGiaSpinEdit1.Value = 0;
            maDichVuComboBox.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vitri3 = cTKM_DICHVUBindingSource.Position;
            button8.Enabled = button9.Enabled = button10.Enabled = false;
            button6.Enabled = button7.Enabled = true;
            cTKM_DICHVUGridControl.Enabled = false;
            groupBox2.Enabled = true;
            btnQuayLai.Enabled = false;
            maDichVuComboBox.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cTKM_DICHVUBindingSource.Count > 0)
            {

                DataRowView drv = (DataRowView)cTKM_DICHVUBindingSource.Current;
                DialogResult dlResult = MessageBox.Show("Bạn muốn xóa chi tiết khuyến mãi có mã dịch vụ là " + drv[1] + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlResult == DialogResult.OK)
                {
                    cTKM_DICHVUBindingSource.RemoveCurrent();
                    cTKM_DICHVUBindingSource.EndEdit();
                    updatekmdichvu();
                }

            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cTKM_DICHVUBindingSource.CancelEdit();
            if (button8.Enabled == false) cTKM_DICHVUBindingSource.Position = vitri3;
            cTKM_DICHVUGridControl.Enabled = true;
            groupBox2.Enabled = false;
            button8.Enabled = button9.Enabled = button10.Enabled = true;
            button7.Enabled = button6.Enabled = false;
            btnQuayLai.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (maDichVuComboBox.Enabled == true)
            {
                if (maDichVuComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    maHangPhongComboBox.Focus();
                    return;
                }
                if (giamGiaSpinEdit1.Value <= 0 || giamGiaSpinEdit1.Value > 100 || giamGiaSpinEdit1.Value == null)
                {
                    MessageBox.Show("Giảm giá không hợp lệ!", "", MessageBoxButtons.OK);
                    giamGiaSpinEdit1.Focus();
                    return;
                }

                try
                {

                    DataRowView drv = (DataRowView)cTKM_DICHVUBindingSource.Current;
                    cTKM_DICHVUBindingSource.EndEdit();
                    cTKM_DICHVUBindingSource.ResetCurrentItem();
                    this.cTKM_DICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.cTKM_DICHVUTableAdapter.Update(this.kHACHSANDataSet.CTKM_DICHVU);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khuyến mãi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (maDichVuComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    maHangPhongComboBox.Focus();
                    return;
                }
                if (giamGiaSpinEdit1.Value <= 0 || giamGiaSpinEdit1.Value > 100 || giamGiaSpinEdit1.Value == null)
                {
                    MessageBox.Show("Giảm giá không hợp lệ!", "", MessageBoxButtons.OK);
                    giamGiaSpinEdit1.Focus();
                    return;
                }
                try
                {

                    DataRowView drv = (DataRowView)cTKM_DICHVUBindingSource.Current;
                    cTKM_DICHVUBindingSource.EndEdit();
                    cTKM_DICHVUBindingSource.ResetCurrentItem();
                    this.cTKM_DICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.cTKM_DICHVUTableAdapter.Update(this.kHACHSANDataSet.CTKM_DICHVU);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khuyến mãi.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }          
            button8.Enabled = button9.Enabled = button10.Enabled = true;
            button6.Enabled = button7.Enabled = false;
            cTKM_DICHVUGridControl.Enabled = true;
            groupBox2.Enabled = false;
            btnQuayLai.Enabled = true;
        }

        private void mAKhuyenMaiTextEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void mAKhuyenMaiTextEdit2_Leave(object sender, EventArgs e)
        {
            mAKhuyenMaiTextEdit2.Text = DataUtil.xoaKhoangTrang(mAKhuyenMaiTextEdit2.Text);
            if (mAKhuyenMaiTextEdit2.Text.Trim() == "")
            {
                MessageBox.Show("Mã khuyến mãi không được để trống");
                mAKhuyenMaiTextEdit2.Focus();
            }
            else
            {
                mAKhuyenMaiTextEdit2.Text = mAKhuyenMaiTextEdit2.Text.ToUpper();

            }
        }

        private void tenKhuyenMaiTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void tenKhuyenMaiTextEdit_Leave(object sender, EventArgs e)
        {
            tenKhuyenMaiTextEdit.Text = DataUtil.xoaKhoangTrang(tenKhuyenMaiTextEdit.Text);
            if (tenKhuyenMaiTextEdit.Text == "")
            {
                MessageBox.Show("Khuyến mãi không được để trống");
                tenKhuyenMaiTextEdit.Focus();
            }
        }

        private void giamGiaSpinEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void giamGiaSpinEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void FormKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
        {
            String sqlCmd = "select a1.MAKhuyenMai from ( select MAKhuyenMai from KhuyenMai except select MaKhuyenMai from CTKM_DICHVU ) as a1 ,( select MAKhuyenMai from KhuyenMai except select MaKhuyenMai from CTKM_HANGPHONG ) as a2 where a1.MAKhuyenMai = a2.MAKhuyenMai";
            DataTable da = DataUtil.ExecSqlDataTable(sqlCmd, DataUtil.connstr);

            if (da.Rows.Count > 0)
            {
                MessageBox.Show("Có " + da.Rows.Count + " khuyến mãi chưa có chi tiết khuyến mãi, Hãy thêm chi tiết cho khuyến mãi hoặc xóa khuyến mãi rồi đóng form ", "Xác nhận");
                e.Cancel = true;
            }
        }
    }
}
