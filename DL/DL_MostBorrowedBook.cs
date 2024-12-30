using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_MostBorrowedBook:DL_Connect
    {
        // Phương thức lấy top N sách mượn nhiều nhất trong một tháng cụ thể
        public List<MostBorrowedBook_TO> GetTopNBorrowedBooksByMonth(int year, int month, int topN)
        {
            List<MostBorrowedBook_TO> books = new List<MostBorrowedBook_TO>();

            try
            {
                connection.Open();

                string query = $@"
            SELECT TOP {topN} 
                S.MaSach, 
                S.TenSach, 
                SUM(CTP.SoLuong) AS TongSL
            FROM ChiTietPhieu CTP
            JOIN Sach S ON CTP.MaSach = S.MaSach
            JOIN Phieu P ON P.MaPhieu = CTP.MaPhieu
            WHERE YEAR(P.NgayMuon) = @Year
              AND MONTH(P.NgayMuon) = @Month
            GROUP BY S.MaSach, S.TenSach
            ORDER BY TongSL DESC;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Month", month);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new MostBorrowedBook_TO
                            {
                                MaSach = reader.GetString(0),
                                TenSach = reader.GetString(1),
                                TongSL = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return books;
        }


        // Phương thức lấy top N sách mượn nhiều nhất trong một quý cụ thể
        public List<MostBorrowedBook_TO> GetTopNBorrowedBooksByQuarter(int year, int quarter, int topN)
        {
            List<MostBorrowedBook_TO> books = new List<MostBorrowedBook_TO>();

            try
            {
                connection.Open();

                // Xác định các tháng trong quý
                int startMonth = (quarter - 1) * 3 + 1;
                int endMonth = startMonth + 2;

                string query = $@"
            SELECT TOP {topN} 
                S.MaSach, 
                S.TenSach, 
                SUM(CTP.SoLuong) AS TongSL
            FROM ChiTietPhieu CTP
            JOIN Sach S ON CTP.MaSach = S.MaSach
            JOIN Phieu P ON P.MaPhieu = CTP.MaPhieu
            WHERE YEAR(P.NgayMuon) = @Year
              AND MONTH(P.NgayMuon) BETWEEN @StartMonth AND @EndMonth
            GROUP BY S.MaSach, S.TenSach
            ORDER BY TongSL DESC;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@StartMonth", startMonth);
                    cmd.Parameters.AddWithValue("@EndMonth", endMonth);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new MostBorrowedBook_TO
                            {
                                MaSach = reader.GetString(0),
                                TenSach = reader.GetString(1),
                                TongSL = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return books;
        }


        // Phương thức lấy top N sách mượn nhiều nhất trong một năm cụ thể
        public List<MostBorrowedBook_TO> GetTopNBorrowedBooksByYear(int year, int topN)
        {
            List<MostBorrowedBook_TO> books = new List<MostBorrowedBook_TO>();

            try
            {
                connection.Open();

                // Truy vấn SQL để lấy top N sách mượn nhiều nhất trong năm
                string query = $@"
            SELECT TOP {topN} 
                S.MaSach, 
                S.TenSach, 
                SUM(CTP.SoLuong) AS TongSL
            FROM ChiTietPhieu CTP
            JOIN Sach S ON CTP.MaSach = S.MaSach
            JOIN Phieu P ON P.MaPhieu = CTP.MaPhieu
            WHERE YEAR(P.NgayMuon) = @Year
            GROUP BY S.MaSach, S.TenSach
            ORDER BY TongSL DESC;";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm tham số năm vào câu truy vấn
                    cmd.Parameters.AddWithValue("@Year", year);

                    // Đọc kết quả trả về từ cơ sở dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            books.Add(new MostBorrowedBook_TO
                            {
                                MaSach = reader.GetString(0),
                                TenSach = reader.GetString(1),
                                TongSL = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return books;
        }
    }
}
