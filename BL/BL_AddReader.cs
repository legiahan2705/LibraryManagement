
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;

namespace BL
{
    public class BL_AddReader
    {
        private DL_AddReader _dlAdd;

        public BL_AddReader()
        {
            _dlAdd = new DL_AddReader();
        }

        public bool AddReader(DocGia_TO reader)
        {
            return _dlAdd.AddReader(reader);
        }

        // Phương thức cập nhật reader
        public bool UpdateReader(DocGia_TO reader)
        {
            return _dlAdd.UpdateReader(reader);
        }
    }
}
