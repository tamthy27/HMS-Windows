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
    public partial class FormKieuPhong : Form
    {
        public static DataTable dtREDOKIEUPHONG = new DataTable();
        public static DataTable dtUNDOKIEUPHONG = new DataTable();
        public static DataTable dtKIEUPHONG = new DataTable();
        public static BindingSource bs = new BindingSource();
        int vitri = 0;
        String Action = "";
        public FormKieuPhong()
        {
            InitializeComponent();
            // dtKIEUPHONG = this.kHACHSANDataSet.KIEUPHONG;
            if (dtUNDOKIEUPHONG.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOKIEUPHONG.Columns.Add("MAKIEUPHONG", typeof(string));
                dtUNDOKIEUPHONG.Columns.Add("TENKIEUPHONG", typeof(string));
                dtUNDOKIEUPHONG.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOKIEUPHONG.Columns.Add("MAKIEUPHONG", typeof(string));
                dtREDOKIEUPHONG.Columns.Add("TENKIEUPHONG", typeof(string));
                dtREDOKIEUPHONG.Columns.Add("ACTION", typeof(string));

            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void FormKieuPhong_Load(object sender, EventArgs e)
        {
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.HANGPHONG' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);

            this.kIEUPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kIEUPHONGTableAdapter.Fill(this.kHACHSANDataSet.KIEUPHONG);
            if (kIEUPHONGBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = kIEUPHONGBindingSource.Position;
            kIEUPHONGBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            kIEUPHONGGridControl.Enabled = false;
            mAKieuPhongTextEdit.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;


        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAKieuPhongTextEdit.Enabled == true)
            {
                if (mAKieuPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã kiểu phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mAKieuPhongTextEdit.Focus();
                    return;
                }
                else
                {
                    mAKieuPhongTextEdit.Text = mAKieuPhongTextEdit.Text.ToUpper();
                }
                if (tenKieuPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Kiểu phòng không được trống!", "", MessageBoxButtons.OK);
                    tenKieuPhongTextEdit.Focus();
                    return;
                }
                try
                {
                    dtUNDOKIEUPHONG.RejectChanges();
                    DataRowView drv = (DataRowView)kIEUPHONGBindingSource.Current;
                    dtUNDOKIEUPHONG.NewRow();
                    dtUNDOKIEUPHONG.Rows.Add(mAKieuPhongTextEdit.Text, tenKieuPhongTextEdit.Text, Action);
                    dtUNDOKIEUPHONG.AcceptChanges();
                    kIEUPHONGBindingSource.EndEdit();
                    kIEUPHONGBindingSource.ResetCurrentItem();
                    this.kIEUPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.kIEUPHONGTableAdapter.Update(this.kHACHSANDataSet.KIEUPHONG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Kiểu Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mAKieuPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã kiểu phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mAKieuPhongTextEdit.Focus();
                    return;
                }
                if (tenKieuPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Kiểu phòng không được trống!", "", MessageBoxButtons.OK);
                    tenKieuPhongTextEdit.Focus();
                    return;
                }
                try
                {

                    kIEUPHONGBindingSource.EndEdit();
                    kIEUPHONGBindingSource.ResetCurrentItem();
                    this.kIEUPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.kIEUPHONGTableAdapter.Update(this.kHACHSANDataSet.KIEUPHONG);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Kiểu Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOKIEUPHONG.Rows.RemoveAt(dtUNDOKIEUPHONG.Rows.Count - 1);
                    return;
                }
            }
            kIEUPHONGGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kIEUPHONGBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDOKIEUPHONG.RejectChanges();
                DataRowView drv = (DataRowView)kIEUPHONGBindingSource.Current;
                dtUNDOKIEUPHONG.NewRow();
                dtUNDOKIEUPHONG.Rows.Add(mAKieuPhongTextEdit.Text, tenKieuPhongTextEdit.Text, Action);
                dtUNDOKIEUPHONG.AcceptChanges();
                vitri = kIEUPHONGBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                mAKieuPhongTextEdit.Enabled = false;
                kIEUPHONGGridControl.Enabled = false;
                dtUNDOKIEUPHONG.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }
        private void updatetable()
        {
            this.kIEUPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kIEUPHONGTableAdapter.Update(this.kHACHSANDataSet.KIEUPHONG);
        }
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kIEUPHONGBindingSource.Count > 0)
            {
                if (hANGPHONGBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)kIEUPHONGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa kiểu phòng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOKIEUPHONG.NewRow();
                        dtUNDOKIEUPHONG.Rows.Add(mAKieuPhongTextEdit.Text, tenKieuPhongTextEdit.Text, Action);
                        dtUNDOKIEUPHONG.AcceptChanges();
                        kIEUPHONGBindingSource.RemoveCurrent();
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
            if (dtUNDOKIEUPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOKIEUPHONG.Rows[dtUNDOKIEUPHONG.Rows.Count - 1];
                String temp = dr[2].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM KIEUPHONG WHERE MAKieuPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KIEUPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KIEUPHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.KIEUPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.KIEUPHONG.AcceptChanges();
                            dtREDOKIEUPHONG.RejectChanges();
                            dtREDOKIEUPHONG.NewRow();

                            dtREDOKIEUPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "INSERT");
                            dtREDOKIEUPHONG.AcceptChanges();
                            dtUNDOKIEUPHONG.RejectChanges();
                            dtUNDOKIEUPHONG.Rows.RemoveAt(dtUNDOKIEUPHONG.Rows.Count - 1);
                            dtUNDOKIEUPHONG.AcceptChanges();
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
                        string sql = "UPDATE KIEUPHONG SET TenKieuPhong  =N'" + dr[1].ToString() + "' WHERE MAKieuPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KIEUPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KIEUPHONG.Rows.Find(dr[0].ToString());
                            dtREDOKIEUPHONG.RejectChanges();
                            dtREDOKIEUPHONG.NewRow();

                            dtREDOKIEUPHONG.Rows.Add(dt[0].ToString(), dt[1].ToString(), "UPDATE");
                            dtREDOKIEUPHONG.AcceptChanges();
                            dt[1] = dr[1];
                            kHACHSANDataSet.KIEUPHONG.AcceptChanges();
                            dtUNDOKIEUPHONG.RejectChanges();
                            dtUNDOKIEUPHONG.Rows.RemoveAt(dtUNDOKIEUPHONG.Rows.Count - 1);
                            dtUNDOKIEUPHONG.AcceptChanges();
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
                        string sql = "Insert into KIEUPHONG ([MAKieuPhong],[TenKieuPhong])VALUES (N'" + dr[0].ToString() + "',N'" + dr[1].ToString() + "')";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KIEUPHONG.RejectChanges();
                            kHACHSANDataSet.KIEUPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.KIEUPHONG.AcceptChanges();
                            dtREDOKIEUPHONG.RejectChanges();
                            dtREDOKIEUPHONG.NewRow();
                            dtREDOKIEUPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "DELETE");
                            dtREDOKIEUPHONG.AcceptChanges();
                            dtUNDOKIEUPHONG.RejectChanges();
                            dtUNDOKIEUPHONG.Rows.RemoveAt(dtUNDOKIEUPHONG.Rows.Count - 1);
                            dtUNDOKIEUPHONG.AcceptChanges();
                            updatetable();
                        }
                        else
                        {
                            MessageBox.Show("WHAT's Error: Insert that bai", "", MessageBoxButtons.OK);

                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) kIEUPHONGBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOKIEUPHONG.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            kIEUPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kIEUPHONGTableAdapter.Fill(this.kHACHSANDataSet.KIEUPHONG);
                dtREDOKIEUPHONG.Clear();
                dtUNDOKIEUPHONG.Clear();
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
            if (dtREDOKIEUPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOKIEUPHONG.Rows[dtREDOKIEUPHONG.Rows.Count - 1];
                String temp = dr[2].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM KIEUPHONG WHERE MAKieuPhong = '" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KIEUPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KIEUPHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.KIEUPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.KIEUPHONG.AcceptChanges();
                            dtUNDOKIEUPHONG.RejectChanges();
                            dtUNDOKIEUPHONG.NewRow();

                            dtUNDOKIEUPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "INSERT");
                            dtUNDOKIEUPHONG.AcceptChanges();
                            dtREDOKIEUPHONG.RejectChanges();
                            dtREDOKIEUPHONG.Rows.RemoveAt(dtREDOKIEUPHONG.Rows.Count - 1);
                            dtREDOKIEUPHONG.AcceptChanges();
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
                        string sql = "UPDATE KIEUPHONG SET TenKieuPhong  = N'" + dr[1].ToString() + "' WHERE MAKieuPhong =N'" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KIEUPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KIEUPHONG.Rows.Find(dr[0].ToString());
                            dtUNDOKIEUPHONG.RejectChanges();
                            dtUNDOKIEUPHONG.NewRow();

                            dtUNDOKIEUPHONG.Rows.Add(dt[0].ToString(), dt[1].ToString(), "UPDATE");
                            dtUNDOKIEUPHONG.AcceptChanges();
                            dt[1] = dr[1];
                            kHACHSANDataSet.KIEUPHONG.AcceptChanges();
                            dtREDOKIEUPHONG.RejectChanges();
                            dtREDOKIEUPHONG.Rows.RemoveAt(dtREDOKIEUPHONG.Rows.Count - 1);
                            dtREDOKIEUPHONG.AcceptChanges();
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
                        string sql = "Insert into KIEUPHONG ([MAKieuPhong],[TenKieuPhong])VALUES ('" + dr[0].ToString() + "',N'" + dr[1].ToString() + "')";

                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KIEUPHONG.RejectChanges();
                            kHACHSANDataSet.KIEUPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString());
                            kHACHSANDataSet.KIEUPHONG.AcceptChanges();
                            dtUNDOKIEUPHONG.RejectChanges();
                            dtUNDOKIEUPHONG.NewRow();
                            dtUNDOKIEUPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), "DELETE");
                            dtUNDOKIEUPHONG.AcceptChanges();
                            dtREDOKIEUPHONG.RejectChanges();
                            dtREDOKIEUPHONG.Rows.RemoveAt(dtREDOKIEUPHONG.Rows.Count - 1);
                            dtREDOKIEUPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) kIEUPHONGBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOKIEUPHONG.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            kIEUPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
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
            if (mAKieuPhongTextEdit.Enabled == false)
            {
                dtUNDOKIEUPHONG.RejectChanges();
                dtUNDOKIEUPHONG.Rows.RemoveAt(dtUNDOKIEUPHONG.Rows.Count - 1);
                dtUNDOKIEUPHONG.AcceptChanges();
            }
            kIEUPHONGBindingSource.CancelEdit();
            if (btnThem.Enabled == false) kIEUPHONGBindingSource.Position = vitri;
            kIEUPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;

        }

        private void mAKieuPhongTextEdit_Leave(object sender, EventArgs e)
        {
            if (mAKieuPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("mã kiểu phòng không được trống");
                mAKieuPhongTextEdit.Focus();
            }
            else
            {
                mAKieuPhongTextEdit.Text = mAKieuPhongTextEdit.Text.ToUpper();

            }
        }
        private void tenKieuPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {

            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void mAKieuPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void tenKieuPhongTextEdit_Leave(object sender, EventArgs e)
        {
            tenKieuPhongTextEdit.Text = DataUtil.xoaKhoangTrang(tenKieuPhongTextEdit.Text);
            if (tenKieuPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Kiểu phòng không được để trống");
                tenKieuPhongTextEdit.Focus();

            }
        }
    }
}
