using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TO;

namespace DL
{
    public class DL_AutoSlipsInfo:DL_Connect
    {
        public List<string> GetBookName()
        { 
            List<string> booknames = new List<string>();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "Select TenSach from Sach";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            booknames.Add(reader["TenSach"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return booknames;

        }

        public string GetBookID(string bookname)
        {
            string id = "";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "Select MaSach from Sach where TenSach LIKE @bookname";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookName", "%" + bookname + "%");
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader["MaSach"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching book names", ex);
            }
            return id;
        }

        public string GenerateMaPhieu()
        {
            string newMaPhieu = "P001";
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                // Truy vấn mã phiếu mượn lớn nhất
                string query = "SELECT TOP 1 MaPhieu FROM Phieu ORDER BY MaPhieu DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        string lastMaPhieu = result.ToString();

                        int numberPart = int.Parse(lastMaPhieu.Substring(2));

                        newMaPhieu = "P" + (numberPart + 1).ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error while generating MaPhieu", ex);
            }
            return newMaPhieu;
        }

        public string GetTenDocGia(string id)
        {
            string name = "";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                string query = "Select Ten from Docgia where MaDG = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader["Ten"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: ", ex);
            }
            return name;
        }
    }
}
