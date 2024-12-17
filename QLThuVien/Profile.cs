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
        private string employeeID;  // ID của nhân viên
        private string employeeName;
        private BL_InformationEmployee _bl_informationEmployee;

        public Profile()
        {
            InitializeComponent();
        }

        //lưu tên NV được truyền từ form Đăng Nhập
        public Profile(string id, string name)
        {
            InitializeComponent();
            //tên welcome
            this.employeeName = name;

            // Gán giá trị cho các thuộc tính
            this.employeeID = id;

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

        // Hàm đăng ký các sự kiện cần thiết (MouseEnter, MouseLeave)
        private void RegisterEvents(Panel panel)
        {
            // Đăng ký sự kiện hover (MouseEnter và MouseLeave) cho chính Panel
            panel.MouseEnter += HoverEffect_MouseEnter;
            panel.MouseLeave += HoverEffect_MouseLeave;

            // Đăng ký sự kiện hover cho từng điều khiển con bên trong Panel
            foreach (Control control in panel.Controls)
            {
                control.MouseEnter += HoverEffect_MouseEnter;
                control.MouseLeave += HoverEffect_MouseLeave;
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
            // Đăng ký sự kiện cho các Panel trong Profile
            RegisterEvents(pnlDashBoard);
            RegisterEvents(pnlProfile);
            RegisterEvents(pnlManageUsers);
            RegisterEvents(pnlManageBooks);
            RegisterEvents(pnlBorrowReturn);
            RegisterEvents(pnlReports);
            RegisterEvents(pnlLogOut);

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

        private void pnlManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooks manageBooks = new ManageBooks();
            manageBooks.Show();
            this.Hide();
        }

        private void pnlDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
