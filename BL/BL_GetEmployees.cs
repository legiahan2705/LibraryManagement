using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;

namespace BL
{
    public class BL_GetEmployees
    {
        private DL_GetEmployees _dlGetEmployees = new DL_GetEmployees();

        public List<NhanVien_TO> GetAllEmployees()
        {
            // Gọi tầng DL để lấy dữ liệu
            List<NhanVien_TO> employees = _dlGetEmployees.GetEmployees();

            // Kiểm tra nếu không có nhân viên nào
            if (employees == null || employees.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("Không có nhân viên nào trong cơ sở dữ liệu.");
                return new List<NhanVien_TO>();
            }

            // Trả về danh sách nhân viên nếu hợp lệ
            return employees;
        }
    }
}
