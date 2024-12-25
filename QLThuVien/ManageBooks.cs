using Microsoft.Data.SqlClient;
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
using BL;
using DL;

namespace QLThuVien
{
    public partial class ManageBooks : Form
    {
        private BL_GetEmployees _blEmployees;
        private BL_DeleteEmployee _blDeleteEmployee;
        private BL_AddEmployee _blAddEmployee;
        private BL_GetBooks _blBooks;
        private BL_DeleteBooks _blDeleteBooks;

        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên
        private string employeeID; // Lưu ID nhân viên
        public ManageBooks()
        {
            InitializeComponent();
        }

        public ManageBooks(string employeeName, string employeeRole, string id)
        {
            InitializeComponent();
            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();
            _blBooks = new BL_GetBooks();

            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.employeeID = id;
        }

        // Chuyển qua các Form
        private void pnlBorrowReturn_Click(object sender, EventArgs e)
        {
            BorrowReturn borrowReturn = new BorrowReturn(employeeName, employeeRole, employeeID);
            borrowReturn.Show();
            this.Hide();
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

        private void ManageBooks_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            pnlBookCase.Visible = false;
            pnlManageBooks.BackColor = ColorTranslator.FromHtml("#BDC0FA");
            //gán tên nhân viên vào label Welcome
            lblEmployeeName.Text = employeeName;

            try
            {
                // Lấy danh sách nhân viên từ Business Logic Layer (BL)
                List<Sach_TO> books = new DL_GetBooks().GetBooks();

                // Kiểm tra danh sách nhân viên
                if (books != null && books.Count > 0)
                {
                    // Làm sạch DataGridView
                    dataGridView1.Rows.Clear();

                    dataGridView1.DataSource = null;

                    // Ánh xạ dữ liệu lên DataGridView
                    foreach (Sach_TO book in books)
                    {
                        dataGridView1.Rows.Add(
                            book.MaSach,
                            book.TenSach,
                            book.MaTL,
                            book.SL,
                            book.NXB,
                            book.NgayNhap
                        );
                    }
                }
                else
                {
                    MessageBox.Show("There are no books in the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Nếu chọn Có, đóng form ManageBook và mở lại form DangNhap
                this.Hide(); // Ẩn form ManageBook hiện tại
                DangNhap loginForm = new DangNhap(); // Tạo mới form DangNhap
                loginForm.Show(); // Hiển thị form DangNhap
            }
            else
            {
                // Nếu chọn không, MessageBox tự tắt
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                // Lấy mã nhân viên từ cột MaNV (giữ dưới dạng chuỗi)
                string bookID = dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to delete the book with Book ID = {bookID}?",
                    "Delete Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // Nếu người dùng chọn OK, tiến hành xóa
                if (dialogResult == DialogResult.OK)
                {

                    bool isDeleted = new BL.BL_DeleteBooks().DeleteBooks(bookID);
                    if (isDeleted)
                    {
                        // Xóa dòng khỏi DataGridView
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Book deleted successfully!", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete book!", "Notification");
                    }
                }
            }

            //if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    panel1.BackColor = Color.Lavender;
            //    btnAddEmployee.BackColor = Color.CornflowerBlue;
            //    btnAddEmployee.Text = "Save";
            //    // Lấy mã nhân viên từ cột MaNV (giữ dưới dạng chuỗi)
            //    string employeeId = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            //    string employeeTen = dataGridView1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
            //    string employeeGioiTinh = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            //    string employeeSDT = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
            //    string employeeNgaySinh = dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
            //    string employeeDiaChi = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            //    string employeeEmail = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            //    string employeePhanQuyen = dataGridView1.Rows[e.RowIndex].Cells["PhanQuyen"].Value.ToString();

            //    txtMaNV.Text = employeeId;
            //    txtTen.Text = employeeTen;
            //    txtGioiTinh.Text = employeeGioiTinh;
            //    txtSDT.Text = employeeSDT;
            //    txtNgaySinh.Text = employeeNgaySinh;
            //    txtDiaChi.Text = employeeDiaChi;
            //    txtEmail.Text = employeeEmail;
            //    txtPhanQuyen.Text = employeePhanQuyen;

            //    // Đặt txtMaNV thành chỉ đọc
            //    txtMaNV.ReadOnly = true;
            //    txtMaNV.Enabled = false;   // k cho nhấn đâu


            //}
            //else
            //{
            //    panel1.BackColor = Color.GhostWhite;

            //    txtMaNV.Clear();
            //    txtTen.Clear();
            //    txtGioiTinh.Clear();
            //    txtSDT.Clear();
            //    txtNgaySinh.Clear();
            //    txtDiaChi.Clear();
            //    txtEmail.Clear();
            //    txtPhanQuyen.Clear();


            //    txtMaNV.ReadOnly = false;
            //    txtMaNV.Enabled = true;

            //    btnAddEmployee.BackColor = Color.DarkSlateBlue;
            //    btnAddEmployee.Text = "Add Employee";
            //}
        }

        private void pnlBookCaseBTN_Click(object sender, EventArgs e)
        {
            pnlBookCase.Visible = true;

            try
            {
                // Lấy danh sách nhân viên từ Business Logic Layer (BL)
                List<Sach_TO> books = new DL_GetBooks().GetBooks();

                // Kiểm tra danh sách reader
                if (books != null && books.Count > 0)
                {
                    // Làm sạch DataGridView
                    dataGridView1.Rows.Clear();

                    dataGridView1.DataSource = null;

                    // Ánh xạ dữ liệu lên DataGridView
                    foreach (Sach_TO book in books)
                    {
                        dataGridView1.Rows.Add(
                            book.MaSach,
                            book.TenSach,
                            book.MaTL,
                            book.SL,
                            book.NXB,
                            book.NgayNhap
                        );
                    }

                    // Hiển thị GroupBox
                    pnlBookCase.Visible = true;
                }
                else
                {
                    MessageBox.Show("There are no books in the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }

}
