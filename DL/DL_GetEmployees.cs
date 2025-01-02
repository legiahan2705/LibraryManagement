using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;
using System.Reflection;

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

        public List<NhanVien_TO> GetQLSach()
        {
            List<NhanVien_TO> nvQLS = new List<NhanVien_TO>(); // Tạo danh sách chứa thông tin nhân viên quản lý

            try
            {
                // Mở kết nối
                connection.Open();

                // Sử dụng câu lệnh SQL để lấy danh sách nhân viên
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT nv.MaNV, nv.Ten " +
                                                        "FROM NhanVien nv " + 
                                                        "INNER JOIN QuanLySach qls ON nv.MaNV = qls.MaNV;", connection))
                {
                    // Thực thi câu lệnh và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo đối tượng Employees và gắn giá trị từ cơ sở dữ liệu
                            NhanVien_TO nvQL = new NhanVien_TO
                            {
                                MaNV = reader.GetString(0),
                                Ten = reader.GetString(1)
                            };

                            // Thêm đối tượng vào danh sách
                            nvQLS.Add(nvQL);
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

            return nvQLS; // Trả về danh sách nhân viên
        }

        public List<Sach_TO> GetSachDuocQL(string maNV)
        {
            List<Sach_TO> sachDQL = new List<Sach_TO>(); // Tạo danh sách chứa thông tin sách 

            try
            {
                // Mở kết nối
                connection.Open();

                // Sử dụng câu lệnh SQL để lấy danh sách nhân viên
                using (SqlCommand cmd = new SqlCommand("SELECT s.MaSach, s.TenSach " +
                       "FROM Sach s " +
                       "INNER JOIN QuanLySach qls ON s.MaSach = qls.MaSach " +
                       "WHERE qls.MaNV = @MaNV", connection))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV); // Gán tham số MaNV
                    // Thực thi câu lệnh và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo đối tượng Employees và gắn giá trị từ cơ sở dữ liệu
                            Sach_TO sachQL = new Sach_TO
                            {
                                MaSach = reader.GetString(0),
                                TenSach = reader.GetString(1)
                            };

                            // Thêm đối tượng vào danh sách
                            sachDQL.Add(sachQL);
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

            return sachDQL; // Trả về danh sách sách
        }
    }
}
