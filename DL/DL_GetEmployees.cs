using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace DL
{
    public class DL_GetEmployees:DL_Connect
    {
        public List<NhanVien_TO> GetEmployees()
        {
            List<NhanVien_TO> employees = new List<NhanVien_TO>(); // Tạo danh sách chứa thông tin nhân viên

            try
            {
                // Mở kết nối
                connection.Open();

                // Sử dụng câu lệnh SQL để lấy danh sách nhân viên
                using (SqlCommand cmd = new SqlCommand("SELECT MaNV, Ten, GioiTinh,SDT,NgaySinh,Diachi,Email,PhanQuyen FROM Nhanvien", connection))
                {
                    // Thực thi câu lệnh và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo đối tượng Employees và gắn giá trị từ cơ sở dữ liệu
                            NhanVien_TO employee = new NhanVien_TO
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

                            // Thêm đối tượng vào danh sách
                            employees.Add(employee);
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

            return employees; // Trả về danh sách nhân viên
        }

        //Lấy danh sách từ QuanLySach
        public bool AddBookToManager(string maNV, string maSach)
        {
            string query = "INSERT INTO QuanLySach (MaNV, MaSach) VALUES (@MaNV, @MaSach)";
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@MaSach", maSach);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding book to manager: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
