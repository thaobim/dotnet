using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlybanHang_MITComputer.form.admin
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string reNewPass = txtReNewPass.Text;
            string sql = "SELECT COUNT(*) FROM tblTaiKhoan WHERE username = '" + share.share.username + "' AND password = '" + share.share.MD5HashTDB(oldPass) + "' ";

            if (share.share.isEmpty(oldPass))
            {
                MessageBox.Show("Mật khẩu cũ không được để trống");
                return;
            }

            if (share.share.isEmpty(newPass))
            {
                MessageBox.Show("Mật khẩu mới không được để trống");
                return;
            }

            if (share.share.isEmpty(reNewPass))
            {
                MessageBox.Show("Mật khẩu nhập lại không được để trống");
                return;
            }

            if (!newPass.Equals(reNewPass))
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }

            if (!share.share.CheckExist(sql))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }

            sql = "UPDATE tblTaiKhoan SET password = '" + share.share.MD5HashTDB(newPass) + "' WHERE username = '"+ share.share.username + "' ";

            if (share.share.CheckExecute(sql))
            {
                MessageBox.Show("Đổi mật khẩu thành công!\nVui lòng đăng nhập lại hệ thống.","Thông báo",MessageBoxButtons.OK);
                this.Close();
                this.DialogResult = DialogResult.OK;
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }


        }
    }
}
