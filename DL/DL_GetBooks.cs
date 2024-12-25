using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
        public class DL_GetBooks : DL_Connect
        {
            public List<Sach_TO> GetBooks()
            {
                List<Sach_TO> books = new List<Sach_TO>(); // Tạo danh sách chứa thông tin sách

                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Sử dụng câu lệnh SQL để lấy danh sách nhân viên
                    using (SqlCommand cmd = new SqlCommand("SELECT MaSach, TenSach, MaTL, SL, NXB, NgayNhap, NoiDung FROM Sach", connection))
                    {
                        // Thực thi câu lệnh và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Tạo đối tượng Employees và gắn giá trị từ cơ sở dữ liệu
                                Sach_TO sach = new Sach_TO
                                {
                                    MaSach = reader.GetString(0),
                                    TenSach = reader.GetString(1),
                                    MaTL = reader.GetString(2),
                                    SL = reader.GetInt32(3),
                                    NXB = reader.GetString(4),
                                    NgayNhap = reader.GetDateTime(5).ToString("yyyy-MM-dd")
                                };

                                // Thêm đối tượng vào danh sách
                                books.Add(sach);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Ghi log lỗi
                    throw ex;
                }
                finally
                {
                    // Đảm bảo đóng kết nối
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

                return books; // Trả về danh sách sách
            }
        }
   
}
