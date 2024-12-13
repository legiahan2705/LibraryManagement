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
using DL;
using Microsoft.Data.SqlClient;
using TO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLThuVien
{
    public partial class Dashboard : Form
    {
        private BL_GetEmployees _blEmployees;
        private BL_DeleteEmployee _blDeleteEmployee;
        private BL_AddEmployee _blAddEmployee;
        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên

        public Dashboard(string employeeName, string employeeRole)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            this.employeeRole = employeeRole;

            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();

            // Ẩn panel Manage Users ban đầu
            grBoxManageEmployees.Visible = false;

            _blDeleteEmployee = new BL_DeleteEmployee();

            _blAddEmployee = new BL_AddEmployee();


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
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Đăng ký sự kiện cho các Panel trong Dashboard
            RegisterEvents(pnlDashBoard);
            RegisterEvents(pnlProfile);
            RegisterEvents(pnlManageUsers);
            RegisterEvents(pnlManageBooks);
            RegisterEvents(pnlBorrowReturn);
            RegisterEvents(pnlReports);
            RegisterEvents(pnlLogOut);

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

        private void pnlManageUsers_Click(object sender, EventArgs e)
        {
            //Kiểm tra vai trò trước\
            string role = "Quản lý";
            if (!string.Equals(this.employeeRole, role, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only managers are allowed to access this function.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Thoát khỏi sự kiện nếu không phải quản lý
            }

            try
            {
                // Lấy danh sách nhân viên từ Business Logic Layer (BL)
                List<NhanVien_TO> employees = new DL_GetEmployees().GetEmployees();

                // Kiểm tra danh sách nhân viên
                if (employees != null && employees.Count > 0)
                {
                    // Làm sạch DataGridView
                    dataGridView1.Rows.Clear();

                    dataGridView1.DataSource = null;

                    // Ánh xạ dữ liệu lên DataGridView
                    foreach (NhanVien_TO employee in employees)
                    {
                        dataGridView1.Rows.Add(
                            employee.MaNV,
                            employee.Ten,
                            employee.GioiTinh,
                            employee.SDT,
                            employee.NgaySinh,
                            employee.DiaChi,
                            employee.Email,
                            employee.PhanQuyen
                        );
                    }

                    // Hiển thị GroupBox
                    grBoxManageEmployees.Visible = true;
                }
                else
                {
                    MessageBox.Show("There are no employees in the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                // Lỗi cơ sở dữ liệu
                MessageBox.Show($"Database connection error: {sqlEx.Message}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Các lỗi khác
                MessageBox.Show($"Error: {ex.Message}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlDashBoard_Click(object sender, EventArgs e)
        {
            grBoxManageEmployees.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Lấy mã nhân viên từ cột MaNV (giữ dưới dạng chuỗi)
                string employeeId = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to delete the employee with Employee ID = {employeeId}?",
                    "Delete Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // Nếu người dùng chọn OK, tiến hành xóa
                if (dialogResult == DialogResult.OK)
                {
                    bool isDeleted = _blDeleteEmployee.DeleteEmployee(employeeId); // Truyền vào chuỗi
                    if (isDeleted)
                    {
                        // Xóa dòng khỏi DataGridView
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Employee deleted successfully!", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete employee!", "Notification");
                    }
                }
            }
        }

        //nút Add Employee
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Kiểm tra các TextBox có dữ liệu đầy đủ hay không
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) ||
                string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtNgaySinh.Text) ||
                string.IsNullOrEmpty(txtPhanQuyen.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Nếu thiếu thông tin thì hiển thị thông báo
            }

            // Kiểm tra xem ngày sinh có hợp lệ không
            DateTime ngaySinh;
            if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Invalid date format. Please enter the date in YYYY-MM-DD format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Nếu ngày sinh không hợp lệ thì thông báo
            }

            // Hiển thị hộp thoại xác nhận việc thêm nhân viên
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to add this employee?",
                "Confirm Add",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu người dùng chọn Yes, tiến hành thêm nhân viên
            if (dialogResult == DialogResult.Yes)
            {
                // Tạo đối tượng nhân viên và gán các giá trị từ TextBox
                NhanVien_TO newEmployee = new NhanVien_TO
                {
                    Ten = txtTen.Text,
                    GioiTinh = txtGioiTinh.Text,
                    SDT = txtSDT.Text,
                    NgaySinh = ngaySinh.ToString("yyyy-MM-dd"), // Cần phải kiểm tra xem định dạng ngày có hợp lệ không
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,
                    PhanQuyen = txtPhanQuyen.Text
                };

                // Gọi phương thức thêm nhân viên (có thể là trong lớp BL hoặc DL)
                bool isAdded = _blAddEmployee.AddEmployee(newEmployee);

                // Thông báo kết quả thêm nhân viên
                if (isAdded)
                {
                    MessageBox.Show("Employee added successfully!", "Success");
                    // Có thể làm sạch các TextBox sau khi thêm
                    txtTen.Clear();
                    txtGioiTinh.Clear();
                    txtSDT.Clear();
                    txtNgaySinh.Clear();
                    txtDiaChi.Clear();
                    txtEmail.Clear();
                    txtPhanQuyen.Clear();

                    // Thêm nhân viên mới vào DataGridView ngay lập tức
                    dataGridView1.Rows.Add(
                        newEmployee.MaNV,
                        newEmployee.Ten,
                        newEmployee.GioiTinh,
                        newEmployee.SDT,
                        newEmployee.NgaySinh,
                        newEmployee.DiaChi,
                        newEmployee.Email,
                        newEmployee.PhanQuyen
                    );
                }
                else
                {
                    MessageBox.Show("Failed to add employee.", "Error");
                }
            }
            else
            {
                // Nếu chọn No, không làm gì cả, đóng MessageBox
                return;
            }
        }
    }
}
    
