using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_DeleteBooks : DL_Connect
    {
        public bool Delete_Books(string MaSach)
        {
            bool isDeleted = false; // Biến kiểm tra trạng thái xóa

            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu lệnh SQL
                string sql = "DELETE FROM Sach WHERE MaSach = @MaSach";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Thêm tham số
                    command.Parameters.AddWithValue("@MaSach", MaSach);

                    // Thực thi câu lệnh
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra nếu có ít nhất một dòng bị ảnh hưởng
                    isDeleted = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                // Log lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return isDeleted; // Trả về trạng thái xóa
        }

        public bool XoaSachKhoiQuanLy(string maSach)
        {

            bool isDeleted = false; // Biến kiểm tra trạng thái xóa
            try
            {
                // Mở kết nối
                connection.Open();

                string sql = "DELETE FROM QuanLySach WHERE MaSach = @MaSach";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaSach", maSach);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có bản ghi bị xóa
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Database error: " + sqlEx.Message);
            }
        }

    }
}
