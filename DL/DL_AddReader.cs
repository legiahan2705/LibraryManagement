using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_AddReader:DL_Connect
    {
        public bool AddReader(DocGia_TO reader)
        {
            bool isAdded = false;

            try
            {
                // Mở kết nối
                connection.Open();

                // Câu lệnh SQL INSERT với OUTPUT để lấy Id vừa thêm
                string sql = "INSERT INTO Docgia (MaDG,Ten,GioiTinh,SDT,NgaySinh,DiaChi) " +
                             "OUTPUT INSERTED.MaDG " +
                             "VALUES (@MaDG, @Ten, @GioiTinh, @SDT, @NgaySinh, @DiaChi)";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Gán giá trị tham số
                    command.Parameters.AddWithValue("@MaDG", reader.MaDG);
                    command.Parameters.AddWithValue("@Ten", reader.Ten);
                    command.Parameters.AddWithValue("@GioiTinh", reader.GioiTinh);
                    command.Parameters.AddWithValue("@SDT", reader.SDT);
                    command.Parameters.AddWithValue("@NgaySinh", reader.NgaySinh);
                    command.Parameters.AddWithValue("@DiaChi", reader.DiaChi);
                   

                    // Thực thi câu lệnh và lấy Id được sinh ra
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem result có phải là giá trị Id hợp lệ không
                    if (result != null)
                    {
                        reader.MaDG = result.ToString(); // Gán Id tự động sinh vào đối tượng
                        isAdded = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to add reader {ex.Message}");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return isAdded;

        }

        // Phương thức cập nhật reader
        public bool UpdateReader(DocGia_TO reader)
        {
            bool isUpdated = false;

            try
            {
                connection.Open();

                string sql = @"UPDATE Docgia
                               SET Ten = @Ten, GioiTinh = @GioiTinh, SDT = @SDT, 
                                   NgaySinh = @NgaySinh, DiaChi = @DiaChi
                               WHERE MaDG = @MaDG";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaDG", reader.MaDG);
                    command.Parameters.AddWithValue("@Ten", reader.Ten);
                    command.Parameters.AddWithValue("@GioiTinh", reader.GioiTinh);
                    command.Parameters.AddWithValue("@SDT", reader.SDT);
                    command.Parameters.AddWithValue("@NgaySinh", reader.NgaySinh);
                    command.Parameters.AddWithValue("@DiaChi", reader.DiaChi);
                    

                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to update reader: {ex.Message}");
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return isUpdated;
        }
    }
}
