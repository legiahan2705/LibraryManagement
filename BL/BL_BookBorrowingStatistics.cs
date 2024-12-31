using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_BookBorrowingStatistics
    {

        private readonly DL_BookBorrowingStatistics dlStatistics;

        public BL_BookBorrowingStatistics()
        {
            dlStatistics = new DL_BookBorrowingStatistics();
        }

        
        public List<BookBorrowingStatistic_TO> GetStatisticsByMonths(int year, List<int> months)
        {
            if (months == null || months.Count == 0)
            {
                throw new ArgumentException("Danh sách tháng không được để trống.");
            }

            // Gọi phương thức trong DL để lấy dữ liệu
            return dlStatistics.GetBookBorrowingStatisticsByMonths(year, months);
        }

       
        public List<BookBorrowingStatistic_TO> GetStatisticsByQuarters(int year, List<int> quarters)
        {
            if (quarters == null || quarters.Count == 0)
            {
                throw new ArgumentException("Danh sách quý không được để trống.");
            }

            // Kiểm tra tính hợp lệ của các quý (chỉ cho phép giá trị từ 1 đến 4)
            foreach (var quarter in quarters)
            {
                if (quarter < 1 || quarter > 4)
                {
                    throw new ArgumentOutOfRangeException($"Giá trị quý không hợp lệ: {quarter}");
                }
            }

            // Gọi phương thức trong DL để lấy dữ liệu
            return dlStatistics.GetBookBorrowingStatisticsByQuarters(year, quarters);
        }
    }
}
