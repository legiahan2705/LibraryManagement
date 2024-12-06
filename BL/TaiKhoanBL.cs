using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;

namespace BL
{
    public class TaiKhoanBL
    {
        // Phương thức kiểm tra đăng nhập và lấy tên nhân viên
        public string CheckLogin(TaiKhoan_TO taikhoan, out string employeeName)
        {
            TaiKhoanAccess taiKhoanAccess = new TaiKhoanAccess();
            string result = taiKhoanAccess.CheckLogin(taikhoan, out employeeName);
            return result;
        }
    }
}