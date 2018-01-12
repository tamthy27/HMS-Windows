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
using System.IO;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormHangPhong : Form
    {
        public static DataTable dtREDOHANGPHONG = new DataTable();
        public static DataTable dtUNDOHANGPHONG = new DataTable();
        int vitri = 0;
        String Action = "";
        String filename = "";
        public FormHangPhong()
        {
            InitializeComponent();
            if (dtUNDOHANGPHONG.Columns.Count < 1)
            {
                btnUndo.Enabled = false;
                dtUNDOHANGPHONG.Columns.Add("MAHANGPHONG", typeof(string));
                dtUNDOHANGPHONG.Columns.Add("MALOAIPHONG", typeof(string));
                dtUNDOHANGPHONG.Columns.Add("MAKIEUPHONG", typeof(string));
                dtUNDOHANGPHONG.Columns.Add("TENHANGPHONG", typeof(string));
                dtUNDOHANGPHONG.Columns.Add("hinhanh", typeof(string));
                dtUNDOHANGPHONG.Columns.Add("ACTION", typeof(string));
                btnRedo.Enabled = false;
                dtREDOHANGPHONG.Columns.Add("MAHANGPHONG", typeof(string));
                dtREDOHANGPHONG.Columns.Add("MALOAIPHONG", typeof(string));
                dtREDOHANGPHONG.Columns.Add("MAKIEUPHONG", typeof(string));
                dtREDOHANGPHONG.Columns.Add("TENHANGPHONG", typeof(string));
                dtREDOHANGPHONG.Columns.Add("hinhanh", typeof(string));
                dtREDOHANGPHONG.Columns.Add("ACTION", typeof(string));
                btnGhi.Enabled = btnHuy.Enabled = false;
            }
            btnGhi.Enabled = btnHuy.Enabled = false;


        }

        private void hANGPHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hANGPHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }
        private void updatetable()
        {
            try
            {
                this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                this.hANGPHONGTableAdapter.Update(this.kHACHSANDataSet);
            }
            catch
            {
                MessageBox.Show("Tồn tại phòng thuộc hạng phòng!", "", MessageBoxButtons.OK);

            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = hANGPHONGBindingSource.Position;
            hANGPHONGBindingSource.AddNew();
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnHuy.Enabled = true;
            hANGPHONGGridControl.Enabled = false;
            mAHangPhongTextEdit.Enabled = true;
            Action = "DELETE";
            groupBox1.Enabled = true;
            mALoaiPhongComboBox.SelectedItem = 0;
            mAKieuPhongComboBox.SelectedItem = 0;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAHangPhongTextEdit.Enabled == true)
            {
                if (mALoaiPhongComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Loại phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiPhongComboBox.Focus();
                    return;
                }

                if (mAKieuPhongComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Kiểu phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mAKieuPhongComboBox.Focus();
                    return;
                }
                if (mAHangPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã hạng phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mAHangPhongTextEdit.Focus();
                    return;
                }
                else
                {
                    mAHangPhongTextEdit.Text = mAHangPhongTextEdit.Text.ToUpper();
                }
                if (hangPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Hạng phòng không được trống!", "", MessageBoxButtons.OK);
                    hangPhongTextEdit.Focus();
                    return;
                }
                try
                {
                    String appPath = @"C:\Users\Thy Dinh\Documents\visual studio 2015\Projects\quanlykhachsanserver\WebApplication1\Assets\admin\img\";
                    if (!File.Exists(appPath + hinhAnhTextEdit.Text))
                    {
                        File.Copy(filename, @"C:\Users\Thy Dinh\Documents\visual studio 2015\Projects\quanlykhachsanserver\WebApplication1\Assets\admin\img\" + hinhAnhTextEdit.Text);
                        File.Copy(filename, @"C:\Users\Thy Dinh\Documents\Visual Studio 2015\Projects\QuanLyKhachSan\QuanLyKhachSan\img\" + hinhAnhTextEdit.Text);
                    }
                    dtUNDOHANGPHONG.RejectChanges();
                    DataRowView drv = (DataRowView)hANGPHONGBindingSource.Current;
                    dtUNDOHANGPHONG.RejectChanges();
                    dtUNDOHANGPHONG.NewRow();
                    dtUNDOHANGPHONG.Rows.Add(mAHangPhongTextEdit.Text, mALoaiPhongComboBox.SelectedValue, mAKieuPhongComboBox.SelectedValue, hangPhongTextEdit.Text, hinhAnhTextEdit.Text, Action);
                    dtUNDOHANGPHONG.AcceptChanges();
                    drv.Row[1] = mALoaiPhongComboBox.SelectedValue;
                    drv.Row[2] = mAKieuPhongComboBox.SelectedValue;
                    drv.Row[4] = hinhAnhTextEdit.Text;

                    hANGPHONGBindingSource.EndEdit();
                    hANGPHONGBindingSource.ResetCurrentItem();
                    this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.hANGPHONGTableAdapter.Update(this.kHACHSANDataSet.HANGPHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Hạng Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            //update
            else
            {
                if (mALoaiPhongComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Loại phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mALoaiPhongComboBox.Focus();
                    return;
                }
                if (mAKieuPhongComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Kiểu phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mAKieuPhongComboBox.Focus();
                    return;
                }
                if (mAHangPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Mã hạng phòng không được thiếu!", "", MessageBoxButtons.OK);
                    mAHangPhongTextEdit.Focus();
                    return;
                }
                else
                {
                    mAHangPhongTextEdit.Text = mAHangPhongTextEdit.Text.ToUpper();
                }
                if (hangPhongTextEdit.Text.Trim() == "")
                {
                    MessageBox.Show("Hạng phòng không được trống!", "", MessageBoxButtons.OK);
                    hangPhongTextEdit.Focus();
                    return;
                }
                try
                {
                    String appPath = @"C:\Users\Thy Dinh\Documents\visual studio 2015\Projects\quanlykhachsanserver\WebApplication1\Assets\admin\img\";
                    if (!File.Exists(appPath+hinhAnhTextEdit.Text))
                    {
                        File.Copy(filename, @"C:\Users\Thy Dinh\Documents\visual studio 2015\Projects\quanlykhachsanserver\WebApplication1\Assets\admin\img\"+hinhAnhTextEdit.Text);
                        File.Copy(filename, @"C:\Users\Thy Dinh\Documents\Visual Studio 2015\Projects\QuanLyKhachSan\QuanLyKhachSan\img\" + hinhAnhTextEdit.Text);
                    }
                    DataRowView drv = (DataRowView)hANGPHONGBindingSource.Current;
                    drv.Row[4] = hinhAnhTextEdit.Text;
                    drv.Row[1] = mALoaiPhongComboBox.SelectedValue;
                    drv.Row[2] = mAKieuPhongComboBox.SelectedValue;
                    hANGPHONGBindingSource.EndEdit();
                    hANGPHONGBindingSource.ResetCurrentItem();
                    this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
                    this.hANGPHONGTableAdapter.Update(this.kHACHSANDataSet.HANGPHONG);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi Hạng Phòng.\n" + ex.Message, "", MessageBoxButtons.OK);
                    dtUNDOHANGPHONG.RejectChanges();
                    dtUNDOHANGPHONG.Rows.RemoveAt(dtUNDOHANGPHONG.Rows.Count - 1);
                    dtUNDOHANGPHONG.AcceptChanges();
                    return;
                }
            }
            hANGPHONGGridControl.Enabled = true;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hANGPHONGBindingSource.Count > 0)
            {
                Action = "UPDATE";
                dtUNDOHANGPHONG.RejectChanges();
                DataRowView drv = (DataRowView)hANGPHONGBindingSource.Current;
                dtUNDOHANGPHONG.NewRow();
                dtUNDOHANGPHONG.Rows.Add(mAHangPhongTextEdit.Text, mALoaiPhongComboBox.SelectedValue, mAKieuPhongComboBox.SelectedValue, hangPhongTextEdit.Text, hinhAnhTextEdit.Text, Action);
                dtUNDOHANGPHONG.AcceptChanges();
                vitri = hANGPHONGBindingSource.Position;
                groupBox1.Enabled = true;
                btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
                btnGhi.Enabled = btnHuy.Enabled = true;
                mAHangPhongTextEdit.Enabled = false;
                hANGPHONGGridControl.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không tồn tại danh mục nào!");
            }
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hANGPHONGBindingSource.Count > 0)
            {
                if (gIAPHONGBindingSource.Count == 0 && cTPHIEUDATBindingSource.Count == 0  && pHONGBindingSource.Count == 0 &&cTKM_HANGPHONGBindingSource.Count==0)
                {
                    DataRowView drv = (DataRowView)hANGPHONGBindingSource.Current;
                    DialogResult dlResult = MessageBox.Show("Bạn muốn xóa hạng phòng có mã " + drv.Row[0].ToString() + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Console.WriteLine("dialogResult" + dlResult);
                    if (dlResult == DialogResult.OK)
                    {
                        Action = "INSERT";
                        dtUNDOHANGPHONG.RejectChanges();
                        dtUNDOHANGPHONG.NewRow();
                        dtUNDOHANGPHONG.Rows.Add(mAHangPhongTextEdit.Text, mALoaiPhongComboBox.SelectedValue, mAKieuPhongComboBox.SelectedValue, hangPhongTextEdit.Text, hinhAnhTextEdit.Text, Action);
                        dtUNDOHANGPHONG.AcceptChanges();
                        hANGPHONGBindingSource.RemoveCurrent();
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
            if (dtUNDOHANGPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtUNDOHANGPHONG.Rows[dtUNDOHANGPHONG.Rows.Count - 1];
                String temp = dr[5].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM HANGPHONG WHERE MAHANGPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.HANGPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.HANGPHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.HANGPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.HANGPHONG.AcceptChanges();
                            dtREDOHANGPHONG.RejectChanges();
                            dtREDOHANGPHONG.NewRow();
                            dtREDOHANGPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(), "INSERT");
                            dtREDOHANGPHONG.AcceptChanges();
                            dtUNDOHANGPHONG.RejectChanges();
                            dtUNDOHANGPHONG.Rows.RemoveAt(dtUNDOHANGPHONG.Rows.Count - 1);
                            dtUNDOHANGPHONG.AcceptChanges();
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
                        string sql = "UPDATE HANGPHONG SET MAHangPhong ='" + dr[0].ToString() + "',MALoaiPhong ='" + dr[1].ToString() + "',MAKieuPhong ='" + dr[2].ToString() + "',HangPhong =N'" + dr[3].ToString() + "',[HinhAnh] = '" + dr[4].ToString() + "' WHERE MAHangPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.HANGPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.HANGPHONG.Rows.Find(dr[0].ToString());
                            dtREDOHANGPHONG.RejectChanges();
                            dtREDOHANGPHONG.NewRow();
                            dtREDOHANGPHONG.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3].ToString(),dr[4].ToString(), "UPDATE");
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            dt[4] = dr[4];
                            kHACHSANDataSet.HANGPHONG.AcceptChanges(); dtREDOHANGPHONG.AcceptChanges();
                            dtUNDOHANGPHONG.RejectChanges();
                            dtUNDOHANGPHONG.Rows.RemoveAt(dtUNDOHANGPHONG.Rows.Count - 1);
                            dtUNDOHANGPHONG.AcceptChanges();
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
                        string sql = "INSERT INTO [HANGPHONG]([MAHangPhong],[MALoaiPhong],[MAKieuPhong],[HangPhong],[HinhAnh])VALUES('" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "',N'" + dr[3].ToString() + "','" + dr[4].ToString() + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.HANGPHONG.RejectChanges();
                            kHACHSANDataSet.HANGPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3],dr[4]);
                            kHACHSANDataSet.HANGPHONG.AcceptChanges();
                            dtREDOHANGPHONG.RejectChanges();
                            dtREDOHANGPHONG.NewRow();
                            dtREDOHANGPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4], "DELETE");
                            dtREDOHANGPHONG.AcceptChanges();
                            dtUNDOHANGPHONG.RejectChanges();
                            dtUNDOHANGPHONG.Rows.RemoveAt(dtUNDOHANGPHONG.Rows.Count - 1);
                            dtUNDOHANGPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) hANGPHONGBindingSource.Position = vitri;
                btnRedo.Enabled = true;
                if (dtUNDOHANGPHONG.Rows.Count - 1 < 0)
                {
                    btnUndo.Enabled = false;

                }
            }

            hANGPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.lOAIPHONGTableAdapter.Fill(this.kHACHSANDataSet.LOAIPHONG);
                // TODO: This line of code loads data into the 'kHACHSANDataSet.HANGPHONG' table. You can move, or remove it, as needed.
                this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
                this.kIEUPHONGTableAdapter.Fill(this.kHACHSANDataSet.KIEUPHONG); dtREDOHANGPHONG.Clear();
                dtUNDOHANGPHONG.Clear();
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
            if (dtREDOHANGPHONG.Rows.Count - 1 >= 0)
            {
                DataRow dr = dtREDOHANGPHONG.Rows[dtREDOHANGPHONG.Rows.Count - 1];
                String temp = dr[5].ToString();
                if (temp.Equals("DELETE"))
                {
                    try
                    {
                        string sql = "DELETE FROM HANGPHONG WHERE MAHANGPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.HANGPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.HANGPHONG.Rows.Find(dr[0].ToString());
                            kHACHSANDataSet.HANGPHONG.Rows.Remove(dt);
                            kHACHSANDataSet.HANGPHONG.AcceptChanges();
                            dtUNDOHANGPHONG.RejectChanges();
                            dtUNDOHANGPHONG.NewRow();
                            dtUNDOHANGPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(), "INSERT");
                            dtUNDOHANGPHONG.AcceptChanges();
                            dtREDOHANGPHONG.RejectChanges();
                            dtREDOHANGPHONG.Rows.RemoveAt(dtREDOHANGPHONG.Rows.Count - 1);
                            dtREDOHANGPHONG.AcceptChanges();
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
                        string sql = "UPDATE HANGPHONG SET MAHangPhong ='" + dr[0].ToString() + "',MALoaiPhong ='" + dr[1].ToString() + "',MAKieuPhong ='" + dr[2].ToString() + "',HangPhong =N'" + dr[3].ToString() + "',[HinhAnh] = '"+ dr[4].ToString()+"' WHERE MAHangPhong ='" + dr[0].ToString() + "'";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.HANGPHONG.RejectChanges();
                            DataRow dt = kHACHSANDataSet.HANGPHONG.Rows.Find(dr[0].ToString());
                            dtUNDOHANGPHONG.RejectChanges();
                            dtUNDOHANGPHONG.NewRow();
                            dtUNDOHANGPHONG.Rows.Add(dt[0].ToString(), dt[1].ToString(), dt[2].ToString(), dt[3].ToString(),dr[4].ToString(), "UPDATE");
                            dtUNDOHANGPHONG.AcceptChanges();
                            dt[1] = dr[1];
                            dt[2] = dr[2];
                            dt[3] = dr[3];
                            dt[4] = dr[4];
                            kHACHSANDataSet.HANGPHONG.AcceptChanges();
                            dtREDOHANGPHONG.RejectChanges();
                            dtREDOHANGPHONG.Rows.RemoveAt(dtREDOHANGPHONG.Rows.Count - 1);
                            dtREDOHANGPHONG.AcceptChanges();
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
                        string sql = "INSERT INTO [HANGPHONG]([MAHangPhong],[MALoaiPhong],[MAKieuPhong],[HangPhong],[HinhAnh])VALUES('" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "',N'" + dr[3].ToString()+ "','" + dr[4].ToString() + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            kHACHSANDataSet.HANGPHONG.RejectChanges();
                            kHACHSANDataSet.HANGPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3],dr[4]);
                            kHACHSANDataSet.HANGPHONG.AcceptChanges();
                            dtUNDOHANGPHONG.RejectChanges();
                            dtUNDOHANGPHONG.NewRow();
                            dtUNDOHANGPHONG.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(), "DELETE");
                            dtUNDOHANGPHONG.AcceptChanges();
                            dtREDOHANGPHONG.RejectChanges();
                            dtREDOHANGPHONG.Rows.RemoveAt(dtREDOHANGPHONG.Rows.Count - 1);
                            dtREDOHANGPHONG.AcceptChanges();
                            updatetable();
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("WHAT's Error: " + e1.Message, "", MessageBoxButtons.OK);
                    }
                }
                if (btnThem.Enabled == false) hANGPHONGBindingSource.Position = vitri;
                btnUndo.Enabled = true;
                if (dtREDOHANGPHONG.Rows.Count - 1 < 0)
                {
                    btnRedo.Enabled = false;

                }
            }

            hANGPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }


        private void FormHangPhong_Load(object sender, EventArgs e)
        {
            this.cTKM_HANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTKM_HANGPHONG' table. You can move, or remove it, as needed.
            this.cTKM_HANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.CTKM_HANGPHONG);

            this.pHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.gIAPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.cTPHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.kHACHSANDataSet.PHONG);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.KhuyenMai' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'kHACHSANDataSet.GIAPHONG' table. You can move, or remove it, as needed.
            this.gIAPHONGTableAdapter.Fill(this.kHACHSANDataSet.GIAPHONG);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.CTPHIEUDAT' table. You can move, or remove it, as needed.
            this.cTPHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.CTPHIEUDAT);

            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.kIEUPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.lOAIPHONGTableAdapter.Fill(this.kHACHSANDataSet.LOAIPHONG);
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            this.kIEUPHONGTableAdapter.Fill(this.kHACHSANDataSet.KIEUPHONG);
            if (hANGPHONGBindingSource.Count <= 0)
            {
                btnHieuChinh.Enabled = btnXoa.Enabled = false;
            }

        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mAHangPhongTextEdit.Enabled == false)
            {
                dtUNDOHANGPHONG.RejectChanges();
                dtUNDOHANGPHONG.Rows.RemoveAt(dtUNDOHANGPHONG.Rows.Count - 1);
                dtUNDOHANGPHONG.AcceptChanges();
            }
            hANGPHONGBindingSource.CancelEdit();
            if (btnThem.Enabled == false) hANGPHONGBindingSource.Position = vitri;
            hANGPHONGGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnHuy.Enabled = false;
        }
        private void mALoaiPhongComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mAKieuPhongComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void mAHangPhongTextEdit_Leave(object sender, EventArgs e)
        {
            if (mAHangPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("mã hạng phòng không được trống");
                mAHangPhongTextEdit.Focus();
            }
            else
            {
                mAHangPhongTextEdit.Text = mAHangPhongTextEdit.Text.ToUpper();
            }
        }

        private void mAHangPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;

        }

        private void hangPhongTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char whitespace = ' ';
            const char Delete = (char)8;
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
        }
        private void hangPhongTextEdit_Leave(object sender, EventArgs e)
        {
            hangPhongTextEdit.Text = DataUtil.xoaKhoangTrang(hangPhongTextEdit.Text);
            if (hangPhongTextEdit.Text.Trim() == "")
            {
                MessageBox.Show("Hạng phòng không được để trống");
                hangPhongTextEdit.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (f.ShowDialog() == DialogResult.OK)
            { 
                filename = f.FileName;
                hinhAnhTextEdit.Text = f.SafeFileName;
            }
        }
    }
}
