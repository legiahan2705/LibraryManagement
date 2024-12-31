using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;

namespace BL
{
    public class BL_GetPhieuDetails
    {
        DL_GetPhieuDetails dl_getphieudetails = new DL_GetPhieuDetails();

        public DataTable bl_getphieuDetails()
        {
            return dl_getphieudetails.dl_getphieuDeTails();
        }

        public DataTable bl_GetDetailForReturn(string MaDG)
        {
            if (string.IsNullOrEmpty(MaDG))
                throw new ArgumentException("Mã độc giả không được để trống!");

            return dl_getphieudetails.dl_GetDetailForReturn(MaDG);
        }

        public DataTable bl_PhieuReturn()
        {
            return dl_getphieudetails.PhieuReturn();
        }
    }
}
