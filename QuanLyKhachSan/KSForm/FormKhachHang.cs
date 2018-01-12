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
    public partial class FormKhachHang : Form
    {
        public static DataTable dtREDOKHACHHANG = new DataTable();
        public static DataTable dtUNDOKHACHHANG = new DataTable();
        int vitri = 0;
        String Action = "";

        public FormKhachHang()
        {
            InitializeComponent();
            if (dtUNDOKHACHHANG.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOKHACHHANG.Columns.Add("CMND_NGaysinh", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("HONV", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("TENKHACHHANG", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("SODT", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("gioitinhnv", typeof(Boolean));
                dtUNDOKHACHHANG.Columns.Add("ngaysinhnv", typeof(DateTime));
                dtUNDOKHACHHANG.Columns.Add("email", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("stk", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("nganhang", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("chinhanhnganhang", typeof(string));
                dtUNDOKHACHHANG.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOKHACHHANG.Columns.Add("CMND_NGaysinh", typeof(string));
                dtREDOKHACHHANG.Columns.Add("HONV", typeof(string));
                dtREDOKHACHHANG.Columns.Add("TENKHACHHANG", typeof(string));
                dtREDOKHACHHANG.Columns.Add("SODT", typeof(string));
                dtREDOKHACHHANG.Columns.Add("gioitinhnv", typeof(Boolean));
                dtREDOKHACHHANG.Columns.Add("ngaysinhnv", typeof(DateTime));
                dtREDOKHACHHANG.Columns.Add("email", typeof(string));
                dtREDOKHACHHANG.Columns.Add("stk", typeof(string));
                dtREDOKHACHHANG.Columns.Add("nganhang", typeof(string));
                dtREDOKHACHHANG.Columns.Add("chinhanhnganhang", typeof(string));
                dtREDOKHACHHANG.Columns.Add("ACTION", typeof(string));
            }
            btnGhi.Enabled = btnHuy.Enabled = false;

        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            this.cTKHACHTHUETableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.PHIEUDAT' table. You can move, or remove it, as needed.
            this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTKHACHTHUE' table. You can move, or remove it, as needed.
            this.cTKHACHTHUETableAdapter.Fill(this.kHACHSANDataSet.CTKHACHTHUE);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
            if (kHACHHANGBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }

        private void updatetable()
        {
            this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kHACHHANGTableAdapter.Update(this.kHACHSANDataSet);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = kHACHHANGBindingSource.Position;
            kHACHHANGBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            kHACHHANGGridControl.Enabled = false;
            cMND_PASSPORTTextEdit.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cMND_PASSPORTTextEdit.Enabled == true)
            {
                if (cMND_PASSPORTTextEdit.Text.Trim() == "" || cMND_PASSPORTTextEdit.Text.Length < 9)
                {
                    MessageBox.Show("Chứng minh nhân dân của khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                    cMND_PASSPORTTextEdit.Focus();
                    return;
                }
                else
                {
                    cMND_PASSPORTTextEdit.Text = cMND_PASSPORTTextEdit.Text.ToUpper();
                }
                hoKHTextEdit.Text = DataUtil.xoaKhoangTrang(hoKHTextEdit.Text);
                if (hoKHTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Họ khách hàng không được trống!", "", MessageBoxButtons.OK);
                    hoKHTextEdit.Focus();
                    return;
                }
                tenKHTextEdit.Text = DataUtil.xoaKhoangTrang(tenKHTextEdit.Text);
                if (tenKHTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khách hàng không được trống!", "", MessageBoxButtons.OK);
                    tenKHTextEdit.Focus();
                    return;
                }
                if (soDienThoaiKHTextEdit.Text.Trim() != "" && soDienThoaiKHTextEdit.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Độ dài SDT phải lớn hơn 9");
                    soDienThoaiKHTextEdit.Focus();
                    return;
                }
                nganHangTextEdit.Text = DataUtil.xoaKhoangTrang(nganHangTextEdit.Text);

                //if (!IsValidEmail(emailTextEdit.Text) && emailTextEdit.Text.Trim() != "")
                //{
                //    MessageBox.Show("Email không đúng định dạng");
                //    emailTextEdit.Focus();
                //    return;

                //}
                try
                {
                    dtUNDOKHACHHANG.RejectChanges();
                    DataRowView drv = (DataRowView)kHACHHANGBindingSource.Current;
                    dtUNDOKHACHHANG.NewRow();
                    dtUNDOKHACHHANG.Rows.Add(cMND_PASSPORTTextEdit.Text, hoKHTextEdit.Text.Trim(), tenKHTextEdit.Text.Trim(), soDienThoaiKHTextEdit.Text, gioiTinhKHCheckEdit.Checked, ngaySinhKHDateEdit.DateTime,"",sTKSpinEdit.Text,nganHangTextEdit.Text,chiNhanhNHTextEdit.Text,Action);
                    dtUNDOKHACHHANG.AcceptChanges();
                    kHACHHANGBindingSource.EndEdit();
                    kHACHHANGBindingSource.ResetCurrentItem();
                    this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.kHACHHANGTableAdapter.Update(this.kHACHSANDataSet.KHACHHANG);


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
                if (cMND_PASSPORTTextEdit.Text.Trim() == "" || cMND_PASSPORTTextEdit.Text.Length < 9)
                {
                    MessageBox.Show("Chứng minh nhân dân của khách hàng không được thiếu!", "", MessageBoxButtons.OK);
                    cMND_PASSPORTTextEdit.Focus();
                    return;
                }
                hoKHTextEdit.Text = DataUtil.xoaKhoangTrang(hoKHTextEdit.Text);
                if (hoKHTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Họ khách hàng không được trống!", "", MessageBoxButtons.OK);
                    hoKHTextEdit.Focus();
                    return;
                }
                tenKHTextEdit.Text = DataUtil.xoaKhoangTrang(tenKHTextEdit.Text);
                if (tenKHTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khách hàng không được trống!", "", MessageBoxButtons.OK);
                    tenKHTextEdit.Focus();
                    return;
                }
                if (soDienThoaiKHTextEdit.Text.Trim()!="" && soDienThoaiKHTextEdit.Text.Trim().Length < 10)
                {
                    MessageBox.Show("Độ dài số điện thoại phải lớn hơn 9");
                    soDienThoaiKHTextEdit.Focus();
                    return;

                }
                nganHangTextEdit.Text = DataUtil.xoaKhoangTrang(nganHangTextEdit.Text);
                chiNhanhNHTextEdit.Text = DataUtil.xoaKhoangTrang(chiNhanhNHTextEdit.Text);

                //if (!IsValidEmail(emailTextEdit.Text) && emailTextEdit.Text.Trim() != "")
                //{
                //    MessageBox.Show("Email không đúng định dạng");
                //    emailTextEdit.Focus();
                //    return;
                //}
                try
                {
                    DateTime sv = ngaySinhKHDateEdit.DateTime;
                    DataRowView drv = (DataRowView)kHACHHANGBindingSource.Current;
                    drv[5] = sv;
                    kHACHHANGBindingSource.EndEdit();
                    kHACHHANGBindingSource.ResetCurrentItem();
                    this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.kHACHHANGTableAdapter.Update(this.kHACHSANDataSet.KHACHHANG);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOKHACHHANG.Rows.RemoveAt(dtUNDOKHACHHANG.Rows.Count - 1);
                    return;
                }
            }
            kHACHHANGGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHACHHANGBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDOKHACHHANG.RejectChanges();
                DataRowView drv = (DataRowView)kHACHHANGBindingSource.Current;
                dtUNDOKHACHHANG.NewRow();
                dtUNDOKHACHHANG.Rows.Add(cMND_PASSPORTTextEdit.Text, hoKHTextEdit.Text.Trim(), tenKHTextEdit.Text.Trim(), soDienThoaiKHTextEdit.Text, gioiTinhKHCheckEdit.Checked, ngaySinhKHDateEdit.DateTime,"", sTKSpinEdit.Text, nganHangTextEdit.Text, chiNhanhNHTextEdit.Text, Action);
                dtUNDOKHACHHANG.AcceptChanges();
                vitri = kHACHHANGBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                cMND_PASSPORTTextEdit.Enabled = false;
                kHACHHANGGridControl.Enabled = false;
                dtUNDOKHACHHANG.RejectChanges();
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kHACHHANGBindingSource.Count > 0)
            {
                if (cTKHACHTHUEBindingSource.Count == 0 && pHIEUDATBindingSource.Count == 0)
                {
                    DataRowView drv = (DataRowView)kHACHHANGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa khách hàng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOKHACHHANG.NewRow();
                        dtUNDOKHACHHANG.Rows.Add(cMND_PASSPORTTextEdit.Text, hoKHTextEdit.Text.Trim(), tenKHTextEdit.Text.Trim(), soDienThoaiKHTextEdit.Text, gioiTinhKHCheckEdit.Checked, ngaySinhKHDateEdit.DateTime, "", sTKSpinEdit.Text, nganHangTextEdit.Text, chiNhanhNHTextEdit.Text, Action);
                        dtUNDOKHACHHANG.AcceptChanges();
                        kHACHHANGBindingSource.RemoveCurrent();
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
            if (dtUNDOKHACHHANG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOKHACHHANG.Rows[dtUNDOKHACHHANG.Rows.Count - 1];
                String temp = dr[10].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM KHACHHANG WHERE CMND_PASSPORT ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KHACHHANG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KHACHHANG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.KHACHHANG.Rows.Remove(dt);
                            kHACHSANDataSet.KHACHHANG.AcceptChanges();
                            dtREDOKHACHHANG.RejectChanges();
                            dtREDOKHACHHANG.NewRow();
                            dtREDOKHACHHANG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6],dr[7],dr[8],dr[9], "INSERT");
                            dtREDOKHACHHANG.AcceptChanges();
                            dtUNDOKHACHHANG.RejectChanges();
                            dtUNDOKHACHHANG.Rows.RemoveAt(dtUNDOKHACHHANG.Rows.Count - 1);
                            dtUNDOKHACHHANG.AcceptChanges();
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
                        string sql = "UPDATE [dbo].[KHACHHANG] SET [CMND_PASSPORT] = '" + dr[0] + "',[HoKH] = N'" + dr[1] + "',[TenKH] = N'" + dr[2] + "',[SoDienThoaiKH] = '" + dr[3] + "',[GioiTinhKH] ='" + dr[4] + "' ,[NgaySinhKH] = '" + dr[5] + "',[Email] = '" + dr[6] + "',[STK] =" + dr[7] + ",[NganHang] = N'" + dr[8] + "',[ChiNhanhNH] = N'" + dr[9] + "'WHERE CMND_PASSPORT='" + dr[0] + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KHACHHANG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KHACHHANG.Rows.Find(dr[0].ToString());
                            dtREDOKHACHHANG.RejectChanges();
                            dtREDOKHACHHANG.NewRow();
                            dtREDOKHACHHANG.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], dt[4], dt[5], dt[6], dt[7], dt[8], dt[9], "UPDATE");
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            dt[4] = dr[4];
                            dt[5] = dr[5];
                            dt[6] = dr[6];
                            dt[7] = dr[7];
                            dt[8] = dr[8];
                            dt[9] = dr[9];
                            kHACHSANDataSet.KHACHHANG.AcceptChanges(); dtREDOKHACHHANG.AcceptChanges();
                            dtUNDOKHACHHANG.RejectChanges();
                            dtUNDOKHACHHANG.Rows.RemoveAt(dtUNDOKHACHHANG.Rows.Count - 1);
                            dtUNDOKHACHHANG.AcceptChanges();
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
                        string sql = "INSERT INTO [KHACHHANG]([CMND_PASSPORT],[HoKH],[TenKH],[SoDienThoaiKH],[GioiTinhKH],[NgaySinhKH],[Email],[STK],[NganHang],[ChiNhanhNH]) VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "','" + dr[6] + "'," + dr[7] + ",'" + dr[8] + "','" + dr[9] + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KHACHHANG.RejectChanges();
                            kHACHSANDataSet.KHACHHANG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9]);
                            kHACHSANDataSet.KHACHHANG.AcceptChanges();
                            dtREDOKHACHHANG.RejectChanges();
                            dtREDOKHACHHANG.NewRow();
                            dtREDOKHACHHANG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9],"DELETE");
                            dtREDOKHACHHANG.AcceptChanges();
                            dtUNDOKHACHHANG.RejectChanges();
                            dtUNDOKHACHHANG.Rows.RemoveAt(dtUNDOKHACHHANG.Rows.Count - 1);
                            dtUNDOKHACHHANG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) kHACHHANGBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOKHACHHANG.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            kHACHHANGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
                dtREDOKHACHHANG.Clear();
                dtUNDOKHACHHANG.Clear();
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
            if (dtREDOKHACHHANG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOKHACHHANG.Rows[dtREDOKHACHHANG.Rows.Count - 1];
                String temp = dr[7].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM KHACHHANG WHERE CMND_PASSPORT ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KHACHHANG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KHACHHANG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.KHACHHANG.Rows.Remove(dt);
                            kHACHSANDataSet.KHACHHANG.AcceptChanges();
                            dtUNDOKHACHHANG.RejectChanges();
                            dtUNDOKHACHHANG.NewRow();
                            dtUNDOKHACHHANG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], "INSERT");
                            dtUNDOKHACHHANG.AcceptChanges();
                            dtREDOKHACHHANG.RejectChanges();
                            dtREDOKHACHHANG.Rows.RemoveAt(dtREDOKHACHHANG.Rows.Count - 1);
                            dtREDOKHACHHANG.AcceptChanges();
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
                        string sql = "UPDATE [dbo].[KHACHHANG] SET [CMND_PASSPORT] = '" + dr[0] + "',[HoKH] = N'" + dr[1] + "',[TenKH] = N'" + dr[2] + "',[SoDienThoaiKH] = '" + dr[3] + "',[GioiTinhKH] ='" + dr[4] + "' ,[NgaySinhKH] = '" + dr[5] + "',[Email] = '" + dr[6] + "',[STK] =" + dr[7] + ",[NganHang] = N'" + dr[8] + "',[ChiNhanhNH] = N'" + dr[9] + "'WHERE CMND_PASSPORT='" + dr[0] + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KHACHHANG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.KHACHHANG.Rows.Find(dr[0].ToString());
                            dtUNDOKHACHHANG.RejectChanges();
                            dtUNDOKHACHHANG.NewRow();
                            dtUNDOKHACHHANG.Rows.Add(dr[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3], dt[4], dt[5], dt[6], dt[7], dt[8], dt[9], "UPDATE");
                            dtUNDOKHACHHANG.AcceptChanges();
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            dt[4] = dr[4];
                            dt[5] = dr[5];
                            dt[6] = dr[6];
                            dt[7] = dr[7];
                            dt[8] = dr[8];
                            dt[9] = dr[9];
                            kHACHSANDataSet.KHACHHANG.AcceptChanges();
                            dtREDOKHACHHANG.RejectChanges();
                            dtREDOKHACHHANG.Rows.RemoveAt(dtREDOKHACHHANG.Rows.Count - 1);
                            dtREDOKHACHHANG.AcceptChanges();
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
                        string sql = "INSERT INTO [KHACHHANG]([CMND_PASSPORT],[HoKH],[TenKH],[SoDienThoaiKH],[GioiTinhKH],[NgaySinhKH],[Email],[STK],[NganHang],[ChiNhanhNH]) VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "','" + dr[6] + "'," + dr[7] + ",'" + dr[8] + "','" + dr[9] +"')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.KHACHHANG.RejectChanges();
                            kHACHSANDataSet.KHACHHANG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3], dr[4], dr[5], dr[6],dr[7],dr[8],dr[9]);
                            kHACHSANDataSet.KHACHHANG.AcceptChanges();
                            dtUNDOKHACHHANG.RejectChanges();
                            dtUNDOKHACHHANG.NewRow();
                            dtUNDOKHACHHANG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3], dr[4], dr[5], dr[6], dr[7], dr[8], dr[9], "DELETE");
                            dtUNDOKHACHHANG.AcceptChanges();
                            dtREDOKHACHHANG.RejectChanges();
                            dtREDOKHACHHANG.Rows.RemoveAt(dtREDOKHACHHANG.Rows.Count - 1);
                            dtREDOKHACHHANG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) kHACHHANGBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOKHACHHANG.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            kHACHHANGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }



        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cMND_PASSPORTTextEdit.Enabled == false)
            {
                dtUNDOKHACHHANG.RejectChanges();
                dtUNDOKHACHHANG.Rows.RemoveAt(dtUNDOKHACHHANG.Rows.Count - 1);
                dtUNDOKHACHHANG.AcceptChanges();
            }
            kHACHHANGBindingSource.CancelEdit();
            if (btnThem.Enabled == false) kHACHHANGBindingSource.Position = vitri;
            kHACHHANGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void soDienThoaiKHTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void cMND_PASSPORTTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void cMND_PASSPORTTextEdit_Leave(object sender, EventArgs e)
        {
            if (cMND_PASSPORTTextEdit.Text == null || cMND_PASSPORTTextEdit.Text.Trim().Length < 9 || cMND_PASSPORTTextEdit.Text.Trim().Length > 12)
            {
                MessageBox.Show("Độ dài CMND phải lớn hơn 9 và nhỏ hơn 12");
                cMND_PASSPORTTextEdit.Focus();
            }
        }

        private void soDienThoaiKHTextEdit_Leave(object sender, EventArgs e)
        {
            if (soDienThoaiKHTextEdit.Text.Trim() != "" && soDienThoaiKHTextEdit.Text.Trim().Length < 10)
            {
                MessageBox.Show("Độ dài số điện thoại phải lớn hơn 9");
                soDienThoaiKHTextEdit.Focus();
            }
        }

        private void hoKHTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }

        private void hoKHTextEdit_Leave(object sender, EventArgs e)
        {
            hoKHTextEdit.Text = DataUtil.xoaKhoangTrang(hoKHTextEdit.Text);
            if (hoKHTextEdit.Text == "")
            {
                MessageBox.Show("Họ khách hàng không được để trống");
                hoKHTextEdit.Focus();
            }
        }

        private void tenKHTextEdit_Leave(object sender, EventArgs e)
        {
            tenKHTextEdit.Text = DataUtil.xoaKhoangTrang(tenKHTextEdit.Text);
            if (tenKHTextEdit.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được để trống");
                tenKHTextEdit.Focus();
            }
        }

        private void tenKHTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete;
        }

        //private void emailTextEdit_MouseLeave(object sender, EventArgs e)
        //{
        //    if (!IsValidEmail(emailTextEdit.Text) && emailTextEdit.Text.Trim() != "")
        //    {
        //        MessageBox.Show("Email không đúng định dạng");
        //        emailTextEdit.Focus();
        //    }

        //}

        private void chiNhanhNHTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete;
        }

        private void chiNhanhNHTextEdit_Leave(object sender, EventArgs e)
        {
             chiNhanhNHTextEdit.Text = DataUtil.xoaKhoangTrang(chiNhanhNHTextEdit.Text);
        }

        private void nganHangTextEdit_Leave(object sender, EventArgs e)
        {
            nganHangTextEdit.Text = DataUtil.xoaKhoangTrang(nganHangTextEdit.Text);
        }

        private void nganHangTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete;
        }

        private void sTKSpinEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void sTKSpinEdit_Leave(object sender, EventArgs e)
        {
            if (sTKSpinEdit.Text.Trim() != "" && sTKSpinEdit.Text.Trim().Length < 10)
            {
                MessageBox.Show("Độ dài số tài khoản phải lớn hơn 9");
                sTKSpinEdit.Focus();
            }
        }
    }
}
