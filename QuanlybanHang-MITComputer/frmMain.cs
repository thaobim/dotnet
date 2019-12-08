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
    }
}
