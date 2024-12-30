namespace QLThuVien
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lblWelcome = new Label();
            pnlDashBoard = new Panel();
            lblDashBoard = new Label();
            picIconDashBoard = new PictureBox();
            pnlProfile = new Panel();
            lblProfile = new Label();
            picIconProfile = new PictureBox();
            pnlManageEmployees = new Panel();
            lblManageUsers = new Label();
            picIconManageUsers = new PictureBox();
            pnlManageBooks = new Panel();
            lblManageBooks = new Label();
            picIconManageBooks = new PictureBox();
            pnlBorrowReturn = new Panel();
            lblBorrowReturn = new Label();
            picIconBorrowReturn = new PictureBox();
            pnlReports = new Panel();
            lblReports = new Label();
            picIconReports = new PictureBox();
            pnlLogOut = new Panel();
            lblLogOut = new Label();
            picIconLogOut = new PictureBox();
            pnlBorrowReturnBTN = new Panel();
            pnlReportsBTN = new Panel();
            pnlLogOutBTN = new Panel();
            lblEmployeeName = new Label();
            lblDashBoardTitle = new Label();
            picIconHome = new PictureBox();
            pnlProfileBTN = new Panel();
            pnlManageUsersBTN = new Panel();
            pnlManageBooksBTN = new Panel();
            bLGetEmployeesBindingSource = new BindingSource(components);
            pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).BeginInit();
            pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).BeginInit();
            pnlManageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).BeginInit();
            pnlManageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).BeginInit();
            pnlBorrowReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).BeginInit();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconReports).BeginInit();
            pnlLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bLGetEmployeesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(86, 122);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(147, 38);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome!";
            // 
            // pnlDashBoard
            // 
            pnlDashBoard.BackColor = Color.Transparent;
            pnlDashBoard.Controls.Add(lblDashBoard);
            pnlDashBoard.Controls.Add(picIconDashBoard);
            pnlDashBoard.Location = new Point(13, 234);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(291, 57);
            pnlDashBoard.TabIndex = 2;
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
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Transparent;
            pnlProfile.Controls.Add(lblProfile);
            pnlProfile.Controls.Add(picIconProfile);
            pnlProfile.Cursor = Cursors.Hand;
            pnlProfile.Location = new Point(13, 306);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(291, 55);
            pnlProfile.TabIndex = 3;
            pnlProfile.Click += pnlProfile_Click;
            pnlProfile.MouseEnter += HoverEffect_MouseEnter;
            pnlProfile.MouseLeave += HoverEffect_MouseLeave;
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
            lblProfile.MouseEnter += HoverEffect_MouseEnter;
            lblProfile.MouseLeave += HoverEffect_MouseLeave;
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
            picIconProfile.MouseEnter += HoverEffect_MouseEnter;
            picIconProfile.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlManageEmployees
            // 
            pnlManageEmployees.BackColor = Color.Transparent;
            pnlManageEmployees.Controls.Add(lblManageUsers);
            pnlManageEmployees.Controls.Add(picIconManageUsers);
            pnlManageEmployees.Cursor = Cursors.Hand;
            pnlManageEmployees.Location = new Point(13, 382);
            pnlManageEmployees.Name = "pnlManageEmployees";
            pnlManageEmployees.Size = new Size(291, 55);
            pnlManageEmployees.TabIndex = 4;
            pnlManageEmployees.Click += pnlManageEmployees_Click;
            pnlManageEmployees.MouseEnter += HoverEffect_MouseEnter;
            pnlManageEmployees.MouseLeave += HoverEffect_MouseLeave;
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
            // pnlManageBooks
            // 
            pnlManageBooks.BackColor = Color.Transparent;
            pnlManageBooks.Controls.Add(lblManageBooks);
            pnlManageBooks.Controls.Add(picIconManageBooks);
            pnlManageBooks.Cursor = Cursors.Hand;
            pnlManageBooks.Location = new Point(13, 457);
            pnlManageBooks.Name = "pnlManageBooks";
            pnlManageBooks.Size = new Size(291, 55);
            pnlManageBooks.TabIndex = 5;
            pnlManageBooks.Click += pnlManageBooks_Click;
            pnlManageBooks.MouseEnter += HoverEffect_MouseEnter;
            pnlManageBooks.MouseLeave += HoverEffect_MouseLeave;
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
            picIconManageBooks.MouseEnter += HoverEffect_MouseEnter;
            picIconManageBooks.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlBorrowReturn
            // 
            pnlBorrowReturn.BackColor = Color.Transparent;
            pnlBorrowReturn.Controls.Add(lblBorrowReturn);
            pnlBorrowReturn.Controls.Add(picIconBorrowReturn);
            pnlBorrowReturn.Cursor = Cursors.Hand;
            pnlBorrowReturn.Location = new Point(13, 533);
            pnlBorrowReturn.Name = "pnlBorrowReturn";
            pnlBorrowReturn.Size = new Size(291, 55);
            pnlBorrowReturn.TabIndex = 6;
            pnlBorrowReturn.Click += pnlBorrowReturn_Click;
            pnlBorrowReturn.MouseEnter += HoverEffect_MouseEnter;
            pnlBorrowReturn.MouseLeave += HoverEffect_MouseLeave;
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
            // pnlReports
            // 
            pnlReports.BackColor = Color.Transparent;
            pnlReports.Controls.Add(lblReports);
            pnlReports.Controls.Add(picIconReports);
            pnlReports.Cursor = Cursors.Hand;
            pnlReports.Location = new Point(13, 609);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(291, 55);
            pnlReports.TabIndex = 7;
            pnlReports.Click += pnlReports_Click;
            pnlReports.MouseEnter += HoverEffect_MouseEnter;
            pnlReports.MouseLeave += HoverEffect_MouseLeave;
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
            lblReports.Click += pnlReports_Click;
            lblReports.MouseEnter += HoverEffect_MouseEnter;
            lblReports.MouseLeave += HoverEffect_MouseLeave;
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
            picIconReports.Click += pnlReports_Click;
            picIconReports.MouseEnter += HoverEffect_MouseEnter;
            picIconReports.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlLogOut
            // 
            pnlLogOut.BackColor = Color.Transparent;
            pnlLogOut.Controls.Add(lblLogOut);
            pnlLogOut.Controls.Add(picIconLogOut);
            pnlLogOut.Cursor = Cursors.Hand;
            pnlLogOut.Location = new Point(13, 687);
            pnlLogOut.Name = "pnlLogOut";
            pnlLogOut.Size = new Size(291, 55);
            pnlLogOut.TabIndex = 8;
            pnlLogOut.Click += pnlLogOut_Click;
            pnlLogOut.MouseEnter += HoverEffect_MouseEnter;
            pnlLogOut.MouseLeave += HoverEffect_MouseLeave;
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
            // pnlBorrowReturnBTN
            // 
            pnlBorrowReturnBTN.BackColor = Color.Transparent;
            pnlBorrowReturnBTN.Cursor = Cursors.Hand;
            pnlBorrowReturnBTN.Location = new Point(360, 464);
            pnlBorrowReturnBTN.Name = "pnlBorrowReturnBTN";
            pnlBorrowReturnBTN.Size = new Size(247, 215);
            pnlBorrowReturnBTN.TabIndex = 7;
            pnlBorrowReturnBTN.Click += pnlBorrowReturn_Click;
            // 
            // pnlReportsBTN
            // 
            pnlReportsBTN.BackColor = Color.Transparent;
            pnlReportsBTN.Cursor = Cursors.Hand;
            pnlReportsBTN.Location = new Point(659, 464);
            pnlReportsBTN.Name = "pnlReportsBTN";
            pnlReportsBTN.Size = new Size(247, 215);
            pnlReportsBTN.TabIndex = 5;
            pnlReportsBTN.Click += pnlReports_Click;
            // 
            // pnlLogOutBTN
            // 
            pnlLogOutBTN.BackColor = Color.Transparent;
            pnlLogOutBTN.Cursor = Cursors.Hand;
            pnlLogOutBTN.Location = new Point(960, 464);
            pnlLogOutBTN.Name = "pnlLogOutBTN";
            pnlLogOutBTN.Size = new Size(247, 215);
            pnlLogOutBTN.TabIndex = 9;
            pnlLogOutBTN.Click += pnlLogOut_Click;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.BackColor = Color.Transparent;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmployeeName.ForeColor = Color.DarkSlateBlue;
            lblEmployeeName.Location = new Point(122, 160);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(58, 28);
            lblEmployeeName.TabIndex = 10;
            lblEmployeeName.Text = "label";
            lblEmployeeName.Click += lblEmployeeName_Click;
            // 
            // lblDashBoardTitle
            // 
            lblDashBoardTitle.AutoSize = true;
            lblDashBoardTitle.BackColor = Color.Transparent;
            lblDashBoardTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDashBoardTitle.ForeColor = Color.DarkSlateBlue;
            lblDashBoardTitle.Location = new Point(404, 125);
            lblDashBoardTitle.Name = "lblDashBoardTitle";
            lblDashBoardTitle.Size = new Size(148, 35);
            lblDashBoardTitle.TabIndex = 2;
            lblDashBoardTitle.Text = "Dash Board";
            // 
            // picIconHome
            // 
            picIconHome.BackColor = Color.Transparent;
            picIconHome.Image = (Image)resources.GetObject("picIconHome.Image");
            picIconHome.Location = new Point(354, 115);
            picIconHome.Name = "picIconHome";
            picIconHome.Size = new Size(47, 51);
            picIconHome.SizeMode = PictureBoxSizeMode.Zoom;
            picIconHome.TabIndex = 2;
            picIconHome.TabStop = false;
            // 
            // pnlProfileBTN
            // 
            pnlProfileBTN.BackColor = Color.Transparent;
            pnlProfileBTN.Cursor = Cursors.Hand;
            pnlProfileBTN.Location = new Point(360, 200);
            pnlProfileBTN.Name = "pnlProfileBTN";
            pnlProfileBTN.Size = new Size(247, 215);
            pnlProfileBTN.TabIndex = 4;
            pnlProfileBTN.Click += pnlProfile_Click;
            // 
            // pnlManageUsersBTN
            // 
            pnlManageUsersBTN.BackColor = Color.Transparent;
            pnlManageUsersBTN.Cursor = Cursors.Hand;
            pnlManageUsersBTN.Location = new Point(659, 200);
            pnlManageUsersBTN.Name = "pnlManageUsersBTN";
            pnlManageUsersBTN.Size = new Size(247, 215);
            pnlManageUsersBTN.TabIndex = 5;
            pnlManageUsersBTN.Click += pnlManageEmployees_Click;
            // 
            // pnlManageBooksBTN
            // 
            pnlManageBooksBTN.BackColor = Color.Transparent;
            pnlManageBooksBTN.Cursor = Cursors.Hand;
            pnlManageBooksBTN.Location = new Point(960, 200);
            pnlManageBooksBTN.Name = "pnlManageBooksBTN";
            pnlManageBooksBTN.Size = new Size(247, 215);
            pnlManageBooksBTN.TabIndex = 6;
            pnlManageBooksBTN.Click += pnlManageBooks_Click;
            // 
            // bLGetEmployeesBindingSource
            // 
            bLGetEmployeesBindingSource.DataSource = typeof(BL.BL_GetEmployees);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1246, 863);
            Controls.Add(pnlManageUsersBTN);
            Controls.Add(pnlProfileBTN);
            Controls.Add(lblDashBoardTitle);
            Controls.Add(lblEmployeeName);
            Controls.Add(pnlLogOutBTN);
            Controls.Add(pnlReportsBTN);
            Controls.Add(pnlBorrowReturnBTN);
            Controls.Add(pnlManageBooksBTN);
            Controls.Add(pnlLogOut);
            Controls.Add(pnlReports);
            Controls.Add(pnlBorrowReturn);
            Controls.Add(pnlManageBooks);
            Controls.Add(pnlManageEmployees);
            Controls.Add(pnlProfile);
            Controls.Add(pnlDashBoard);
            Controls.Add(lblWelcome);
            Controls.Add(picIconHome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += Dashboard_FormClosing;
            Load += Dashboard_Load;
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).EndInit();
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).EndInit();
            pnlManageEmployees.ResumeLayout(false);
            pnlManageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).EndInit();
            pnlManageBooks.ResumeLayout(false);
            pnlManageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).EndInit();
            pnlBorrowReturn.ResumeLayout(false);
            pnlBorrowReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).EndInit();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconReports).EndInit();
            pnlLogOut.ResumeLayout(false);
            pnlLogOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)bLGetEmployeesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWelcome;
        private Panel pnlDashBoard;
        private PictureBox picIconDashBoard;
        private Label lblDashBoard;
        private Panel pnlProfile;
        private Label lblProfile;
        private PictureBox picIconProfile;
        private Panel pnlManageEmployees;
        private Label lblManageUsers;
        private PictureBox picIconManageUsers;
        private Panel pnlManageBooks;
        private Label lblManageBooks;
        private PictureBox picIconManageBooks;
        private Panel pnlBorrowReturn;
        private Label lblBorrowReturn;
        private PictureBox picIconBorrowReturn;
        private Panel pnlReports;
        private Label lblReports;
        private PictureBox picIconReports;
        private Panel pnlLogOut;
        private Label lblLogOut;
        private PictureBox picIconLogOut;
        private Panel pnlBorrowReturnBTN;
        private Panel pnlReportsBTN;
        private Panel pnlLogOutBTN;
        private Label lblEmployeeName;
        private Label lblDashBoardTitle;
        private PictureBox picIconHome;
        private Panel pnlProfileBTN;
        private Panel pnlManageUsersBTN;
        private Panel pnlManageBooksBTN;
        private BindingSource bLGetEmployeesBindingSource;
    }
}