using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BL
{
    public class BL_AddBook
    {
        private DL_AddBook dlAddBook;

        public BL_AddBook()
        {
            dlAddBook = new DL_AddBook();
        }

        public bool AddBook(Sach_TO book)
        {
            // Kiểm tra dữ liệu trước khi thêm
            if (string.IsNullOrEmpty(book.MaSach) || string.IsNullOrEmpty(book.TenSach) ||
                string.IsNullOrEmpty(book.MaTL) || book.SL <= 0 ||
                string.IsNullOrEmpty(book.NXB) || string.IsNullOrEmpty(book.NgayNhap))
            {
                throw new ArgumentException("Invalid book data.");
            }

            // Gọi phương thức từ tầng DL
            return dlAddBook.AddBook(book);
        }

        // Phương thức cập nhật sách
        public bool UpdateBook(Sach_TO book)
        {
            return dlAddBook.UpdateBook(book);
        }
    }
}
