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

namespace QLThuVien
{
    public partial class DangNhap : Form
    {
        // đối tượng lưu trữ thông tin tài khoản gồm MaNV và MK
        TaiKhoan_TO taikhoan = new TaiKhoan_TO();
        BL_AccountAccess TaiKhoanBL = new BL_AccountAccess();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các ô nhập liệu
            string maNV = txt_MaNhanVien.Text;
            string mk = txt_MatKhau.Text;

            // Kiểm tra các ô có bị để trống không
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Employee ID cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MaNhanVien.Focus();
                return;
            }

            if (string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_MatKhau.Focus();
                return;
            }

            // Tạo đối tượng TaiKhoan_TO
            TaiKhoan_TO taiKhoan = new TaiKhoan_TO
            {
                MaNV = maNV,
                MK = mk
            };

            // Gọi tầng BL để kiểm tra đăng nhập
            BL_AccountAccess blAccount = new BL_AccountAccess();
            string employeeName, employeeRole;
            string result = blAccount.Login(taiKhoan, out employeeName, out employeeRole);

            // Hiển thị thông báo dựa trên kết quả
            if (result == "Login successful") // Nếu đăng nhập thành công
            {
                DialogResult dialogResult = MessageBox.Show(
                $"Login successful with role: {employeeRole}", // Thông báo bao gồm vai trò
                "Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    // Tạo form Dashboard và truyền tên, quyền nhân viên vào
                    Dashboard dashboardForm = new Dashboard(employeeName, employeeRole, maNV);

                    // Đóng form DangNhap hiện tại
                    this.Hide();

                    // Hiển thị form Dashboard
                    dashboardForm.Show();
                }
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        // Hàm thoát dùng chung để tránh lặp lại
        private bool ConfirmExit()
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?", // Nội dung thông báo
                "Exit Confirmation",                     // Tiêu đề
                MessageBoxButtons.YesNo,              // Các nút lựa chọn
                MessageBoxIcon.Question               // Biểu tượng
            );

            // Trả về true nếu người dùng chọn Yes
            return result == DialogResult.Yes;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (ConfirmExit()) // Gọi hàm xác nhận thoát
            {
                Environment.Exit(0); // Thoát ứng dụng ngay lập tức
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private bool isExiting = false;
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExiting && !ConfirmExit()) // Nếu chưa xác nhận thoát hoặc chọn Không
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
            else
            {
                isExiting = true; // Đánh dấu đã xác nhận thoát
                Environment.Exit(0); // Thoát ứng dụng
            }
        }

        private void DangNhap_Load_1(object sender, EventArgs e)
        {
            txt_MaNhanVien.Text = "NV100005";
            txt_MatKhau.Text = "12345";
        }
    }
}