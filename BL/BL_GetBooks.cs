using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_GetBooks
    {
        private DL_GetBooks _dlGetBooks = new DL_GetBooks();

            public List<Sach_TO> GetAllBooks()
            {
                // Gọi tầng DL để lấy dữ liệu
                List<Sach_TO> books = _dlGetBooks.GetBooks();

                // Kiểm tra nếu không có nhân viên nào
                if (books == null || books.Count == 0)
                {
                    // Trả về danh sách rỗng hoặc ném thông báo lỗi
                    Console.WriteLine("There are no employees in the database");
                    return new List<Sach_TO>();
                }

                // Trả về danh sách nhân viên nếu hợp lệ
                return books;
            }
        }
}
