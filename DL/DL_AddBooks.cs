using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_AddBooks : DL_Connect
    {
        public bool AddBooks(Sach_TO book)
        {
            bool isAdded = false;

            try
            {
                // Mở kết nối
                connection.Open();

                // Câu lệnh SQL INSERT với OUTPUT để lấy Id vừa thêm
                string sql = "INSERT INTO Sach (MaSach,TenSach,MaTL,SL,NXB,NgayNhap) " +
                             "OUTPUT INSERTED.MaSach " +
                             "VALUES (@MaSach, @TenSach, @MaTL, @SL, @NXB, @NgayNhap)";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Gán giá trị tham số
                    command.Parameters.AddWithValue("@MaSach", book.MaSach);
                    command.Parameters.AddWithValue("@TenSach", book.TenSach);
                    command.Parameters.AddWithValue("@MaTL", book.MaTL);
                    command.Parameters.AddWithValue("@SL", book.SL);
                    command.Parameters.AddWithValue("@NXB", book.NXB);
                    command.Parameters.AddWithValue("@NgayNhap", book.NgayNhap);


                    // Thực thi câu lệnh và lấy Id được sinh ra
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem result có phải là giá trị Id hợp lệ không
                    if (result != null)
                    {
                        //book.MaSach = result.ToString(); // Gán Id tự động sinh vào đối tượng
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

        // Phương thức cập nhật book
        public bool UpdateBook(Sach_TO book)
        {
            bool isUpdated = false;

            try
            {
                connection.Open();

                string sql = @"UPDATE Sach
                               SET TenSach = @TenSach, MaTL = @MaTL, SL = @SL, 
                                   NXB = @NXB, NgayNhap = @NgayNhap
                               WHERE MaSach = @MaSach";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@MaSach", book.MaSach);
                    command.Parameters.AddWithValue("@TenSach", book.TenSach);
                    command.Parameters.AddWithValue("@MaTL", book.MaTL);
                    command.Parameters.AddWithValue("@SL", book.SL);
                    command.Parameters.AddWithValue("@NXB", book.NXB);
                    command.Parameters.AddWithValue("@NgayNhap", book.NgayNhap);


                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to add book: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
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
