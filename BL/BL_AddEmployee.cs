using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;

namespace BL
{
    public class BL_AddEmployee
    {
        private DL_AddEmployee _dlAdd;

        public BL_AddEmployee()
        {
            _dlAdd = new DL_AddEmployee();
        }

        public bool AddEmployee(NhanVien_TO employee)
        {
            return _dlAdd.AddEmployee(employee);
        }

        // Phương thức cập nhật nhân viên
        public bool UpdateEmployee(NhanVien_TO employee)
        {
            return _dlAdd.UpdateEmployee(employee);
        }
        

    }
}
