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
    public partial class FormLoaiDichVu : Form
    {
        public static DataTable dtREDOLOAIDICHVU = new DataTable();
        public static DataTable dtUNDOLOAIDICHVU = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormLoaiDichVu()
        {
            InitializeComponent();
            if (dtUNDOLOAIDICHVU.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOLOAIDICHVU.Columns.Add("MALOAIDICHVU", typeof(string));
                dtUNDOLOAIDICHVU.Columns.Add("TENLOAIDICHVU", typeof(string));
                dtUNDOLOAIDICHVU.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOLOAIDICHVU.Columns.Add("MALOAIDICHVU", typeof(string));
                dtREDOLOAIDICHVU.Columns.Add("TENLOAIDICHVU", typeof(string));
                dtREDOLOAIDICHVU.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
            groupBox1.Enabled = false;

        }
        private void FormDichVu_Load(object sender, EventArgs e)
        {
            this.dICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.kHACHSANDataSet.DICHVU);
            this.lOAIDICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIDICHVUTableAdapter.Fill(this.kHACHSANDataSet.LOAIDICHVU);
            if (lOAIDICHVUBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }
        private void updatetable()
        {
            this.lOAIDICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIDICHVUTableAdapter.Update(this.kHACHSANDataSet.LOAIDICHVU);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOAIDICHVUBindingSource.Position;
            lOAIDICHVUBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            lOAIDICHVUGridControl.Enabled = false;
            mALoaiDVTextEdit.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mALoaiDVTextEdit.Enabled == true)
            {
                if (mALoaiDVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã loại dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiDVTextEdit.Focus();
                    return;
                }
                else
                {
                    mALoaiDVTextEdit.Text = mALoaiDVTextEdit.Text.ToUpper();
                }
                if (tenDVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Loại Dịch Vụ không được trống!", "", MessageBoxButtons.OK);
                    tenDVTextEdit.Focus();
                    return;
                }
                try
                {
                    dtUNDOLOAIDICHVU.RejectChanges();
                    DataRowView drv = (DataRowView)lOAIDICHVUBindingSource.Current;
                    dtUNDOLOAIDICHVU.NewRow();
                    dtUNDOLOAIDICHVU.Rows.Add(drv.Row[0].ToString(), tenDVTextEdit.Text.Trim(), Action);
                    dtUNDOLOAIDICHVU.AcceptChanges();
                    lOAIDICHVUBindingSource.EndEdit();
                    lOAIDICHVUBindingSource.ResetCurrentItem();
                    this.lOAIDICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.lOAIDICHVUTableAdapter.Update(this.kHACHSANDataSet.LOAIDICHVU);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Loại Dịch Vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mALoaiDVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã loại dịch vụ không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiDVTextEdit.Focus();
                    return;
                }
                if (tenDVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Loại Dịch Vụ không được trống!", "", MessageBoxButtons.OK);
                    tenDVTextEdit.Focus();
                    return;
                }

                try
                {
                    lOAIDICHVUBindingSource.EndEdit();
                    lOAIDICHVUBindingSource.ResetCurrentItem();
                    this.lOAIDICHVUTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.lOAIDICHVUTableAdapter.Update(this.kHACHSANDataSet.LOAIDICHVU);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Loại Dịch Vụ.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOLOAIDICHVU.Rows.RemoveAt(dtUNDOLOAIDICHVU.Rows.Count - 1);
                    return;
                }
            }
            lOAIDICHVUGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOAIDICHVUBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDOLOAIDICHVU.RejectChanges();
                DataRowView drv = (DataRowView)lOAIDICHVUBindingSource.Current;
                dtUNDOLOAIDICHVU.NewRow();
                dtUNDOLOAIDICHVU.Rows.Add(drv.Row[0].ToString(), drv.Row[1].ToString(), Action);
                dtUNDOLOAIDICHVU.AcceptChanges();
                vitri = lOAIDICHVUBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = true;
                mALoaiDVTextEdit.Enabled = false;
                lOAIDICHVUGridControl.Enabled = false;
                dtUNDOLOAIDICHVU.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOAIDICHVUBindingSource.Count > 0)
            {
                if (dICHVUBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)lOAIDICHVUBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa dịch vụ có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOLOAIDICHVU.NewRow();
                        dtUNDOLOAIDICHVU.Rows.Add(drv.Row[0].ToString(), drv.Row[1].ToString(), Action);
                        dtUNDOLOAIDICHVU.AcceptChanges();
                        lOAIDICHVUBindingSource.RemoveCurrent();
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
            if (dtUNDOLOAIDICHVU.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOLOAIDICHVU.Rows[dtUNDOLOAIDICHVU.Rows.Count - 1];
                String temp = dr[2].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM LOAIDICHVU WHERE MALoaiDV ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIDICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIDICHVU.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.LOAIDICHVU.Rows.Remove(dt);
                            kHACHSANDataSet.LOAIDICHVU.AcceptChanges();
                            dtREDOLOAIDICHVU.RejectChanges();
                            dtREDOLOAIDICHVU.NewRow();
                            dtREDOLOAIDICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), "INSERT");
                            dtREDOLOAIDICHVU.AcceptChanges();
                            dtUNDOLOAIDICHVU.RejectChanges();
                            dtUNDOLOAIDICHVU.Rows.RemoveAt(dtUNDOLOAIDICHVU.Rows.Count - 1);
                            dtUNDOLOAIDICHVU.AcceptChanges();
                            lOAIDICHVUBindingSource.EndEdit();
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
                        string sql = "UPDATE LOAIDICHVU SET TenDV  =' " + dr[1].ToString() + "' WHERE MALoaiDV ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIDICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIDICHVU.Rows.Find(dr[0].ToString());
                            dtREDOLOAIDICHVU.RejectChanges();
                            dtREDOLOAIDICHVU.NewRow();
                            dtREDOLOAIDICHVU.Rows.Add(dt[0].ToString(), dt[1].ToString(), "UPDATE");
                            dtREDOLOAIDICHVU.AcceptChanges();
                            dt[1] = dr[1];
                            kHACHSANDataSet.LOAIDICHVU.AcceptChanges();
                            dtUNDOLOAIDICHVU.RejectChanges();
                            dtUNDOLOAIDICHVU.Rows.RemoveAt(dtUNDOLOAIDICHVU.Rows.Count - 1);
                            dtUNDOLOAIDICHVU.AcceptChanges();
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
                        string sql = "Insert into LOAIDICHVU ([MAloaiDV],[TenDV])VALUES ('" + dr[0].ToString() + "','" + dr[1].ToString() + "')";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIDICHVU.RejectChanges();
                            kHACHSANDataSet.LOAIDICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.LOAIDICHVU.AcceptChanges();
                            dtREDOLOAIDICHVU.RejectChanges();
                            dtREDOLOAIDICHVU.NewRow();
                            dtREDOLOAIDICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), "DELETE");
                            dtREDOLOAIDICHVU.AcceptChanges();
                            dtUNDOLOAIDICHVU.RejectChanges();
                            dtUNDOLOAIDICHVU.Rows.RemoveAt(dtUNDOLOAIDICHVU.Rows.Count - 1);
                            dtUNDOLOAIDICHVU.AcceptChanges();
                            lOAIDICHVUBindingSource.EndEdit();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) lOAIDICHVUBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOLOAIDICHVU.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            lOAIDICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOAIDICHVUTableAdapter.Fill(this.kHACHSANDataSet.LOAIDICHVU);
                dtREDOLOAIDICHVU.Clear();
                dtUNDOLOAIDICHVU.Clear();
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
            if (dtREDOLOAIDICHVU.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOLOAIDICHVU.Rows[dtREDOLOAIDICHVU.Rows.Count - 1];
                String temp = dr[2].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM LOAIDICHVU WHERE MALOaiDV ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIDICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIDICHVU.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.LOAIDICHVU.Rows.Remove(dt);
                            kHACHSANDataSet.LOAIDICHVU.AcceptChanges();
                            dtUNDOLOAIDICHVU.RejectChanges();
                            dtUNDOLOAIDICHVU.NewRow();
                            dtUNDOLOAIDICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), "INSERT");
                            dtUNDOLOAIDICHVU.AcceptChanges();
                            dtREDOLOAIDICHVU.RejectChanges();
                            dtREDOLOAIDICHVU.Rows.RemoveAt(dtREDOLOAIDICHVU.Rows.Count - 1);
                            dtREDOLOAIDICHVU.AcceptChanges();
                            lOAIDICHVUBindingSource.EndEdit();
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
                        string sql = "UPDATE LOAIDICHVU SET TenDV  =' " + dr[1].ToString() + "' WHERE MALOaiDV ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIDICHVU.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIDICHVU.Rows.Find(dr[0].ToString());
                            dtUNDOLOAIDICHVU.RejectChanges();
                            dtUNDOLOAIDICHVU.NewRow();
                            dtUNDOLOAIDICHVU.Rows.Add(dt[0].ToString(), dt[1].ToString(), "UPDATE");
                            dtUNDOLOAIDICHVU.AcceptChanges();
                            dt[1] = dr[1];
                            kHACHSANDataSet.LOAIDICHVU.AcceptChanges();
                            dtREDOLOAIDICHVU.RejectChanges();
                            dtREDOLOAIDICHVU.Rows.RemoveAt(dtREDOLOAIDICHVU.Rows.Count - 1);
                            dtREDOLOAIDICHVU.AcceptChanges();
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
                        string sql = "Insert into LOAIDICHVU ([MALOaiDV],[TenDV])VALUES ('" + dr[0].ToString() + "','" + dr[1].ToString() + "')";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIDICHVU.RejectChanges();
                            kHACHSANDataSet.LOAIDICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.LOAIDICHVU.AcceptChanges();
                            dtUNDOLOAIDICHVU.RejectChanges();
                            dtUNDOLOAIDICHVU.NewRow();
                            dtUNDOLOAIDICHVU.Rows.Add(dr[0].ToString(), dr[1].ToString(), "DELETE");
                            dtUNDOLOAIDICHVU.AcceptChanges();
                            dtREDOLOAIDICHVU.RejectChanges();
                            dtREDOLOAIDICHVU.Rows.RemoveAt(dtREDOLOAIDICHVU.Rows.Count - 1);
                            dtREDOLOAIDICHVU.AcceptChanges();
                            lOAIDICHVUBindingSource.EndEdit();
                            lOAIDICHVUBindingSource.ResetCurrentItem();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) lOAIDICHVUBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOLOAIDICHVU.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            lOAIDICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mALoaiDVTextEdit.Enabled == false)
            {
                dtUNDOLOAIDICHVU.RejectChanges();
                dtUNDOLOAIDICHVU.Rows.RemoveAt(dtUNDOLOAIDICHVU.Rows.Count - 1);
                dtUNDOLOAIDICHVU.AcceptChanges();
            }
            lOAIDICHVUBindingSource.CancelEdit();
            if (btnThem.Enabled == false) lOAIDICHVUBindingSource.Position = vitri;
            lOAIDICHVUGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void mALoaiDVTextEdit_Leave(object sender, EventArgs e)
        {
            if (mALoaiDVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("mã loại phòng không được trống");
                mALoaiDVTextEdit.Focus();
            }
            else
            {
                mALoaiDVTextEdit.Text = mALoaiDVTextEdit.Text.ToUpper();
            }
        }

        private void mALoaiDVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tenDVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void tenDVTextEdit_Leave(object sender, EventArgs e)
        {
            tenDVTextEdit.Text = DataUtil.xoaKhoangTrang(tenDVTextEdit.Text);
            if (tenDVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Loại dịch vụ không được để trống");
                tenDVTextEdit.Focus();

            }
        }
    }
}
