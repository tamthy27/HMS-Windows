using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DatabaseUtil
{
    class DataUtil
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String dataBase = "KHACHSAN";
        public static String nameServer = "DESKTOP-IEF1TTK";
        public static String loginName = "";
        public static string password = "";
        public static string username = "";
        public static String hoten = "";
        public static string bophan = "";
        public static KHACHSANDataSet kHACHSANDataSet = new QuanLyKhachSan.KHACHSANDataSet();
       

        public void setDataset()
        {
            kHACHSANDataSet.DataSetName = "KHACHSANDataSet";
            kHACHSANDataSet.EnforceConstraints = false;
            kHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        }
        public static int KetNoi()
        {
            try
            {
                GetDBConnection();
                conn.Open();
                return 1;
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static void setConString()
        {
            DataUtil.connstr = "Data Source=" + DataUtil.nameServer + ";Initial Catalog=" +
                  DataUtil.dataBase + ";User ID=" +
                  DataUtil.loginName + ";password=" + DataUtil.password;
        }
        public static SqlConnection GetDBConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            setConString();
            DataUtil.conn.ConnectionString = DataUtil.connstr;
            string connString = DataUtil.connstr;
            conn = new SqlConnection(connString);
            return conn;
        }
        public static DataTable ExecSqlDataTable(String cmd, string connstr)
        {
            GetDBConnection();
            DataTable dt = new DataTable();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecSqlNonQuery(String strlenh)
        {
            GetDBConnection();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    Console.Write("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else Console.Write(ex.Message);
                conn.Close();
                return ex.State;
            }
        }

        public static DataTable getKIEUPHONG()
        {
            DataTable dtKIEUPHONG = new DataTable();
            GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_getKIEUPHONG", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtKIEUPHONG);
            conn.Close();
            return dtKIEUPHONG;
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            GetDBConnection();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh,conn);
            sqlcmd.CommandType = CommandType.Text;
            if (DataUtil.conn.State == ConnectionState.Closed) DataUtil.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                DataUtil.conn.Close();
                Console.Write(ex.Message);
                return null;
            }
        }

        internal static Boolean AddHoaDon(string username, DateTime today,String tencongty,String masothue,int tongcong,int tratruoc,DataTable ct, String mahd)
        {
            try
            {
                GetDBConnection();
                conn.Open();
                //SqlCommand cmd = new SqlCommand("dbo.AddHoaDon", DataUtil.conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@manhanvien", username);
                //cmd.Parameters.AddWithValue("@ngaythanhtoan", today);
                //SqlParameter tvparam = cmd.Parameters.AddWithValue("@CTHOADON", ct);
                //tvparam.SqlDbType = SqlDbType.Structured;
                //cmd.ExecuteNonQuery();

               // int count = kHACHSANDataSet.HOADONDO.Rows.Count-1;

                String sql = "INSERT INTO [dbo].[HOADON]([MAHD],[MANV],[NgayThanhToan],[TenCTy],[MASoThue],[ThanhTien],[TraTruoc],[MAHDDO]) VALUES ('" + mahd + "','" + username + "','" + today + "',null,null,"+tratruoc+","+tongcong+ ", NULL)";
         
                if(!tencongty.Equals("null"))
                {
                    sql = "INSERT INTO [dbo].[HOADON]([MAHD],[MANV],[NgayThanhToan],[TenCTy],[MASoThue],[ThanhTien],[TraTruoc],[MAHDDO]) VALUES ('" + mahd + "','" + username + "','" + today + "','"+tencongty+"','"+masothue+ "'," + tratruoc + "," + tongcong + ", NULL)";
                }
                DataUtil.ExecQueryString(sql);

                foreach(DataRow dr  in ct.Rows)
                {
                    String sqlct = "INSERT INTO [dbo].[CTHOADON]([MAHD],[MACTPhieuThue],[TienPhong],[TienDV],[GiamGia]) VALUES ('" + mahd + "','"+dr[0] + "','" + dr[1] + "','" + dr[2] + "','" + dr[3] + "')";
                    ExecQueryString(sqlct);
               
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        internal static Boolean AddHoaDonDo(string username, DateTime today, List<string> maCTHD, List<string> mahdls, String tenconty, String masothue )
        {
            try
            {
                GetDBConnection();
                conn.Open();
                string sql = "select *  from HOADONDO";
                DataTable dt = DataUtil.ExecSqlDataTable(sql,connstr);
                int count = dt.Rows.Count;
                String sqldo = "INSERT INTO [dbo].[HOADONDO]([MAHDDO],[NGAYXUATHOADON],[MANV],[TENCONGTY],[MASOTHUE])VALUES('MAHDD" + count+"','"+today+"','"+username+"',N'"+tenconty+"','"+masothue+"')";
                DataUtil.ExecQueryString(sqldo);
                foreach (String mahd in mahdls)
                {
                    string up = "UPDATE [dbo].[HOADON] SET [MAHDDO] = 'MAHDD" + count + "' WHERE HOADON.MAHD = '" + mahd + "'";
                    DataUtil.ExecQueryString(up);
                }
                //foreach (string ma in maCTHD)
                //{
                //    String sqlct = "INSERT INTO[dbo].[CTHOADONDO]([MAHDDO],[MACTHD]) VALUES('MAHDD"+count+"','"+ma+"')";
                //    ExecQueryString(sqlct);
                //}
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //public static Boolean deleteKIEUPHONG(string makp)
        //{
        //    GetDBConnection();
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("SP_DELETE_KIEUPHONG", conn);
        //    // truyền tham số vào SqlCommand
        //    cmd.Parameters.AddWithValue("@MaKIEUPHONG", makp);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        int count = cmd.ExecuteNonQuery();

        //        conn.Close();
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.Write("WHAT's Error: " + e.Message, "");

        //        return false;
        //    }
        //}
        public static Boolean ExecQueryString(string query)
        {
            GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            if (count == 0) return false;
            else return true;
        }
        //public static Boolean insertKIEUPHONG(string makp,string tenkp)
        //{            
        //    string sql = "Insert into KIEUPHONG ([MAKieuPhong],[TenKieuPhong])VALUES ("+makp+","+tenkp+")";
        //    try
        //    {
        //        if (ExecQueryString(sql) != 0)
        //        {                   
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.Message);
        //        return false;
        //    }
        //    return false;
        //}
        public static Boolean changePassword(string lgName, string oldPassword,string newpassword)
        {
            GetDBConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SP_SUAPASS", conn);
            cmd.Parameters.AddWithValue("@LGNAME", lgName);
            cmd.Parameters.AddWithValue("@OLDPASS", oldPassword);
            cmd.Parameters.AddWithValue("@NEWPASS", newpassword);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                int count = cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Write("WHAT's Error: " + e.Message, "");

                return false;
            }
        }
        public static int taoLogin(String LoginName, String pass, String username, String role, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand("SP_TAOLOGIN", conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = new SqlParameter("@Return", SqlDbType.Int);
            parm.Direction = ParameterDirection.ReturnValue;

            Sqlcmd.Parameters.Add(parm);
            Sqlcmd.Parameters.Add(new SqlParameter("@LGNAME", LoginName));
            Sqlcmd.Parameters.Add(new SqlParameter("@PASS", pass));
            Sqlcmd.Parameters.Add(new SqlParameter("@USRNAME", username));
            Sqlcmd.Parameters.Add(new SqlParameter("@ROLE", role));

            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                int id = 0;

                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                id = Convert.ToInt32(parm.Value);
                return id;
            }
            catch (SqlException ex)
            {
                Console.Write("WHAT's Error: " + ex.Message, "");
                conn.Close();
                int id = Convert.ToInt32(parm.Value);
                return id;
            }
        }
        public static string xoaKhoangTrang(String a)
        {
            a = String.Join(" ", a.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            return a;
        }       
    }
}
