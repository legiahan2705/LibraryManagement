using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_GetReaders
    {
        private DL_GetReaders _dlGetReader = new DL_GetReaders();

        public List<DocGia_TO> GetAllReader()
        {
            // Gọi tầng DL để lấy dữ liệu
            List<DocGia_TO> readers = _dlGetReader.GetReaders();

            // Kiểm tra nếu không có nhân viên nào
            if (readers == null ||readers.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("There are no readers in the database.");
                return new List<DocGia_TO>();
            }

            // Trả về danh sách nhân viên nếu hợp lệ
            return readers;
        }
    }
}
