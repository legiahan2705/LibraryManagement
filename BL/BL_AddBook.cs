using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_AddBook
    {
        private DL_AddBook _dlAdd;

        public BL_AddBook()
        {
            _dlAdd = new DL_AddBook();
        }

        public bool AddBook(Sach_TO book)
        {
            return _dlAdd.AddBook(book);
        }

        // Phương thức cập nhật sách
        public bool UpdateBook(Sach_TO book)
        {
            return _dlAdd.UpdateBook(book);
        }
    }
}
