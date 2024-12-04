using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        //Dùng biến cờ theo dõi, tránh hiển thị messagebox nhiều lần, Dùng Environment.Exit để thoát toàn bộ ứng dụng, đảm bảo không lặp lại MessageBox
        private bool isExiting = false;
        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            // Thay đổi màu nền khi chuột hover
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.LightBlue; // Đổi màu sang LightBlue
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền gốc
            Panel panel = sender as Panel;
            if (panel != null)
            {
                panel.BackColor = Color.White; // Đổi lại màu nền ban đầu
            }
        }
    }
}
