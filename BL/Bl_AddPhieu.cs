using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace BL
{
    public class Bl_AddPhieu
    {
        DL_AddPhieu dl_addphieu = new DL_AddPhieu();
        public bool AddPhieu(string maPhieu, string maDocGia, DateTime ngayMuon, List<(string maSach, int soLuong)> chiTietPhieu)
        {
            return dl_addphieu.AddPhieu(maPhieu, maDocGia, ngayMuon, chiTietPhieu);
        }

        public bool Checkname(string name, string id)
        {
            return dl_addphieu.CheckName(name, id);
        }
    }
}
