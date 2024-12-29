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
        private BL_GetBooks _blGetBooks;
        private BL_DeleteBooks _blDeleteBooks;
        private BL_AddBooks _blAddBooks;

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
            // Khởi tạo đối tượng BL_GetBooks
            _blDeleteBooks = new BL_DeleteBooks();
            _blGetBooks = new BL_GetBooks();
            _blAddBooks = new BL_AddBooks();

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

            if (e.ColumnIndex == dataGridView1.Columns["Sua"].Index && e.RowIndex >= 0)
            {
                panel1.BackColor = Color.Lavender;
                btnAddBook.BackColor = Color.CornflowerBlue;
                btnAddBook.Text = "Save";
                // Lấy mã sách từ cột MaSach (giữ dưới dạng chuỗi)
                string bookId = dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value.ToString();
                string bookTen = dataGridView1.Rows[e.RowIndex].Cells["TenSach"].Value.ToString();
                string bookMaTL = dataGridView1.Rows[e.RowIndex].Cells["MaTL"].Value.ToString();
                string bookSL = dataGridView1.Rows[e.RowIndex].Cells["SL"].Value.ToString();
                string bookNXB = dataGridView1.Rows[e.RowIndex].Cells["NXB"].Value.ToString();
                string bookNgayNhap = dataGridView1.Rows[e.RowIndex].Cells["NgayNhap"].Value.ToString();

                txtMaSach.Text = bookId;
                txtTenSach.Text = bookTen;
                txtMaTL.Text = bookMaTL;
                txtSL.Text = bookSL;
                txtNXB.Text = bookNXB;
                txtNgayNhap.Text = bookNgayNhap;

                // Đặt txtMaNV thành chỉ đọc
                txtMaSach.ReadOnly = true;
                txtMaSach.Enabled = false;   // k cho nhấn đâu


            }
            else
            {
               

                txtMaSach.Clear();
                txtTenSach.Clear();
                txtMaTL.Clear();
                txtSL.Clear();
                txtNXB.Clear();
                txtNgayNhap.Clear();


                txtMaSach.ReadOnly = false;
                txtMaSach.Enabled = true;

                btnAddBook.BackColor = Color.DarkSlateBlue;
                btnAddBook.Text = "Add Book";
            }
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (btnAddBook.Text == "Add Book")
            {
                // Kiểm tra các TextBox có dữ liệu đầy đủ hay không
                if (string.IsNullOrEmpty(txtMaSach.Text) ||
                    string.IsNullOrEmpty(txtTenSach.Text) || string.IsNullOrEmpty(txtMaTL.Text) ||
                    string.IsNullOrEmpty(txtSL.Text) || string.IsNullOrEmpty(txtNXB.Text) || 
                    string.IsNullOrEmpty(txtNgayNhap.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Nếu thiếu thông tin thì hiển thị thông báo
                }

                // Kiểm tra xem ngày nhập có hợp lệ không
                DateTime ngayNhap;
                if (!DateTime.TryParse(txtNgayNhap.Text, out ngayNhap))
                {
                    MessageBox.Show("Invalid date format. Please enter the date in YYYY-MM-DD format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Nếu ngày sinh không hợp lệ thì thông báo
                }

                // Hiển thị hộp thoại xác nhận việc thêm sách
                DialogResult dialogResult = MessageBox.Show(
                    "Are you sure you want to add this book?",
                    "Confirm Add",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn Yes, tiến hành thêm book
                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo đối tượng sách và gán các giá trị từ TextBox
                    Sach_TO newBook = new Sach_TO
                    {
                        MaSach = txtMaSach.Text,
                        TenSach = txtTenSach.Text,
                        MaTL = txtMaTL.Text,
                        NXB = txtNXB.Text,
                        SL = int.Parse(txtSL.Text),
                        NgayNhap = ngayNhap.ToString("yyyy-MM-dd"), // Cần phải kiểm tra xem định dạng ngày có hợp lệ không
                    };

                    // Gọi phương thức thêm book
                    bool isAdded = _blAddBooks.AddBooks(newBook);

                    // Thông báo kết quả thêm book
                    if (isAdded)
                    {
                        MessageBox.Show("Book added successfully!", "Success");
                        // Có thể làm sạch các TextBox sau khi thêm
                        txtMaSach.Clear();
                        txtTenSach.Clear();
                        txtMaTL.Clear();
                        txtSL.Clear();
                        txtNXB.Clear();
                        txtNgayNhap.Clear();

                        // Thêm sách mới vào DataGridView ngay lập tức
                        dataGridView1.Rows.Add(
                            newBook.MaSach,
                            newBook.TenSach,
                            newBook.MaTL,
                            newBook.SL,
                            newBook.NXB,
                            newBook.NgayNhap
                        );
                    }
                    else
                    {
                        MessageBox.Show("Failed to add book.", "Error");
                    }
                }
                else
                {
                    // Nếu chọn No, không làm gì cả, đóng MessageBox
                    return;
                }
            }

            if (btnAddBook.Text == "Save")
            {
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(txtMaSach.Text) ||
                    string.IsNullOrEmpty(txtTenSach.Text) ||
                    string.IsNullOrEmpty(txtMaTL.Text) ||
                    string.IsNullOrEmpty(txtSL.Text) ||
                    string.IsNullOrEmpty(txtNXB.Text) ||
                    string.IsNullOrEmpty(txtNgayNhap.Text))

                {
                    MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime ngayNhap;
                if (!DateTime.TryParse(txtNgayNhap.Text, out ngayNhap))
                {
                    MessageBox.Show("Invalid date format. Please enter the date in YYYY-MM-DD format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị hộp thoại xác nhận
                DialogResult confirmResult = MessageBox.Show(
                    "Are you sure you want to update this book's information?",
                    "Confirm Update",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.OK)
                {
                    // Cập nhật thông tin book
                    Sach_TO updateBook = new Sach_TO
                    {
                        MaSach = txtMaSach.Text,
                        TenSach = txtTenSach.Text, 
                        MaTL = txtMaTL.Text,
                        SL = int.Parse(txtSL.Text),
                        NXB = txtNXB.Text,
                        NgayNhap = ngayNhap.ToString("yyyy-MM-dd"),
                    };

                    // Gọi phương thức cập nhật từ lớp BL
                    bool isUpdated = _blAddBooks.UpdateBook(updateBook);

                    if (isUpdated)
                    {
                        MessageBox.Show("Book updated successfully!", "Success");

                        // Đặt lại giao diện
                        panel1.BackColor = Color.White;
                        txtMaSach.Clear();
                        txtTenSach.Clear();
                        txtMaTL.Clear();
                        txtSL.Clear();
                        txtNXB.Clear();
                        txtNgayNhap.Clear();


                        // Đặt txtMaSach thành chỉ đọc
                        txtMaSach.ReadOnly = false;
                        txtMaSach.Enabled = true;   // Cho phép nhấp chuột

                        btnAddBook.BackColor = Color.DarkSlateBlue;
                        btnAddBook.Text = "Add Book";

                        // Cập nhật lại hàng trong DataGridView
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MaSach"].Value.ToString() == updateBook.MaSach)
                            {
                                row.SetValues(
                                    updateBook.MaSach,
                                    updateBook.TenSach,
                                    updateBook.MaTL,
                                    updateBook.SL,
                                    updateBook.NXB,
                                    updateBook.NgayNhap

                                );
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

}
