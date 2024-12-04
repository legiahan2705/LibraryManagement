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
        public string CheckLogin(TaiKhoan_TO taikhoan)
        {
            string info = CheckLogin_TO(taikhoan);
            return info;
        }
    }
}
