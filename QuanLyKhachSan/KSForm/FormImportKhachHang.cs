using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using QuanLyKhachSan.DatabaseUtil;
using DevExpress.XtraGrid.Columns;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormImportKhachHang : Form
    {
        private DataTable dtbResult = new DataTable();
        public FormImportKhachHang()
        {
            InitializeComponent();
            gridControl1.UseEmbeddedNavigator = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel File|*.xlsx";
            string sheet = "Sheet1$";
            if (of.ShowDialog() == DialogResult.OK)
            {
                string fileName = of.FileName;
                OleDbConnection connection = new OleDbConnection();
                String connectionstring = String.Empty;
                string[] splitdot = fileName.Split(new char[1] { '.' });
                string dot = splitdot[splitdot.Length - 1].ToLower();
                if (dot == "xls")
                {
                    //tao chuoi ket noi voi Excel 2003
                    connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
                }
                else if (dot == "xlsx")
                {
                    //tao chuoi ket noi voi Excel 2007
                    connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0 XML;";
                }
                connection = new OleDbConnection(connectionstring);
                ReadExcelContents(of.FileName, "Sheet1$C7:L");

            }

        }

        public DataTable ReadExcelContents(string fileName, string sheet)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection();
                String connectionstring = String.Empty;
                string[] splitdot = fileName.Split(new char[1] { '.' });
                string dot = splitdot[splitdot.Length - 1].ToLower();
                if (dot == "xls")
                {
                    //tao chuoi ket noi voi Excel 2003
                    connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
                }
                else if (dot == "xlsx")
                {
                    //tao chuoi ket noi voi Excel 2007
                    connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0 XML;";
                }

                //connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Extended Properties=Excel 12.0 XML;Data Source=" + fileName); 

                //MessageBox.Show(excelQuery);
                connection = new OleDbConnection(connectionstring);
                string excelQuery = @"Select * FROM [" + sheet + "]";
                //excelQuery = @"Select * FROM [Sheet1$]";
                connection.Open();
                OleDbCommand cmd = new OleDbCommand(excelQuery, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                 dtbResult = ds.Tables[0];
                //dtbResult.Merge(ds.Tables[0]);
                this.gridControl1.DataSource = dtbResult;
                //this.kHACHHANGGridControl.DataSource = dtbResult;
                connection.Close();
                return dtbResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở file vui lòng xem lại! " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;


            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int count = 0;
                foreach (DataRow dr in dtbResult.Rows)
                {
                    String cmnd = dr[0].ToString();
                    try
                    {

                        String checkkh = "Select * FROM KHACHHANG WHERE CMND_PASSPORT ='" + cmnd + "'";
                        for (int t = 1; t <= dr.ItemArray.Length - 1; t++)
                        {
                            if (dr[t] != null)
                            {
                                dr.BeginEdit();
                                dr[t] = DataUtil.xoaKhoangTrang(dr[t].ToString());
                                dr.EndEdit();
                               
                            }
                        }
                        String stk = "";
                        if (dr[7].ToString().Equals("")||dr[7]==null)
                        {
                            stk = "NULL";
                            //dr.BeginEdit();
                            //dr[7] = "NULL";
                            //dr.EndEdit();
                        }
                        else
                        {
                            stk = dr[7].ToString();
                        }
                        if (dr[4].Equals("")|| dr[4] == null)
                        {
                            dr.BeginEdit();
                            dr[4] = "1";
                            dr.EndEdit();
                        }
                        DataTable dt = DataUtil.ExecSqlDataTable(checkkh, DataUtil.connstr);
                        if (dt.Rows.Count > 0)
                        {
                            String sqlkh = "UPDATE [dbo].[KHACHHANG] SET  [HoKH] = N'" + dr[1].ToString() + "',[TenKH] = N'" + dr[2].ToString() + "',[SoDienThoaiKH] = '" + dr[3].ToString() + "',[GioiTinhKH] = '" + dr[4].ToString() + "',[NgaySinhKH] = '" + dr[5].ToString() + "',[Email] = '" + dr[6].ToString() + "',[STK] =" + stk + ",[NganHang] = N'" + dr[8].ToString() + "',[ChiNhanhNH] = N'" + dr[9].ToString() + "' WHERE CMND_PASSPORT = '" + cmnd + "'";
                            if (!DataUtil.ExecQueryString(sqlkh))
                            {
                                MessageBox.Show("Lỗi ghi khách hàng.\n xin xem lại khách hàng có cmnd" + cmnd, "Error", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                count++;
                            }
                        }
                        else
                        {
                            string sql = "INSERT INTO [KHACHHANG]([CMND_PASSPORT],[HoKH],[TenKH],[SoDienThoaiKH],[GioiTinhKH],[NgaySinhKH],[Email],[STK],[NganHang],[ChiNhanhNH]) VALUES('" + dr[0] + "',N'" + dr[1] + "',N'" + dr[2] + "','" + dr[3] + "','" + dr[4] + "','" + dr[5] + "','" + dr[6] + "'," + stk + ",N'" + dr[8] + "',N'" + dr[9] + "')";
                            if (!DataUtil.ExecQueryString(sql))
                            {
                                MessageBox.Show("Lỗi ghi khách hàng.\n xin xem lại khách hàng có cmnd: " + cmnd , "Error", MessageBoxButtons.OK);
                                return;
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Lỗi ghi khách hàng.\n xin xem lại khách hàng có cmnd " + cmnd +" " + e1.Message, "Error", MessageBoxButtons.OK);
                        return;
                    }
                    
                    
                }
                MessageBox.Show("Đã ghi hoàn tất file excel với " + count + " khách hàng", "Thành công", MessageBoxButtons.OK);
                dtbResult.Clear();
                //dtbResult.Merge(ds.Tables[0]);
                this.gridControl1.DataSource = dtbResult;
                this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);
                return;
            }
            catch
            {
                MessageBox.Show("Lỗi ghi khách hàng.\n", "Error", MessageBoxButtons.OK);
                this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);

            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                int rowfocus = e.RowHandle;
                GridColumn CMND = view.Columns["CMND/PASSWORD*"];
                GridColumn HOVATEN = view.Columns["HỌ và TÊN ĐỆM*"];
                GridColumn TEN = view.Columns["TÊN*"];
                GridColumn SDT = view.Columns["SỐ ĐIỆN THOẠI"];
                GridColumn GENDER = view.Columns["GIỚI TÍNH"];
                GridColumn DATEBIRTH = view.Columns["NGÀY SINH"];
                GridColumn EMAIL = view.Columns["EMAIL"];
                GridColumn STK = view.Columns["SỐ TÀI KHOẢN"];
                GridColumn NGANHANG = view.Columns["NGÂN HÀNG"];
                GridColumn CHINHANH = view.Columns["CHI NHÁNH NGÂN HÀNG"];
                String cmnd = Convert.ToString(view.GetRowCellValue(rowfocus, CMND));
                String hovaten = Convert.ToString(view.GetRowCellValue(rowfocus, HOVATEN));
                String ten = Convert.ToString(view.GetRowCellValue(rowfocus, TEN));
                String sdt = Convert.ToString(view.GetRowCellValue(rowfocus, SDT));
                String gender = Convert.ToString(view.GetRowCellValue(rowfocus, GENDER));
                String datebirth = Convert.ToString(view.GetRowCellValue(rowfocus, DATEBIRTH));
                String email = Convert.ToString(view.GetRowCellValue(rowfocus, EMAIL));
                String stk = Convert.ToString(view.GetRowCellValue(rowfocus, STK));
                String nganhang = Convert.ToString(view.GetRowCellValue(rowfocus, NGANHANG));
                String chinhanh = Convert.ToString(view.GetRowCellValue(rowfocus, CHINHANH));
                if (cmnd == null || cmnd.Trim().Length < 9 || cmnd.Trim().Length > 12)
                {
                    e.Valid = false;
                    view.SetColumnError(CMND, "Độ dài CMND phải lớn hơn 9 và nhỏ hơn 12");
                }
                if (sdt.Trim() != "" && sdt.Trim().Length < 10 && stk.Trim().Length>12)
                {
                    e.Valid = false;
                    view.SetColumnError(SDT, "Độ dài số điện thoại phải lớn hơn 9 và nhỏ hơn 12");
                }
                hovaten = DataUtil.xoaKhoangTrang(hovaten);
                if (hovaten == "")
                {
                    e.Valid = false;
                    view.SetColumnError(HOVATEN, "Họ khách hàng không được để trống");
                }
                ten = DataUtil.xoaKhoangTrang(ten);
                if (ten == "")
                {
                    e.Valid = false;
                    view.SetColumnError(TEN, "Tên khách hàng không được để trống");
                }
                if (stk!= "" && stk.Length < 10)
                {
                    e.Valid = false;
                    view.SetColumnError(STK, "Độ dài số tài khoản phải lớn hơn 9");
                }
                if(gender != "" && gender.Length < 1)
                {
                    e.Valid = false;
                    view.SetColumnError(GENDER, "Giới tính không đúng định dạng");
                }
                if (!IsValidEmail(email) && email.Trim() != "")
                {
                    e.Valid = false;
                    view.SetColumnError(EMAIL, "Email không đúng định dạng");
                }
            }
            catch (Exception) { }
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

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kHACHSANDataSet);

        }

        private void FormImportKhachHang_Load(object sender, EventArgs e)
        {
            this.kHACHHANGTableAdapter.Connection.ConnectionString = DataUtil.connstr;

            // TODO: This line of code loads data into the 'kHACHSANDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.kHACHSANDataSet.KHACHHANG);

        }
        

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete && gridView1.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
                {

                    if (MessageBox.Show("Bạn có muốn xóa dòng này khỏi lịch thi?", "", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        try
                        {

                            this.gridView1.DeleteSelectedRows();
                            this.dtbResult.AcceptChanges();
                        }
                        catch { return; }
                    }
                }
            }
            catch { }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
            e.WindowCaption = "Cảnh báo";
            e.ErrorText = "Bạn nhập thiếu thông tin khách hàng!.\t\n- YES: Bổ sung thêm\t\n- NO: Xóa nhập lại\t\n";
        }

        private void gridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                GridColumn CMND = view.Columns["CMND/PASSWORD*"];
                GridColumn HOVATEN = view.Columns["HỌ và TÊN ĐỆM*"];
                GridColumn TEN = view.Columns["TÊN*"];
                GridColumn SDT = view.Columns["SỐ ĐIỆN THOẠI"];
                GridColumn GENDER = view.Columns["GIỚI TÍNH"];
                GridColumn DATEBIRTH = view.Columns["NGÀY SINH"];
                GridColumn EMAIL = view.Columns["EMAIL"];
                GridColumn STK = view.Columns["SỐ TÀI KHOẢN"];
                GridColumn NGANHANG = view.Columns["NGÂN HÀNG"];
                GridColumn CHINHANH = view.Columns["CHI NHÁNH NGÂN HÀNG"];
                if (view.FocusedColumn.Equals(CMND))
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
                   
                }
                if (view.FocusedColumn == HOVATEN)
                {
                    const char whitespace = ' ';
                    const char Delete = (char)8;
                    e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete && e.KeyChar != whitespace;
                }
                if (view.FocusedColumn == TEN)
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != Delete;

                }
                if (view.FocusedColumn == SDT)
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
                }
                if (view.FocusedColumn == GENDER)
                {
                    const char Delete = (char)8;
                    const char khong = (char)48;
                    const char mot = (char)49;
                    e.Handled = e.KeyChar!=khong &&e.KeyChar!=mot && e.KeyChar != Delete;
                }
                if (view.FocusedColumn == DATEBIRTH)
                {
                    const char Delete = (char)8;
                    const char date = '/';
                     e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete&& e.KeyChar!=date;
                }
                if (view.FocusedColumn == EMAIL)
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
                }
                if (view.FocusedColumn == STK)
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
                }
                if (view.FocusedColumn == NGANHANG)
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
                }
                if (view.FocusedColumn == CHINHANH)
                {
                    const char Delete = (char)8;
                    e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
                }
            }
            catch { }
        }

        private void gridControl1_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            GridControl grid = sender as GridControl;
            gridView1_KeyPress(grid.FocusedView, e);
        }
    }
}
