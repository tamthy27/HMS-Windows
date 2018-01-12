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
using System.Data.SqlClient;
using QuanLyKhachSan.KSForm;

namespace QuanLyKhachSan
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private bool passw()
        {
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }
            return true;
        }
        private bool tendn()
        {
            if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoan.Focus();
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (tendn() && passw())
            {
                return true;
            }
            return false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtra())
                {
                    DataUtil.loginName = txtTenTaiKhoan.Text.Trim();
                    DataUtil.password = txtMatKhau.Text.Trim();
                    int ketqua = DataUtil.KetNoi();


                    if (ketqua == 0)
                    {
                        DataUtil.loginName = "";
                        DataUtil.password = "";
                        MessageBox.Show("Đăng nhập thất bại.\n Xin kiểm tra lại tài khoản và mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        String query = "exec SP_DANGNHAP N'" + DataUtil.loginName + "'";
                        SqlDataReader data = DataUtil.ExecSqlDataReader(query);
                        if (data == null)
                        {
                            MessageBox.Show("Đăng nhập thất bại.\n Xin kiểm tra lại tài khoản và mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            data.Read();
                            DataUtil.username = data.GetString(0);
                            DataUtil.hoten = data.GetString(1);
                            DataUtil.bophan = data.GetString(2);
                            DataUtil.conn.Close();
                            this.Hide();
                            String information = "Mã NV: " + DataUtil.username + " Họ tên: " + DataUtil.hoten + " Bộ phận: " + DataUtil.bophan;
                            FormMain frmTrangChu = new FormMain();
                            frmTrangChu.setInformation(information);
                            frmTrangChu.Show();
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Đăng nhập thất bại.\n Xin kiểm tra lại tài khoản và mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
