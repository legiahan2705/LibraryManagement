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
        TaiKhoan_TO taikhoan = new TaiKhoan_TO();
        TaiKhoanBL TaiKhoanBL = new TaiKhoanBL();

        public DangNhap()
        {
            InitializeComponent();
        }


        private void btn_DangNhap_Click_1(object sender, EventArgs e)
        {
            taikhoan.MaNV = txt_MaNhanVien.Text;
            taikhoan.MK = txt_MatKhau.Text;
            string getuser = TaiKhoanBL.CheckLogin(taikhoan);

            //trả lại kq nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "required_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "required_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                // Tạo instance của Dashboard form
                Dashboard dashboardForm = new Dashboard();

                // Đóng form DangNhap hiện tại
                this.Hide();

                // Hiển thị form Dashboard
                dashboardForm.Show();
            }

        }

        // Hàm thoát dùng chung để tránh lặp lại
        private bool ConfirmExit()
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?", // Nội dung thông báo
                "Xác nhận thoát",                     // Tiêu đề
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
    }
}