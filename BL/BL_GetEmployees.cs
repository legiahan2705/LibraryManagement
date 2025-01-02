using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using DL;

namespace BL
{
    public class BL_GetEmployees
    {
        private DL_GetEmployees _dlGetEmployees = new DL_GetEmployees();

        public List<NhanVien_TO> GetAllEmployees()
        {
            // Gọi tầng DL để lấy dữ liệu
            List<NhanVien_TO> employees = _dlGetEmployees.GetEmployees();

            // Kiểm tra nếu không có nhân viên nào
            if (employees == null || employees.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("There are no employees in the database");
                return new List<NhanVien_TO>();
            }

            // Trả về danh sách nhân viên nếu hợp lệ
            return employees;
        }

<<<<<<< HEAD
        //public List<QuanLySach_TO> GetAllQuanLySach()
        //{
        //    // Gọi tầng DL để lấy dữ liệu
        //    List<QuanLySach_TO> qlSach = _dlGetEmployees.AddBookToManager();

        //    // Kiểm tra nếu không có nhân viên nào
        //    if (employees == null || employees.Count == 0)
        //    {
        //        // Trả về danh sách rỗng hoặc ném thông báo lỗi
        //        Console.WriteLine("There are no employees in the database");
        //        return new List<NhanVien_TO>();
        //    }

        //    // Trả về danh sách nhân viên nếu hợp lệ
        //    return employees;
        //}
=======
        public List<NhanVien_TO> GetQLSach()
        {
            // Gọi tầng DL để lấy dữ liệu
            List<NhanVien_TO> nvQLS = _dlGetEmployees.GetQLSach();

            // Kiểm tra nếu không có nhân viên nào
            if (nvQLS == null || nvQLS.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("There are no employees in the database");
                return new List<NhanVien_TO>();
            }

            // Trả về danh sách nhân viên nếu hợp lệ
            return nvQLS;
        }

        public List<Sach_TO> GetSachDuocQL(string maNV)
        {
            // Gọi tầng DL để lấy dữ liệu
            DL_GetEmployees dlQuanLySach = new DL_GetEmployees(); // Tạo đối tượng tầng DL
            List<Sach_TO> sachDQL = dlQuanLySach.GetSachDuocQL(maNV); // Truyền maNV vào DL

            // Kiểm tra nếu không có sách nào
            if (sachDQL == null || sachDQL.Count == 0)
            {
                // Trả về danh sách rỗng hoặc ném thông báo lỗi
                Console.WriteLine("There are no book in the database");
                return new List<Sach_TO>();
            }

            // Trả về danh sách sách nếu hợp lệ
            return sachDQL;
        }
>>>>>>> d0f93771b860fcfaea895f97c6963a23fbcd9ac8

    }
}
