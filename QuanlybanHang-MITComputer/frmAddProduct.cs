using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanlybanHang_MITComputer.Class;


namespace QuanlybanHang_MITComputer
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        private void frmAddProduct_Load(object sender, EventArgs e)
        {

            btnSave.Enabled = false;
            
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            string masp = txtMaSPAdd.Text;
            string tensp = txtTenSPAdd.Text;
            string madm = txtMaHDAdd.Text;
            string soluong = txtNumberAdd.Text;
            string gianhap = txtGiaNhapAdd.Text;
            string giaban = txtGiabanAdd.Text;
            string ghichu = txtGhichuAdd.Text;

            if (isExistsMasanpham(masp))
            {
                MessageBox.Show("Trùng rồi má ơi");
                return;
            }

            if (masp != "" && tensp != "")
            {
                /*
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
                con.Open();
                */
                String sql = "INSERT INTO tblSanPham (MaSP, TenSP, MaDM, SoLuong, DonGiaNhap, DonGiaBan, Ghichu) Values ('"+masp+"','"+tensp+ "','" +madm+"','"+soluong+"','"+gianhap+"','"+giaban+"', '"+ghichu+"')";
                Class.Functions.RunSQL(sql);
                
                DialogResult result = MessageBox.Show("Thêm thành công sản phẩm "+tensp+"!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                
            }
            else
                MessageBox.Show("Vui lòng điền Mã sản phẩm và mã danh mục", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private Boolean isExistsMasanpham(string masp)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
            con.Open();
            String sql = "Select count(*)  from tblSanPham where MaSP= '"+ masp + "'";
            SqlCommand cmd = new SqlCommand(sql,con);
            
            SqlDataReader read =  cmd.ExecuteReader();
            
            if (read.Read())
            {
                if(read[0].ToString() == "1")
                {
                    con.Close();
                    return true;
                } 
            }
            con.Close();
            return false;
        }

        private void txtMaSPAdd_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtTenSPAdd_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtMaHDAdd_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtNumberAdd_TextChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void txtGiabanAdd_TextChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
