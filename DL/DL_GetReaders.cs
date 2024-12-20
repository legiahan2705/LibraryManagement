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
    public class DL_GetReaders : DL_Connect
    {
        public List<DocGia_TO> GetReaders()
        {
            List<DocGia_TO> readers = new List<DocGia_TO>(); // Tạo danh sách chứa thông tin nhân viên

            try
            {
                // Mở kết nối
                connection.Open();

                // Sử dụng câu lệnh SQL để lấy danh sách nhân viên
                using (SqlCommand cmd = new SqlCommand("SELECT MaDG,Ten,GioiTinh,SDT,NgaySinh,Diachi FROM Docgia", connection))
                {
                    // Thực thi câu lệnh và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo đối tượng Employees và gắn giá trị từ cơ sở dữ liệu
                            DocGia_TO Reader = new DocGia_TO
                            {
                                MaDG = reader.GetString(0),
                                Ten = reader.GetString(1),
                                GioiTinh = reader.GetString(2),
                                SDT = reader.GetString(3),
                                NgaySinh = reader.GetDateTime(4).ToString("yyyy-MM-dd"),
                                DiaChi = reader.GetString(5),
                                
                            };

                            // Thêm đối tượng vào danh sách
                            readers.Add(Reader);
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

            return readers; // Trả về danh sách nhân viên
        }
    }
}
