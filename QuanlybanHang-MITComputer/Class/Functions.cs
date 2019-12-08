using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanlybanHang_MITComputer.Class
{
    class Functions
    {
        //public static SqlConnection con;  //Khai báo đối tượng kết nối        

        public static void RunSQL(string sql)
        {
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\c#\QuanlybanHang-MITComputer\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                con.Close();
            }

        }
        

    }
}
