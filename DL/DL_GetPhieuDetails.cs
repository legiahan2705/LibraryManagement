using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
	public class DL_GetPhieuDetails : DL_Connect
	{
		public DataTable dl_getphieuDeTails()
		{
			DataTable dt = new DataTable();
			string query = @"
					SELECT 
						ct.MaPhieu as N'Mã phiếu', 
						p.MaDG as N'Mã độc giả',
						dg.Ten as N'Tên độc giả',
						ct.MaSach as N'Mã sách', 
						s.TenSach as N'Tên Sách',
						ct.SoLuong as N'SL', 
						p.NgayMuon as N'Ngày mượn', 
						p.NgayTra as N'Ngày Trả', 
						p.TrangThai as N'Trạng Thái'
					FROM ChiTietPhieu ct
					INNER JOIN Phieu p ON ct.MaPhieu = p.MaPhieu
					INNER JOIN Sach s ON ct.MaSach = s.MaSach
					INNER JOIN Docgia dg on p.MaDG = dg.MaDG";

			try
			{
				if (connection.State == System.Data.ConnectionState.Closed)
				{
					connection.Open();
				}
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(dt);
				}

				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public DataTable dl_GetDetailForReturn(string MaDG)
		{
			DataTable dt = new DataTable();
			string query = @"
					SELECT 
						ct.MaPhieu as N'Mã phiếu', 
						p.MaDG as N'Mã độc giả',
						dg.Ten as N'Tên độc giả',
						ct.MaSach as N'Mã sách', 
						s.TenSach as N'Tên Sách',
						ct.SoLuong as N'SL', 
						p.NgayMuon as N'Ngày mượn', 
						p.NgayTra as N'Ngày Trả', 
						p.TrangThai as N'Trạng Thái'
					FROM ChiTietPhieu ct
					INNER JOIN Phieu p ON ct.MaPhieu = p.MaPhieu
					INNER JOIN Sach s ON ct.MaSach = s.MaSach
					INNER JOIN Docgia dg on p.MaDG = dg.MaDG
					Where p.MaDG = @MaDocGia and p.TrangThai like N'%Chưa trả%'";
			
			try
			{
				if (connection.State == System.Data.ConnectionState.Closed)
				{
					connection.Open();
				}
				using (SqlCommand cmd = new SqlCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@MaDocGia", MaDG);
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(dt);
				}
				return dt;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		
		public DataTable PhieuReturn()
		{
			DataTable dt = new DataTable();
            string query = @"
					SELECT 
						ct.MaPhieu as N'Mã phiếu', 
						p.MaDG as N'Mã độc giả',
						dg.Ten as N'Tên độc giả',
						ct.MaSach as N'Mã sách', 
						s.TenSach as N'Tên Sách',
						ct.SoLuong as N'SL', 
						p.NgayMuon as N'Ngày mượn', 
					FROM ChiTietPhieu ct
					INNER JOIN Phieu p ON ct.MaPhieu = p.MaPhieu
					INNER JOIN Sach s ON ct.MaSach = s.MaSach
					INNER JOIN Docgia dg on p.MaDG = dg.MaDG
					Where p.TrangThai like N'%Chưa trả%'";

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	}
}
