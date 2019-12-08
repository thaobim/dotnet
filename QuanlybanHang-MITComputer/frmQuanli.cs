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
    public partial class frmQuanli : Form
    {   
        public DataTable tblSanPham;
        public frmQuanli()
        {
            InitializeComponent();
            //LoadCategoryList();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
        //Hàm load danh sách sản phẩm
        private void updateGridData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
            con.Open();
            String sql = "Select * from tblSanPham ORDER BY Ngaynhap DESC";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvListSanphams.DataSource = ds.Tables[0];
            dgvListSanphams.Refresh();
            con.Close();
        }
        void LoadCategoryList()
        {
        }

        private void lblSanpham_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlybanhangDataSet1.tblNhanVien' table. You can move, or remove it, as needed.
            this.tblNhanVienTableAdapter.Fill(this.quanlybanhangDataSet1.tblNhanVien);
            // TODO: This line of code loads data into the 'quanlybanhangDataSet.tblSanPham' table. You can move, or remove it, as needed.
            this.tblSanPhamTableAdapter.Fill(this.quanlybanhangDataSet.tblSanPham);
            btnHuy.Enabled = false;
            btnUpdate.Enabled = false;
            btnHuySPCT.Enabled = false;
        }

        //Tìm kiếm sản phẩm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            String sql = "";
            string masp = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            

            if(masp != "" && tenSP == "")
            {
               sql = "Select * from tblSanPham where MaSP LIKE '%" + masp + "%'";
            }
            else if (tenSP != "" && masp == "")
            {
                sql = "Select * from tblSanPham where TenSP LIKE '%" + tenSP + "%'";
            }
            else if(tenSP != "" && masp != "")
            {
                sql = "Select * from tblSanPham where ( MaSP LIKE '%" + masp + "%' ) AND (TenSP LIKE '%" + tenSP + "%')";
            }
            else
            {
                MessageBox.Show("Vui lòng điền nhập Mã sản phẩm hoặc tên sản phẩm để tìm kiếm", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvListSanphams.DataSource = ds.Tables[0];
            dgvListSanphams.Refresh();
            con.Close();
        }

        //button hủy click
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            updateGridData();
        }

        //DoubleClick vào cột sản phẩm
        private void dgvListSanphams_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgvListSanphams.CurrentCell.RowIndex;
            txtMaSPCT.Text = dgvListSanphams.Rows[currentRow].Cells[0].Value.ToString();
            txtDanhmucSPCT.Text = dgvListSanphams.Rows[currentRow].Cells[1].Value.ToString();
            txtTenSPCT.Text = dgvListSanphams.Rows[currentRow].Cells[2].Value.ToString();
            txtSoluong.Text = dgvListSanphams.Rows[currentRow].Cells[3].Value.ToString();
            txtGianhap.Text = dgvListSanphams.Rows[currentRow].Cells[4].Value.ToString();
            txtGiaban.Text = dgvListSanphams.Rows[currentRow].Cells[5].Value.ToString();
            txtGhichu.Text = dgvListSanphams.Rows[currentRow].Cells[6].Value.ToString();
            btnUpdate.Enabled = true;
            btnHuySPCT.Enabled = true;
            txtTenSPCT.Enabled = true;
            txtSoluong.Enabled = true;
            txtGiaban.Enabled = true;
            txtGianhap.Enabled = true;
            txtGhichu.Enabled = true;
        }

        
        //Button update sản phẩm
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int currentRow = dgvListSanphams.CurrentCell.RowIndex;
            string  MaSPCT = dgvListSanphams.Rows[currentRow].Cells[0].Value.ToString();
            string masp = txtMaSPCT.Text;
            string tensp = txtTenSPCT.Text;
            string danhmuc = txtDanhmucSPCT.Text;
            string soluong = txtSoluong.Text;
            string gianhap = txtGianhap.Text;
            string giaban = txtGiaban.Text;
            string ghichu = txtGhichu.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
            con.Open();
            String sql = "Update tblSanPham SET MaSP= '"+masp+"', TenSP='"+tensp+ "',MaDM='" + danhmuc + "', SoLuong='" + soluong+"', DonGiaNhap='"+gianhap+"', DonGiaBan='"+giaban+"', GhiChu='"+ghichu+"' Where MaSP='"+ masp + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
           
            updateGridData();
        }

        //Button xóa sản phẩm
        private void btnHuySPCT_Click(object sender, EventArgs e)
        {
            if (txtMaSPCT.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa sản phẩm " + txtTenSPCT.Text + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int currentRow = dgvListSanphams.CurrentCell.RowIndex;
                    string MaSPCT = dgvListSanphams.Rows[currentRow].Cells[0].Value.ToString();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
                    con.Open();
                    String sql = "DELETE FROM tblSanPham WHERE MaSP='" + MaSPCT + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    //Xoá trắng các textbox
                    txtMaSPCT.Text = "";
                    txtTenSPCT.Text = "";
                    txtGianhap.Text = "";
                    txtSoluong.Text = "";
                    txtGiaban.Text = "";
                    txtGhichu.Text = "";
                    //update lại bảng danh sách sản phẩm
                    updateGridData();
                }
                
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frmAddProduct frm = new frmAddProduct())
            {
                var result = frm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    updateGridData();
                }
            }
                
        }
      //Code tab quản lý nhân viên
        private void dtgListNV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dtgListNV.CurrentCell.RowIndex;
            textCodeNV.Text = dtgListNV.Rows[currentRow].Cells[0].Value.ToString();
            txtNameNV.Text = dtgListNV.Rows[currentRow].Cells[1].Value.ToString();
            dptNgaysinh.Text = dtgListNV.Rows[currentRow].Cells[2].Value.ToString();
            txtAddressNV.Text = dtgListNV.Rows[currentRow].Cells[4].Value.ToString();
            txtSdtNV.Text = dtgListNV.Rows[currentRow].Cells[5].Value.ToString();
            txtChucvu.Text = dtgListNV.Rows[currentRow].Cells[6].Value.ToString();

            string Gioitinh = dtgListNV.Rows[currentRow].Cells[3].Value.ToString();
            if (Gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
            else if (Gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else rdbKhac.Checked = true;
        }

        //Update Data grid view Nhân viên
        private void updateGridData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";
            con.Open();
            String sql = "Select * from tblSanPham ORDER BY Ngaynhap DESC";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(ds);
            dgvListSanphams.DataSource = ds.Tables[0];
            dgvListSanphams.Refresh();
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblNhanVien WHERE MaNV= '"+textCodeNV.Text+"'";

        }

        private void txtCodeNVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            btnSearch.Enabled = true;
        }

        private void txtNameNVSearch_KeyUp(object sender, KeyEventArgs e)
        {
            btnSearch.Enabled = true;
        }
    }
}
