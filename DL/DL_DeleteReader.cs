using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_DeleteReader:DL_Connect
    {
        public bool Delete_Reader(string MaDG)
        {
            bool isDeleted = false; // Biến kiểm tra trạng thái xóa

            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu lệnh SQL
                string sql = "DELETE FROM Docgia WHERE MaDG = @MaDG";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Thêm tham số
                    command.Parameters.AddWithValue("@MaDG", MaDG);

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

    }
}
