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

        // Phương thức cập nhật thông tin nhân viên
        public bool UpdateEmployee(NhanVien_TO employee)
        {
            try
            {
                // Mở kết nối
                connection.Open();

                // Sử dụng câu lệnh SQL để cập nhật thông tin nhân viên
                string query = "UPDATE Nhanvien SET Ten = @Ten, GioiTinh = @GioiTinh, SDT = @SDT, Email = @Email, NgaySinh = @NgaySinh, Diachi = @DiaChi, PhanQuyen = @PhanQuyen WHERE MaNV = @MaNV";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm tham số để tránh SQL Injection
                    cmd.Parameters.AddWithValue("@Ten", employee.Ten);
                    cmd.Parameters.AddWithValue("@GioiTinh", employee.GioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", employee.SDT);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
                    cmd.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                    cmd.Parameters.AddWithValue("@PhanQuyen", employee.PhanQuyen);
                    cmd.Parameters.AddWithValue("@MaNV", employee.MaNV);

                    // Thực thi câu lệnh UPDATE và kiểm tra kết quả
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có ít nhất một dòng bị thay đổi
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
        }
    }
}
