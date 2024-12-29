using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using TO;


namespace BL
{
    public class BL_AutoSlipInfo
    {
        private DL_AutoSlipsInfo dl_AutoSlipInfo = new DL_AutoSlipsInfo();
        public List<string> GetBookNames()
        {
            List<string> booknames = dl_AutoSlipInfo.GetBookName();

            if (booknames == null || booknames.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("There are no book in the database");
                return new List<string>();
            }
            return booknames;
        }

        public string GetBookID(string bookname)
        {
            string id = dl_AutoSlipInfo.GetBookID(bookname);
            
            return id;
        }

        public string GenerateMaPhieu()
        {
            string Maphieu = dl_AutoSlipInfo.GenerateMaPhieu();

            return Maphieu;
        }

        public string GetTenDocGia(string id)
        {
            string name = dl_AutoSlipInfo.GetTenDocGia(id);

            return name;
        }
    }
}
