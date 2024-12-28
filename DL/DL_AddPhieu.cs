using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class DL_AddPhieu:DL_Connect
    {
        public bool AddPhieu(string MaPhieu,  string MaDocGia, DateTime Ngaymuon, List<(string MaSach, int SoLuong)> chitietPhieu)
        {

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                string QueryInsertPhieu = "INSERT INTO Phieu (MaPhieu, MaDG, NgayMuon) VALUES (@MaPhieu, @MaDG, @NgayMuon)";
                using (SqlCommand command = new SqlCommand(QueryInsertPhieu, connection, transaction))
                {
                    command.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                    command.Parameters.AddWithValue("@MaDG", MaDocGia);
                    command.Parameters.AddWithValue("@NgayMuon", Ngaymuon);
                    command.ExecuteNonQuery();
                }

                foreach (var item in chitietPhieu)
                {
                    string queryCheckStock = "SELECT SL FROM Sach WHERE MaSach = @MaSach";
                    using (SqlCommand cmd = new SqlCommand(queryCheckStock, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", item.MaSach);
                        int soLuongTon = (int)cmd.ExecuteScalar();

                        if (soLuongTon < item.SoLuong)
                        {
                            throw new Exception($"Sách {item.MaSach} không đủ tồn kho. Hiện có {soLuongTon}, yêu cầu {item.SoLuong}.");
                        }
                    }

                    string queryInsertChiTiet = "INSERT INTO ChiTietPhieu (MaPhieu, MaSach, SoLuong) VALUES (@MaPhieu, @MaSach, @SoLuong)";
                    using (SqlCommand cmd = new SqlCommand(queryInsertChiTiet, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                        cmd.Parameters.AddWithValue("@MaSach", item.MaSach);
                        cmd.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmd.ExecuteNonQuery();
                    }

                    string queryUpdateStock = "UPDATE Sach SET SL = SL - @SoLuong WHERE MaSach = @MaSach";
                    using (SqlCommand cmd = new SqlCommand(queryUpdateStock, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmd.Parameters.AddWithValue("@MaSach", item.MaSach);
                        cmd.ExecuteNonQuery();
                    }
                }

                string queryUpdatePhieu = "UPDATE Phieu SET NgayTra = DATEADD(DAY, 14, NgayMuon), TrangThai = N'Chưa trả' WHERE MaPhieu = @MaPhieu";
                using (SqlCommand cmd = new SqlCommand(queryUpdatePhieu, connection, transaction))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit(); 
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback(); // Rollback nếu xảy ra lỗi
                throw ex;
            }
        }

        public bool CheckName(string name, string id)
        {
            string DB_name = "";
            string query = "Select Ten from DocGia where MaDG = @ID";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DB_name = reader["Ten"].ToString();
                    }
                }
            }

            if(DB_name == name)
            {
                return true;
            }
            return false;
        }
    }
}
