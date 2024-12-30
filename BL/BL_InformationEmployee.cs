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

        // Phương thức cập nhật thông tin nhân viên
        public bool UpdateEmployeeInfo(NhanVien_TO employee)
        {
            if (employee == null)
            {
                throw new ArgumentException("Employee information cannot be null.");
            }

            // Gọi phương thức từ DL để cập nhật thông tin
            bool isUpdated = dlInformationEmployee.UpdateEmployee(employee);

            if (!isUpdated)
            {
                throw new Exception("Failed to update employee information.");
            }

            return true; // Trả về true nếu cập nhật thành công
        }
    }
}
