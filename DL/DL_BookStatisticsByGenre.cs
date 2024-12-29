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
    public class DL_BookStatisticsByGenre:DL_Connect
    {
        // Hàm lấy thống kê sách theo thể loại
        public List<ThongKeSach_TO> GetBookStatisticsByGenre()
        {
            List<ThongKeSach_TO> bookStatistics = new List<ThongKeSach_TO>();

            // Câu lệnh SQL truy vấn thống kê sách theo thể loại (không dùng AS)
            string query = @"
               SELECT t.MaTL,
                    t.Ten, 
                    SUM(s.SL), 
                    CAST(ROUND(SUM(s.SL) * 100.0 / (SELECT SUM(SL) FROM Sach), 2) AS DECIMAL(10, 2)) 
                FROM 
                    Sach s
                JOIN 
                    TheLoai t ON s.MaTL = t.MaTL
                GROUP BY 
                    t.Ten, t.MaTL
                ORDER BY
                        t.MaTL";

            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                SqlCommand cmd = new SqlCommand(query, connection);

                // Thực thi câu lệnh và lấy dữ liệu
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Tạo đối tượng ThongKeSach_TO và gán giá trị từ cơ sở dữ liệu
                        ThongKeSach_TO statistics = new ThongKeSach_TO
                        {
                            MaTheLoai = reader.GetString(0),
                            TenTheLoai = reader.GetString(1),
                            SoLuongSach = reader.GetInt32(2),
                            TyLe = reader.GetDecimal(3) 
                        };

                        // Thêm đối tượng vào danh sách
                        bookStatistics.Add(statistics);
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng sau khi hoàn thành
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return bookStatistics; // Trả về danh sách thống kê sách theo thể loại
        }
    }
}
