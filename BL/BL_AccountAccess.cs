using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;

namespace BL
{
    public class BL_AccountAccess
    {
        public string Login(TaiKhoan_TO taiKhoan, out string employeeName, out string employeeRole)
        {
            employeeName = null;
            employeeRole = null;

            // Gọi phương thức từ tầng DL
            bool loginResult = DL_AccountAccess.AccountAccess(taiKhoan, out employeeName, out employeeRole);

            // Xây dựng thông báo dựa trên kết quả
            if (loginResult)
            {
                return "Login successful";
            }
            else
            {
                return "Incorrect username or password";
            }
        }
    }
}