using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using DL;

namespace BL
{
    public class BL_ReturnPhieu
    {
        private readonly DL_ReturnPhieu dl_returnphieu = new DL_ReturnPhieu();

        public string bl_ReturnPhieu(string MaPhieu, DateTime ngayMuon)
        {
            // Kiểm tra đầu vào
            if (string.IsNullOrWhiteSpace(MaPhieu))
                throw new ArgumentException("Mã phiếu không được để trống!", nameof(MaPhieu));

            // Lấy ngày trả là ngày hiện tại
            DateTime ngayTra = DateTime.Now;

            // Tính số ngày mượn
            int soNgayMuon = (ngayTra - ngayMuon).Days;

            // Cập nhật trạng thái phiếu và ngày trả
            dl_returnphieu.dl_ReturnPhieu(MaPhieu);

            // Xử lý trả kết quả theo số ngày mượn
            if (soNgayMuon > 14)
            {
                return $"Phiếu {MaPhieu} đã trả, nhưng trễ {soNgayMuon - 14} ngày!";
            }
            else
            {
                return $"Phiếu {MaPhieu} đã trả đúng hạn.";
            }
        }
    }
}

