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
using BL;
using TO;
using DL;
using Microsoft.Data.SqlClient;

namespace QLThuVien
{
    public partial class BorrowReturn : Form
    {
        private BL_GetReaders _blReaders;
        private BL_DeleteReader _blDeleteReader;
        private BL_AddReader _blAddReader;


        private BL_GetEmployees _blEmployees;
        private string employeeName; // Lưu tên nhân viên
        private string employeeRole; // Lưu quyền của nhân viên
        private string employeeID; // Lưu ID nhân viên

        public BorrowReturn(string employeeName, string employeeRole, string id)
        {
            InitializeComponent();

            this.employeeName = employeeName;
            this.employeeRole = employeeRole;
            this.employeeID = id;

            _blDeleteReader = new BL_DeleteReader();

            // Khởi tạo đối tượng BL_GetEmployees
            _blEmployees = new BL_GetEmployees();

            _blAddReader = new BL_AddReader();
        }

        // Chuyển qua các Form
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

        private void BorrowReturn_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BorrowReturn_Load(object sender, EventArgs e)
        {
            pnlBorrowReturn.BackColor = ColorTranslator.FromHtml("#BDC0FA");

            //gán tên nhân viên vào label Welcome
            lblEmployeeName.Text = employeeName;

            // Hiển thị GroupBox
            pnlReader.Visible = false;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Lấy mã nhân viên từ cột MaNV (giữ dưới dạng chuỗi)
                string MaDG = dataGridView1.Rows[e.RowIndex].Cells["MaDG"].Value.ToString();

                // Hiển thị hộp thoại xác nhận
                DialogResult dialogResult = MessageBox.Show(
                    $"Are you sure you want to delete the reader with Reader ID = {MaDG}?",
                    "Delete Confirmation",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                // Nếu người dùng chọn OK, tiến hành xóa
                if (dialogResult == DialogResult.OK)
                {
                    bool isDeleted = _blDeleteReader.DeleteReader(MaDG); // Truyền vào chuỗi
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
                btnAddReader.BackColor = Color.CornflowerBlue;
                btnAddReader.Text = "Save";
                // Lấy mã nhân viên từ cột MaDG (giữ dưới dạng chuỗi)
                string readerId = dataGridView1.Rows[e.RowIndex].Cells["MaDG"].Value.ToString();
                string readerTen = dataGridView1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                string readerGioiTinh = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                string readerSDT = dataGridView1.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                string readerNgaySinh = dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value.ToString();
                string readerDiaChi = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();


                txtMaDG.Text = readerId;
                txtTen.Text = readerTen;
                txtGioiTinh.Text = readerGioiTinh;
                txtSDT.Text = readerSDT;
                txtNgaySinh.Text = readerNgaySinh;
                txtDiaChi.Text = readerDiaChi;

                // Đặt txtMaDG thành chỉ đọc
                txtMaDG.ReadOnly = true;
                txtMaDG.Enabled = false;   // Cho phép nhấp chuột


            }
            else
            {
                panel1.BackColor = Color.White;

                txtMaDG.Clear();
                txtTen.Clear();
                txtGioiTinh.Clear();
                txtSDT.Clear();
                txtNgaySinh.Clear();
                txtDiaChi.Clear();



                txtMaDG.ReadOnly = false;
                txtMaDG.Enabled = true;

                btnAddReader.BackColor = Color.DarkSlateBlue;
                btnAddReader.Text = "Add Reader";
            }
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            if (btnAddReader.Text == "Add Reader")
            {
                // Kiểm tra các TextBox có dữ liệu đầy đủ hay không
                if (string.IsNullOrEmpty(txtMaDG.Text) ||
                    string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtGioiTinh.Text) ||
                    string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtNgaySinh.Text))

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
                    "Are you sure you want to add this reader?",
                    "Confirm Add",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // Nếu người dùng chọn Yes, tiến hành thêm reader
                if (dialogResult == DialogResult.Yes)
                {
                    // Tạo đối tượng nhân viên và gán các giá trị từ TextBox
                    DocGia_TO newReader = new DocGia_TO
                    {
                        MaDG = txtMaDG.Text,
                        Ten = txtTen.Text,
                        GioiTinh = txtGioiTinh.Text,
                        SDT = txtSDT.Text,
                        NgaySinh = ngaySinh.ToString("yyyy-MM-dd"), // Cần phải kiểm tra xem định dạng ngày có hợp lệ không
                        DiaChi = txtDiaChi.Text

                    };

                    // Gọi phương thức thêm reader
                    bool isAdded = _blAddReader.AddReader(newReader);

                    // Thông báo kết quả thêm READER
                    if (isAdded)
                    {
                        MessageBox.Show("Reader added successfully!", "Success");
                        // Có thể làm sạch các TextBox sau khi thêm
                        txtMaDG.Clear();
                        txtTen.Clear();
                        txtGioiTinh.Clear();
                        txtSDT.Clear();
                        txtNgaySinh.Clear();
                        txtDiaChi.Clear();


                        // Thêm nhân viên mới vào DataGridView ngay lập tức
                        dataGridView1.Rows.Add(
                            newReader.MaDG,
                            newReader.Ten,
                            newReader.GioiTinh,
                            newReader.SDT,
                            newReader.NgaySinh,
                            newReader.DiaChi

                        );
                    }
                    else
                    {
                        MessageBox.Show("Failed to add reader.", "Error");
                    }
                }
                else
                {
                    // Nếu chọn No, không làm gì cả, đóng MessageBox
                    return;
                }
            }

