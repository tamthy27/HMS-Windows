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
    public partial class FormNhanVien : Form
    {
        public static DataTable dtREDONHANVIEN = new DataTable();
        public static DataTable dtUNDONHANVIEN = new DataTable();
        int vitri = 0;
        String Action = "";
        public FormNhanVien()
        {
            InitializeComponent();
            if (dtUNDONHANVIEN.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDONHANVIEN.Columns.Add("MANHANVIEN", typeof(string));
                dtUNDONHANVIEN.Columns.Add("HONV", typeof(string));
                dtUNDONHANVIEN.Columns.Add("TENNHANVIEN", typeof(string));
                dtUNDONHANVIEN.Columns.Add("LuongNV", typeof(double));
                dtUNDONHANVIEN.Columns.Add("ngaysinhnv", typeof(DateTime));
                dtUNDONHANVIEN.Columns.Add("gioitinhnv", typeof(Boolean));
                dtUNDONHANVIEN.Columns.Add("diachinv", typeof(string));
                dtUNDONHANVIEN.Columns.Add("CMND", typeof(string));
                dtUNDONHANVIEN.Columns.Add("SODT", typeof(string));
                dtUNDONHANVIEN.Columns.Add("MBP", typeof(string));
                dtUNDONHANVIEN.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDONHANVIEN.Columns.Add("MANHANVIEN", typeof(string));
                dtREDONHANVIEN.Columns.Add("HONV", typeof(string));
                dtREDONHANVIEN.Columns.Add("TENNHANVIEN", typeof(string));
                dtREDONHANVIEN.Columns.Add("LuongNV", typeof(double));
                dtREDONHANVIEN.Columns.Add("ngaysinhnv", typeof(DateTime));
                dtREDONHANVIEN.Columns.Add("gioitinhnv", typeof(Boolean));
                dtREDONHANVIEN.Columns.Add("diachinv", typeof(string));
                dtREDONHANVIEN.Columns.Add("CMND", typeof(string));
                dtREDONHANVIEN.Columns.Add("SODT", typeof(string));
                dtREDONHANVIEN.Columns.Add("MBP", typeof(string));
                dtREDONHANVIEN.Columns.Add("ACTION", typeof(string));
            }
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.hOADONTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
            this.hOADONTableAdapter.Fill(this.kHACHSANDataSet.HOADON);
            this.bOPHANTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.bOPHANTableAdapter.Fill(this.kHACHSANDataSet.BOPHAN);
            this.nHANVIENTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.nHANVIENTableAdapter.Fill(this.kHACHSANDataSet.NHANVIEN);
            this.maBPComboBox.DataSource = this.kHACHSANDataSet.BOPHAN;
            this.maBPComboBox.DisplayMember = "TenBP";
            this.maBPComboBox.ValueMember = "MaBP";
            if (nHANVIENBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }
        }
        private void updatetable()
        {
            this.nHANVIENTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.nHANVIENTableAdapter.Update(this.kHACHSANDataSet);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = nHANVIENBindingSource.Position;
            nHANVIENBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            nHANVIENGridControl.Enabled = false;
            mANVTextEdit.Enabled = true;
            Action = "DELETE";
            maBPComboBox.SelectedIndex = 0;
            groupBox1.Enabled = true;


        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mANVTextEdit.Enabled == true)
            {
                if (mANVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                    mANVTextEdit.Focus();
                    return;
                }
                else
                {
                    mANVTextEdit.Text = mANVTextEdit.Text.ToUpper();
                }
                if (hoNVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Họ nhân viên không được trống!", "", MessageBoxButtons.OK);
                    hoNVTextEdit.Focus();
                    return;
                }
                if (tenNVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Tên nhân viên không được trống!", "", MessageBoxButtons.OK);
                    tenNVTextEdit.Focus();
                    return;
                }
                if (luongNVSpinEdit.Value <= 0)
                {
                    MessageBox.Show("Lương không hợp lệ", "", MessageBoxButtons.OK);
                    luongNVSpinEdit.Focus();
                    return;
                }
                if (cMNDTextEdit.Text.Trim() != "" && cMNDTextEdit.Text.Trim().Length < 9 || cMNDTextEdit.Text.Trim().Length > 12)
                {
                    MessageBox.Show("Độ dài CMND phải lớn hơn 9 và nhỏ hơn 12");
                    cMNDTextEdit.Focus();
                    return;
                }
                if (soDienThoaiNVTextEdit.Text.Trim() != "" && soDienThoaiNVTextEdit.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Độ dài SDT phải lớn hơn 9");
                    soDienThoaiNVTextEdit.Focus();
                    return;
                }
                    try
                {
                    dtUNDONHANVIEN.RejectChanges();
                    DataRowView drv = (DataRowView)nHANVIENBindingSource.Current;
                    dtUNDONHANVIEN.NewRow();
                    dtUNDONHANVIEN.Rows.Add(drv.Row[0].ToString(), hoNVTextEdit.Text.Trim(), tenNVTextEdit.Text.Trim(), luongNVSpinEdit.Value, ngaySinhNVDateEdit.DateTime, gioiTinhNVCheckEdit.Checked, diaChiNVTextEdit.Text.Trim(), cMNDTextEdit.Text.Trim(), soDienThoaiNVTextEdit.Text.Trim(), maBPComboBox.SelectedValue, Action);
                    dtUNDONHANVIEN.AcceptChanges();
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENBindingSource.ResetCurrentItem();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.nHANVIENTableAdapter.Update(this.kHACHSANDataSet.NHANVIEN);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mANVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                    mANVTextEdit.Focus();
                    return;
                }
                if (hoNVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Họ nhân viên không được trống!", "", MessageBoxButtons.OK);
                    hoNVTextEdit.Focus();
                    return;
                }
                if (tenNVTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Tên nhân viên không được trống!", "", MessageBoxButtons.OK);
                    tenNVTextEdit.Focus();
                    return;
                }
                if (luongNVSpinEdit.Value <= 0)
                {
                    MessageBox.Show("Lương không hợp lệ", "", MessageBoxButtons.OK);
                    luongNVSpinEdit.Focus();
                    return;
                }
                if (cMNDTextEdit.Text.Trim() != "" && cMNDTextEdit.Text.Trim().Length < 9 || cMNDTextEdit.Text.Trim().Length > 12)
                {
                    MessageBox.Show("Độ dài CMND phải lớn hơn 9 và nhỏ hơn 12");
                    cMNDTextEdit.Focus();
                    return;
                }
                if (soDienThoaiNVTextEdit.Text.Trim() != "" && soDienThoaiNVTextEdit.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Độ dài SDT phải lớn hơn 9");
                    soDienThoaiNVTextEdit.Focus();
                    return;
                }
                try
                {
                    DataRowView drv = (DataRowView)nHANVIENBindingSource.Current;
                    nHANVIENBindingSource.EndEdit();
                    nHANVIENBindingSource.ResetCurrentItem();
                    this.nHANVIENTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.nHANVIENTableAdapter.Update(this.kHACHSANDataSet.NHANVIEN);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDONHANVIEN.Rows.RemoveAt(dtUNDONHANVIEN.Rows.Count - 1);
                    return;
                }
            }
            nHANVIENGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nHANVIENBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDONHANVIEN.RejectChanges();
                DataRowView drv = (DataRowView)nHANVIENBindingSource.Current;
                dtUNDONHANVIEN.NewRow();
                dtUNDONHANVIEN.Rows.Add(drv.Row[0].ToString(), hoNVTextEdit.Text.Trim(), tenNVTextEdit.Text.Trim(), luongNVSpinEdit.Value, ngaySinhNVDateEdit.DateTime, gioiTinhNVCheckEdit.Checked, diaChiNVTextEdit.Text.Trim(), cMNDTextEdit.Text.Trim(), soDienThoaiNVTextEdit.Text.Trim(), maBPComboBox.SelectedValue, Action);
                dtUNDONHANVIEN.AcceptChanges();
                vitri = nHANVIENBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                mANVTextEdit.Enabled = false;
                nHANVIENGridControl.Enabled = false;
                dtUNDONHANVIEN.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (nHANVIENBindingSource.Count > 0)
            {
                if (pHIEUDATBindingSource.Count == 0 && hOADONBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)nHANVIENBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa nhân viên có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDONHANVIEN.NewRow();
                        dtUNDONHANVIEN.Rows.Add(drv.Row[0].ToString(), hoNVTextEdit.Text.Trim(), tenNVTextEdit.Text.Trim(), luongNVSpinEdit.Value, ngaySinhNVDateEdit.DateTime, gioiTinhNVCheckEdit.Checked, diaChiNVTextEdit.Text.Trim(), cMNDTextEdit.Text.Trim(), soDienThoaiNVTextEdit.Text.Trim(), maBPComboBox.SelectedValue, Action);
                        dtUNDONHANVIEN.AcceptChanges();
                        nHANVIENBindingSource.RemoveCurrent();
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
            if (dtUNDONHANVIEN.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDONHANVIEN.Rows[dtUNDONHANVIEN.Rows.Count - 1];
                String temp = dr[10].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM NHANVIEN WHERE manv ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.NHANVIEN.RejectChanges();
                            DataRow dt = kHACHSANDataSet.NHANVIEN.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.NHANVIEN.Rows.Remove(dt);
                            kHACHSANDataSet.NHANVIEN.AcceptChanges();
                            dtREDONHANVIEN.RejectChanges();
                            dtREDONHANVIEN.NewRow();
                            dtREDONHANVIEN.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], "INSERT");
                            dtREDONHANVIEN.AcceptChanges();
                            dtUNDONHANVIEN.RejectChanges();
                            dtUNDONHANVIEN.Rows.RemoveAt(dtUNDONHANVIEN.Rows.Count - 1);
                            dtUNDONHANVIEN.AcceptChanges();
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
                        string sql = "UPDATE [NHANVIEN]  SET [MANV] ='" + dr[0].ToString() + "',[HoNV] = N'" + dr[1] + "',[TenNV] = N'" + dr[2] + "',[LuongNV] = " + dr[3] + ",[NgaySinhNV] ='" + dr[4] + "',[GioiTinhNV] ='" + dr[5] + "',[DiaChiNV] = N'" + dr[6] + "',[CMND] = '" + dr[7] + "' ,[SoDienThoaiNV] = '" + dr[8] + "',[MaBP] ='" + dr[9] + "' WHERE [MANV] ='" + dr[0] + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.NHANVIEN.RejectChanges();
                            DataRow dt = kHACHSANDataSet.NHANVIEN.Rows.Find(dr[0].ToString());
                            dtREDONHANVIEN.RejectChanges();
                            dtREDONHANVIEN.NewRow();
                            dtREDONHANVIEN.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], dt[4], dt[5], dt[6], dt[7], dt[8], dt[9], "UPDATE");
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            dt[4] = dr[4];
                            dt[5] = dr[5];
                            dt[6] = dr[6];
                            dt[7] = dr[7];
                            dt[8] = dr[8];
                            dt[9] = dr[9];
                            kHACHSANDataSet.NHANVIEN.AcceptChanges(); dtREDONHANVIEN.AcceptChanges();
                            dtUNDONHANVIEN.RejectChanges();
                            dtUNDONHANVIEN.Rows.RemoveAt(dtREDONHANVIEN.Rows.Count - 1);
                            dtUNDONHANVIEN.AcceptChanges();
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
                        string sql = "INSERT INTO [dbo].[NHANVIEN]([MANV],[HoNV],[TenNV],[LuongNV],[NgaySinhNV],[GioiTinhNV],[DiaChiNV],[CMND],[SoDienThoaiNV],[MaBP])VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "',N'" + dr[6] + "','" + dr[7] + "','" + dr[8] + "','" + dr[9] + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.NHANVIEN.RejectChanges();
                            kHACHSANDataSet.NHANVIEN.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
                            kHACHSANDataSet.NHANVIEN.AcceptChanges();
                            dtREDONHANVIEN.RejectChanges();
                            dtREDONHANVIEN.NewRow();
                            dtREDONHANVIEN.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], "DELETE");
                            dtREDONHANVIEN.AcceptChanges();
                            dtUNDONHANVIEN.RejectChanges();
                            dtUNDONHANVIEN.Rows.RemoveAt(dtREDONHANVIEN.Rows.Count - 1);
                            dtUNDONHANVIEN.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) nHANVIENBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDONHANVIEN.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            nHANVIENGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bOPHANTableAdapter.Fill(this.kHACHSANDataSet.BOPHAN);
                this.nHANVIENTableAdapter.Fill(this.kHACHSANDataSet.NHANVIEN);
                dtREDONHANVIEN.Clear();
                dtUNDONHANVIEN.Clear();
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
            if (dtREDONHANVIEN.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDONHANVIEN.Rows[dtREDONHANVIEN.Rows.Count - 1];
                String temp = dr[10].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM NHANVIEN WHERE manv ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.NHANVIEN.RejectChanges();
                            DataRow dt = kHACHSANDataSet.NHANVIEN.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.NHANVIEN.Rows.Remove(dt);
                            kHACHSANDataSet.NHANVIEN.AcceptChanges();
                            dtUNDONHANVIEN.RejectChanges();
                            dtUNDONHANVIEN.NewRow();
                            dtUNDONHANVIEN.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], "INSERT");
                            dtUNDONHANVIEN.AcceptChanges();
                            dtREDONHANVIEN.RejectChanges();
                            dtREDONHANVIEN.Rows.RemoveAt(dtREDONHANVIEN.Rows.Count - 1);
                            dtREDONHANVIEN.AcceptChanges();
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
                        string sql = "UPDATE [NHANVIEN]  SET [MANV] ='" + dr[0].ToString() + "',[HoNV] = N'" + dr[1] + "',[TenNV] = N'" + dr[2] + "',[LuongNV] = " + dr[3] + ",[NgaySinhNV] ='" + dr[4] + "',[GioiTinhNV] ='" + dr[5] + "',[DiaChiNV] = N'" + dr[6] + "',[CMND] = '" + dr[7] + "' ,[SoDienThoaiNV] = '" + dr[8] + "',[MaBP] ='" + dr[9] + "' WHERE [MANV] ='" + dr[0] + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.NHANVIEN.RejectChanges();
                            DataRow dt = kHACHSANDataSet.NHANVIEN.Rows.Find(dr[0].ToString());
                            dtUNDONHANVIEN.RejectChanges();
                            dtUNDONHANVIEN.NewRow();
                            dtUNDONHANVIEN.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], dt[4], dt[5], dt[6], dt[7], dt[8], dt[9], "UPDATE");
                            dtUNDONHANVIEN.AcceptChanges();
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            dt[4] = dr[4];
                            dt[5] = dr[5];
                            dt[6] = dr[6];
                            dt[7] = dr[7];
                            dt[8] = dr[8];
                            dt[9] = dr[9];
                            kHACHSANDataSet.NHANVIEN.AcceptChanges();
                            dtREDONHANVIEN.RejectChanges();
                            dtREDONHANVIEN.Rows.RemoveAt(dtREDONHANVIEN.Rows.Count - 1);
                            dtREDONHANVIEN.AcceptChanges();
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
                        string sql = "INSERT INTO [dbo].[NHANVIEN]([MANV],[HoNV],[TenNV],[LuongNV],[NgaySinhNV],[GioiTinhNV],[DiaChiNV],[CMND],[SoDienThoaiNV],[MaBP])VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "',N'" + dr[6] + "','" + dr[7] + "','" + dr[8] + "','" + dr[9] + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.NHANVIEN.RejectChanges();
                            kHACHSANDataSet.NHANVIEN.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
                            kHACHSANDataSet.NHANVIEN.AcceptChanges();
                            dtUNDONHANVIEN.RejectChanges();
                            dtUNDONHANVIEN.NewRow();
                            dtUNDONHANVIEN.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], "DELETE");
                            dtUNDONHANVIEN.AcceptChanges();
                            dtREDONHANVIEN.RejectChanges();
                            dtREDONHANVIEN.Rows.RemoveAt(dtREDONHANVIEN.Rows.Count - 1);
                            dtREDONHANVIEN.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) nHANVIENBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDONHANVIEN.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            nHANVIENGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mANVTextEdit.Enabled == false)
            {
                dtUNDONHANVIEN.RejectChanges();
                dtUNDONHANVIEN.Rows.RemoveAt(dtUNDONHANVIEN.Rows.Count - 1);
                dtUNDONHANVIEN.AcceptChanges();
            }
            nHANVIENBindingSource.CancelEdit();
            if (btnThem.Enabled == false) nHANVIENBindingSource.Position = vitri;
            nHANVIENGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void mANVTextEdit_Leave(object sender, EventArgs e)
        {
            mANVTextEdit.Text = mANVTextEdit.Text.Trim();
            if (mANVTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống");
                mANVTextEdit.Focus();
            }
            else
            {
                mANVTextEdit.Text = mANVTextEdit.Text.Trim().ToUpper();

            }
        }

        private void mANVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void hoNVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void hoNVTextEdit_Leave(object sender, EventArgs e)
        {
            hoNVTextEdit.Text = DataUtil.xoaKhoangTrang(hoNVTextEdit.Text);
            if (hoNVTextEdit.Text == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống");
                hoNVTextEdit.Focus();
            }
        }

        private void tenNVTextEdit_Leave(object sender, EventArgs e)
        {
            tenNVTextEdit.Text = DataUtil.xoaKhoangTrang(tenNVTextEdit.Text);
            if (tenNVTextEdit.Text == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống");
                tenNVTextEdit.Focus();
            }
        }

        private void tenNVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete;
        }

        private void maBPComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void diaChiNVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void diaChiNVTextEdit_Leave(object sender, EventArgs e)
        {
            diaChiNVTextEdit.Text = DataUtil.xoaKhoangTrang(diaChiNVTextEdit.Text);
        }

        private void soDienThoaiNVTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void soDienThoaiNVTextEdit_Leave(object sender, EventArgs e)
        {
            if (soDienThoaiNVTextEdit.Text.Trim() != "" && soDienThoaiNVTextEdit.Text.Trim().Length < 10)
            {
                MessageBox.Show("Độ dài SDT phải lớn hơn 9");
                soDienThoaiNVTextEdit.Focus();
            }
        }

        private void cMNDTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void cMNDTextEdit_Leave(object sender, EventArgs e)
        {
            if (cMNDTextEdit.Text.Trim() != "" && cMNDTextEdit.Text.Trim().Length < 9 || cMNDTextEdit.Text.Trim().Length > 12)
            {
                MessageBox.Show("Độ dài CMND phải lớn hơn 9 và nhỏ hơn 12");
                cMNDTextEdit.Focus();
            }
        }

        private void maBPComboBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
