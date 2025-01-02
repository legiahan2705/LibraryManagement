using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL;
using BL;
using System.Data.SqlClient;

namespace QLThuVien
{
    public partial class AddBorrow : Form
    {
        BL_AutoSlipInfo bl_AutoSlipInfo = new BL_AutoSlipInfo();
        Bl_AddPhieu bl_addPhieu = new Bl_AddPhieu();
        public AddBorrow()
        {
            InitializeComponent();
            GenerateMaphieu();
            LoadBookToComboBox();

        }

        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(AddBorrow));
            lbl_title = new Label();
            label1 = new Label();
            txt_MaPhieu = new TextBox();
            txt_MaDocGia = new TextBox();
            label2 = new Label();
            txt_TenDocGia = new TextBox();
            label3 = new Label();
            comboBox_books = new ComboBox();
            bLGetBooksBindingSource = new BindingSource(components);
            txt_BookID = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_SL = new TextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            btn_AddSlip = new Button();
            ((ISupportInitialize)bLGetBooksBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_title.ForeColor = Color.DarkSlateBlue;
            lbl_title.Location = new Point(107, 20);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(232, 38);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Add Borrow Slip";
            lbl_title.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(33, 86);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 1;
            label1.Text = "Mã Phiếu";
            // 
            // txt_MaPhieu
            // 
            txt_MaPhieu.Location = new Point(177, 90);
            txt_MaPhieu.Name = "txt_MaPhieu";
            txt_MaPhieu.ReadOnly = true;
            txt_MaPhieu.Size = new Size(227, 27);
            txt_MaPhieu.TabIndex = 1;
            // 
            // txt_MaDocGia
            // 
            txt_MaDocGia.Location = new Point(177, 138);
            txt_MaDocGia.Name = "txt_MaDocGia";
            txt_MaDocGia.Size = new Size(227, 27);
            txt_MaDocGia.TabIndex = 2;
            txt_MaDocGia.TextChanged += txt_MaDocGia_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(33, 134);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 3;
            label2.Text = "Mã Độc Giả";
            // 
            // txt_TenDocGia
            // 
            txt_TenDocGia.Location = new Point(177, 186);
            txt_TenDocGia.Name = "txt_TenDocGia";
            txt_TenDocGia.ReadOnly = true;
            txt_TenDocGia.Size = new Size(227, 27);
            txt_TenDocGia.TabIndex = 3;
            txt_TenDocGia.TextChanged += txt_TenDocGia_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(33, 182);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 5;
            label3.Text = "Tên Độc Giả";
            // 
            // comboBox_books
            // 
            comboBox_books.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_books.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox_books.Cursor = Cursors.Hand;
            comboBox_books.FormattingEnabled = true;
            comboBox_books.Location = new Point(177, 234);
            comboBox_books.Name = "comboBox_books";
            comboBox_books.Size = new Size(227, 28);
            comboBox_books.TabIndex = 4;
            comboBox_books.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bLGetBooksBindingSource
            // 
            bLGetBooksBindingSource.DataSource = typeof(BL_GetBooks);
            // 
            // txt_BookID
            // 
            txt_BookID.Location = new Point(177, 282);
            txt_BookID.Name = "txt_BookID";
            txt_BookID.ReadOnly = true;
            txt_BookID.Size = new Size(227, 27);
            txt_BookID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(33, 230);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 9;
            label4.Text = "Tên Sách";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(33, 278);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 10;
            label5.Text = "Mã Sách";
            // 
            // txt_SL
            // 
            txt_SL.Location = new Point(177, 330);
            txt_SL.Name = "txt_SL";
            txt_SL.Size = new Size(227, 27);
            txt_SL.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.DarkSlateBlue;
            label6.Location = new Point(33, 326);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 12;
            label6.Text = "Số Lượng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(177, 378);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.DarkSlateBlue;
            label7.Location = new Point(33, 374);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 14;
            label7.Text = "Ngày Mượn";
            // 
            // btn_AddSlip
            // 
            btn_AddSlip.BackColor = Color.Lavender;
            btn_AddSlip.Cursor = Cursors.Hand;
            btn_AddSlip.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_AddSlip.ForeColor = Color.DarkSlateBlue;
            btn_AddSlip.Location = new Point(156, 442);
            btn_AddSlip.Name = "btn_AddSlip";
            btn_AddSlip.Size = new Size(120, 46);
            btn_AddSlip.TabIndex = 15;
            btn_AddSlip.Text = "Add Slip";
            btn_AddSlip.UseVisualStyleBackColor = false;
            btn_AddSlip.Click += btn_AddSlip_Click;
            // 
            // AddBorrow
            // 
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(445, 521);
            Controls.Add(btn_AddSlip);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(txt_SL);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_BookID);
            Controls.Add(comboBox_books);
            Controls.Add(txt_TenDocGia);
            Controls.Add(label3);
            Controls.Add(txt_MaDocGia);
            Controls.Add(label2);
            Controls.Add(txt_MaPhieu);
            Controls.Add(label1);
            Controls.Add(lbl_title);
            Name = "AddBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Borrow Slip";
            Load += AddBorrow_Load;
            ((ISupportInitialize)bLGetBooksBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txt_BookID;
        private Label label4;
        private Label label5;
        private TextBox txt_SL;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button btn_AddSlip;
        private Label lbl_title;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_BookID.Text = bl_AutoSlipInfo.GetBookID(comboBox_books.Text.ToString());
        }

        private void LoadBookToComboBox()
        {
            try
            {
                var booknames = bl_AutoSlipInfo.GetBookNames();
                comboBox_books.Items.Clear();
                comboBox_books.Items.AddRange(booknames.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateMaphieu()
        {
            txt_MaPhieu.Text = bl_AutoSlipInfo.GenerateMaPhieu();
        }

        private Label label1;
        private TextBox txt_MaPhieu;
        private TextBox txt_MaDocGia;
        private Label label2;
        private TextBox txt_TenDocGia;
        private Label label3;
        private ComboBox comboBox_books;
        private BindingSource bLGetBooksBindingSource;
        private IContainer components;

        private void txt_TenDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddSlip_Click(object sender, EventArgs e)
        {
            try
            {
                string maPhieu = txt_MaPhieu.Text.Trim();
                string maDocGia = txt_MaDocGia.Text.Trim();
                DateTime ngayMuon = dateTimePicker1.Value;

                // Kiểm tra ngày hợp lệ
                if (ngayMuon < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày mượn không được nhỏ hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<(string maSach, int soLuong)> chitietPhieu = new List<(string maSach, int soLuong)>
        {
            (txt_BookID.Text.Trim(), int.Parse(txt_SL.Text))
        };

                if (string.IsNullOrWhiteSpace(maDocGia) || string.IsNullOrWhiteSpace(txt_TenDocGia.Text) || string.IsNullOrWhiteSpace(comboBox_books.Text) || string.IsNullOrWhiteSpace(txt_SL.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!bl_addPhieu.Checkname(txt_TenDocGia.Text, txt_MaDocGia.Text))
                {
                    MessageBox.Show("Tên độc giả không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = bl_addPhieu.AddPhieu(maPhieu, maDocGia, ngayMuon, chitietPhieu);

                if (success)
                {
                    MessageBox.Show("Tạo phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_MaDocGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_TenDocGia.Text = bl_AutoSlipInfo.GetTenDocGia(txt_MaDocGia.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBorrow_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; // Đặt lại định dạng
            dateTimePicker1.Value = DateTime.Now;       // Đặt ngày mặc định là hôm nay
        }
    }
}
