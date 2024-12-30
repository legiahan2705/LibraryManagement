using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using TO;

namespace DL
{
    public class DL_BookBorrowingStatistics : DL_Connect
    {
        // Phương thức lấy tổng số sách mượn theo tháng
        public List<BookBorrowingStatistic_TO> GetBookBorrowingStatisticsByMonths(int year, List<int> months)
        {
            List<BookBorrowingStatistic_TO> statistics = new List<BookBorrowingStatistic_TO>();

            try
            {
                connection.Open();

                // Chuyển danh sách tháng thành chuỗi để sử dụng trong SQL
                string monthsList = string.Join(",", months);

                // Truy vấn SQL
                string query = $@"
                    SELECT 
                        MONTH(P.NgayMuon) AS Month, 
                        SUM(CTP.SoLuong) AS TotalBooks
                    FROM Phieu P
                    JOIN ChiTietPhieu CTP ON P.MaPhieu = CTP.MaPhieu
                    WHERE YEAR(P.NgayMuon) = @Year
                    AND MONTH(P.NgayMuon) IN ({monthsList})
                    GROUP BY MONTH(P.NgayMuon)
                    ORDER BY MONTH(P.NgayMuon);";

                // Sử dụng SqlCommand để thực thi câu truy vấn
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm tham số năm vào câu truy vấn
                    cmd.Parameters.AddWithValue("@Year", year);

                    // Đọc kết quả trả về từ cơ sở dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var statistic = new BookBorrowingStatistic_TO
                            {
                                Month = reader.GetInt32(0),
                                TotalBooks = reader.GetInt32(1)
                            };
                            statistics.Add(statistic);
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

            return statistics;
        }

        // Phương thức lấy tổng số sách mượn theo quý
        public List<BookBorrowingStatistic_TO> GetBookBorrowingStatisticsByQuarters(int year, List<int> quarters)
        {
            List<BookBorrowingStatistic_TO> statistics = new List<BookBorrowingStatistic_TO>();

            try
            {
                connection.Open();

                // Truy vấn SQL
                string query = $@"
                    SELECT 
                        CASE
                            WHEN MONTH(P.NgayMuon) BETWEEN 1 AND 3 THEN 1
                            WHEN MONTH(P.NgayMuon) BETWEEN 4 AND 6 THEN 2
                            WHEN MONTH(P.NgayMuon) BETWEEN 7 AND 9 THEN 3
                            WHEN MONTH(P.NgayMuon) BETWEEN 10 AND 12 THEN 4
                        END AS Quarter,
                        SUM(CTP.SoLuong) AS TotalBooks
                    FROM Phieu P
                    JOIN ChiTietPhieu CTP ON P.MaPhieu = CTP.MaPhieu
                    WHERE YEAR(P.NgayMuon) = @Year
                    AND CASE
                            WHEN MONTH(P.NgayMuon) BETWEEN 1 AND 3 THEN 1
                            WHEN MONTH(P.NgayMuon) BETWEEN 4 AND 6 THEN 2
                            WHEN MONTH(P.NgayMuon) BETWEEN 7 AND 9 THEN 3
                            WHEN MONTH(P.NgayMuon) BETWEEN 10 AND 12 THEN 4
                        END IN ({string.Join(",", quarters)})
                    GROUP BY CASE
                            WHEN MONTH(P.NgayMuon) BETWEEN 1 AND 3 THEN 1
                            WHEN MONTH(P.NgayMuon) BETWEEN 4 AND 6 THEN 2
                            WHEN MONTH(P.NgayMuon) BETWEEN 7 AND 9 THEN 3
                            WHEN MONTH(P.NgayMuon) BETWEEN 10 AND 12 THEN 4
                        END
                    ORDER BY Quarter;";

                // Sử dụng SqlCommand để thực thi câu truy vấn
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm tham số năm vào câu truy vấn
                    cmd.Parameters.AddWithValue("@Year", year);

                    // Đọc kết quả trả về từ cơ sở dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var statistic = new BookBorrowingStatistic_TO
                            {
                                Quarter = reader.GetInt32(0),
                                TotalBooks = reader.GetInt32(1)
                            };
                            statistics.Add(statistic);
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

            return statistics;
        }

    }
}
