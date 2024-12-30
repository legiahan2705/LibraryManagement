using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Microsoft.Data.SqlClient;
using TO;
using DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLThuVien
{
    public partial class Dashboard : Form
    {
        private BL_GetEmployees _blEmployees;
        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên
        private string employeeID; // Lưu ID nhân viên

        public Dashboard(string employeeName, string employeeRole, string id)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.employeeID = id;

            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();
        }

        // Chuyển qua các Form
        private void pnlBorrowReturn_Click(object sender, EventArgs e)
        {
            BorrowReturn borrowReturn = new BorrowReturn(employeeName, employeeRole, employeeID);
            borrowReturn.Show();
            this.Hide();
        }

        private void pnlProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(employeeName, employeeRole, employeeID);
            profile.Show();
            this.Hide();
        }

        private void pnlManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooks = new ManageBooks(employeeName, employeeRole, employeeID);
            manageBooks.Show();
            this.Hide();
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

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pnlDashBoard.BackColor = ColorTranslator.FromHtml("#BDC0FA");

            //gán tên nhân viên vào label Welcome
            lblEmployeeName.Text = employeeName;
        }

        //Xử lí nút Log Out bên Trái, nút logout trên control panel dùng chung event 
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
                // Nếu chọn Có, đóng form Dashboard và mở lại form DangNhap
                this.Hide(); // Ẩn form Dashboard hiện tại
                DangNhap loginForm = new DangNhap(); // Tạo mới form DangNhap
                loginForm.Show(); // Hiển thị form DangNhap
            }
            else
            {
                // Nếu chọn không, MessageBox tự tắt
            }
        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void pnlReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(employeeName, employeeRole, employeeID);
            reports.Show();
            this.Hide();
        }
    }
}
    
