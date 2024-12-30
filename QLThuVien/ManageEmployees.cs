using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BL;
using DL;
using Microsoft.Data.SqlClient;
using TO;


namespace QLThuVien
{
    public partial class ManageEmployees : Form
    {
        private BL_GetEmployees _blEmployees;
        private BL_DeleteEmployee _blDeleteEmployee;
        private BL_AddEmployee _blAddEmployee;

        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên
        private string employeeID; // Lưu ID nhân viên
        public ManageEmployees(string employeeName, string employeeRole, string id)
        {
            InitializeComponent();

            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.employeeID = id;

            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();
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

        private void ManageEmployees_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            pnlManageEmployees.BackColor = ColorTranslator.FromHtml("#BDC0FA");

            //gán tên nhân viên vào label Welcome
            lblEmployeeName.Text = employeeName;

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

            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                panel1.BackColor = Color.Lavender;
                btnAddEmployee.BackColor = Color.CornflowerBlue;
                btnAddEmployee.Text = "Save";
                // Lấy mã nhân viên từ cột MaNV (giữ dưới dạng chuỗi)
                string employeeId = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                string employeeTen = dataGridView1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                string employeeGioiTinh = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                string employeeSDT = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                string employeeNgaySinh = dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                string employeeDiaChi = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                string employeeEmail = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                string employeePhanQuyen = dataGridView1.Rows[e.RowIndex].Cells["PhanQuyen"].Value.ToString();

                txtMaNV.Text = employeeId;
                txtTen.Text = employeeTen;
                txtGioiTinh.Text = employeeGioiTinh;
                txtSDT.Text = employeeSDT;
                txtNgaySinh.Text = employeeNgaySinh;
                txtDiaChi.Text = employeeDiaChi;
                txtEmail.Text = employeeEmail;
                txtPhanQuyen.Text = employeePhanQuyen;

                // Đặt txtMaNV thành chỉ đọc
                txtMaNV.ReadOnly = true;
                txtMaNV.Enabled = false;   // k cho nhấn đâu


            }
            else
            {

                panel1.BackColor = Color.White;
                txtMaNV.Clear();
                txtTen.Clear();
                txtGioiTinh.Clear();
                txtSDT.Clear();
                txtNgaySinh.Clear();
                txtDiaChi.Clear();
                txtEmail.Clear();
                txtPhanQuyen.Clear();


                txtMaNV.ReadOnly = false;
                txtMaNV.Enabled = true;

                btnAddEmployee.BackColor = Color.DarkSlateBlue;
                btnAddEmployee.Text = "Add Employee";
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            if (btnAddEmployee.Text == "Add Employee")
            {
                // Kiểm tra các TextBox có dữ liệu đầy đủ hay không
                if (string.IsNullOrEmpty(txtMaNV.Text) ||
                    string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) ||
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
                        MaNV = txtMaNV.Text,
                        Ten = txtTen.Text,
                        GioiTinh = txtGioiTinh.Text,
                        SDT = txtSDT.Text,
                        NgaySinh = ngaySinh.ToString("yyyy-MM-dd"), // Cần phải kiểm tra xem định dạng ngày có hợp lệ không
                        DiaChi = txtDiaChi.Text,
                        Email = txtEmail.Text,
                        PhanQuyen = txtPhanQuyen.Text
                    };

                    // Gọi phương thức thêm nhân viên 
                    bool isAdded = _blAddEmployee.AddEmployee(newEmployee);

                    // Thông báo kết quả thêm nhân viên
                    if (isAdded)
                    {
                        MessageBox.Show("Employee added successfully!", "Success");
                        // Có thể làm sạch các TextBox sau khi thêm
                        txtMaNV.Clear();
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

            if (btnAddEmployee.Text == "Save")
            {
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(txtMaNV.Text) ||
                    string.IsNullOrEmpty(txtTen.Text) ||
                    string.IsNullOrEmpty(txtGioiTinh.Text) ||
                    string.IsNullOrEmpty(txtSDT.Text) ||
                    string.IsNullOrEmpty(txtNgaySinh.Text) ||
                    string.IsNullOrEmpty(txtPhanQuyen.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngaySinh;
                if (!DateTime.TryParse(txtNgaySinh.Text, out ngaySinh))
                {
                    MessageBox.Show("Invalid date format. Please enter the date in YYYY-MM-DD format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to update this employee's information?",
                    "Confirm Update",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.OK)
                {
                    // Cập nhật thông tin nhân viên
                    NhanVien_TO updatedEmployee = new NhanVien_TO
                    {
                        MaNV = txtMaNV.Text,
                        Ten = txtTen.Text,
                        GioiTinh = txtGioiTinh.Text,
                        SDT = txtSDT.Text,
                        NgaySinh = ngaySinh.ToString("yyyy-MM-dd"),
                        DiaChi = txtDiaChi.Text,
                        Email = txtEmail.Text,
                        PhanQuyen = txtPhanQuyen.Text
                    };

                    // Gọi phương thức cập nhật từ lớp BL
                    bool isUpdated = _blAddEmployee.UpdateEmployee(updatedEmployee);

                    if (isUpdated)
                    {
                        MessageBox.Show("Employee updated successfully!", "Success");

                        // Đặt lại giao diện

                        txtMaNV.Clear();
                        txtTen.Clear();
                        txtGioiTinh.Clear();
                        txtSDT.Clear();
                        txtNgaySinh.Clear();
                        txtDiaChi.Clear();
                        txtEmail.Clear();
                        txtPhanQuyen.Clear();

                        // Đặt txtMaNV thành chỉ đọc
                        txtMaNV.ReadOnly = false;
                        txtMaNV.Enabled = true;   // Cho phép nhấp chuột

                        btnAddEmployee.BackColor = Color.DarkSlateBlue;
                        btnAddEmployee.Text = "Add Employee";

                        // Cập nhật lại hàng trong DataGridView
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MaNV"].Value.ToString() == updatedEmployee.MaNV)
                            {
                                row.SetValues(
                                    updatedEmployee.MaNV,
                                    updatedEmployee.Ten,
                                    updatedEmployee.GioiTinh,
                                    updatedEmployee.SDT,
                                    updatedEmployee.NgaySinh,
                                    updatedEmployee.DiaChi,
                                    updatedEmployee.Email,
                                    updatedEmployee.PhanQuyen
                                );
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to update employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


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

        private void pnlDashBoard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(employeeName, employeeRole, employeeID);
            dashboard.Show();
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
            ManageBooks managebooks = new ManageBooks(employeeName, employeeRole, employeeID);
            managebooks.Show();
            this.Hide();
        }

        private void pnlBorrowReturn_Click(object sender, EventArgs e)
        {
            BorrowReturn borrowReturn = new BorrowReturn(employeeName, employeeRole, employeeID);
            borrowReturn.Show();
            this.Hide();
        }

        private void pnlReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(employeeName, employeeRole, employeeID);
            reports.Show();
            this.Hide();
        }
    }
}
