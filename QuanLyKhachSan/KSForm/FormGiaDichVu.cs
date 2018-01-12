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
    public partial class FormGiaDichVu : Form
    {
        public static DataTable dtREDOGIADICHVU = new DataTable();
        public static DataTable dtUNDOGIADICHVU = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormGiaDichVu()
        {
            InitializeComponent();
            if (dtUNDOGIADICHVU.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOGIADICHVU.Columns.Add("MADV", typeof(string));
                dtUNDOGIADICHVU.Columns.Add("NgayApDung", typeof(DateTime));
                dtUNDOGIADICHVU.Columns.Add("GiaDichVu", typeof(Double));
                dtUNDOGIADICHVU.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOGIADICHVU.Columns.Add("MAGIADICHVU", typeof(string));
                dtREDOGIADICHVU.Columns.Add("NgayApDung", typeof(DateTime));
                dtREDOGIADICHVU.Columns.Add("GiaDichVu", typeof(Double));
                dtREDOGIADICHVU.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
            groupBox1.Enabled = false;

        }
        private void FormGiaDichVu_Load(object sender, EventArgs e)
        {
            this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
            this.gIADICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.gIADICHVUTableAdapter.Fill(this.kHACHSANDataSet.GIADICHVU);
            if (gIADICHVUBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }
        }
        private void updatetable()
        {
            this.gIADICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.gIADICHVUTableAdapter.Update(this.kHACHSANDataSet.GIADICHVU);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = gIADICHVUBindingSource.Position;
            gIADICHVUBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            gIADICHVUGridControl.Enabled = false;
            mADVComboBox.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
            mADVComboBox.SelectedIndex =0;
            ngayApDungDateEdit.Properties.MinValue = DateTime.Today;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mADVComboBox.Enabled == true)
            {
                if (mADVComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Loại dịch vụ không được trống!", "", MessageBoxButtons.OK);
                    mADVComboBox.Focus();
                    return;
                }
                if (ngayApDungDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày áp dụng không được trống!", "", MessageBoxButtons.OK);
                    ngayApDungDateEdit.Focus();
                    return;
                }
                if (giaDichVuSpinEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Giá không được thiếu!", "", MessageBoxButtons.OK);
                    giaDichVuSpinEdit.Focus();
                    return;
                }
                try
                {
                    dtUNDOGIADICHVU.RejectChanges();
                    DataRowView drv = (DataRowView)gIADICHVUBindingSource.Current;
                    dtUNDOGIADICHVU.NewRow();
                    dtUNDOGIADICHVU.Rows.Add(drv.Row[0].ToString(), Convert.ToDateTime(ngayApDungDateEdit.DateTime), Convert.ToDouble(giaDichVuSpinEdit.Value), Action);
                    dtUNDOGIADICHVU.AcceptChanges();
                    drv[0] = mADVComboBox.SelectedValue;
                    gIADICHVUBindingSource.EndEdit();
                    gIADICHVUBindingSource.ResetCurrentItem();
                    this.gIADICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.gIADICHVUTableAdapter.Update(this.kHACHSANDataSet.GIADICHVU);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Giá dịch vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mADVComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Loại dịch vụ không được trống!", "", MessageBoxButtons.OK);
                    mADVComboBox.Focus();
                    return;
                }
                if (ngayApDungDateEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Ngày áp dụng không được trống!", "", MessageBoxButtons.OK);
                    ngayApDungDateEdit.Focus();
                    return;
                }
                if (giaDichVuSpinEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Giá không được thiếu!", "", MessageBoxButtons.OK);
                    giaDichVuSpinEdit.Focus();
                    return;
                }
                try
                {
                    DataRowView drv = (DataRowView)gIADICHVUBindingSource.Current;
                    drv[0] = mADVComboBox.SelectedValue;
                    gIADICHVUBindingSource.EndEdit();
                    gIADICHVUBindingSource.ResetCurrentItem();
                    this.gIADICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.gIADICHVUTableAdapter.Update(this.kHACHSANDataSet.GIADICHVU);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Giá dịch vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOGIADICHVU.Rows.RemoveAt(dtUNDOGIADICHVU.Rows.Count - 1);
                    return;
                }
            }
            gIADICHVUGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gIADICHVUBindingSource.Count > 0)
            {
                 if ( ngayApDungDateEdit.DateTime>= DateTime.Today)
                {
                    Action = "UPDATE";
                    dtUNDOGIADICHVU.RejectChanges();
                    DataRowView drv = (DataRowView)gIADICHVUBindingSource.Current;
                    dtUNDOGIADICHVU.NewRow();
                    dtUNDOGIADICHVU.Rows.Add(drv.Row[0].ToString(), Convert.ToDateTime(ngayApDungDateEdit.DateTime), Convert.ToDouble(giaDichVuSpinEdit.Value), Action);
                    dtUNDOGIADICHVU.AcceptChanges();
                    vitri = gIADICHVUBindingSource.Position;
                    groupBox1.Enabled = true;
                    btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                    btnGhi.Enabled = btnHuy.Enabled = true;
                    mADVComboBox.Enabled = false;
                    gIADICHVUGridControl.Enabled = false;
                    dtUNDOGIADICHVU.RejectChanges();
                    ngayApDungDateEdit.Properties.MinValue = DateTime.Today;

                }
                else
                {
                    MessageBox.Show("Không sửa dữ liệu trong quá khứ !");

                }
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gIADICHVUBindingSource.Count > 0)
            {
                if (ngayApDungDateEdit.DateTime >= DateTime.Today)
                {
                    DataRowView drv = (DataRowView)gIADICHVUBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa giá phòng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOGIADICHVU.NewRow();
                        dtUNDOGIADICHVU.Rows.Add(drv.Row[0].ToString(), Convert.ToDateTime(ngayApDungDateEdit.DateTime), Convert.ToDouble(giaDichVuSpinEdit.Value), Action);
                        dtUNDOGIADICHVU.AcceptChanges();
                        gIADICHVUBindingSource.RemoveCurrent();
                        updatetable();
                        btnUndo.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Không được phép thao tác với dữ liệu trong quá khứ!");

                }
            }

            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtUNDOGIADICHVU.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOGIADICHVU.Rows[dtUNDOGIADICHVU.Rows.Count - 1];
                String temp = dr[3].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM GIADICHVU WHERE MADV ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIADICHVU.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIADICHVU.Rows.Find(findTheseVals);
                            kHACHSANDataSet.GIADICHVU.Rows.Remove(dt);
                            kHACHSANDataSet.GIADICHVU.AcceptChanges();
                            dtREDOGIADICHVU.RejectChanges();
                            dtREDOGIADICHVU.NewRow();
                            dtREDOGIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "INSERT");
                            dtREDOGIADICHVU.AcceptChanges();
                            dtUNDOGIADICHVU.RejectChanges();
                            dtUNDOGIADICHVU.Rows.RemoveAt(dtUNDOGIADICHVU.Rows.Count - 1);
                            dtUNDOGIADICHVU.AcceptChanges();
                            gIADICHVUBindingSource.EndEdit();
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
                        string sql = "UPDATE GIADICHVU SET GIADichVu  = " + dr[2].ToString() + " WHERE MADV ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIADICHVU.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIADICHVU.Rows.Find(findTheseVals);
                            dtREDOGIADICHVU.RejectChanges();
                            dtREDOGIADICHVU.NewRow();
                            dtREDOGIADICHVU.Rows.Add(dr[0].ToString(), dt[1].ToString(), Convert.ToDouble(dt[2]), "UPDATE");
                            dtREDOGIADICHVU.AcceptChanges();
                            dt[2] = dr[2];
                            kHACHSANDataSet.GIADICHVU.AcceptChanges();
                            dtUNDOGIADICHVU.RejectChanges();
                            dtUNDOGIADICHVU.Rows.RemoveAt(dtUNDOGIADICHVU.Rows.Count - 1);
                            dtUNDOGIADICHVU.AcceptChanges();
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
                        string sql = "Insert into GIADICHVU ([MADV],[NgayAPdung],[GIADichVu])VALUES ('" + dr[0].ToString() + "','" + dr[1].ToString() + "'," + dr[2].ToString() + ")";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIADICHVU.RejectChanges();
                            kHACHSANDataSet.GIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]));
                            kHACHSANDataSet.GIADICHVU.AcceptChanges();
                            dtREDOGIADICHVU.RejectChanges();
                            dtREDOGIADICHVU.NewRow();
                            dtREDOGIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "DELETE");
                            dtREDOGIADICHVU.AcceptChanges();
                            dtUNDOGIADICHVU.RejectChanges();
                            dtUNDOGIADICHVU.Rows.RemoveAt(dtUNDOGIADICHVU.Rows.Count - 1);
                            dtUNDOGIADICHVU.AcceptChanges();
                            gIADICHVUBindingSource.EndEdit();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) gIADICHVUBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOGIADICHVU.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            gIADICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
                this.gIADICHVUTableAdapter.Fill(this.kHACHSANDataSet.GIADICHVU);
                dtREDOGIADICHVU.Clear();
                dtUNDOGIADICHVU.Clear();
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
            if (dtREDOGIADICHVU.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOGIADICHVU.Rows[dtREDOGIADICHVU.Rows.Count - 1];
                String temp = dr[3].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM GIADICHVU WHERE MADV ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIADICHVU.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIADICHVU.Rows.Find(findTheseVals);
                            kHACHSANDataSet.GIADICHVU.Rows.Remove(dt);
                            kHACHSANDataSet.GIADICHVU.AcceptChanges();
                            dtUNDOGIADICHVU.RejectChanges();
                            dtUNDOGIADICHVU.NewRow();
                            dtUNDOGIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "INSERT");
                            dtUNDOGIADICHVU.AcceptChanges();
                            dtREDOGIADICHVU.RejectChanges();
                            dtREDOGIADICHVU.Rows.RemoveAt(dtREDOGIADICHVU.Rows.Count - 1);
                            dtREDOGIADICHVU.AcceptChanges();
                            gIADICHVUBindingSource.EndEdit();
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
                        string sql = "UPDATE GIADICHVU SET GIADichVu  = " + dr[2].ToString() + "WHERE MADV ='" + dr[0].ToString() + "'and NgayApDung='" + dr[1].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIADICHVU.RejectChanges();
                            object[] findTheseVals = new object[2];
                            findTheseVals[0] = dr[0].ToString();
                            findTheseVals[1] = dr[1].ToString();
                            DataRow dt = kHACHSANDataSet.GIADICHVU.Rows.Find(findTheseVals);
                            dtUNDOGIADICHVU.RejectChanges();
                            dtUNDOGIADICHVU.NewRow();
                            dtUNDOGIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dt[2]), "UPDATE");
                            dtUNDOGIADICHVU.AcceptChanges();
                            dt[2] = dr[2];
                            kHACHSANDataSet.GIADICHVU.AcceptChanges();
                            dtREDOGIADICHVU.RejectChanges();
                            dtREDOGIADICHVU.Rows.RemoveAt(dtREDOGIADICHVU.Rows.Count - 1);
                            dtREDOGIADICHVU.AcceptChanges();
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
                        string sql = "Insert into GIADICHVU ([MADV],[NgayAPdung],[GIADichVu])VALUES ('" + dr[0].ToString() + "','" + dr[1].ToString() + "'," + dr[2].ToString() + ")";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.GIADICHVU.RejectChanges();
                            kHACHSANDataSet.GIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]));
                            kHACHSANDataSet.GIADICHVU.AcceptChanges();
                            dtUNDOGIADICHVU.RejectChanges();
                            dtUNDOGIADICHVU.NewRow();
                            dtUNDOGIADICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), Convert.ToDouble(dr[2]), "DELETE");
                            dtUNDOGIADICHVU.AcceptChanges();
                            dtREDOGIADICHVU.RejectChanges();
                            dtREDOGIADICHVU.Rows.RemoveAt(dtREDOGIADICHVU.Rows.Count - 1);
                            dtREDOGIADICHVU.AcceptChanges();
                            gIADICHVUBindingSource.EndEdit();
                            gIADICHVUBindingSource.ResetCurrentItem();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) gIADICHVUBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOGIADICHVU.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            gIADICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mADVComboBox.Enabled == false)
            {
                dtUNDOGIADICHVU.RejectChanges();
                dtUNDOGIADICHVU.Rows.RemoveAt(dtUNDOGIADICHVU.Rows.Count - 1);
                dtUNDOGIADICHVU.AcceptChanges();
            }
            gIADICHVUBindingSource.CancelEdit();
            if (btnThem.Enabled == false) gIADICHVUBindingSource.Position = vitri;
            gIADICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void giaDichVuSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (giaDichVuSpinEdit.Value < 0)
            {
                giaDichVuSpinEdit.Value = 0;
            }
        }

        private void mADVComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void giaDichVuSpinEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
