using Microsoft.Data.SqlClient;
using System;
using TO;

namespace DL
{
    public class DL_AccountAccess : DL_Connect
    {
        public static bool AccountAccess(TaiKhoan_TO taiKhoan, out string employeeName, out string employeeRole)
        {
            employeeName = null;
            employeeRole = null;

            try
            {
                connection.Open();

                string query = @"
                SELECT Nhanvien.Ten, Nhanvien.PhanQuyen
                FROM TaiKhoan
                INNER JOIN Nhanvien ON TaiKhoan.MaNV = Nhanvien.MaNV
                WHERE TaiKhoan.MaNV = @user AND TaiKhoan.MK = @pass";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user", taiKhoan.MaNV);
                    cmd.Parameters.AddWithValue("@pass", taiKhoan.MK);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employeeName = reader["Ten"].ToString();
                            employeeRole = reader["PhanQuyen"].ToString();
                            return true; // Đăng nhập thành công
                        }
                        else
                        {
                            return false; // Đăng nhập thất bại
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false; // Lỗi trong quá trình xử lý
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
