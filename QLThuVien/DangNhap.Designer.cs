namespace QLThuVien
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            txt_MatKhau = new TextBox();
            txt_MaNhanVien = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_DangNhap = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(415, 234);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(229, 27);
            txt_MatKhau.TabIndex = 8;
            // 
            // txt_MaNhanVien
            // 
            txt_MaNhanVien.Location = new Point(415, 165);
            txt_MaNhanVien.Name = "txt_MaNhanVien";
            txt_MaNhanVien.Size = new Size(229, 27);
            txt_MaNhanVien.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(415, 208);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 6;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(415, 139);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 5;
            label1.Text = "Mã Nhân Viên";
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.DarkSlateBlue;
            btn_DangNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_DangNhap.ForeColor = Color.White;
            btn_DangNhap.Location = new Point(415, 280);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(111, 36);
            btn_DangNhap.TabIndex = 9;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click_1;
            // 
            // btn_Thoat
            // 
            btn_Thoat.BackColor = Color.DarkSlateBlue;
            btn_Thoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Thoat.ForeColor = Color.Snow;
            btn_Thoat.Location = new Point(533, 280);
            btn_Thoat.Margin = new Padding(0);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(111, 36);
            btn_Thoat.TabIndex = 10;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = false;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(748, 422);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_MaNhanVien);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_MatKhau;
        private TextBox txt_MaNhanVien;
        private Label label2;
        private Label label1;
        private Button btn_DangNhap;
        private Button btn_Thoat;
    }
}