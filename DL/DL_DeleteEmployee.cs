using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_DeleteEmployee : DL_Connect
    {
        public bool Delete_Employee(string employeeId)
        {
            bool isDeleted = false; // Biến kiểm tra trạng thái xóa

            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu lệnh SQL
                string sql = "DELETE FROM Nhanvien WHERE MaNV = @EmployeeId";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Thêm tham số
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

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
