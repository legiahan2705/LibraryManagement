using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TO;
using DL;

namespace QLThuVien
{
    public partial class Profile : Form
    {
        private BL_GetEmployees _blEmployees;
        private BL_DeleteEmployee _blDeleteEmployee;
        private BL_AddEmployee _blAddEmployee;

        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên
        private string employeeID; // Lưu ID nhân viên

        private BL_InformationEmployee _bl_informationEmployee;

        //lưu tên NV được truyền từ form Đăng Nhập
        public Profile(string employeeName, string employeeRole, string id)
        {
            InitializeComponent();

            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.employeeID = id;

            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();


            _bl_informationEmployee = new BL_InformationEmployee();
        }

        // Hàm thoát dùng chung để tránh lặp lại MessageBox thoát nhiều lần
        private bool ConfirmExit()
        {
            // Hiển thị hộp thoại xác nhận thoát
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return result == DialogResult.Yes; // Trả về true nếu người dùng chọn Yes
        }

        // Biến cờ để theo dõi trạng thái thoát
        private bool isExiting = false;


        // Hàm xử lý Hover các panel bên Trái
        private void HoverEffect_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Control control) // Kiểm tra nếu sender là một Control
            {
                // Lấy Panel cha từ Control hiện tại (nếu Control là Panel thì chính nó, nếu không thì lấy Parent)
                Panel? parentPanel = control as Panel ?? control.Parent as Panel;

                if (parentPanel != null) // Nếu tìm thấy Panel cha
                {
                    parentPanel.BackColor = ColorTranslator.FromHtml("#BDC0FA"); // đổi màu nền
                }
            }
        }

        // Hàm xử lý khi chuột rời khỏi một thành phần
        private void HoverEffect_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Control control) // Kiểm tra nếu sender là một Control
            {
                // Lấy Panel cha từ Control hiện tại
                Panel? parentPanel = control as Panel ?? control.Parent as Panel;

                if (parentPanel != null) // Nếu tìm thấy Panel cha
                {
                    parentPanel.BackColor = Color.Transparent; // Khôi phục màu nền mặc định
                }
            }
        }

        //Xử lí nút Log Out bên Trái
        private void pnlLogOut_Click(object sender, EventArgs e)
        {
            // Hiển thị MessageBox xác nhận đăng xuất
            DialogResult result = MessageBox.Show(
                "Do you want to log out?",
                "Log Out Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Nếu chọn Có, đóng form Profile và mở lại form DangNhap
                this.Hide(); // Ẩn form Profile hiện tại
                DangNhap loginForm = new DangNhap(); // Tạo mới form DangNhap
                loginForm.Show(); // Hiển thị form DangNhap
            }
            else
            {
                // Nếu chọn không, MessageBox tự tắt
            }
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu chưa xác nhận thoát hoặc chọn Không, hủy sự kiện đóng form
            if (!isExiting && !ConfirmExit())
            {
                e.Cancel = true;
            }
            else
            {
                isExiting = true; // Đánh dấu đã xác nhận thoát
                Environment.Exit(0); // Thoát toàn bộ ứng dụng
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            pnlProfile.BackColor = ColorTranslator.FromHtml("#BDC0FA");

            NhanVien_TO employee = _bl_informationEmployee.GetEmployeeInfo(employeeID);

            txtEmployeeID.Text = employee.MaNV;
            txtName.Text = employee.Ten;
            txtSex.Text = employee.GioiTinh;
            txtPhoneNo.Text = employee.SDT;
            txtEmail.Text = employee.Email;
            txtDateOfBirth.Text = employee.NgaySinh;
            txtAddress.Text = employee.DiaChi;
            txtRole.Text = employee.PhanQuyen;

            //gán tên nhân viên vào label Welcome
            lblEmployeeName.Text = employeeName;

            // Hiển thị thông tin nhân viên lên các TextBox
        }

        private void pnlManageEmployees_Click(object sender, EventArgs e)
        {
            //Kiểm tra vai trò trước\
            string role = "Quản lý";
            if (!string.Equals(this.employeeRole, role, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only managers are allowed to access this function.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi sự kiện nếu không phải quản lý
            }

            ManageEmployees manageEmployees = new ManageEmployees(employeeName, employeeRole, employeeID);
            manageEmployees.Show();
            this.Hide();
        }

        private void pnlBorrowReturn_Click(object sender, EventArgs e)
        {
            BorrowReturn borrowReturn = new BorrowReturn(employeeName, employeeRole, employeeID);
            borrowReturn.Show();
            this.Hide();
        }
        private void pnlManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooks = new ManageBooks(employeeName, employeeRole, employeeID);
            manageBooks.Show();
            this.Hide();
        }

        private void pnlDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(employeeName, employeeRole, employeeID);
            dashboard.Show();
            this.Hide();
        }

    }
}
