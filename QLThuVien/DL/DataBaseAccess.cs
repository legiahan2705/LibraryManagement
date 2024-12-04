
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TO;

namespace DL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối csdl

        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=LEGIAHAN\SQLEXPRESS01;Initial Catalog=QuanLyThuvien;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(strcon); // Khởi tạo connect
            return conn;
        }
    }

    public class DataBaseAccess
    {
        public static string CheckLogin_TO(TaiKhoan_TO taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taikhoan.MaNV);
            cmd.Parameters.AddWithValue("@pass", taikhoan.MK);

            // Kiểm tra quyền
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }



            return user;
        }
    }
}
