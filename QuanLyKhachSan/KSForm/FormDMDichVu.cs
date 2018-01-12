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
    public partial class FormDMDichVu : Form
    {
        public static DataTable dtREDODICHVU = new DataTable();
        public static DataTable dtUNDODICHVU = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormDMDichVu()
        {
            InitializeComponent();
            if (dtUNDODICHVU.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDODICHVU.Columns.Add("MADichVu", typeof(string));
                dtUNDODICHVU.Columns.Add("TenDichVu", typeof(string));
                dtUNDODICHVU.Columns.Add("MALoaiDichVu", typeof(string));
                dtUNDODICHVU.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDODICHVU.Columns.Add("MADichVu", typeof(string));
                dtREDODICHVU.Columns.Add("TenDichVu", typeof(string));
                dtREDODICHVU.Columns.Add("MALoaiDichVu", typeof(string));
                dtREDODICHVU.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;

        }

        private void dICHVUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dICHVUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormDichVu_Load(object sender, EventArgs e)
        {
            this.cTKM_DICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTKM_DICHVU' table. You can move, or remove it, as needed.
            this.cTKM_DICHVUTableAdapter.Fill(this.kHACHSANDataSet.CTKM_DICHVU);
            this.kHSDDVTableAdapter.Connection.ConnectionString = DataUtil.connstr;


            this.gIADICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.KHSDDV' table. You can move, or remove it, as needed.
            this.kHSDDVTableAdapter.Fill(this.kHACHSANDataSet.KHSDDV);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.KhuyenMai' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'kHACHSANDataSet.GIADICHVU' table. You can move, or remove it, as needed.
            this.gIADICHVUTableAdapter.Fill(this.kHACHSANDataSet.GIADICHVU);
            this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIDICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.LOAIDICHVU' table. You can move, or remove it, as needed.
            this.lOAIDICHVUTableAdapter.Fill(this.kHACHSANDataSet.LOAIDICHVU);

            // TODO: This line of code loads data into the 'kHACHSANDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
            if (dICHVUBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }
        private void updatetable()
        {
            this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.dICHVUTableAdapter.Update(this.kHACHSANDataSet.DICHVU);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = dICHVUBindingSource.Position;
            dICHVUBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            dICHVUGridControl.Enabled = false;
            mADichVuTextEdit.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
            mALoaiDichVuComboBox.SelectedIndex = 0;
            mADichVuTextEdit.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mADichVuTextEdit.Enabled == true)
            {
                if (mALoaiDichVuComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Loại dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiDichVuComboBox.Focus();
                    return;
                }

                if (mADichVuTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mADichVuTextEdit.Focus();
                    return;
                }

                else
                {
                    mADichVuTextEdit.Text = mADichVuTextEdit.Text.ToUpper();
                }
                if (tenDichVuTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Dịch vụ không được trống!", "", MessageBoxButtons.OK);
                    tenDichVuTextEdit.Focus();
                    return;
                }

                try
                {
                    dtUNDODICHVU.RejectChanges();
                    DataRowView drv = (DataRowView)dICHVUBindingSource.Current;
                    drv[2] = mALoaiDichVuComboBox.SelectedValue;
                    dtUNDODICHVU.NewRow();
                    dtUNDODICHVU.Rows.Add(drv.Row[0].ToString(), tenDichVuTextEdit.Text.Trim(), mALoaiDichVuComboBox.SelectedValue, Action);
                    dtUNDODICHVU.AcceptChanges();
                    dICHVUBindingSource.EndEdit();
                    dICHVUBindingSource.ResetCurrentItem();
                    this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.dICHVUTableAdapter.Update(this.kHACHSANDataSet.DICHVU);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Dịch Vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mALoaiDichVuComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Loại dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiDichVuComboBox.Focus();
                    return;
                }
                if (mADichVuTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mADichVuTextEdit.Focus();
                    return;
                }
                if (tenDichVuTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Dịch vụ không được trống!", "", MessageBoxButtons.OK);
                    tenDichVuTextEdit.Focus();
                    return;
                }
                try
                {
                    DataRowView drv = (DataRowView)dICHVUBindingSource.Current;
                    drv[2] = mALoaiDichVuComboBox.SelectedValue;
                    dICHVUBindingSource.EndEdit();
                    dICHVUBindingSource.ResetCurrentItem();
                    this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.dICHVUTableAdapter.Update(this.kHACHSANDataSet.DICHVU);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi dịch vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDODICHVU.Rows.RemoveAt(dtUNDODICHVU.Rows.Count - 1);
                    return;
                }
            }
            dICHVUGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dICHVUBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDODICHVU.RejectChanges();
                DataRowView drv = (DataRowView)dICHVUBindingSource.Current;
                dtUNDODICHVU.NewRow();
                dtUNDODICHVU.Rows.Add(drv.Row[0].ToString(), drv.Row[1].ToString(), mALoaiDichVuComboBox.SelectedValue, Action);
                dtUNDODICHVU.AcceptChanges();
                vitri = dICHVUBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                mADichVuTextEdit.Enabled = false;
                dICHVUGridControl.Enabled = false;
                dtUNDODICHVU.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dICHVUBindingSource.Count > 0)
            {
                if (gIADICHVUBindingSource.Count==0&&kHSDDVBindingSource.Count==0&&cTKM_DICHVUBindingSource.Count==0)
                {
                    DataRowView drv = (DataRowView)dICHVUBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa dịch vụ có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDODICHVU.NewRow();
                        dtUNDODICHVU.Rows.Add(drv.Row[0].ToString(), drv.Row[1].ToString(), drv.Row[2].ToString(), Action);
                        dtUNDODICHVU.AcceptChanges();
                        dICHVUBindingSource.RemoveCurrent();
                        updatetable();
                        btnUndo.Enabled = true;
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

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtUNDODICHVU.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDODICHVU.Rows[dtUNDODICHVU.Rows.Count - 1];
                String temp = dr[3].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM DICHVU WHERE MAdichvu ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.DICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.DICHVU.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.DICHVU.Rows.Remove(dt);
                            kHACHSANDataSet.DICHVU.AcceptChanges();
                            dtREDODICHVU.RejectChanges();
                            dtREDODICHVU.NewRow();
                            dtREDODICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "INSERT");
                            dtREDODICHVU.AcceptChanges();
                            dtUNDODICHVU.RejectChanges();
                            dtUNDODICHVU.Rows.RemoveAt(dtUNDODICHVU.Rows.Count - 1);
                            dtUNDODICHVU.AcceptChanges();
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
                        string sql = "UPDATE DICHVU SET madichvu ='" + dr[0].ToString() + "',tendichvu =N'" + dr[1].ToString() + "',maloaidichvu ='" + dr[2].ToString() + "' WHERE madichvu ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.DICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.DICHVU.Rows.Find(dr[0].ToString());
                            dtREDODICHVU.RejectChanges();
                            dtREDODICHVU.NewRow();
                            dtREDODICHVU.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), "UPDATE");
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            kHACHSANDataSet.DICHVU.AcceptChanges(); dtREDODICHVU.AcceptChanges();
                            dtUNDODICHVU.RejectChanges();
                            dtUNDODICHVU.Rows.RemoveAt(dtUNDODICHVU.Rows.Count - 1);
                            dtUNDODICHVU.AcceptChanges();
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
                        string sql = "INSERT INTO [DICHVU]([MAdichvu],[TenDichVu],[MAloaidichvu])VALUES('" + dr[0].ToString() + "',N'" + dr[1].ToString() + "','" + dr[2].ToString() + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.DICHVU.RejectChanges();
                            kHACHSANDataSet.DICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.DICHVU.AcceptChanges();
                            dtREDODICHVU.RejectChanges();
                            dtREDODICHVU.NewRow();
                            dtREDODICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "DELETE");
                            dtREDODICHVU.AcceptChanges();
                            dtUNDODICHVU.RejectChanges();
                            dtUNDODICHVU.Rows.RemoveAt(dtUNDODICHVU.Rows.Count - 1);
                            dtUNDODICHVU.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) dICHVUBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDODICHVU.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            dICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'kHACHSANDataSet.LOAIDICHVU' table. You can move, or remove it, as needed.
                this.lOAIDICHVUTableAdapter.Fill(this.kHACHSANDataSet.LOAIDICHVU);

                // TODO: This line of code loads data into the 'kHACHSANDataSet.DICHVU' table. You can move, or remove it, as needed.
                this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
                dtREDODICHVU.Clear();
                dtUNDODICHVU.Clear();
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
            if (dtREDODICHVU.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDODICHVU.Rows[dtREDODICHVU.Rows.Count - 1];
                String temp = dr[3].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM DICHVU WHERE MAdichvu ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.DICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.DICHVU.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.DICHVU.Rows.Remove(dt);
                            kHACHSANDataSet.DICHVU.AcceptChanges();
                            dtUNDODICHVU.RejectChanges();
                            dtUNDODICHVU.NewRow();
                            dtUNDODICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "INSERT");
                            dtUNDODICHVU.AcceptChanges();
                            dtREDODICHVU.RejectChanges();
                            dtREDODICHVU.Rows.RemoveAt(dtREDODICHVU.Rows.Count - 1);
                            dtREDODICHVU.AcceptChanges();
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
                        string sql = "UPDATE DICHVU SET madichvu ='" + dr[0].ToString() + "',tendichvu =N'" + dr[1].ToString() + "',maloaidichvu ='" + dr[2].ToString() + "' WHERE madichvu ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.DICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.DICHVU.Rows.Find(dr[0].ToString());
                            dtUNDODICHVU.RejectChanges();
                            dtUNDODICHVU.NewRow();
                            dtUNDODICHVU.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), "UPDATE");
                            dtUNDODICHVU.AcceptChanges();
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            kHACHSANDataSet.DICHVU.AcceptChanges();
                            dtREDODICHVU.RejectChanges();
                            dtREDODICHVU.Rows.RemoveAt(dtREDODICHVU.Rows.Count - 1);
                            dtREDODICHVU.AcceptChanges();
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
                        string sql = "INSERT INTO [DICHVU]([MAdichvu],[TenDichVu],[MAloaidichvu])VALUES('" + dr[0].ToString() + "',N'" + dr[1].ToString() + "','" + dr[2].ToString() + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.DICHVU.RejectChanges();
                            kHACHSANDataSet.DICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.DICHVU.AcceptChanges();
                            dtUNDODICHVU.RejectChanges();
                            dtUNDODICHVU.NewRow();
                            dtUNDODICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), "DELETE");
                            dtUNDODICHVU.AcceptChanges();
                            dtREDODICHVU.RejectChanges();
                            dtREDODICHVU.Rows.RemoveAt(dtREDODICHVU.Rows.Count - 1);
                            dtREDODICHVU.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) dICHVUBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDODICHVU.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            dICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }



        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mADichVuTextEdit.Enabled == false)
            {
                dtUNDODICHVU.RejectChanges();
                dtUNDODICHVU.Rows.RemoveAt(dtUNDODICHVU.Rows.Count - 1);
                dtUNDODICHVU.AcceptChanges();
            }
            dICHVUBindingSource.CancelEdit();
            if (btnThem.Enabled == false) dICHVUBindingSource.Position = vitri;
            dICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void mALoaiDichVuComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mADichVuTextEdit_Leave(object sender, EventArgs e)
        {
            if (mADichVuTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("mã dịch vụ không được trống");
                mADichVuTextEdit.Focus();
            }
            else
            {
                mADichVuTextEdit.Text = mADichVuTextEdit.Text.ToUpper();
            }
        }

        private void mADichVuTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tenDichVuTextEdit_Leave(object sender, EventArgs e)
        {
            tenDichVuTextEdit.Text = DataUtil.xoaKhoangTrang(tenDichVuTextEdit.Text);
            if (tenDichVuTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Dịch vụ không được để trống");
                tenDichVuTextEdit.Focus();
            }
        }

        private void tenDichVuTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }
    }
}
