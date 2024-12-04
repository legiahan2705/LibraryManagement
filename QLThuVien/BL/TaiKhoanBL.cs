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
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogin(TaiKhoan_TO taikhoan)
        {
            // Kiểm tra nghiệp vụ
            if (taikhoan.MaNV == "")
            {
                return "required_taikhoan";
            }
            if (taikhoan.MK == "")
            {
                return "required_matkhau";
            }

            string info = tkAccess.CheckLogin(taikhoan);
            return info;
        }
    }
}
