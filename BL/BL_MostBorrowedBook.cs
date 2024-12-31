using System;
using System.Collections.Generic;
using TO;
using DL;

namespace BL
{
    public class BL_MostBorrowedBook
    {
        private DL_MostBorrowedBook dlMostBorrowedBook;

        public BL_MostBorrowedBook()
        {
            dlMostBorrowedBook = new DL_MostBorrowedBook();
        }

        // Lấy top N sách được mượn nhiều nhất trong một tháng cụ thể của một năm
        public List<MostBorrowedBook_TO> GetTopNBorrowedBooksByMonth(int year, int month, int topN)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Tháng không hợp lệ. Giá trị phải từ 1 đến 12.");
            if (topN <= 0)
                throw new ArgumentException("Số lượng Top N không hợp lệ. Giá trị phải là số dương.");

            return dlMostBorrowedBook.GetTopNBorrowedBooksByMonth(year, month, topN);
        }

        // Lấy top N sách được mượn nhiều nhất trong một quý cụ thể của một năm
        public List<MostBorrowedBook_TO> GetTopNBorrowedBooksByQuarter(int year, int quarter, int topN)
        {
            if (quarter < 1 || quarter > 4)
                throw new ArgumentException("Quý không hợp lệ. Giá trị phải từ 1 đến 4.");
            if (topN <= 0)
                throw new ArgumentException("Số lượng Top N không hợp lệ. Giá trị phải là số dương.");

            return dlMostBorrowedBook.GetTopNBorrowedBooksByQuarter(year, quarter, topN);
        }

        // Lấy top N sách được mượn nhiều nhất trong một năm cụ thể
        public List<MostBorrowedBook_TO> GetTopNBorrowedBooksByYear(int year, int topN)
        {
            if (year < 0)
                throw new ArgumentException("Năm không hợp lệ. Giá trị phải là số dương.");
            if (topN <= 0)
                throw new ArgumentException("Số lượng Top N không hợp lệ. Giá trị phải là số dương.");

            return dlMostBorrowedBook.GetTopNBorrowedBooksByYear(year, topN);
        }
    }
}
