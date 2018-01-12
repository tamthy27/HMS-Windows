using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QuanLyKhachSan.DatabaseUtil
{
    class RoomDAO
    {
        public static RoomDAO instance;
        public static int width = 90;
        public static int height = 90;

        public static RoomDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new RoomDAO(); }
                return RoomDAO.instance;
            }

           private set
            {
                
                instance = value;
            }
        }
        private RoomDAO ()
        {

        }
        public  List<RoomObject> lst()
        {
            List<RoomObject> rooms = new List<RoomObject>();
            DataTable data = DataUtil.ExecSqlDataTable("EXEC SP_GETALLROOM", DataUtil.connstr);
            foreach(DataRow item in data.Rows)
            {
                RoomObject room = new RoomObject(item);
                if (room.Tinhtrang.Equals("Đã thuê"))
                {
                    String thongtin = getthongtin(room.Name);
                    room.Information = thongtin;
                }
                rooms.Add(room);
            }
            return rooms;
        }

        private string getthongtin(string name)
        {
            String temp = "";
            String indate = "";
            String outdate = "";
            String khachhang = "";
            DataTable data = DataUtil.ExecSqlDataTable("EXEC SP_GETTHONGTINHPHONG "+ name, DataUtil.connstr);
           
            if (data.Rows.Count==0)
            {
                try
                {
                    DataTable data1 = DataUtil.ExecSqlDataTable("EXEC SP_GETNGAYDENNGAYDIPHONG " + name, DataUtil.connstr);
                    ArrayList dr = ConvertDT(data1);
                    DataRow get0 = (DataRow)dr[0];
                    indate = get0["NgayDen"].ToString();
                    outdate = get0["NgayDi"].ToString();
                    khachhang = "Chưa nhập thông tin khách hàng";
                }
                catch
                {

                }


            }
            else
            {
                ArrayList dr = ConvertDT(data);
                DataRow get0 = (DataRow)dr[0];
                indate = get0["NgayDen"].ToString();
                outdate = get0["NgayDi"].ToString();

                if (data.Rows.Count == 1)
                {
                    khachhang = get0["hovaten"].ToString();
                }
                else
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        DataRow drt = (DataRow)dr[i];
                        khachhang = khachhang + drt["hovaten"].ToString();
                        if (i + 1 < data.Rows.Count)
                        {
                            khachhang = khachhang + " , ";
                        }
                    }
                }
            }
            temp = "Ngày đến: " +indate+ "\n Ngày đi: " +outdate+ "\n Khách hàng: "+ khachhang;
            return temp;               
        }

        public ArrayList ConvertDT( DataTable dt)
        {
            ArrayList converted = new ArrayList(dt.Rows.Count);
            foreach (DataRow row in dt.Rows)
            {
                converted.Add(row);
            }
            return converted;
        }
    }
}
