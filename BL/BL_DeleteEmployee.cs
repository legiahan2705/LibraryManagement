using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_DeleteEmployee
    {
        private DL_DeleteEmployee _dlDelete; // Đối tượng của tầng DL

        public BL_DeleteEmployee()
        {
            _dlDelete = new DL_DeleteEmployee(); // Khởi tạo đối tượng tầng DL
        }

        public bool DeleteEmployee(string employeeId)
        {
            // Gọi phương thức Delete_Employee từ tầng DL
            return _dlDelete.Delete_Employee(employeeId);
        }
    }
}
