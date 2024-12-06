using Microsoft.Data.SqlClient;
using System;
using TO;

namespace DL
{
    public class SqlConnectionData
    {
        // Tạo chuỗi kết nối CSDL
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=LEGIAHAN\SQLEXPRESS01;Initial Catalog=QuanLyThuvien;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection conn = new SqlConnection(strcon); // Khởi tạo connect
            return conn;
        }
    }

    public class DataBaseAccess
    {
        //kiểm tra thông tin đăng nhập: MaNV, Pass. Đăng nhập thành công lấy tên NV
        public static string CheckLogin_TO(TaiKhoan_TO taikhoan, out string employeeName) //out string employeeName: biến đầu ra để trả về tên NV
        {
            string result = null;
            employeeName = null;  // Khởi tạo employeeName mặc định

            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();

            // Sử dụng câu truy vấn JOIN giữa TaiKhoan và NhanVien để lấy tên nhân viên sau khi xác thực tài khoản và mật khẩu
            string query = @"
            SELECT NhanVien.Ten
            FROM TaiKhoan
            INNER JOIN NhanVien ON TaiKhoan.MaNV = NhanVien.MaNV
            WHERE TaiKhoan.MaNV = @user AND TaiKhoan.MK = @pass";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", taikhoan.MaNV);  // Truyền mã nhân viên
            cmd.Parameters.AddWithValue("@pass", taikhoan.MK);   // Truyền mật khẩu

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employeeName = reader.GetString(0);  // Lấy tên nhân viên từ kết quả JOIN
                    result = "LoginSuccess";  // Đánh dấu đăng nhập thành công
                }
            }
            else
            {
                result = "Tài khoản hoặc mật khẩu không chính xác!";
            }

            reader.Close();
            conn.Close();

            return result;
        }

    }
}
