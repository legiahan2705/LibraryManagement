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
            MessageBox.Show("Đăng nhập thành công");

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
