using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;

namespace BL
{
    public class BL_InformationEmployee
    {
        private DL_InformationEmployee dlInformationEmployee;

        public BL_InformationEmployee()
        {
            dlInformationEmployee = new DL_InformationEmployee();
        }

        public NhanVien_TO GetEmployeeInfo(string maNV)
        {
            if (string.IsNullOrEmpty(maNV))
            {
                throw new ArgumentException("Employee ID cannot be empty.");
            }

            NhanVien_TO employee = dlInformationEmployee.GetEmployeeByMaNV(maNV);

            if (employee == null)
            {
                throw new Exception("Employee information not found.");
            }

            return employee;
        }
    }
}
