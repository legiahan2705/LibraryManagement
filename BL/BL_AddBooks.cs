using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_AddBooks
    {
        private DL_AddBooks _dlAdd;

        public BL_AddBooks()
        {
            _dlAdd = new DL_AddBooks();
        }

        public bool AddBooks(Sach_TO book)
        {
            return _dlAdd.AddBooks(book);
        }

        // Phương thức cập nhật reader
        public bool UpdateBook(Sach_TO book)
        {
            return _dlAdd.UpdateBook(book);
        }
    }
}
