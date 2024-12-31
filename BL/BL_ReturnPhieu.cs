using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace BL
{
    public class BL_ReturnPhieu
    {
        DL_ReturnPhieu dl_returnphieu = new DL_ReturnPhieu();

        public string bl_ReturnPhieu(string MaPhieu, DateTime ngayMuon)
        {
            if (string.IsNullOrEmpty(MaPhieu))
                throw new ArgumentException("Mã phiếu không được để trống!");

            DateTime ngayTra = DateTime.Now;
            int soNgayMuon = (ngayTra - ngayMuon).Days;

            dl_returnphieu.dl_ReturnPhieu(MaPhieu);

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
