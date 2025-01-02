using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;
using System.Text.RegularExpressions;

namespace BL
{
    public class BL_DeleteBooks
    {
        private DL_DeleteBooks _dlDeletebooks; // Đối tượng của tầng DL

        public BL_DeleteBooks()
        {
            _dlDeletebooks = new DL_DeleteBooks(); // Khởi tạo đối tượng tầng DL
        }

        public bool DeleteBooks(string bookId)
        {
            return _dlDeletebooks.Delete_Books(bookId);
        }

        public bool XoaSachKhoiQuanLy(string bookId)
        {
            return _dlDeletebooks.XoaSachKhoiQuanLy(bookId);
        }

    }
}
