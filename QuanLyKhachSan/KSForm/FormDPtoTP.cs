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
using DevExpress.XtraGrid.Localization;

namespace QuanLyKhachSan.KSForm
{
    public partial class FormDPtoTP : Form
    {
        private String mapd = "";
        DataTable dt;
        DataTable hangphong;
        Boolean hople = true;
        //String mpt = "";
        public FormDPtoTP()
        {
            InitializeComponent();
            GridLocalizer.Active = new CustomGridLocalizer();
            dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("HangPhong", typeof(string));
            dt.Columns.Add("Phong", typeof(string));
            dt.PrimaryKey = new DataColumn[]
           {
               dt.Columns[2]
           };
            hangphong = new DataTable();
            hangphong.Columns.Add("maHangPhong", typeof(string));
            hangphong.Columns.Add("sl", typeof(int));
            hangphong.PrimaryKey = new DataColumn[]
           {
               hangphong.Columns[0]
           };
            dataGridView1.DataSource = dt;

        }

        public FormDPtoTP(String MaPD, DateTime rentday, DateTime payday)
        {
            InitializeComponent();
            mapd = MaPD;
            ngayden.DateTime = rentday;
            ngaydi.DateTime = payday;
            GridLocalizer.Active = new CustomGridLocalizer();
            dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("HangPhong", typeof(string));
            dt.Columns.Add("Phong", typeof(string));
            dt.PrimaryKey = new DataColumn[]
           {
               dt.Columns[2]
           };
            hangphong = new DataTable();
            hangphong = DataUtil.ExecSqlDataTable("Exec SoLuongPhongCoTheThue '" + ngayden.DateTime + "','" + ngaydi.DateTime + "','" + mapd + "'", DataUtil.connstr);
            hangphong.PrimaryKey = new DataColumn[]
         {
               hangphong.Columns[0]
         };
            dataGridView1.DataSource = dt;
        }


