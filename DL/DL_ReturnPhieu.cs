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
            string query = @"
                UPDATE Phieu
                SET TrangThai = 'Đã Trả'
                WHERE MaPhieu = @MaPhieu";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MaPhieu", MaPhieu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
