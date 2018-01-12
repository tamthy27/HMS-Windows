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
    public partial class FormGiaPhong : Form
    {
        public static DataTable dtREDOGIAPHONG = new DataTable();
        public static DataTable dtUNDOGIAPHONG = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormGiaPhong()
        {
            InitializeComponent();
            if (dtUNDOGIAPHONG.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOGIAPHONG.Columns.Add("MAHANGPHONG", typeof(string));
                dtUNDOGIAPHONG.Columns.Add("NgayApDung", typeof(DateTime));
                dtUNDOGIAPHONG.Columns.Add("GiaHangPhong", typeof(Double));
                dtUNDOGIAPHONG.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOGIAPHONG.Columns.Add("MAGIAPHONG", typeof(string));
                dtREDOGIAPHONG.Columns.Add("NgayApDung", typeof(DateTime));
                dtREDOGIAPHONG.Columns.Add("GiaHangPhong", typeof(Double));
                dtREDOGIAPHONG.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
            groupBox1.Enabled = false;

        }
        private void FormGiaPhong_Load(object sender, EventArgs e)
        {
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.HANGPHONG' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            this.gIAPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.PHONG' table. You can move, or remove it, as needed.
            this.gIAPHONGTableAdapter.Fill(this.kHACHSANDataSet.GIAPHONG);
            if (gIAPHONGBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }
        private void updatetable()
        {
            this.gIAPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.gIAPHONGTableAdapter.Update(this.kHACHSANDataSet.GIAPHONG);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = gIAPHONGBindingSource.Position;
            gIAPHONGBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gIAPHONGGridControl.Enabled = false;
            mAHangPhongComboBox.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
            ngayApDungDateEdit.Properties.MinValue = DateTime.Today;
            mAHangPhongComboBox.SelectedIndex = 0;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAHangPhongComboBox.Enabled == true)
            {
                if (mAHangPhongComboBox.Text.Trim() == "")
                {
                    MessageBox.Show("Hạng phòng không được trống!", "", MessageBoxButtons.OK);
                    mAHangPhongComboBox.Focus();
                    return;
                }
                if (ngayApDungDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày áp dụng không được trống!", "", MessageBoxButtons.OK);
                    ngayApDungDateEdit.Focus();
                    return;
                }
                if (giaHangPhongSpinEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Giá không được thiếu!", "", MessageBoxButtons.OK);
                    giaHangPhongSpinEdit.Focus();
                    return;
                }
                try
                {
                    dtUNDOGIAPHONG.RejectChanges();
                    DataRowView drv = (DataRowView)gIAPHONGBindingSource.Current;
                    dtUNDOGIAPHONG.NewRow();
                    dtUNDOGIAPHONG.Rows.Add(drv.Row[0].ToString(), Convert.ToDateTime(ngayApDungDateEdit.DateTime), Convert.ToDouble(giaHangPhongSpinEdit.Value), Action);
                    dtUNDOGIAPHONG.AcceptChanges();
                    drv[0] = mAHangPhongComboBox.SelectedValue;
                    drv[1] = ngayApDungDateEdit.DateTime;
                    drv[2] = giaHangPhongSpinEdit.Value;
                    gIAPHONGBindingSource.EndEdit();
                    gIAPHONGBindingSource.ResetCurrentItem();
                    this.gIAPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.gIAPHONGTableAdapter.Update(this.kHACHSANDataSet.GIAPHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Giá Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mAHangPhongComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Hạng phòng không được trống!", "", MessageBoxButtons.OK);
                    mAHangPhongComboBox.Focus();
                    return;
                }
                if (ngayApDungDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày áp dụng không được trống!", "", MessageBoxButtons.OK);
                    ngayApDungDateEdit.Focus();
                    return;
                }
                if (giaHangPhongSpinEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Giá không được thiếu!", "", MessageBoxButtons.OK);
                    giaHangPhongSpinEdit.Focus();
                    return;
                }
                try
                {
                    DataRowView drv = (DataRowView)gIAPHONGBindingSource.Current;
                    drv[0] = mAHangPhongComboBox.SelectedValue;
                    gIAPHONGBindingSource.EndEdit();
                    gIAPHONGBindingSource.ResetCurrentItem();
                    this.gIAPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.gIAPHONGTableAdapter.Update(this.kHACHSANDataSet.GIAPHONG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Giá Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOGIAPHONG.Rows.RemoveAt(dtUNDOGIAPHONG.Rows.Count - 1);
                    return;
                }
            }
            gIAPHONGGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gIAPHONGBindingSource.Count > 0)
            {
                if (ngayApDungDateEdit.DateTime >= DateTime.Today)
                {
                    Action = "UPDATE";
                    dtUNDOGIAPHONG.RejectChanges();
                    DataRowView drv = (DataRowView)gIAPHONGBindingSource.Current;
                    dtUNDOGIAPHONG.NewRow();
                    dtUNDOGIAPHONG.Rows.Add(drv.Row[0].ToString(), Convert.ToDateTime(ngayApDungDateEdit.DateTime), Convert.ToDouble(giaHangPhongSpinEdit.Value), Action);
                    dtUNDOGIAPHONG.AcceptChanges();
                    vitri = gIAPHONGBindingSource.Position;
                    groupBox1.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                    btnGhi.Enabled = btnHuy.Enabled = true;
                    mAHangPhongComboBox.Enabled = false;
                    gIAPHONGGridControl.Enabled = false;
                    dtUNDOGIAPHONG.RejectChanges();
                    ngayApDungDateEdit.Properties.MinValue = DateTime.Today;

                }
                else
                {
                    MessageBox.Show("Không thao tác với dữ liệu trong quá khứ!");

                }
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gIAPHONGBindingSource.Count > 0)
            {
                if (ngayApDungDateEdit.DateTime >= DateTime.Today)
                {
                    DataRowView drv = (DataRowView)gIAPHONGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa giá phòng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOGIAPHONG.NewRow();
                        dtUNDOGIAPHONG.Rows.Add(drv.Row[0].ToString(), Convert.ToDateTime(ngayApDungDateEdit.DateTime), Convert.ToDouble(giaHangPhongSpinEdit.Value), Action);
                        dtUNDOGIAPHONG.AcceptChanges();
                        gIAPHONGBindingSource.RemoveCurrent();
                        updatetable();
                        btnUndo.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Không thao tác với dữ liệu trong quá khứ!");

                }
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtUNDOGIAPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOGIAPHONG.Rows[dtUNDOGIAPHONG.Rows.Count - 1];
                String temp = dr[3].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM GIAPHONG WHERE MAHangPhong ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIAPHONG.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIAPHONG.Rows.Find(findTheseVals);
                            kHACHSANDataSet.GIAPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.GIAPHONG.AcceptChanges();
                            dtREDOGIAPHONG.RejectChanges();
                            dtREDOGIAPHONG.NewRow();
                            dtREDOGIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "INSERT");
                            dtREDOGIAPHONG.AcceptChanges();
                            dtUNDOGIAPHONG.RejectChanges();
                            dtUNDOGIAPHONG.Rows.RemoveAt(dtUNDOGIAPHONG.Rows.Count - 1);
                            dtUNDOGIAPHONG.AcceptChanges();
                            gIAPHONGBindingSource.EndEdit();
                            updatetable();
                        }

                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                else if (temp.Equals("UPDATE"))
                {
                    try
                    {
                        string sql = "UPDATE GIAPHONG SET GIAHANGPHONG  = " + dr[2].ToString() + " WHERE MAHangPhong ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIAPHONG.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIAPHONG.Rows.Find(findTheseVals);
                            dtREDOGIAPHONG.RejectChanges();
                            dtREDOGIAPHONG.NewRow();
                            dtREDOGIAPHONG.Rows.Add(dr[0].ToString(), dt[1].ToString(), Convert.ToDouble(dt[2]), "UPDATE");
                            dtREDOGIAPHONG.AcceptChanges();
                            dt[2] = dr[2];
                            kHACHSANDataSet.GIAPHONG.AcceptChanges();
                            dtUNDOGIAPHONG.RejectChanges();
                            dtUNDOGIAPHONG.Rows.RemoveAt(dtUNDOGIAPHONG.Rows.Count - 1);
                            dtUNDOGIAPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                else if (temp.Equals("INSERT"))
                {
                    try
                    {
                        string sql = "Insert into GIAPHONG ([MAHANGPHONG],[NgayAPdung],[GIAHANGPHONG])VALUES ('" + dr[0].ToString() + "','" + dr[1].ToString() + "'," + dr[2].ToString() + ")";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIAPHONG.RejectChanges();
                            kHACHSANDataSet.GIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]));
                            kHACHSANDataSet.GIAPHONG.AcceptChanges();
                            dtREDOGIAPHONG.RejectChanges();
                            dtREDOGIAPHONG.NewRow();
                            dtREDOGIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "DELETE");
                            dtREDOGIAPHONG.AcceptChanges();
                            dtUNDOGIAPHONG.RejectChanges();
                            dtUNDOGIAPHONG.Rows.RemoveAt(dtUNDOGIAPHONG.Rows.Count - 1);
                            dtUNDOGIAPHONG.AcceptChanges();
                            gIAPHONGBindingSource.EndEdit();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) gIAPHONGBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOGIAPHONG.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            gIAPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
                this.gIAPHONGTableAdapter.Fill(this.kHACHSANDataSet.GIAPHONG);
                dtREDOGIAPHONG.Clear();
                dtUNDOGIAPHONG.Clear();
                btnRedo.Enabled = btnUndo.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (dtREDOGIAPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOGIAPHONG.Rows[dtREDOGIAPHONG.Rows.Count - 1];
                String temp = dr[3].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM GIAPHONG WHERE MAHangPhong ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIAPHONG.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIAPHONG.Rows.Find(findTheseVals);
                            kHACHSANDataSet.GIAPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.GIAPHONG.AcceptChanges();
                            dtUNDOGIAPHONG.RejectChanges();
                            dtUNDOGIAPHONG.NewRow();
                            dtUNDOGIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "INSERT");
                            dtUNDOGIAPHONG.AcceptChanges();
                            dtREDOGIAPHONG.RejectChanges();
                            dtREDOGIAPHONG.Rows.RemoveAt(dtREDOGIAPHONG.Rows.Count - 1);
                            dtREDOGIAPHONG.AcceptChanges();
                            gIAPHONGBindingSource.EndEdit();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                else if (temp.Equals("UPDATE"))
                {
                    try
                    {
                        string sql = "UPDATE GIAPHONG SET GIAHANGPHONG  = " + dr[2].ToString() + "WHERE MAHangPhong ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIAPHONG.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIAPHONG.Rows.Find(findTheseVals);
                            dtUNDOGIAPHONG.RejectChanges();
                            dtUNDOGIAPHONG.NewRow();
                            dtUNDOGIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dt[2]), "UPDATE");
                            dtUNDOGIAPHONG.AcceptChanges();
                            dt[2] = dr[2];
                            kHACHSANDataSet.GIAPHONG.AcceptChanges();
                            dtREDOGIAPHONG.RejectChanges();
                            dtREDOGIAPHONG.Rows.RemoveAt(dtREDOGIAPHONG.Rows.Count - 1);
                            dtREDOGIAPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                else if (temp.Equals("INSERT"))
                {
                    try
                    {
                        string sql = "Insert into GIAPHONG ([MAHANGPHONG],[NgayAPdung],[GIAHANGPHONG])VALUES ('" + dr[0].ToString() + "','" + dr[1].ToString() + "'," + dr[2].ToString() + ")";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIAPHONG.RejectChanges();
                            kHACHSANDataSet.GIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]));
                            kHACHSANDataSet.GIAPHONG.AcceptChanges();
                            dtUNDOGIAPHONG.RejectChanges();
                            dtUNDOGIAPHONG.NewRow();
                            dtUNDOGIAPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "DELETE");
                            dtUNDOGIAPHONG.AcceptChanges();
                            dtREDOGIAPHONG.RejectChanges();
                            dtREDOGIAPHONG.Rows.RemoveAt(dtREDOGIAPHONG.Rows.Count - 1);
                            dtREDOGIAPHONG.AcceptChanges();
                            gIAPHONGBindingSource.EndEdit();
                            gIAPHONGBindingSource.ResetCurrentItem();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) gIAPHONGBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOGIAPHONG.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            gIAPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAHangPhongComboBox.Enabled == false)
            {
                dtUNDOGIAPHONG.RejectChanges();
                dtUNDOGIAPHONG.Rows.RemoveAt(dtUNDOGIAPHONG.Rows.Count - 1);
                dtUNDOGIAPHONG.AcceptChanges();
            }
            gIAPHONGBindingSource.CancelEdit();
            if (btnThem.Enabled == false) gIAPHONGBindingSource.Position = vitri;
            gIAPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void giaHangPhongSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (giaHangPhongSpinEdit.Value < 0)
            {
                giaHangPhongSpinEdit.Value = 0;
            }
        }

        private void mAHangPhongComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void giaHangPhongSpinEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