        private void FormChildTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kHACHSANDataSet.SP_SelectReadyRoom' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.pHIEUDATTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.sP_SelectReadyRoomTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.soLuongPhongCoTheThueTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            // TODO: This line of code loads data into the 'kHACHSANDataSet.HANGPHONG' table. You can move, or remove it, as needed.
            this.hANGPHONGTableAdapter.Fill(this.kHACHSANDataSet.HANGPHONG);
            // TODO: This line of code loads data into the 'kHACHSANDataSet.PHIEUDAT' table. You can move, or remove it, as needed.
            this.pHIEUDATTableAdapter.Fill(this.kHACHSANDataSet.PHIEUDAT);
            //this.sP_SelectReadyRoom_HangPhongTableAdapter.Fill(this.kHACHSANDataSet.SP_SelectReadyRoom_HangPhong, comboBox1.SelectedValue.ToString());
            this.soLuongPhongCoTheThueTableAdapter.Fill(this.kHACHSANDataSet.SoLuongPhongCoTheThue, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayden.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngaydi.DateTime, typeof(System.DateTime))))), mapd);
            this.sP_SelectReadyRoomTableAdapter.Fill(this.kHACHSANDataSet.SP_SelectReadyRoom);


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.sP_SelectReadyRoom_HangPhongTableAdapter.Fill(this.kHACHSANDataSet.SP_SelectReadyRoom_HangPhong, comboBox1.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        //{
        //    ngaydi.Properties.MinValue = ngayden.DateTime;
        //    this.soLuongPhongCoTheThueTableAdapter.Fill(this.kHACHSANDataSet.SoLuongPhongCoTheThue, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayden.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngaydi.Text, typeof(System.DateTime))))), mapd);
        //    hangphong = DataUtil.ExecSqlDataTable("Exec SoLuongPhongCoTheThue '" + ngayden.DateTime + "','" + ngaydi.DateTime + "','" + mapd + "'", DataUtil.connstr);


        //}
     
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
            DataRowView drv = (DataRowView)sP_SelectReadyRoom_HangPhongBindingSource.Current;
            String a = dr[0].ToString();
            if (drv != null && dr[3].ToString() == "true")
            {
                MessageBox.Show("checked" + drv.Row[0].ToString());
            }
        }
        int t = 200;
        bool click = true;
        int temp1 = 0;
        int temp2 = 0;
        Boolean a = true;
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
                     
                try
                {
                    DataRowView dr = (DataRowView)gridView1.GetFocusedRow();
                DataRowView drv = (DataRowView)sP_SelectReadyRoomBindingSource.Current;
            //    MessageBox.Show(gridView1.GetSelectedRows().Count().ToString(), "");
              //  MessageBox.Show(gridView1.GetSelectedRows().FirstOrDefault().ToString());
                //if (a)
                //{
                //    temp1 = gridView1.GetSelectedRows().Count();
                //    a = false;
                //}
                //else
                //{
                //    temp2 = gridView1.GetSelectedRows().Count();
                //    a = true;
                //}
                //if ((temp1 == temp2) && (gridView1.GetSelectedRows().FirstOrDefault() != t))
                //{

                //    t = gridView1.GetSelectedRows().FirstOrDefault();
                //    //gridView1.SelectRow(gridView1.GetFocusedDataSourceRowIndex());
                //    click = false;

                //}
                if (click)
                {
                    if (dr != null && !gridView1.IsRowSelected(gridView1.GetFocusedDataSourceRowIndex()))
                    {
                    int stt = dt.Rows.Count + 1;
                    int numrc = dt.Select("STT = '" + stt.ToString() + "'").Length;
                     
                    if (numrc == 0)
                    {
                    String mahangphong = dr[3].ToString();
                    int numberOfRecords = dt.Select("Hangphong = '" + mahangphong + "'").Length;
                    int t = hangphong.Rows.Count;
                    DataRow hp = hangphong.Rows.Find(mahangphong);
                    int num = int.Parse(hp[2].ToString());
                    
                    String maphong = dr[1].ToString();
                   
                    //if (num > numberOfRecords)
                    //{
                  
                        try
                        {
                            dt.NewRow();
                            dt.Rows.Add(stt.ToString(), mahangphong, maphong);
                                if (num <= numberOfRecords)
                                {
                                    // gridView1.UnselectRow(gridView1.GetFocusedDataSourceRowIndex());
                                    // gridView1.select
                                    MessageBox.Show("Số phòng đặt tại hạng phòng " + mahangphong + "đã nhiều hơn cho phép. Hãy kiểm tra lại", "Lỗi");
                                    hople = false;
                                    //   return;
                                }
                                else
                                {
                                    hople = true;
                                }
                            }
                        catch
                        {
                            DataRow r = dt.Rows.Find(dr[1].ToString());
                            dt.Rows.Remove(r);
                        }
                        //}
                   
                    }
                    else
                        {
                            for( int i =1; i< stt; i++)
                            {
                                int tempnum = dt.Select("STT = '" + i.ToString() + "'").Length;
                                if(tempnum ==0)
                                {
                                    stt = i;
                                   // MessageBox.Show(i.ToString());
                                    break;
                                }

                            }
                            String mahangphong = dr[3].ToString();
                            int numberOfRecords = dt.Select("Hangphong = '" + mahangphong + "'").Length;
                            int t = hangphong.Rows.Count;
                            DataRow hp = hangphong.Rows.Find(mahangphong);
                            int num = int.Parse(hp[2].ToString());
                            String maphong = dr[1].ToString();
                            //if (num > numberOfRecords)
                            //{

                            try
                            {
                                dt.NewRow();
                                dt.Rows.Add(stt.ToString(), mahangphong, maphong);
                                if (num <= numberOfRecords)
                                {
                                    // gridView1.UnselectRow(gridView1.GetFocusedDataSourceRowIndex());
                                    // gridView1.select
                                    MessageBox.Show("Số phòng đặt tại hạng phòng " + mahangphong + "đã nhiều hơn cho phép. Hãy kiểm tra lại", "Lỗi");
                                    hople = false;
                                    //   return;
                                }
                                else
                                {
                                    hople = true;
                                }
                            }
                            catch
                            {
                                DataRow r = dt.Rows.Find(dr[1].ToString());
                                dt.Rows.Remove(r);
                            }

                        }
                    //click = false;
                    //return;
                }

                if (dr != null && gridView1.IsRowSelected(gridView1.GetFocusedDataSourceRowIndex()))
                {

                    int stt = dt.Rows.Count + 1;
                    int numrc = dt.Select("STT = '" + stt.ToString() + "'").Length;
                    if (numrc == 0)
                    {
                        String mahangphong = dr[3].ToString();
                        int numberOfRecords = dt.Select("Hangphong = '" + mahangphong + "'").Length;
                        int t = hangphong.Rows.Count;
                        DataRow hp = hangphong.Rows.Find(mahangphong);
                        int num = int.Parse(hp[2].ToString());

                        String maphong = dr[1].ToString();

                        //if (num > numberOfRecords)
                        //{

                        try
                        {
                            dt.NewRow();
                            dt.Rows.Add(stt.ToString(), mahangphong, maphong);
                                if (num <= numberOfRecords)
                                {
                                    // gridView1.UnselectRow(gridView1.GetFocusedDataSourceRowIndex());
                                    // gridView1.select
                                    MessageBox.Show("Số phòng đặt tại hạng phòng " + mahangphong + "đã nhiều hơn cho phép. Hãy kiểm tra lại", "Lỗi");
                                    hople = false;
                                    //   return;
                                }
                                else
                                {
                                    hople = true;
                                }
                            }
                        catch
                        {
                            DataRow r = dt.Rows.Find(dr[1].ToString());
                            dt.Rows.Remove(r);
                        }
                        //}
                     
                    }
                        else
                        {
                            for (int i = 1; i < stt; i++)
                            {
                                int tempnum = dt.Select("STT = '" + i.ToString() + "'").Length;
                                if (tempnum == 0)
                                {
                                    stt = i;
                                 //   MessageBox.Show(i.ToString());
                                    break;
                                }

                            }
                            String mahangphong = dr[3].ToString();
                            int numberOfRecords = dt.Select("Hangphong = '" + mahangphong + "'").Length;
                            int t = hangphong.Rows.Count;
                            DataRow hp = hangphong.Rows.Find(mahangphong);
                            int num = int.Parse(hp[2].ToString());
                            String maphong = dr[1].ToString();
                            //if (num > numberOfRecords)
                            //{

                            try
                            {
                                dt.NewRow();
                                dt.Rows.Add(stt.ToString(), mahangphong, maphong);
                                if (num <= numberOfRecords)
                                {
                                    // gridView1.UnselectRow(gridView1.GetFocusedDataSourceRowIndex());
                                    // gridView1.select
                                    MessageBox.Show("Số phòng đặt tại hạng phòng " + mahangphong + "đã nhiều hơn cho phép. Hãy kiểm tra lại", "Lỗi");
                                    hople = false;
                                    //   return;
                                }
                                else
                                {
                                    hople = true;
                                }
                            }
                            catch
                            {
                                DataRow r = dt.Rows.Find(dr[1].ToString());
                                dt.Rows.Remove(r);
                            }

                        }
                        //click = false;
                        //return;
                    }
                    //if (t != 200)
                    //{

                    //    if ((gridView1.GetSelectedRows().FirstOrDefault() < t || gridView1.GetSelectedRows().FirstOrDefault() > t))
                    //    {

                    //        t = gridView1.GetSelectedRows().FirstOrDefault();
                    //        //gridView1.SelectRow(gridView1.GetFocusedDataSourceRowIndex());
                    //        click = false;

                    //    }
                    //}
                    //else
                    //{
                    //    t = gridView1.GetSelectedRows().FirstOrDefault();
                    //}
                
          
            }
            else
            {
                click = true;
            }
            }
            catch { }

           
        }
        private double Getgia(object selectedValue, string a)
        {
            try
            {
                Double gia = 0;
                String sql = "select top 1 GIAPHONG.GiaHangPhong from phong,GIAPHONG where phong.MAHangPhong = GIAPHONG.MAHangPhong and phong.MAPhong='" + selectedValue.ToString() + "' and giaphong.NgayApDung< '" + a + "' order by GIAPHONG.NgayApDung desc";
                DataTable dt = DataUtil.ExecSqlDataTable(sql, DataUtil.connstr);
                DataRow dr = dt.Rows[0];
                gia = double.Parse(dr[0].ToString());
                return gia;
            }
            catch
            {
                return 0;

            }
        }
        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.soLuongPhongCoTheThueTableAdapter.Fill(this.kHACHSANDataSet.SoLuongPhongCoTheThue, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayden.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngaydi.DateTime, typeof(System.DateTime))))), mapd);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ngaydi_EditValueChanged(object sender, EventArgs e)
        {

            this.soLuongPhongCoTheThueTableAdapter.Connection.ConnectionString = DataUtil.connstr;
            this.soLuongPhongCoTheThueTableAdapter.Fill(this.kHACHSANDataSet.SoLuongPhongCoTheThue, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayden.DateTime, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngaydi.DateTime, typeof(System.DateTime))))), mapd);
            hangphong = DataUtil.ExecSqlDataTable("Exec SoLuongPhongCoTheThue '" + ngayden.DateTime + "','" + ngaydi.DateTime + "','" + mapd + "'", DataUtil.connstr);
            hangphong.PrimaryKey = new DataColumn[]
      {
               hangphong.Columns[0]
      };

        }

        private void ngayden_EditValueChanged(object sender, EventArgs e)
        {
            ngaydi.Properties.MinValue = ngayden.DateTime;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hople)
            {
                if (dt.Rows.Count > 0)
                {
                    try
                    {
                        string sql = "INSERT INTO [PHIEUTHUE]([MAPhieuThue],[MAPhieuDat],[MANhanVien])VALUES('" + "PT" + mapd + "','" + mapd + "','" + DataUtil.username + "')";
                        if (DataUtil.ExecQueryString(sql))
                        {
                            int num = 1;
                            foreach (DataRow temp in dt.Rows)
                            {
                                double dongia = Getgia(temp[2], ngayden.DateTime.ToString());
                                string sqltemp = "INSERT INTO [CTPHIEUTHUE]([MACTPhieuThue],[MAPhieuThue],[MAPhong],[GiamGia],[NgayDen],[NgayDi],[ThanhToan],[DonGia])VALUES('" + "PT" + mapd + "CT" + num + "','" + "PT" + mapd + "','" + temp[2] + "',0,'" + ngayden.DateTime + "','" + ngaydi.DateTime + "',0," + dongia + ")";
                                DataUtil.ExecQueryString(sqltemp);
                                string tinhtrangphong = "update   PHONG  set PHONG.MATinhTrangPhong='TTP002' where PHONG.MAPhong='" + temp[2] + "'";
                                DataUtil.ExecQueryString(tinhtrangphong);
                                num++;
                            }
                            string st = "update PHIEUDAT set TrangThaiPhieuDat = 6 where PHIEUDAT.MAPhieuDat ='" + mapd + "'";
                            DataUtil.ExecQueryString(st);
                        }
                        MessageBox.Show("Xếp phòng thành công! Hãy kiểm tra phiếu thuê");
                        this.Close();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("What's Error: " + e1.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn phòng để xuất phiếu thuê");

                }
            }
            else
            {
                MessageBox.Show( "Số lượng phòng ứng với hạng phòng chưa hợp lệ. Hãy kiểm tra lại", "Lỗi");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.sP_SelectReadyRoom_HangPhongTableAdapter.Fill(this.kHACHSANDataSet.SP_SelectReadyRoom_HangPhong, comboBox1.SelectedValue.ToString());

        }

        private void ngayden_DateTimeChanged(object sender, EventArgs e)
        {
            ngaydi_EditValueChanged(sender, e);
            ngaydi.Properties.MinValue = ngayden.DateTime.AddDays(1);
        }
    }
    public class CustomGridLocalizer : GridLocalizer
    {
        public override string GetLocalizedString(GridStringId id)
        {
            if (id == GridStringId.CheckboxSelectorColumnCaption)
            {
                return "Thuê";
            }
            return base.GetLocalizedString(id);
        }
    }
}
