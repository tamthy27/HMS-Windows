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
    public partial class FormPhong : Form
    {
        public static DataTable dtREDOPHONG = new DataTable();
        public static DataTable dtUNDOPHONG = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormPhong()
        {
            InitializeComponent();
            if (dtUNDOPHONG.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOPHONG.Columns.Add("MAPhong", typeof(string));
                dtUNDOPHONG.Columns.Add("mahangphong", typeof(string));
                dtUNDOPHONG.Columns.Add("matinhtrangphong", typeof(string));
                dtUNDOPHONG.Columns.Add("matang", typeof(string));
                dtUNDOPHONG.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOPHONG.Columns.Add("MAPhong", typeof(string));
                dtREDOPHONG.Columns.Add("mahangphong", typeof(string));
                dtREDOPHONG.Columns.Add("matinhtrangphong", typeof(string));
                dtREDOPHONG.Columns.Add("matang", typeof(string));
                dtREDOPHONG.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            this.cTPHIEUTHUETableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTPHIEUTHUE' table. You can move, or remove it, as needed.
            this.cTPHIEUTHUETableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUTHUE);
            this.tANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.TANG' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.tINHTRANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.HANGPHONG' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.TINHTRANGPHONG' table. You can move, or remove it, as needed.
            this.tINHTRANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.TINHTRANGPHONG);
            this.tANGTableAdapter.Fill(this.kHACHSANDataSet.TANG);

            this.pHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.kHACHSANDataSet.PHONG);
            if (pHONGBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }
        private void updatetable()
        {
            this.pHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.pHONGTableAdapter.Update(this.kHACHSANDataSet);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = pHONGBindingSource.Position;
            pHONGBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            pHONGGridControl.Enabled = false;
            mAPhongTextEdit.Enabled = true;
            Action = "DELETE";
            mAHangPhongComboBox.SelectedIndex = mATangComboBox.SelectedIndex = mATinhTrangPhongComboBox.SelectedIndex = 0;
            groupBox1.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAPhongTextEdit.Enabled == true)
            {
                if (mAPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phòng không được trống!", "", MessageBoxButtons.OK);
                    mAPhongTextEdit.Focus();
                    return;
                }
                else
                {
                    mAPhongTextEdit.Text = mAPhongTextEdit.Text.ToUpper();
                }
                if (mAHangPhongComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Mã hạng phòng không được trống!", "", MessageBoxButtons.OK);
                    mAHangPhongComboBox.Focus();
                    return;
                }
                if (mATinhTrangPhongComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Mã tình trạng phòng không được trống!", "", MessageBoxButtons.OK);
                    mATinhTrangPhongComboBox.Focus();
                    return;
                }
                if (mATangComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã tầng không hợp lệ", "", MessageBoxButtons.OK);
                    mATangComboBox.Focus();
                    return;
                }
                try
                {
                    dtUNDOPHONG.RejectChanges();
                    DataRowView drv = (DataRowView)pHONGBindingSource.Current;
                    dtUNDOPHONG.NewRow();
                    dtUNDOPHONG.Rows.Add(mAPhongTextEdit.Text, mAHangPhongComboBox.SelectedValue, mATinhTrangPhongComboBox.SelectedValue, mATangComboBox.SelectedValue, Action);
                    dtUNDOPHONG.AcceptChanges();
                    pHONGBindingSource.EndEdit();
                    pHONGBindingSource.ResetCurrentItem();
                    this.pHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.pHONGTableAdapter.Update(this.kHACHSANDataSet.PHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mAPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã phòng không được trống!", "", MessageBoxButtons.OK);
                    mAPhongTextEdit.Focus();
                    return;
                }
                if (mAHangPhongComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Mã hạng phòng không được trống!", "", MessageBoxButtons.OK);
                    mAHangPhongComboBox.Focus();
                    return;
                }
                if (mATinhTrangPhongComboBox.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Mã tình trạng phòng không được trống!", "", MessageBoxButtons.OK);
                    mATinhTrangPhongComboBox.Focus();
                    return;
                }
                if (mATangComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Mã tầng không hợp lệ", "", MessageBoxButtons.OK);
                    mATangComboBox.Focus();
                    return;
                }
                try
                {
                    pHONGBindingSource.EndEdit();
                    pHONGBindingSource.ResetCurrentItem();
                    this.pHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.pHONGTableAdapter.Update(this.kHACHSANDataSet.PHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOPHONG.Rows.RemoveAt(dtUNDOPHONG.Rows.Count - 1);
                    return;
                }
            }
            pHONGGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pHONGBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDOPHONG.RejectChanges();
                DataRowView drv = (DataRowView)pHONGBindingSource.Current;
                dtUNDOPHONG.NewRow();
                dtUNDOPHONG.Rows.Add(mAPhongTextEdit.Text, mAHangPhongComboBox.SelectedValue, mATinhTrangPhongComboBox.SelectedValue, mATangComboBox.SelectedValue, Action);
                dtUNDOPHONG.AcceptChanges();
                vitri = pHONGBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                mAPhongTextEdit.Enabled = false;
                pHONGGridControl.Enabled = false;
                dtUNDOPHONG.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pHONGBindingSource.Count > 0)
            {
                if (cTPHIEUTHUEBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)pHONGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa khách hàng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOPHONG.NewRow();
                        dtUNDOPHONG.Rows.Add(mAPhongTextEdit.Text, mAHangPhongComboBox.SelectedValue, mATinhTrangPhongComboBox.SelectedValue, mATangComboBox.SelectedValue, Action);
                        dtUNDOPHONG.AcceptChanges();
                        pHONGBindingSource.RemoveCurrent();
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
            if (dtUNDOPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOPHONG.Rows[dtUNDOPHONG.Rows.Count - 1];
                String temp = dr[4].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM PHONG WHERE MAphong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.PHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.PHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.PHONG.Rows.Remove(dt);
                            kHACHSANDataSet.PHONG.AcceptChanges();
                            dtREDOPHONG.RejectChanges();
                            dtREDOPHONG.NewRow();
                            dtREDOPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], "INSERT");
                            dtREDOPHONG.AcceptChanges();
                            dtUNDOPHONG.RejectChanges();
                            dtUNDOPHONG.Rows.RemoveAt(dtUNDOPHONG.Rows.Count - 1);
                            dtUNDOPHONG.AcceptChanges();
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
                        string sql = "UPDATE [dbo].[PHONG] SET [MAPhong] = '" + dr[0] + "',[MAHangPhong] = '" + dr[1] + "',[MATinhTrangPhong] ='" + dr[2] + "',[MATang] = '" + dr[3] + "' WHERE MAPhong = '" + dr[0] + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.PHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.PHONG.Rows.Find(dr[0].ToString());
                            dtREDOPHONG.RejectChanges();
                            dtREDOPHONG.NewRow();
                            dtREDOPHONG.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], "UPDATE");
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            kHACHSANDataSet.PHONG.AcceptChanges(); dtREDOPHONG.AcceptChanges();
                            dtUNDOPHONG.RejectChanges();
                            dtUNDOPHONG.Rows.RemoveAt(dtUNDOPHONG.Rows.Count - 1);
                            dtUNDOPHONG.AcceptChanges();
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
                        string sql = "INSERT INTO [PHONG] ([MAPhong],[MAHangPhong],[MATinhTrangPhong],[SoLuongGiuong],[MATang]) VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.PHONG.RejectChanges();
                            kHACHSANDataSet.PHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3]);
                            kHACHSANDataSet.PHONG.AcceptChanges();
                            dtREDOPHONG.RejectChanges();
                            dtREDOPHONG.NewRow();
                            dtREDOPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], "DELETE");
                            dtREDOPHONG.AcceptChanges();
                            dtUNDOPHONG.RejectChanges();
                            dtUNDOPHONG.Rows.RemoveAt(dtUNDOPHONG.Rows.Count - 1);
                            dtUNDOPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) pHONGBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOPHONG.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            pHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
                // TODO: This line of code loads data into the 'kHACHSANDataSet.TINHTRANGPHONG' table. You can move, or remove it, as needed.
                this.tINHTRANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.TINHTRANGPHONG);
                this.tANGTableAdapter.Fill(this.kHACHSANDataSet.TANG);
                this.pHONGTableAdapter.Fill(this.kHACHSANDataSet.PHONG);
                dtREDOPHONG.Clear();
                dtUNDOPHONG.Clear();
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
            if (dtREDOPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOPHONG.Rows[dtREDOPHONG.Rows.Count - 1];
                String temp = dr[4].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM PHONG WHERE MAphong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.PHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.PHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.PHONG.Rows.Remove(dt);
                            kHACHSANDataSet.PHONG.AcceptChanges();
                            dtUNDOPHONG.RejectChanges();
                            dtUNDOPHONG.NewRow();
                            dtUNDOPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], "INSERT");
                            dtUNDOPHONG.AcceptChanges();
                            dtREDOPHONG.RejectChanges();
                            dtREDOPHONG.Rows.RemoveAt(dtREDOPHONG.Rows.Count - 1);
                            dtREDOPHONG.AcceptChanges();
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
                        string sql = "UPDATE [dbo].[PHONG] SET [MAPhong] = '" + dr[0] + "',[MAHangPhong] = '" + dr[1] + "',[MATinhTrangPhong] ='" + dr[2] + "',[MATang] = '" + dr[3] + "' WHERE MAPhong = '" + dr[0] + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.PHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.PHONG.Rows.Find(dr[0].ToString());
                            dtUNDOPHONG.RejectChanges();
                            dtUNDOPHONG.NewRow();
                            dtUNDOPHONG.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], "UPDATE");
                            dtUNDOPHONG.AcceptChanges();
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            kHACHSANDataSet.PHONG.AcceptChanges();
                            dtREDOPHONG.RejectChanges();
                            dtREDOPHONG.Rows.RemoveAt(dtREDOPHONG.Rows.Count - 1);
                            dtREDOPHONG.AcceptChanges();
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
                        string sql = "INSERT INTO [PHONG] ([MAPhong],[MAHangPhong],[MATinhTrangPhong],[SoLuongGiuong],[MATang]) VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {

                            kHACHSANDataSet.PHONG.RejectChanges();
                            kHACHSANDataSet.PHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3]);
                            kHACHSANDataSet.PHONG.AcceptChanges();
                            dtUNDOPHONG.RejectChanges();
                            dtUNDOPHONG.NewRow();
                            dtUNDOPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], "DELETE");
                            dtUNDOPHONG.AcceptChanges();
                            dtREDOPHONG.RejectChanges();
                            dtREDOPHONG.Rows.RemoveAt(dtREDOPHONG.Rows.Count - 1);
                            dtREDOPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) pHONGBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOPHONG.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            pHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }



        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAPhongTextEdit.Enabled == false)
            {
                dtUNDOPHONG.RejectChanges();
                dtUNDOPHONG.Rows.RemoveAt(dtUNDOPHONG.Rows.Count - 1);
                dtUNDOPHONG.AcceptChanges();
            }
            pHONGBindingSource.CancelEdit();
            if (btnThem.Enabled == false) pHONGBindingSource.Position = vitri;
            pHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void mAHangPhongComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mATinhTrangPhongComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mATangComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mAPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void mAPhongTextEdit_Leave(object sender, EventArgs e)
        {
            mAPhongTextEdit.Text = DataUtil.xoaKhoangTrang(mAPhongTextEdit.Text);
            if (mAPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Phòng không được để trống");
                mAPhongTextEdit.Focus();
            }
            else
            {
                mAPhongTextEdit.Text = mAPhongTextEdit.Text.ToUpper();

            }
        }
    }
}
