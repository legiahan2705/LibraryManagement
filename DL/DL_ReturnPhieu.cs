using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DL_ReturnPhieu: DL_Connect
    {
        public void dl_ReturnPhieu(string MaPhieu)
        {
            // Query để cập nhật cả TrangThai và NgayTra
            string query = @"
                UPDATE Phieu
                SET TrangThai = N'Đã Trả',
                    NgayTra = @NgayTra
                WHERE MaPhieu = @MaPhieu";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm tham số Mã Phiếu và Ngày Trả
                    cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                    cmd.Parameters.AddWithValue("@NgayTra", DateTime.Now); // Ngày hiện tại

                    // Thực thi truy vấn
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật phiếu: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối luôn được đóng
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
