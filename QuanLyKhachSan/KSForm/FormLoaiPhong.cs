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
    public partial class FormLoaiPhong : Form
    {
        public static DataTable dtREDOLOAIPHONG = new DataTable();
        public static DataTable dtUNDOLOAIPHONG = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormLoaiPhong()
        {
            InitializeComponent();
            if (dtUNDOLOAIPHONG.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOLOAIPHONG.Columns.Add("MALOAIPHONG", typeof(string));
                dtUNDOLOAIPHONG.Columns.Add("TENLOAIPHONG", typeof(string));
                dtUNDOLOAIPHONG.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOLOAIPHONG.Columns.Add("MALOAIPHONG", typeof(string));
                dtREDOLOAIPHONG.Columns.Add("TENLOAIPHONG", typeof(string));
                dtREDOLOAIPHONG.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.HANGPHONG' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);

            // TODO: This line of code loads data into the 'kHACHSANDataSet.LOAIPHONG' table. You can move, or remove it, as needed.
            this.lOAIPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIPHONGTableAdapter.Fill(this.kHACHSANDataSet.LOAIPHONG);
            if (lOAIPHONGBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }
        private void updatetable()
        {
            this.lOAIPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIPHONGTableAdapter.Update(this.kHACHSANDataSet.LOAIPHONG);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = lOAIPHONGBindingSource.Position;
            lOAIPHONGBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            lOAIPHONGGridControl.Enabled = false;
            mALoaiPhongTextEdit.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mALoaiPhongTextEdit.Enabled == true)
            {
                if (mALoaiPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã loại phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiPhongTextEdit.Focus();
                    return;
                }
                else
                {
                    mALoaiPhongTextEdit.Text = mALoaiPhongTextEdit.Text.ToUpper();
                }
                if (tenLoaiPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Loai5 phòng không được trống!", "", MessageBoxButtons.OK);
                    tenLoaiPhongTextEdit.Focus();
                    return;
                }

                try
                {
                    dtUNDOLOAIPHONG.RejectChanges();
                    DataRowView drv = (DataRowView)lOAIPHONGBindingSource.Current;
                    dtUNDOLOAIPHONG.NewRow();
                    dtUNDOLOAIPHONG.Rows.Add(drv.Row[0].ToString(), tenLoaiPhongTextEdit.Text, Action);
                    dtUNDOLOAIPHONG.AcceptChanges();
                    lOAIPHONGBindingSource.EndEdit();
                    lOAIPHONGBindingSource.ResetCurrentItem();
                    this.lOAIPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.lOAIPHONGTableAdapter.Update(this.kHACHSANDataSet.LOAIPHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Loại Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mALoaiPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã loại phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiPhongTextEdit.Focus();
                    return;
                }
                if (tenLoaiPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Loại phòng không được trống!", "", MessageBoxButtons.OK);
                    tenLoaiPhongTextEdit.Focus();
                    return;
                }

                try
                {

                    lOAIPHONGBindingSource.EndEdit();
                    lOAIPHONGBindingSource.ResetCurrentItem();
                    this.lOAIPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.lOAIPHONGTableAdapter.Update(this.kHACHSANDataSet.LOAIPHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Loại Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOLOAIPHONG.Rows.RemoveAt(dtUNDOLOAIPHONG.Rows.Count - 1);
                    return;
                }
            }
            lOAIPHONGGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOAIPHONGBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDOLOAIPHONG.RejectChanges();
                DataRowView drv = (DataRowView)lOAIPHONGBindingSource.Current;
                dtUNDOLOAIPHONG.NewRow();
                dtUNDOLOAIPHONG.Rows.Add(mALoaiPhongTextEdit.Text, tenLoaiPhongTextEdit.Text, Action);
                dtUNDOLOAIPHONG.AcceptChanges();
                vitri = lOAIPHONGBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                mALoaiPhongTextEdit.Enabled = false;
                lOAIPHONGGridControl.Enabled = false;
                dtUNDOLOAIPHONG.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (lOAIPHONGBindingSource.Count > 0)
            {
                if (hANGPHONGBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)lOAIPHONGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa loại phòng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOLOAIPHONG.NewRow();
                        dtUNDOLOAIPHONG.Rows.Add(mALoaiPhongTextEdit.Text, tenLoaiPhongTextEdit.Text, Action);
                        dtUNDOLOAIPHONG.AcceptChanges();
                        lOAIPHONGBindingSource.RemoveCurrent();
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
            if (dtUNDOLOAIPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOLOAIPHONG.Rows[dtUNDOLOAIPHONG.Rows.Count - 1];
                String temp = dr[2].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM LOAIPHONG WHERE MALoaiPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIPHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.LOAIPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.LOAIPHONG.AcceptChanges();
                            dtREDOLOAIPHONG.RejectChanges();
                            dtREDOLOAIPHONG.NewRow();
                            dtREDOLOAIPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "INSERT");
                            dtREDOLOAIPHONG.AcceptChanges();
                            dtUNDOLOAIPHONG.RejectChanges();
                            dtUNDOLOAIPHONG.Rows.RemoveAt(dtUNDOLOAIPHONG.Rows.Count - 1);
                            dtUNDOLOAIPHONG.AcceptChanges();
                            lOAIPHONGBindingSource.EndEdit();
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
                        string sql = "UPDATE LOAIPHONG SET TenLoaiPhong  =N'" + dr[1].ToString() + "' WHERE MALoaiPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIPHONG.Rows.Find(dr[0].ToString());
                            dtREDOLOAIPHONG.RejectChanges();
                            dtREDOLOAIPHONG.NewRow();
                            dtREDOLOAIPHONG.Rows.Add(dt[0].ToString(), dt[1].ToString(), "UPDATE");
                            dtREDOLOAIPHONG.AcceptChanges();
                            dt[1] = dr[1];
                            kHACHSANDataSet.LOAIPHONG.AcceptChanges();
                            dtUNDOLOAIPHONG.RejectChanges();
                            dtUNDOLOAIPHONG.Rows.RemoveAt(dtUNDOLOAIPHONG.Rows.Count - 1);
                            dtUNDOLOAIPHONG.AcceptChanges();
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
                        string sql = "Insert into LOAIPHONG ([MALOAIPhong],[TenLOAIPhong])VALUES ('" + dr[0].ToString() + "',N'" + dr[1].ToString() + "')";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIPHONG.RejectChanges();
                            kHACHSANDataSet.LOAIPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.LOAIPHONG.AcceptChanges();
                            dtREDOLOAIPHONG.RejectChanges();
                            dtREDOLOAIPHONG.NewRow();
                            dtREDOLOAIPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "DELETE");
                            dtREDOLOAIPHONG.AcceptChanges();
                            dtUNDOLOAIPHONG.RejectChanges();
                            dtUNDOLOAIPHONG.Rows.RemoveAt(dtUNDOLOAIPHONG.Rows.Count - 1);
                            dtUNDOLOAIPHONG.AcceptChanges();
                            lOAIPHONGBindingSource.EndEdit();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) lOAIPHONGBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOLOAIPHONG.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            lOAIPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOAIPHONGTableAdapter.Fill(this.kHACHSANDataSet.LOAIPHONG);
                dtREDOLOAIPHONG.Clear();
                dtUNDOLOAIPHONG.Clear();
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
            if (dtREDOLOAIPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOLOAIPHONG.Rows[dtREDOLOAIPHONG.Rows.Count - 1];
                String temp = dr[2].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM LOAIPHONG WHERE MALoaiPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIPHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.LOAIPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.LOAIPHONG.AcceptChanges();
                            dtUNDOLOAIPHONG.RejectChanges();
                            dtUNDOLOAIPHONG.NewRow();
                            dtUNDOLOAIPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "INSERT");
                            dtUNDOLOAIPHONG.AcceptChanges();
                            dtREDOLOAIPHONG.RejectChanges();
                            dtREDOLOAIPHONG.Rows.RemoveAt(dtREDOLOAIPHONG.Rows.Count - 1);
                            dtREDOLOAIPHONG.AcceptChanges();
                            lOAIPHONGBindingSource.EndEdit();
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
                        string sql = "UPDATE LOAIPHONG SET TenLoaiPhong  =N'" + dr[1].ToString() + "' WHERE MALoaiPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.LOAIPHONG.Rows.Find(dr[0].ToString());
                            dtUNDOLOAIPHONG.RejectChanges();
                            dtUNDOLOAIPHONG.NewRow();
                            dtUNDOLOAIPHONG.Rows.Add(dt[0].ToString(), dt[1].ToString(), "UPDATE");
                            dtUNDOLOAIPHONG.AcceptChanges();
                            dt[1] = dr[1];
                            kHACHSANDataSet.LOAIPHONG.AcceptChanges();
                            dtREDOLOAIPHONG.RejectChanges();
                            dtREDOLOAIPHONG.Rows.RemoveAt(dtREDOLOAIPHONG.Rows.Count - 1);
                            dtREDOLOAIPHONG.AcceptChanges();
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
                        string sql = "Insert into LOAIPHONG ([MALOAIPhong],[TenLOAIPhong])VALUES ('" + dr[0].ToString() + "',N'" + dr[1].ToString() + "')";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.LOAIPHONG.RejectChanges();
                            kHACHSANDataSet.LOAIPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.LOAIPHONG.AcceptChanges();
                            dtUNDOLOAIPHONG.RejectChanges();
                            dtUNDOLOAIPHONG.NewRow();
                            dtUNDOLOAIPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "DELETE");
                            dtUNDOLOAIPHONG.AcceptChanges();
                            dtREDOLOAIPHONG.RejectChanges();
                            dtREDOLOAIPHONG.Rows.RemoveAt(dtREDOLOAIPHONG.Rows.Count - 1);
                            dtREDOLOAIPHONG.AcceptChanges();
                            lOAIPHONGBindingSource.EndEdit();
                            lOAIPHONGBindingSource.ResetCurrentItem();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) lOAIPHONGBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOLOAIPHONG.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            lOAIPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mALoaiPhongTextEdit.Enabled == false)
            {
                dtUNDOLOAIPHONG.RejectChanges();
                dtUNDOLOAIPHONG.Rows.RemoveAt(dtUNDOLOAIPHONG.Rows.Count - 1);
                dtUNDOLOAIPHONG.AcceptChanges();
            }
            lOAIPHONGBindingSource.CancelEdit();
            if (btnThem.Enabled == false) lOAIPHONGBindingSource.Position = vitri;
            lOAIPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = btnHuy.Enabled = false;
        }

        private void mALoaiPhongTextEdit_Leave(object sender, EventArgs e)
        {
            if (mALoaiPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã loại phòng không được trống");
                mALoaiPhongTextEdit.Focus();
            }
            else
            {
                mALoaiPhongTextEdit.Text = mALoaiPhongTextEdit.Text.ToUpper();

            }
        }

        private void mALoaiPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tenLoaiPhongTextEdit_Leave(object sender, EventArgs e)
        {
            tenLoaiPhongTextEdit.Text = DataUtil.xoaKhoangTrang(tenLoaiPhongTextEdit.Text);
            if (tenLoaiPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Loại phòng không được để trống");
                tenLoaiPhongTextEdit.Focus();
            }
            else
            {
                mALoaiPhongTextEdit.Text = mALoaiPhongTextEdit.Text.ToUpper();

            }
        }

        private void tenLoaiPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }
    }
}
