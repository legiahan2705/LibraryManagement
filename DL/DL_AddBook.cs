using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_AddBook : DL_Connect
    {
            public bool AddBook(Sach_TO book)
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Sach (MaSach, TenSach, MaTL, SL, NXB, NgayNhap) " +
                                   "VALUES (@MaSach, @TenSach, @MaTL, @SL, @NXB, @NgayNhap)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", book.MaSach);
                        cmd.Parameters.AddWithValue("@TenSach", book.TenSach);
                        cmd.Parameters.AddWithValue("@MaTL", book.MaTL);
                        cmd.Parameters.AddWithValue("@SL", book.SL);
                        cmd.Parameters.AddWithValue("@NXB", book.NXB);
                        cmd.Parameters.AddWithValue("@NgayNhap", book.NgayNhap);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Trả về true nếu thêm thành công
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding book: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        // Phương thức cập nhật sách
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
                    command.Parameters.AddWithValue("@NgayNhap", book.NgayNhap);

                    int rowsAffected = command.ExecuteNonQuery();

                    isUpdated = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to update book: {ex.Message}");
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
