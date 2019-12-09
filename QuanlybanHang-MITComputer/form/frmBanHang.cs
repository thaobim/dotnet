using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlybanHang_MITComputer.form
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void PanelKhachHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string tenKH = txtNameKH.Text;
            string diachiKH = txtDiaChiKH.Text;
            string soDT = txtSDTKH.Text;
            DateTime ngaysinhKH = dtBirthday.Value.Date;

            string sql = "SELECT * FROM tblKhachHang WHERE Sodt = '"+ soDT + "'";
            if (share.share.CheckExist(sql))
            {
                MessageBox.Show("Số điện thoại đã có trên hệ thống","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            sql = "INSERT INTO tblKhachHang (TenKH,Diachi,Sodt,NgaySN) VALUES (N'" + tenKH + "',N'"+ diachiKH + "','"+ soDT + "','"+ ngaysinhKH.ToString() + "')";
            if (share.share.CheckExecute(sql))
            {
                MessageBox.Show("Đã thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchKH_Click(object sender, EventArgs e)
        {
            string sdtKH = txtSDTKHS.Text;
            string sql = "SELECT * FROM tblKhachHang WHERE Sodt = '" + sdtKH + "'";
            if (!share.share.CheckExist(sql))
            {
                MessageBox.Show("Không tồn tại số điện thoại này trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(share.share.connectionString))
                {
                    connect.Open();

                    SqlCommand cmd = new SqlCommand(sql, connect);

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            txtHoTenKH.Text = read[1].ToString();
                            dateNgaySN.Text = read[4].ToString();
                        }
                    }
                    connect.Close();
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnTimSP_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;

            if(share.share.isEmpty(maSP))
            {
                MessageBox.Show("Mã sản phẩm không được để trống");
                return;
            }

            string sql = "SELECT COUNT(*) FROM tblSanPham WHERE MaSP = '" + maSP + "'";

            if (!share.share.CheckExist(sql))
            {
                MessageBox.Show("Không tồn tại sản phẩm này trên hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = "SELECT * FROM tblSanPham WHERE MaSP = '" + maSP + "'";
                using (SqlConnection connect = new SqlConnection(share.share.connectionString))
                {
                    connect.Open();

                    SqlCommand cmd = new SqlCommand(sql, connect);

                    SqlDataReader read = cmd.ExecuteReader();

                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            txtTenSP.Text = read[1].ToString();
                            txtGiaSP.Text = read[5].ToString();
                            txtSoLuong.Enabled = true;
                            txtSoLuong.Text = "1";
                            txtGhiChu.Enabled = true;
                            lblThanhTien.Text = read[5].ToString();
                        }
                    }
                    connect.Close();
                }
            }

        }

        private void TxtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            int giatien,soluong;
            int.TryParse(txtGiaSP.Text, out giatien);
            int.TryParse(txtSoLuong.Text, out soluong);
            lblThanhTien.Text = (giatien * soluong).ToString();
        }

        private void BtnLenDonHang_Click(object sender, EventArgs e)
        {

        }
    }
}
