using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlybanHang_MITComputer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuHoadon_Click_1(object sender, EventArgs e)
        {
            
        }

        private void menuQuanli_Click(object sender, EventArgs e)
        {
            frmQuanli frm = new frmQuanli();
            frm.Show();

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM tblSanPham";
            lblNumberSP.Text = share.share.getRowCount(sql).ToString();
        }

        private void MenuLogout_Click(object sender, EventArgs e)
        {
            form.admin.frmLogin frmLogin = new form.admin.frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void MenuDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (form.admin.frmDoiMatKhau frmDoiMatKhau = new form.admin.frmDoiMatKhau())
            {
                DialogResult result = frmDoiMatKhau.ShowDialog();
                if(result == DialogResult.OK)
                {
                    this.Close();
                }
            }
                
        }

        private void BánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.frmBanHang frmBanHang = new form.frmBanHang();
            frmBanHang.Show();
        }
    }
}
