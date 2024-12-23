namespace QLThuVien
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            picIconReports = new PictureBox();
            lblLogOut = new Label();
            picIconLogOut = new PictureBox();
            pnlReports = new Panel();
            lblReports = new Label();
            pnlBorrowReturn = new Panel();
            lblBorrowReturn = new Label();
            picIconBorrowReturn = new PictureBox();
            lblWelcome = new Label();
            pnlManageBooks = new Panel();
            lblManageBooks = new Label();
            picIconManageBooks = new PictureBox();
            lblManageUsers = new Label();
            picIconManageUsers = new PictureBox();
            pnlManageEmployees = new Panel();
            pnlProfile = new Panel();
            lblProfile = new Label();
            picIconProfile = new PictureBox();
            lblDashBoard = new Label();
            picIconDashBoard = new PictureBox();
            lblEmployeeName = new Label();
            pnlLogOut = new Panel();
            pnlDashBoard = new Panel();
            picAvatar = new PictureBox();
            lblDashBoardTitle = new Label();
            pictureBox2 = new PictureBox();
            pnlBookCaseBTN = new FlowLayoutPanel();
            pnlSearchBTN = new FlowLayoutPanel();
            pnlAddBookBTN = new FlowLayoutPanel();
            pnlBookManagerBTN = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)picIconReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).BeginInit();
            pnlReports.SuspendLayout();
            pnlBorrowReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).BeginInit();
            pnlManageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).BeginInit();
            pnlManageEmployees.SuspendLayout();
            pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).BeginInit();
            pnlLogOut.SuspendLayout();
            pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            picIconReports.MouseEnter += HoverEffect_MouseEnter;
            picIconReports.MouseLeave += HoverEffect_MouseLeave;
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
            picIconLogOut.MouseEnter += HoverEffect_MouseEnter;
            picIconLogOut.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.Transparent;
            pnlReports.Controls.Add(lblReports);
            pnlReports.Controls.Add(picIconReports);
            pnlReports.Cursor = Cursors.Hand;
            pnlReports.Location = new Point(12, 604);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(291, 55);
            pnlReports.TabIndex = 18;
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
            lblReports.MouseEnter += HoverEffect_MouseEnter;
            lblReports.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlBorrowReturn
            // 
            pnlBorrowReturn.BackColor = Color.Transparent;
            pnlBorrowReturn.Controls.Add(lblBorrowReturn);
            pnlBorrowReturn.Controls.Add(picIconBorrowReturn);
            pnlBorrowReturn.Cursor = Cursors.Hand;
            pnlBorrowReturn.Location = new Point(12, 528);
            pnlBorrowReturn.Name = "pnlBorrowReturn";
            pnlBorrowReturn.Size = new Size(291, 55);
            pnlBorrowReturn.TabIndex = 17;
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
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(156, 100);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(147, 38);
            lblWelcome.TabIndex = 12;
            lblWelcome.Text = "Welcome!";
            // 
            // pnlManageBooks
            // 
            pnlManageBooks.BackColor = Color.Transparent;
            pnlManageBooks.Controls.Add(lblManageBooks);
            pnlManageBooks.Controls.Add(picIconManageBooks);
            pnlManageBooks.Cursor = Cursors.Hand;
            pnlManageBooks.Location = new Point(12, 452);
            pnlManageBooks.Name = "pnlManageBooks";
            pnlManageBooks.Size = new Size(291, 55);
            pnlManageBooks.TabIndex = 16;
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
            picIconManageUsers.MouseEnter += HoverEffect_MouseEnter;
            picIconManageUsers.MouseLeave += HoverEffect_MouseLeave;
            // 
            // pnlManageEmployees
            // 
            pnlManageEmployees.BackColor = Color.Transparent;
            pnlManageEmployees.Controls.Add(lblManageUsers);
            pnlManageEmployees.Controls.Add(picIconManageUsers);
            pnlManageEmployees.Cursor = Cursors.Hand;
            pnlManageEmployees.Location = new Point(12, 377);
            pnlManageEmployees.Name = "pnlManageEmployees";
            pnlManageEmployees.Size = new Size(291, 55);
            pnlManageEmployees.TabIndex = 15;
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
            pnlProfile.Location = new Point(12, 301);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(291, 55);
            pnlProfile.TabIndex = 14;
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
            lblDashBoard.MouseEnter += HoverEffect_MouseEnter;
            lblDashBoard.MouseLeave += HoverEffect_MouseLeave;
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
            picIconDashBoard.MouseEnter += HoverEffect_MouseEnter;
            picIconDashBoard.MouseLeave += HoverEffect_MouseLeave;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.BackColor = Color.Transparent;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmployeeName.ForeColor = Color.DarkSlateBlue;
            lblEmployeeName.Location = new Point(182, 138);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(70, 28);
            lblEmployeeName.TabIndex = 20;
            lblEmployeeName.Text = "label1";
            // 
            // pnlLogOut
            // 
            pnlLogOut.BackColor = Color.Transparent;
            pnlLogOut.Controls.Add(lblLogOut);
            pnlLogOut.Controls.Add(picIconLogOut);
            pnlLogOut.Cursor = Cursors.Hand;
            pnlLogOut.Location = new Point(12, 682);
            pnlLogOut.Name = "pnlLogOut";
            pnlLogOut.Size = new Size(291, 55);
            pnlLogOut.TabIndex = 19;
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
            pnlDashBoard.Location = new Point(12, 229);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(291, 57);
            pnlDashBoard.TabIndex = 13;
            pnlDashBoard.Click += pnlDashBoard_Click;
            pnlDashBoard.MouseEnter += HoverEffect_MouseEnter;
            pnlDashBoard.MouseLeave += HoverEffect_MouseLeave;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(12, 100);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(127, 113);
            picAvatar.TabIndex = 11;
            picAvatar.TabStop = false;
            // 
            // lblDashBoardTitle
            // 
            lblDashBoardTitle.AutoSize = true;
            lblDashBoardTitle.BackColor = Color.Transparent;
            lblDashBoardTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDashBoardTitle.ForeColor = Color.DarkSlateBlue;
            lblDashBoardTitle.Location = new Point(398, 138);
            lblDashBoardTitle.Name = "lblDashBoardTitle";
            lblDashBoardTitle.Size = new Size(187, 35);
            lblDashBoardTitle.TabIndex = 22;
            lblDashBoardTitle.Text = "Manage Books";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(333, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pnlBookCaseBTN
            // 
            pnlBookCaseBTN.BackColor = Color.Transparent;
            pnlBookCaseBTN.Location = new Point(495, 203);
            pnlBookCaseBTN.Name = "pnlBookCaseBTN";
            pnlBookCaseBTN.Size = new Size(249, 217);
            pnlBookCaseBTN.TabIndex = 23;
            // 
            // pnlSearchBTN
            // 
            pnlSearchBTN.BackColor = Color.Transparent;
            pnlSearchBTN.Location = new Point(833, 203);
            pnlSearchBTN.Name = "pnlSearchBTN";
            pnlSearchBTN.Size = new Size(249, 217);
            pnlSearchBTN.TabIndex = 24;
            // 
            // pnlAddBookBTN
            // 
            pnlAddBookBTN.BackColor = Color.Transparent;
            pnlAddBookBTN.Location = new Point(495, 480);
            pnlAddBookBTN.Name = "pnlAddBookBTN";
            pnlAddBookBTN.Size = new Size(249, 217);
            pnlAddBookBTN.TabIndex = 25;
            // 
            // pnlBookManagerBTN
            // 
            pnlBookManagerBTN.BackColor = Color.Transparent;
            pnlBookManagerBTN.Location = new Point(833, 480);
            pnlBookManagerBTN.Name = "pnlBookManagerBTN";
            pnlBookManagerBTN.Size = new Size(249, 217);
            pnlBookManagerBTN.TabIndex = 24;
            // 
            // ManageBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1246, 863);
            Controls.Add(pnlBookManagerBTN);
            Controls.Add(pnlAddBookBTN);
            Controls.Add(pnlSearchBTN);
            Controls.Add(pnlBookCaseBTN);
            Controls.Add(pictureBox2);
            Controls.Add(lblDashBoardTitle);
            Controls.Add(pnlReports);
            Controls.Add(pnlBorrowReturn);
            Controls.Add(lblWelcome);
            Controls.Add(pnlManageBooks);
            Controls.Add(pnlManageEmployees);
            Controls.Add(pnlProfile);
            Controls.Add(lblEmployeeName);
            Controls.Add(pnlLogOut);
            Controls.Add(pnlDashBoard);
            Controls.Add(picAvatar);
            Name = "ManageBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test";
            FormClosing += ManageBooks_FormClosing;
            Load += ManageBooks_Load;
            ((System.ComponentModel.ISupportInitialize)picIconReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).EndInit();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            pnlBorrowReturn.ResumeLayout(false);
            pnlBorrowReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).EndInit();
            pnlManageBooks.ResumeLayout(false);
            pnlManageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).EndInit();
            pnlManageEmployees.ResumeLayout(false);
            pnlManageEmployees.PerformLayout();
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).EndInit();
            pnlLogOut.ResumeLayout(false);
            pnlLogOut.PerformLayout();
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picIconReports;
        private Label lblLogOut;
        private PictureBox picIconLogOut;
        private Panel pnlReports;
        private Label lblReports;
        private Panel pnlBorrowReturn;
        private Label lblBorrowReturn;
        private PictureBox picIconBorrowReturn;
        private Label lblWelcome;
        private Panel pnlManageBooks;
        private Label lblManageBooks;
        private PictureBox picIconManageBooks;
        private Label lblManageUsers;
        private PictureBox picIconManageUsers;
        private Panel pnlManageEmployees;
        private Panel pnlProfile;
        private Label lblProfile;
        private PictureBox picIconProfile;
        private Label lblDashBoard;
        private PictureBox picIconDashBoard;
        private Label lblEmployeeName;
        private Panel pnlLogOut;
        private Panel pnlDashBoard;
        private PictureBox picAvatar;
        private Label lblDashBoardTitle;
        private PictureBox pictureBox2;
        private FlowLayoutPanel pnlBookCaseBTN;
        private FlowLayoutPanel pnlSearchBTN;
        private FlowLayoutPanel pnlAddBookBTN;
        private FlowLayoutPanel pnlBookManagerBTN;
    }
}