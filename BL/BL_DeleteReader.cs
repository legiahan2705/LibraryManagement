using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_DeleteReader
    {
        private DL_DeleteReader _dlDelete; // Đối tượng của tầng DL

        public BL_DeleteReader()
        {
            _dlDelete = new DL_DeleteReader(); // Khởi tạo đối tượng tầng DL
        }

        public bool DeleteReader(string MaDG)
        {
            return _dlDelete.Delete_Reader(MaDG);
        }
    }
}
