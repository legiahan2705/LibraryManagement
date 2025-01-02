using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            bool isAdded = false;
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
                        //throw new Exception("Error adding book: " + ex.Message);
                    }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                return isAdded;

            }

        // Phương thức cập nhật sách
        public bool UpdateBook(Sach_TO book)
        {
            bool isUpdated = false;

            try
            {
                connection.Open();

                string sql = @"Update Sach 
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
                Console.WriteLine($"Failed to update book: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return isUpdated;

        }

        // Thêm sách vào quản lý
        public bool AddBookToEmployee(string maNV, string maSach)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            try
            {
                    
                    // Kiểm tra mã sách có tồn tại trong bảng Sach không
                    string checkQuery = "SELECT COUNT(*) FROM Sach WHERE MaSach = @MaSach";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@MaSach", maSach);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            // Nếu mã sách không tồn tại
                            return false;
                        }
                    }

                    // Thêm thông tin vào bảng QuanLySach
                    string insertQuery = "INSERT INTO QuanLySach (MaNV, MaSach) VALUES (@MaNV, @MaSach)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@MaNV", maNV);
                        insertCmd.Parameters.AddWithValue("@MaSach", maSach);
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        return rowsAffected > 0; // Trả về true nếu thêm thành công
                    }
            
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Database error: " + sqlEx.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public List<Sach_TO> GetBooksManagedByEmployee(string maNV)
        {
            List<Sach_TO> books = new List<Sach_TO>();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            try
            {
                string query = "SELECT S.MaSach, S.TenSach FROM QuanLySach QL " +
                               "JOIN Sach S ON QL.MaSach = S.MaSach " +
                               "WHERE QL.MaNV = @MaNV";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sach_TO book = new Sach_TO
                            {
                                MaSach = reader["MaSach"].ToString(),
                                TenSach = reader["TenSach"].ToString()
                            };
                            books.Add(book);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return books;
        }


    }
}
