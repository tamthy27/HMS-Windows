using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DatabaseUtil
{
    class KhachHang
    {
        String CMND;
        String HoKH;
        String TenKH;
        String SoDienThoaiKH;
        Boolean GioiTinh;
        String NgaySinh;
        String Email;
        String STK;
        String NganHang;
        String ChiNhanhNH;
        
        public KhachHang()
        {

        }

        public KhachHang(string cMND, string hoKH, string tenKH, string soDienThoaiKH, bool gioiTinh, string ngaySinh, string email, string sTK, string nganHang, string chiNhanhNH)
        {
            CMND = cMND;
            HoKH = hoKH;
            TenKH = tenKH;
            SoDienThoaiKH = soDienThoaiKH;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            STK = sTK;
            NganHang = nganHang;
            ChiNhanhNH = chiNhanhNH;
        }

        public string CMND1
        {
            get
            {
                return CMND;
            }

            set
            {
                CMND = value;
            }
        }

        public string HoKH1
        {
            get
            {
                return HoKH;
            }

            set
            {
                HoKH = value;
            }
        }

        public string TenKH1
        {
            get
            {
                return TenKH;
            }

            set
            {
                TenKH = value;
            }
        }

        public string SoDienThoaiKH1
        {
            get
            {
                return SoDienThoaiKH;
            }

            set
            {
                SoDienThoaiKH = value;
            }
        }

        public bool GioiTinh1
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }

        public string NgaySinh1
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string STK1
        {
            get
            {
                return STK;
            }

            set
            {
                STK = value;
            }
        }

        public string NganHang1
        {
            get
            {
                return NganHang;
            }

            set
            {
                NganHang = value;
            }
        }

        public string ChiNhanhNH1
        {
            get
            {
                return ChiNhanhNH;
            }

            set
            {
                ChiNhanhNH = value;
            }
        }
    }
}