            if (btnAddReader.Text == "Save")
            {
                // Kiểm tra dữ liệu hợp lệ
                if (string.IsNullOrEmpty(txtMaDG.Text) ||
                    string.IsNullOrEmpty(txtTen.Text) ||
                    string.IsNullOrEmpty(txtGioiTinh.Text) ||
                    string.IsNullOrEmpty(txtSDT.Text) ||
                    string.IsNullOrEmpty(txtNgaySinh.Text) ||
                    string.IsNullOrEmpty(txtDiaChi.Text))

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
                    "Are you sure you want to update this reader's information?",
                    "Confirm Update",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (confirmResult == DialogResult.OK)
                {
                    // Cập nhật thông tin reader
                    DocGia_TO updatedReader = new DocGia_TO
                    {
                        MaDG = txtMaDG.Text,
                        Ten = txtTen.Text,
                        GioiTinh = txtGioiTinh.Text,
                        SDT = txtSDT.Text,
                        NgaySinh = ngaySinh.ToString("yyyy-MM-dd"),
                        DiaChi = txtDiaChi.Text
                    };

                    // Gọi phương thức cập nhật từ lớp BL
                    bool isUpdated = _blAddReader.UpdateReader(updatedReader);

                    if (isUpdated)
                    {
                        MessageBox.Show("Reader updated successfully!", "Success");

                        // Đặt lại giao diện
                        panel1.BackColor = Color.White;
                        txtMaDG.Clear();
                        txtTen.Clear();
                        txtGioiTinh.Clear();
                        txtSDT.Clear();
                        txtNgaySinh.Clear();
                        txtDiaChi.Clear();


                        // Đặt txtMaNV thành chỉ đọc
                        txtMaDG.ReadOnly = false;
                        txtMaDG.Enabled = true;   // Cho phép nhấp chuột

                        btnAddReader.BackColor = Color.DarkSlateBlue;
                        btnAddReader.Text = "Add Reader";

                        // Cập nhật lại hàng trong DataGridView
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["MaDG"].Value.ToString() == updatedReader.MaDG)
                            {
                                row.SetValues(
                                    updatedReader.MaDG,
                                    updatedReader.Ten,
                                    updatedReader.GioiTinh,
                                    updatedReader.SDT,
                                    updatedReader.NgaySinh,
                                    updatedReader.DiaChi

                                );
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to update reader.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pnlReaderBTN_Click(object sender, EventArgs e)
        {
            pnlReader.Visible = true;

            try
            {
                // Lấy danh sách nhân viên từ Business Logic Layer (BL)
                List<DocGia_TO> readers = new DL_GetReaders().GetReaders();

                // Kiểm tra danh sách reader
                if (readers != null && readers.Count > 0)
                {
                    // Làm sạch DataGridView
                    dataGridView1.Rows.Clear();

                    dataGridView1.DataSource = null;

                    // Ánh xạ dữ liệu lên DataGridView
                    foreach (DocGia_TO reader in readers)
                    {
                        dataGridView1.Rows.Add(
                            reader.MaDG,
                            reader.Ten,
                            reader.GioiTinh,
                            reader.SDT,
                            reader.NgaySinh,
                            reader.DiaChi


                        );
                    }

                    // Hiển thị GroupBox
                    pnlReader.Visible = true;
                }
                else
                {
                    MessageBox.Show("There are no readers in the database.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pnlAddBorrowSlipsBTN_Click(object sender, EventArgs e)
        {
            AddBorrow brr = new AddBorrow();
            brr.Show();
        }
    }
}
