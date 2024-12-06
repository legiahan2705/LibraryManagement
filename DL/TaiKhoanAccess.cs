using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace DL
{
    public class TaiKhoanAccess : DataBaseAccess
    {
        public string CheckLogin(TaiKhoan_TO taikhoan, out string employeeName)
        {
            // Gọi phương thức từ DataBaseAccess để kiểm tra đăng nhập
            string result = CheckLogin_TO(taikhoan, out employeeName);
            return result;
        }


    }
}