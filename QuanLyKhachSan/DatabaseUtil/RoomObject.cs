using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyKhachSan.DatabaseUtil
{
    class RoomObject
    {
        private String name;
        private String tinhtrang;
        private String Tang;
        private String information;

        public RoomObject(string name, string tinhtrang, string tang)
        {
            this.name = name;
            this.tinhtrang = tinhtrang;
            Tang = tang;
        }
        public RoomObject (DataRow row)
        {
            this.name = row["Maphong"].ToString();
            this.Tang = row["Tang"].ToString();
            this.tinhtrang = row["TenTinhTrangPhong"].ToString();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Tinhtrang
        {
            get
            {
                return tinhtrang;
            }

            set
            {
                tinhtrang = value;
            }
        }

        public string Tang1
        {
            get
            {
                return Tang;
            }

            set
            {
                Tang = value;
            }
        }

        public string Information
        {
            get
            {
                return information;
            }

            set
            {
                information = value;
            }
        }
    }
}
