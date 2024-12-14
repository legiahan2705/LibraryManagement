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
    public class DL_AddEmployee : DL_Connect
    {
        public bool AddEmployee(NhanVien_TO employee)
        {
            bool isAdded = false;

            try
            {
                // Mở kết nối
                connection.Open();

                // Câu lệnh SQL INSERT với OUTPUT để lấy Id vừa thêm
                string sql = "INSERT INTO Nhanvien (MaNV, Ten, GioiTinh, SDT, NgaySinh, DiaChi,Email, PhanQuyen) " +
                             "OUTPUT INSERTED.MaNV " +
                             "VALUES (@MaNV, @Ten, @GioiTinh, @SDT, @NgaySinh, @DiaChi, @Email, @PhanQuyen)";

                // Tạo SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Gán giá trị tham số
                    command.Parameters.AddWithValue("@MaNV", employee.MaNV);
                    command.Parameters.AddWithValue("@Ten", employee.Ten);
                    command.Parameters.AddWithValue("@GioiTinh", employee.GioiTinh);
                    command.Parameters.AddWithValue("@SDT", employee.SDT);
                    command.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
                    command.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
                    command.Parameters.AddWithValue("@Email", employee.Email);
                    command.Parameters.AddWithValue("@PhanQuyen",employee.PhanQuyen);

                    // Thực thi câu lệnh và lấy Id được sinh ra
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem result có phải là giá trị Id hợp lệ không
                    if (result != null)
                    {
                        employee.MaNV = result.ToString(); // Gán Id tự động sinh vào đối tượng
                        isAdded = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to add employee {ex.Message}");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return isAdded;
        }
    }
}
