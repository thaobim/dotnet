using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanlybanHang_MITComputer.share
{
    class share
    {
        public static string username;
        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Baitap\LTDOTNET\BTLDOTNET\dotnet\QuanlybanHang-MITComputer\Quanlybanhang.mdf;Integrated Security=True";

        public static string MD5HashTDB(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        public static bool CheckExist(string sql)
        {
            Int32 count = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(sql, connect);

                count = Convert.ToInt32(cmd.ExecuteScalar());

                connect.Close();

            }
            if (count > 0) return true;
            return false;
        }

        public static int getRowCount(string sql)
        {
            int count = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(sql, connect);

                count = Convert.ToInt32(cmd.ExecuteScalar());

                connect.Close();
            }
            
            return count;
        }

        public static bool CheckExecute(string sql)
        {
            int count = 0;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(sql, connect);

                count = cmd.ExecuteNonQuery();

                connect.Close();

            }
            if (count > 0) return true;
            return false;
        }

        public static bool isEmpty(string str)
        {
            if (str != "") return false;
            return true;
        }

        public static SqlDataReader GetAllResult(string sql)
        {
            SqlDataReader read;
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();

                SqlCommand cmd = new SqlCommand(sql, connect);

                read = cmd.ExecuteReader();

               connect.Close();
            }

            return read;
        }

    }


    
}
