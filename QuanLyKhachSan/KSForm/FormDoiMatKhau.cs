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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }


        private void btnXN_Click(object sender, EventArgs e)
        {
            if(txtMK.Text.Trim()=="")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //txtMK.Focus();
                return;
            }
            if (txtMKM.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu mới không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // txtMKM.Focus();
                return;
            }
            if (txtXN.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu xác nhận không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // txtXN.Focus();
                return;
            }
            if(txtMKM.Text.Trim()==txtXN.Text.Trim())
            {
                if(DataUtil.changePassword(DataUtil.loginName,txtMK.Text.Trim(),txtXN.Text.Trim()))
                {
                    MessageBox.Show("Cập nhật thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    this.ParentForm.Hide();
                    this.ParentForm.Close();
                    FormLogin frmDangNhap = new FormLogin();
                    frmDangNhap.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhận không giống nhau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtMKM_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtXN_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
