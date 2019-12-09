using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlybanHang_MITComputer.form.admin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            string username = txtUsername.Text;
            string password = txtPassWord.Text;

            if(username == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            if(password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            password = share.share.MD5HashTDB(password);

            sql = "SELECT COUNT(*) FROM tblTaiKhoan WHERE username = '"+ username + "' AND password = '"+ password +"' ";

            if (share.share.CheckExist(sql))
            {
                share.share.username = username;
                this.Hide();
                frmMain mainf = new frmMain();
                mainf.Show();
            }
            else
            {
                MessageBox.Show("Không thành công");
            }

        }
    }
}
