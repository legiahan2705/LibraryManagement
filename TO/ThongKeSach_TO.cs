using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class ThongKeSach_TO
    {

        public string MaTheLoai { get; set; }
        // Tên thể loại sách
        public string TenTheLoai { get; set; }

        // Số lượng sách trong thể loại đó
        public int SoLuongSach { get; set; }

        // Tỷ lệ phần trăm của thể loại sách so với tổng số sách
        public decimal TyLe { get; set; }
    }
}
