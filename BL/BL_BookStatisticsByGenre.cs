using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_BookStatisticsByGenre
    {
        private DL_BookStatisticsByGenre dlBookStatisticsByGenre;

        public BL_BookStatisticsByGenre()
        {
            // Khởi tạo đối tượng DL_BookStatisticsByGenre
            dlBookStatisticsByGenre = new DL_BookStatisticsByGenre();
        }

        // Phương thức lấy thống kê sách theo thể loại
        public List<ThongKeSach_TO> GetBookStatisticsByGenre()
        {
            try
            {
                // Gọi phương thức từ Data Layer để lấy dữ liệu
                List<ThongKeSach_TO> bookStatistics = dlBookStatisticsByGenre.GetBookStatisticsByGenre();

                // Xử lý dữ liệu (nếu cần thêm logic nghiệp vụ)
                // Ví dụ: Tính toán thêm hoặc lọc dữ liệu

                return bookStatistics;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi và thông báo cho người dùng nếu có vấn đề xảy ra
                Console.WriteLine("Error in BL: " + ex.Message);
                throw;
            }
        }
    }
}
