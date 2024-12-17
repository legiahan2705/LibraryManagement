using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class DL_InformationEmployee : DL_Connect
    {
            public NhanVien_TO GetEmployeeByMaNV(string maNV)
            {
                NhanVien_TO employee = null; // Khởi tạo đối tượng nhân viên

                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Sử dụng câu lệnh SQL để lấy thông tin nhân viên theo MaNV
                    using (SqlCommand cmd = new SqlCommand("SELECT MaNV, Ten, GioiTinh, SDT, NgaySinh, Diachi, Email, PhanQuyen FROM Nhanvien WHERE MaNV = @MaNV", connection))
                    {
                        // Thêm tham số để tránh SQL Injection
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        // Thực thi câu lệnh và đọc kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Chỉ đọc một dòng dữ liệu
                            {
                                employee = new NhanVien_TO
                                {
                                    MaNV = reader.GetString(0),
                                    Ten = reader.GetString(1),
                                    GioiTinh = reader.GetString(2),
                                    SDT = reader.GetString(3),
                                    NgaySinh = reader.GetDateTime(4).ToString("yyyy-MM-dd"),
                                    DiaChi = reader.GetString(5),
                                    Email = reader.GetString(6),
                                    PhanQuyen = reader.GetString(7)
                                };
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

                return employee; // Trả về thông tin nhân viên
            }
        
    }
}
