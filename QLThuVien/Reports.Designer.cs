namespace QLThuVien
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            lblLogOut = new Label();
            lblReports = new Label();
            picIconReports = new PictureBox();
            lblBorrowReturn = new Label();
            picIconBorrowReturn = new PictureBox();
            lblManageBooks = new Label();
            picIconManageBooks = new PictureBox();
            lblManageUsers = new Label();
            picIconManageUsers = new PictureBox();
            lblProfile = new Label();
            picIconLogOut = new PictureBox();
            picIconProfile = new PictureBox();
            picIconDashBoard = new PictureBox();
            lblWelcome = new Label();
            pnlReports = new Panel();
            pnlBorrowReturn = new Panel();
            pnlManageBooks = new Panel();
            pnlManageEmployees = new Panel();
            pnlProfile = new Panel();
            pnlLogOut = new Panel();
            pnlDashBoard = new Panel();
            lblDashBoard = new Label();
            lblEmployeeName = new Label();
            pictureBox2 = new PictureBox();
            lblDashBoardTitle = new Label();
            pnl_Quarter = new Panel();
            dgvQuarter = new DataGridView();
            column = new DataGridViewTextBoxColumn();
            columnTotalQuarter = new DataGridViewTextBoxColumn();
            pnlMostBorrowedBook = new Panel();
            txtTopN = new TextBox();
            label7 = new Label();
            dgvTop5Book = new DataGridView();
            columnSTT = new DataGridViewTextBoxColumn();
            columnMaSach = new DataGridViewTextBoxColumn();
            columnTenSach = new DataGridViewTextBoxColumn();
            columnTongSoLuong = new DataGridViewTextBoxColumn();
            btn_Quarter = new Button();
            btn_Year = new Button();
            btn_Month = new Button();
            cb_Quarter = new ComboBox();
            cb_Month = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_Year = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlBookBorrowingBTN = new Panel();
            pnlMostBorrowedBTN = new Panel();
            txtYear = new TextBox();
            label1 = new Label();
            clbQuarter = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            clbMonth = new CheckedListBox();
            btnQuarter = new Button();
            btnMonth = new Button();
            pnl_Month = new Panel();
            dgvMonth = new DataGridView();
            columnTotal = new DataGridViewTextBoxColumn();
            columnMonth = new DataGridViewTextBoxColumn();
            pnlBookBorrowing = new Panel();
            ((System.ComponentModel.ISupportInitialize)picIconReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).BeginInit();
            pnlReports.SuspendLayout();
            pnlBorrowReturn.SuspendLayout();
            pnlManageBooks.SuspendLayout();
            pnlManageEmployees.SuspendLayout();
            pnlProfile.SuspendLayout();
            pnlLogOut.SuspendLayout();
            pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_Quarter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuarter).BeginInit();
            pnlMostBorrowedBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5Book).BeginInit();
            pnl_Month.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonth).BeginInit();
            pnlBookBorrowing.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogOut
            // 
            lblLogOut.AutoSize = true;
            lblLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblLogOut.ForeColor = Color.DarkSlateBlue;
            lblLogOut.Location = new Point(59, 15);
            lblLogOut.Name = "lblLogOut";
            lblLogOut.Size = new Size(87, 28);
            lblLogOut.TabIndex = 0;
            lblLogOut.Text = "Log Out";
            lblLogOut.Click += pnlLogOut_Click;
            lblLogOut.MouseEnter += HoverEffect_MouseEnter;
            lblLogOut.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblReports.ForeColor = Color.DarkSlateBlue;
            lblReports.Location = new Point(59, 15);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(86, 28);
            lblReports.TabIndex = 0;
            lblReports.Text = "Reports";
            // 
            // picIconReports
            // 
            picIconReports.Image = (Image)resources.GetObject("picIconReports.Image");
            picIconReports.Location = new Point(1, 7);
            picIconReports.Name = "picIconReports";
            picIconReports.Size = new Size(60, 42);
            picIconReports.SizeMode = PictureBoxSizeMode.Zoom;
            picIconReports.TabIndex = 1;
            picIconReports.TabStop = false;
            // 
            // lblBorrowReturn
            // 
            lblBorrowReturn.AutoSize = true;
            lblBorrowReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblBorrowReturn.ForeColor = Color.DarkSlateBlue;
            lblBorrowReturn.Location = new Point(59, 15);
            lblBorrowReturn.Name = "lblBorrowReturn";
            lblBorrowReturn.Size = new Size(192, 28);
            lblBorrowReturn.TabIndex = 0;
            lblBorrowReturn.Text = "Borrow and Return";
            lblBorrowReturn.Click += pnlBorrowReturn_Click;
            lblBorrowReturn.MouseEnter += HoverEffect_MouseEnter;
            lblBorrowReturn.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picIconBorrowReturn
            // 
            picIconBorrowReturn.Image = (Image)resources.GetObject("picIconBorrowReturn.Image");
            picIconBorrowReturn.Location = new Point(1, 7);
            picIconBorrowReturn.Name = "picIconBorrowReturn";
            picIconBorrowReturn.Size = new Size(60, 42);
            picIconBorrowReturn.SizeMode = PictureBoxSizeMode.Zoom;
            picIconBorrowReturn.TabIndex = 1;
            picIconBorrowReturn.TabStop = false;
            picIconBorrowReturn.Click += pnlBorrowReturn_Click;
            picIconBorrowReturn.MouseEnter += HoverEffect_MouseEnter;
            picIconBorrowReturn.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblManageBooks
            // 
            lblManageBooks.AutoSize = true;
            lblManageBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblManageBooks.ForeColor = Color.DarkSlateBlue;
            lblManageBooks.Location = new Point(59, 15);
            lblManageBooks.Name = "lblManageBooks";
            lblManageBooks.Size = new Size(151, 28);
            lblManageBooks.TabIndex = 0;
            lblManageBooks.Text = "Manage Books";
            lblManageBooks.Click += pnlManageBooks_Click;
            lblManageBooks.MouseEnter += HoverEffect_MouseEnter;
            lblManageBooks.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picIconManageBooks
            // 
            picIconManageBooks.Image = (Image)resources.GetObject("picIconManageBooks.Image");
            picIconManageBooks.Location = new Point(1, 7);
            picIconManageBooks.Name = "picIconManageBooks";
            picIconManageBooks.Size = new Size(60, 42);
            picIconManageBooks.SizeMode = PictureBoxSizeMode.Zoom;
            picIconManageBooks.TabIndex = 1;
            picIconManageBooks.TabStop = false;
            picIconManageBooks.Click += pnlManageBooks_Click;
            picIconManageBooks.MouseEnter += HoverEffect_MouseEnter;
            picIconManageBooks.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblManageUsers
            // 
            lblManageUsers.AutoSize = true;
            lblManageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblManageUsers.ForeColor = Color.DarkSlateBlue;
            lblManageUsers.Location = new Point(59, 15);
            lblManageUsers.Name = "lblManageUsers";
            lblManageUsers.Size = new Size(195, 28);
            lblManageUsers.TabIndex = 0;
            lblManageUsers.Text = "Manage Employees";
            lblManageUsers.Click += pnlManageEmployees_Click;
            lblManageUsers.MouseEnter += HoverEffect_MouseEnter;
            lblManageUsers.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picIconManageUsers
            // 
            picIconManageUsers.Image = (Image)resources.GetObject("picIconManageUsers.Image");
            picIconManageUsers.Location = new Point(1, 7);
            picIconManageUsers.Name = "picIconManageUsers";
            picIconManageUsers.Size = new Size(60, 42);
            picIconManageUsers.SizeMode = PictureBoxSizeMode.Zoom;
            picIconManageUsers.TabIndex = 1;
            picIconManageUsers.TabStop = false;
            picIconManageUsers.Click += pnlManageEmployees_Click;
            picIconManageUsers.MouseEnter += HoverEffect_MouseEnter;
            picIconManageUsers.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblProfile.ForeColor = Color.DarkSlateBlue;
            lblProfile.Location = new Point(59, 15);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(75, 28);
            lblProfile.TabIndex = 0;
            lblProfile.Text = "Profile";
            lblProfile.Click += pnlProfile_Click;
            lblProfile.MouseEnter += HoverEffect_MouseEnter;
            lblProfile.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picIconLogOut
            // 
            picIconLogOut.Image = (Image)resources.GetObject("picIconLogOut.Image");
            picIconLogOut.Location = new Point(1, 7);
            picIconLogOut.Name = "picIconLogOut";
            picIconLogOut.Size = new Size(60, 42);
            picIconLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            picIconLogOut.TabIndex = 1;
            picIconLogOut.TabStop = false;
            picIconLogOut.Click += pnlLogOut_Click;
            picIconLogOut.MouseEnter += HoverEffect_MouseEnter;
            picIconLogOut.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picIconProfile
            // 
            picIconProfile.Image = (Image)resources.GetObject("picIconProfile.Image");
            picIconProfile.Location = new Point(1, 7);
            picIconProfile.Name = "picIconProfile";
            picIconProfile.Size = new Size(60, 42);
            picIconProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picIconProfile.TabIndex = 1;
            picIconProfile.TabStop = false;
            picIconProfile.Click += pnlProfile_Click;
            picIconProfile.MouseEnter += HoverEffect_MouseEnter;
            picIconProfile.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picIconDashBoard
            // 
            picIconDashBoard.Image = (Image)resources.GetObject("picIconDashBoard.Image");
            picIconDashBoard.Location = new Point(1, 7);
            picIconDashBoard.Name = "picIconDashBoard";
            picIconDashBoard.Size = new Size(60, 42);
            picIconDashBoard.SizeMode = PictureBoxSizeMode.Zoom;
            picIconDashBoard.TabIndex = 1;
            picIconDashBoard.TabStop = false;
            picIconDashBoard.Click += pnlDashBoard_Click;
            picIconDashBoard.MouseEnter += HoverEffect_MouseEnter;
            picIconDashBoard.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(85, 121);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(147, 38);
            lblWelcome.TabIndex = 35;
            lblWelcome.Text = "Welcome!";
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.Transparent;
            pnlReports.Controls.Add(lblReports);
            pnlReports.Controls.Add(picIconReports);
            pnlReports.Location = new Point(11, 603);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(291, 55);
            pnlReports.TabIndex = 33;
            // 
            // pnlBorrowReturn
            // 
            pnlBorrowReturn.BackColor = Color.Transparent;
            pnlBorrowReturn.Controls.Add(lblBorrowReturn);
            pnlBorrowReturn.Controls.Add(picIconBorrowReturn);
            pnlBorrowReturn.Cursor = Cursors.Hand;
            pnlBorrowReturn.Location = new Point(11, 527);
            pnlBorrowReturn.Name = "pnlBorrowReturn";
            pnlBorrowReturn.Size = new Size(291, 55);
            pnlBorrowReturn.TabIndex = 32;
            pnlBorrowReturn.Click += pnlBorrowReturn_Click;
            pnlBorrowReturn.MouseEnter += HoverEffect_MouseEnter;
            pnlBorrowReturn.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlManageBooks
            // 
            pnlManageBooks.BackColor = Color.Transparent;
            pnlManageBooks.Controls.Add(lblManageBooks);
            pnlManageBooks.Controls.Add(picIconManageBooks);
            pnlManageBooks.Cursor = Cursors.Hand;
            pnlManageBooks.Location = new Point(11, 451);
            pnlManageBooks.Name = "pnlManageBooks";
            pnlManageBooks.Size = new Size(291, 55);
            pnlManageBooks.TabIndex = 31;
            pnlManageBooks.Click += pnlManageBooks_Click;
            pnlManageBooks.MouseEnter += HoverEffect_MouseEnter;
            pnlManageBooks.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlManageEmployees
            // 
            pnlManageEmployees.BackColor = Color.Transparent;
            pnlManageEmployees.Controls.Add(lblManageUsers);
            pnlManageEmployees.Controls.Add(picIconManageUsers);
            pnlManageEmployees.Cursor = Cursors.Hand;
            pnlManageEmployees.Location = new Point(11, 376);
            pnlManageEmployees.Name = "pnlManageEmployees";
            pnlManageEmployees.Size = new Size(291, 55);
            pnlManageEmployees.TabIndex = 30;
            pnlManageEmployees.Click += pnlManageEmployees_Click;
            pnlManageEmployees.MouseEnter += HoverEffect_MouseEnter;
            pnlManageEmployees.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Transparent;
            pnlProfile.Controls.Add(lblProfile);
            pnlProfile.Controls.Add(picIconProfile);
            pnlProfile.Cursor = Cursors.Hand;
            pnlProfile.Location = new Point(11, 300);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(291, 55);
            pnlProfile.TabIndex = 29;
            pnlProfile.Click += pnlProfile_Click;
            pnlProfile.MouseEnter += HoverEffect_MouseEnter;
            pnlProfile.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlLogOut
            // 
            pnlLogOut.BackColor = Color.Transparent;
            pnlLogOut.Controls.Add(lblLogOut);
            pnlLogOut.Controls.Add(picIconLogOut);
            pnlLogOut.Cursor = Cursors.Hand;
            pnlLogOut.Location = new Point(11, 681);
            pnlLogOut.Name = "pnlLogOut";
            pnlLogOut.Size = new Size(291, 55);
            pnlLogOut.TabIndex = 34;
            pnlLogOut.Click += pnlLogOut_Click;
            pnlLogOut.MouseEnter += HoverEffect_MouseEnter;
            pnlLogOut.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlDashBoard
            // 
            pnlDashBoard.BackColor = Color.Transparent;
            pnlDashBoard.Controls.Add(lblDashBoard);
            pnlDashBoard.Controls.Add(picIconDashBoard);
            pnlDashBoard.Cursor = Cursors.Hand;
            pnlDashBoard.Location = new Point(11, 228);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(291, 57);
            pnlDashBoard.TabIndex = 28;
            pnlDashBoard.Click += pnlDashBoard_Click;
            pnlDashBoard.MouseEnter += HoverEffect_MouseEnter;
            pnlDashBoard.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblDashBoard
            // 
            lblDashBoard.AutoSize = true;
            lblDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDashBoard.ForeColor = Color.DarkSlateBlue;
            lblDashBoard.Location = new Point(59, 15);
            lblDashBoard.Name = "lblDashBoard";
            lblDashBoard.Size = new Size(121, 28);
            lblDashBoard.TabIndex = 0;
            lblDashBoard.Text = "Dash Board";
            lblDashBoard.Click += pnlDashBoard_Click;
            lblDashBoard.MouseEnter += HoverEffect_MouseEnter;
            lblDashBoard.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.BackColor = Color.Transparent;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmployeeName.ForeColor = Color.DarkSlateBlue;
            lblEmployeeName.Location = new Point(121, 159);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(70, 28);
            lblEmployeeName.TabIndex = 36;
            lblEmployeeName.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(335, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // lblDashBoardTitle
            // 
            lblDashBoardTitle.AutoSize = true;
            lblDashBoardTitle.BackColor = Color.Transparent;
            lblDashBoardTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDashBoardTitle.ForeColor = Color.DarkSlateBlue;
            lblDashBoardTitle.Location = new Point(400, 124);
            lblDashBoardTitle.Name = "lblDashBoardTitle";
            lblDashBoardTitle.Size = new Size(107, 35);
            lblDashBoardTitle.TabIndex = 38;
            lblDashBoardTitle.Text = "Reports";
            // 
            // pnl_Quarter
            // 
            pnl_Quarter.Controls.Add(dgvQuarter);
            pnl_Quarter.Location = new Point(3, 127);
            pnl_Quarter.Name = "pnl_Quarter";
            pnl_Quarter.Size = new Size(928, 419);
            pnl_Quarter.TabIndex = 44;
            // 
            // dgvQuarter
            // 
            dgvQuarter.BackgroundColor = Color.White;
            dgvQuarter.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvQuarter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvQuarter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuarter.Columns.AddRange(new DataGridViewColumn[] { column, columnTotalQuarter });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvQuarter.DefaultCellStyle = dataGridViewCellStyle9;
            dgvQuarter.Location = new Point(3, 6);
            dgvQuarter.Name = "dgvQuarter";
            dgvQuarter.ReadOnly = true;
            dgvQuarter.RowHeadersWidth = 51;
            dgvQuarter.Size = new Size(343, 134);
            dgvQuarter.TabIndex = 9;
            // 
            // column
            // 
            column.HeaderText = "Quarter";
            column.MinimumWidth = 6;
            column.Name = "column";
            column.ReadOnly = true;
            column.Width = 88;
            // 
            // columnTotalQuarter
            // 
            columnTotalQuarter.HeaderText = "Total Borrowed Books";
            columnTotalQuarter.MinimumWidth = 6;
            columnTotalQuarter.Name = "columnTotalQuarter";
            columnTotalQuarter.ReadOnly = true;
            columnTotalQuarter.Width = 200;
            // 
            // pnlMostBorrowedBook
            // 
            pnlMostBorrowedBook.BackColor = Color.White;
            pnlMostBorrowedBook.Controls.Add(txtTopN);
            pnlMostBorrowedBook.Controls.Add(label7);
            pnlMostBorrowedBook.Controls.Add(dgvTop5Book);
            pnlMostBorrowedBook.Controls.Add(btn_Quarter);
            pnlMostBorrowedBook.Controls.Add(btn_Year);
            pnlMostBorrowedBook.Controls.Add(btn_Month);
            pnlMostBorrowedBook.Controls.Add(cb_Quarter);
            pnlMostBorrowedBook.Controls.Add(cb_Month);
            pnlMostBorrowedBook.Controls.Add(label6);
            pnlMostBorrowedBook.Controls.Add(label5);
            pnlMostBorrowedBook.Controls.Add(label4);
            pnlMostBorrowedBook.Controls.Add(txt_Year);
            pnlMostBorrowedBook.Location = new Point(316, 315);
            pnlMostBorrowedBook.Name = "pnlMostBorrowedBook";
            pnlMostBorrowedBook.Size = new Size(931, 549);
            pnlMostBorrowedBook.TabIndex = 42;
            // 
            // txtTopN
            // 
            txtTopN.Cursor = Cursors.IBeam;
            txtTopN.Location = new Point(67, 42);
            txtTopN.Name = "txtTopN";
            txtTopN.Size = new Size(151, 27);
            txtTopN.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label7.Location = new Point(60, 13);
            label7.Name = "label7";
            label7.Size = new Size(157, 23);
            label7.TabIndex = 10;
            label7.Text = "Enter Top N Books";
            // 
            // dgvTop5Book
            // 
            dgvTop5Book.BackgroundColor = Color.White;
            dgvTop5Book.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvTop5Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvTop5Book.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5Book.Columns.AddRange(new DataGridViewColumn[] { columnSTT, columnMaSach, columnTenSach, columnTongSoLuong });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvTop5Book.DefaultCellStyle = dataGridViewCellStyle11;
            dgvTop5Book.Location = new Point(180, 150);
            dgvTop5Book.Name = "dgvTop5Book";
            dgvTop5Book.ReadOnly = true;
            dgvTop5Book.RowHeadersWidth = 51;
            dgvTop5Book.Size = new Size(578, 147);
            dgvTop5Book.TabIndex = 9;
            // 
            // columnSTT
            // 
            columnSTT.HeaderText = "STT";
            columnSTT.MinimumWidth = 6;
            columnSTT.Name = "columnSTT";
            columnSTT.ReadOnly = true;
            columnSTT.Width = 125;
            // 
            // columnMaSach
            // 
            columnMaSach.HeaderText = "Mã Sách";
            columnMaSach.MinimumWidth = 6;
            columnMaSach.Name = "columnMaSach";
            columnMaSach.ReadOnly = true;
            columnMaSach.Width = 125;
            // 
            // columnTenSach
            // 
            columnTenSach.HeaderText = "Tên Sách";
            columnTenSach.MinimumWidth = 6;
            columnTenSach.Name = "columnTenSach";
            columnTenSach.ReadOnly = true;
            columnTenSach.Width = 125;
            // 
            // columnTongSoLuong
            // 
            columnTongSoLuong.HeaderText = "Tổng Số Lượng";
            columnTongSoLuong.MinimumWidth = 6;
            columnTongSoLuong.Name = "columnTongSoLuong";
            columnTongSoLuong.ReadOnly = true;
            columnTongSoLuong.Width = 150;
            // 
            // btn_Quarter
            // 
            btn_Quarter.BackColor = Color.Lavender;
            btn_Quarter.Cursor = Cursors.Hand;
            btn_Quarter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Quarter.Location = new Point(501, 76);
            btn_Quarter.Name = "btn_Quarter";
            btn_Quarter.Size = new Size(151, 39);
            btn_Quarter.TabIndex = 8;
            btn_Quarter.Text = "Quarterly Statistics";
            btn_Quarter.UseVisualStyleBackColor = false;
            btn_Quarter.Click += btn_Quarter_Click;
            // 
            // btn_Year
            // 
            btn_Year.BackColor = Color.Lavender;
            btn_Year.Cursor = Cursors.Hand;
            btn_Year.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Year.Location = new Point(285, 77);
            btn_Year.Name = "btn_Year";
            btn_Year.Size = new Size(151, 39);
            btn_Year.TabIndex = 7;
            btn_Year.Text = "Yearly Statistics";
            btn_Year.UseVisualStyleBackColor = false;
            btn_Year.Click += btn_Year_Click;
            // 
            // btn_Month
            // 
            btn_Month.BackColor = Color.Lavender;
            btn_Month.Cursor = Cursors.Hand;
            btn_Month.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Month.Location = new Point(718, 77);
            btn_Month.Name = "btn_Month";
            btn_Month.Size = new Size(151, 39);
            btn_Month.TabIndex = 6;
            btn_Month.Text = "Monthly Statistics";
            btn_Month.UseVisualStyleBackColor = false;
            btn_Month.Click += btn_Month_Click;
            // 
            // cb_Quarter
            // 
            cb_Quarter.Cursor = Cursors.Hand;
            cb_Quarter.FormattingEnabled = true;
            cb_Quarter.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cb_Quarter.Location = new Point(501, 40);
            cb_Quarter.Name = "cb_Quarter";
            cb_Quarter.Size = new Size(151, 28);
            cb_Quarter.TabIndex = 5;
            // 
            // cb_Month
            // 
            cb_Month.Cursor = Cursors.Hand;
            cb_Month.FormattingEnabled = true;
            cb_Month.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cb_Month.Location = new Point(718, 41);
            cb_Month.Name = "cb_Month";
            cb_Month.Size = new Size(151, 28);
            cb_Month.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label6.Location = new Point(739, 12);
            label6.Name = "label6";
            label6.Size = new Size(116, 23);
            label6.TabIndex = 3;
            label6.Text = "Select Month";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label5.Location = new Point(509, 13);
            label5.Name = "label5";
            label5.Size = new Size(125, 23);
            label5.TabIndex = 2;
            label5.Text = "Select Quarter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(314, 12);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 1;
            label4.Text = "Enter Year";
            // 
            // txt_Year
            // 
            txt_Year.Cursor = Cursors.IBeam;
            txt_Year.Location = new Point(285, 41);
            txt_Year.Name = "txt_Year";
            txt_Year.Size = new Size(151, 27);
            txt_Year.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pnlBookBorrowingBTN
            // 
            pnlBookBorrowingBTN.BackColor = Color.Transparent;
            pnlBookBorrowingBTN.Cursor = Cursors.Hand;
            pnlBookBorrowingBTN.Location = new Point(555, 180);
            pnlBookBorrowingBTN.Name = "pnlBookBorrowingBTN";
            pnlBookBorrowingBTN.Size = new Size(208, 113);
            pnlBookBorrowingBTN.TabIndex = 40;
            pnlBookBorrowingBTN.Click += pnlBookBorrowingBTN_Click;
            // 
            // pnlMostBorrowedBTN
            // 
            pnlMostBorrowedBTN.BackColor = Color.Transparent;
            pnlMostBorrowedBTN.Cursor = Cursors.Hand;
            pnlMostBorrowedBTN.Location = new Point(794, 180);
            pnlMostBorrowedBTN.Name = "pnlMostBorrowedBTN";
            pnlMostBorrowedBTN.Size = new Size(207, 113);
            pnlMostBorrowedBTN.TabIndex = 41;
            pnlMostBorrowedBTN.Click += pnlMostBorrowedBTN_Click;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.White;
            txtYear.Cursor = Cursors.IBeam;
            txtYear.Location = new Point(157, 3);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(118, 27);
            txtYear.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(38, 3);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter Year";
            // 
            // clbQuarter
            // 
            clbQuarter.BackColor = Color.White;
            clbQuarter.CheckOnClick = true;
            clbQuarter.Cursor = Cursors.Hand;
            clbQuarter.FormattingEnabled = true;
            clbQuarter.Items.AddRange(new object[] { "1", "2", "3", "4" });
            clbQuarter.Location = new Point(490, 3);
            clbQuarter.Name = "clbQuarter";
            clbQuarter.Size = new Size(109, 92);
            clbQuarter.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(335, 3);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 3;
            label2.Text = "Select Quarter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(648, 3);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 4;
            label3.Text = "Select Month";
            // 
            // clbMonth
            // 
            clbMonth.BackColor = Color.White;
            clbMonth.CheckOnClick = true;
            clbMonth.Cursor = Cursors.Hand;
            clbMonth.FormattingEnabled = true;
            clbMonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            clbMonth.Location = new Point(792, 3);
            clbMonth.Name = "clbMonth";
            clbMonth.Size = new Size(109, 92);
            clbMonth.TabIndex = 5;
            // 
            // btnQuarter
            // 
            btnQuarter.BackColor = Color.Lavender;
            btnQuarter.Cursor = Cursors.Hand;
            btnQuarter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnQuarter.Location = new Point(359, 47);
            btnQuarter.Name = "btnQuarter";
            btnQuarter.Size = new Size(98, 48);
            btnQuarter.TabIndex = 6;
            btnQuarter.Text = "Quarterly Report";
            btnQuarter.UseVisualStyleBackColor = false;
            btnQuarter.Click += btnQuarter_Click;
            // 
            // btnMonth
            // 
            btnMonth.BackColor = Color.Lavender;
            btnMonth.Cursor = Cursors.Hand;
            btnMonth.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnMonth.Location = new Point(667, 51);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(98, 48);
            btnMonth.TabIndex = 7;
            btnMonth.Text = "Monthly Report";
            btnMonth.UseVisualStyleBackColor = false;
            btnMonth.Click += btnMonth_Click;
            // 
            // pnl_Month
            // 
            pnl_Month.Controls.Add(dgvMonth);
            pnl_Month.Location = new Point(3, 127);
            pnl_Month.Name = "pnl_Month";
            pnl_Month.Size = new Size(928, 419);
            pnl_Month.TabIndex = 43;
            // 
            // dgvMonth
            // 
            dgvMonth.BackgroundColor = Color.White;
            dgvMonth.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonth.Columns.AddRange(new DataGridViewColumn[] { columnMonth, columnTotal });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgvMonth.DefaultCellStyle = dataGridViewCellStyle13;
            dgvMonth.Location = new Point(3, 6);
            dgvMonth.Name = "dgvMonth";
            dgvMonth.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgvMonth.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgvMonth.RowHeadersWidth = 51;
            dgvMonth.Size = new Size(333, 134);
            dgvMonth.TabIndex = 8;
            // 
            // columnTotal
            // 
            columnTotal.HeaderText = "Total Borrowed Books";
            columnTotal.MinimumWidth = 6;
            columnTotal.Name = "columnTotal";
            columnTotal.ReadOnly = true;
            columnTotal.Width = 200;
            // 
            // columnMonth
            // 
            columnMonth.HeaderText = "Month";
            columnMonth.MinimumWidth = 6;
            columnMonth.Name = "columnMonth";
            columnMonth.ReadOnly = true;
            columnMonth.Width = 81;
            // 
            // pnlBookBorrowing
            // 
            pnlBookBorrowing.BackColor = Color.White;
            pnlBookBorrowing.Controls.Add(pnl_Quarter);
            pnlBookBorrowing.Controls.Add(pnl_Month);
            pnlBookBorrowing.Controls.Add(btnMonth);
            pnlBookBorrowing.Controls.Add(btnQuarter);
            pnlBookBorrowing.Controls.Add(clbMonth);
            pnlBookBorrowing.Controls.Add(label3);
            pnlBookBorrowing.Controls.Add(label2);
            pnlBookBorrowing.Controls.Add(clbQuarter);
            pnlBookBorrowing.Controls.Add(label1);
            pnlBookBorrowing.Controls.Add(txtYear);
            pnlBookBorrowing.Location = new Point(316, 315);
            pnlBookBorrowing.Name = "pnlBookBorrowing";
            pnlBookBorrowing.Size = new Size(931, 549);
            pnlBookBorrowing.TabIndex = 39;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1246, 863);
            Controls.Add(pnlMostBorrowedBook);
            Controls.Add(pnlMostBorrowedBTN);
            Controls.Add(pnlBookBorrowingBTN);
            Controls.Add(pnlBookBorrowing);
            Controls.Add(pictureBox2);
            Controls.Add(lblDashBoardTitle);
            Controls.Add(lblWelcome);
            Controls.Add(pnlReports);
            Controls.Add(pnlBorrowReturn);
            Controls.Add(pnlManageBooks);
            Controls.Add(pnlManageEmployees);
            Controls.Add(pnlProfile);
            Controls.Add(pnlLogOut);
            Controls.Add(pnlDashBoard);
            Controls.Add(lblEmployeeName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            FormClosing += Reports_FormClosing;
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)picIconReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).EndInit();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            pnlBorrowReturn.ResumeLayout(false);
            pnlBorrowReturn.PerformLayout();
            pnlManageBooks.ResumeLayout(false);
            pnlManageBooks.PerformLayout();
            pnlManageEmployees.ResumeLayout(false);
            pnlManageEmployees.PerformLayout();
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            pnlLogOut.ResumeLayout(false);
            pnlLogOut.PerformLayout();
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_Quarter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuarter).EndInit();
            pnlMostBorrowedBook.ResumeLayout(false);
            pnlMostBorrowedBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5Book).EndInit();
            pnl_Month.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonth).EndInit();
            pnlBookBorrowing.ResumeLayout(false);
            pnlBookBorrowing.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogOut;
        private Label lblReports;
        private PictureBox picIconReports;
        private Label lblBorrowReturn;
        private PictureBox picIconBorrowReturn;
        private Label lblManageBooks;
        private PictureBox picIconManageBooks;
        private Label lblManageUsers;
        private PictureBox picIconManageUsers;
        private Label lblProfile;
        private PictureBox picIconLogOut;
        private PictureBox picIconProfile;
        private PictureBox picIconDashBoard;
        private Label lblWelcome;
        private Panel pnlReports;
        private Panel pnlBorrowReturn;
        private Panel pnlManageBooks;
        private Panel pnlManageEmployees;
        private Panel pnlProfile;
        private Panel pnlLogOut;
        private Panel pnlDashBoard;
        private Label lblDashBoard;
        private Label lblEmployeeName;
        private PictureBox pictureBox2;
        private Label lblDashBoardTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel pnlBookBorrowingBTN;
        private Panel pnlMostBorrowedBTN;
        private DataGridView dgvQuarter;
        private DataGridViewTextBoxColumn column;
        private DataGridViewTextBoxColumn columnTotalQuarter;
        private Panel pnlMostBorrowedBook;
        private Label label4;
        private TextBox txt_Year;
        private ComboBox cb_Quarter;
        private ComboBox cb_Month;
        private Label label6;
        private Label label5;
        private Button btn_Month;
        private DataGridView dgvTop5Book;
        private Button btn_Quarter;
        private Button btn_Year;
        private Label label7;
        private TextBox txtTopN;
        private DataGridViewTextBoxColumn columnSTT;
        private DataGridViewTextBoxColumn columnMaSach;
        private DataGridViewTextBoxColumn columnTenSach;
        private DataGridViewTextBoxColumn columnTongSoLuong;
        private Panel pnl_Quarter;
        private TextBox txtYear;
        private Label label1;
        private CheckedListBox clbQuarter;
        private Label label2;
        private Label label3;
        private CheckedListBox clbMonth;
        private Button btnQuarter;
        private Button btnMonth;
        private Panel pnl_Month;
        private DataGridView dgvMonth;
        private DataGridViewTextBoxColumn columnMonth;
        private DataGridViewTextBoxColumn columnTotal;
        private Panel pnlBookBorrowing;
    }
}