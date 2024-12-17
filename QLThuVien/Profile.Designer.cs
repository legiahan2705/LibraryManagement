namespace QLThuVien
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            picAvatar = new PictureBox();
            lblWelcome = new Label();
            lblDashBoard = new Label();
            picIconDashBoard = new PictureBox();
            pnlDashBoard = new Panel();
            picIconLogOut = new PictureBox();
            pnlLogOut = new Panel();
            lblLogOut = new Label();
            pnlReports = new Panel();
            lblReports = new Label();
            picIconReports = new PictureBox();
            lblBorrowReturn = new Label();
            picIconBorrowReturn = new PictureBox();
            pnlBorrowReturn = new Panel();
            pnlManageBooks = new Panel();
            lblManageBooks = new Label();
            picIconManageBooks = new PictureBox();
            lblManageUsers = new Label();
            picIconManageUsers = new PictureBox();
            pnlManageUsers = new Panel();
            lblProfile = new Label();
            picIconProfile = new PictureBox();
            pnlProfile = new Panel();
            btnEdit = new Button();
            txtEmployeeID = new TextBox();
            txtSex = new TextBox();
            txtPhoneNo = new TextBox();
            txtDateOfBirth = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtRole = new TextBox();
            lblEmployeeName = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).BeginInit();
            pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).BeginInit();
            pnlLogOut.SuspendLayout();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).BeginInit();
            pnlBorrowReturn.SuspendLayout();
            pnlManageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).BeginInit();
            pnlManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).BeginInit();
            pnlProfile.SuspendLayout();
            SuspendLayout();
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(12, 108);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(127, 113);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblWelcome.ForeColor = Color.DarkSlateBlue;
            lblWelcome.Location = new Point(156, 108);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(147, 38);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome!";
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
            // pnlDashBoard
            // 
            pnlDashBoard.BackColor = Color.Transparent;
            pnlDashBoard.Controls.Add(lblDashBoard);
            pnlDashBoard.Controls.Add(picIconDashBoard);
            pnlDashBoard.Cursor = Cursors.Hand;
            pnlDashBoard.Location = new Point(12, 251);
            pnlDashBoard.Name = "pnlDashBoard";
            pnlDashBoard.Size = new Size(291, 57);
            pnlDashBoard.TabIndex = 3;
            pnlDashBoard.Click += pnlDashBoard_Click;
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
            // 
            // pnlLogOut
            // 
            pnlLogOut.BackColor = Color.Transparent;
            pnlLogOut.Controls.Add(lblLogOut);
            pnlLogOut.Controls.Add(picIconLogOut);
            pnlLogOut.Cursor = Cursors.Hand;
            pnlLogOut.Location = new Point(13, 709);
            pnlLogOut.Name = "pnlLogOut";
            pnlLogOut.Size = new Size(291, 55);
            pnlLogOut.TabIndex = 14;
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
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.Transparent;
            pnlReports.Controls.Add(lblReports);
            pnlReports.Controls.Add(picIconReports);
            pnlReports.Cursor = Cursors.Hand;
            pnlReports.Location = new Point(13, 631);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(291, 55);
            pnlReports.TabIndex = 13;
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
            // 
            // pnlBorrowReturn
            // 
            pnlBorrowReturn.BackColor = Color.Transparent;
            pnlBorrowReturn.Controls.Add(lblBorrowReturn);
            pnlBorrowReturn.Controls.Add(picIconBorrowReturn);
            pnlBorrowReturn.Cursor = Cursors.Hand;
            pnlBorrowReturn.Location = new Point(13, 555);
            pnlBorrowReturn.Name = "pnlBorrowReturn";
            pnlBorrowReturn.Size = new Size(291, 55);
            pnlBorrowReturn.TabIndex = 12;
            // 
            // pnlManageBooks
            // 
            pnlManageBooks.BackColor = Color.Transparent;
            pnlManageBooks.Controls.Add(lblManageBooks);
            pnlManageBooks.Controls.Add(picIconManageBooks);
            pnlManageBooks.Cursor = Cursors.Hand;
            pnlManageBooks.Location = new Point(13, 479);
            pnlManageBooks.Name = "pnlManageBooks";
            pnlManageBooks.Size = new Size(291, 55);
            pnlManageBooks.TabIndex = 11;
            pnlManageBooks.Click += pnlManageBooks_Click;
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
            // 
            // lblManageUsers
            // 
            lblManageUsers.AutoSize = true;
            lblManageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblManageUsers.ForeColor = Color.DarkSlateBlue;
            lblManageUsers.Location = new Point(59, 15);
            lblManageUsers.Name = "lblManageUsers";
            lblManageUsers.Size = new Size(145, 28);
            lblManageUsers.TabIndex = 0;
            lblManageUsers.Text = "Manage Users";
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
            // 
            // pnlManageUsers
            // 
            pnlManageUsers.BackColor = Color.Transparent;
            pnlManageUsers.Controls.Add(lblManageUsers);
            pnlManageUsers.Controls.Add(picIconManageUsers);
            pnlManageUsers.Cursor = Cursors.Hand;
            pnlManageUsers.Location = new Point(13, 404);
            pnlManageUsers.Name = "pnlManageUsers";
            pnlManageUsers.Size = new Size(291, 55);
            pnlManageUsers.TabIndex = 10;
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
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.Transparent;
            pnlProfile.Controls.Add(lblProfile);
            pnlProfile.Controls.Add(picIconProfile);
            pnlProfile.Cursor = Cursors.Hand;
            pnlProfile.Location = new Point(13, 328);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(291, 55);
            pnlProfile.TabIndex = 9;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnEdit.Location = new Point(727, 743);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(167, 48);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmployeeID.Location = new Point(751, 286);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(292, 31);
            txtEmployeeID.TabIndex = 16;
            // 
            // txtSex
            // 
            txtSex.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSex.Location = new Point(751, 381);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(292, 31);
            txtSex.TabIndex = 17;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhoneNo.Location = new Point(751, 428);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(292, 31);
            txtPhoneNo.TabIndex = 18;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtDateOfBirth.Location = new Point(751, 480);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(292, 31);
            txtDateOfBirth.TabIndex = 19;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtAddress.Location = new Point(751, 536);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(292, 31);
            txtAddress.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtEmail.Location = new Point(751, 588);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(292, 31);
            txtEmail.TabIndex = 21;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtRole.Location = new Point(751, 638);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(292, 31);
            txtRole.TabIndex = 22;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.BackColor = Color.Transparent;
            lblEmployeeName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblEmployeeName.ForeColor = Color.DarkSlateBlue;
            lblEmployeeName.Location = new Point(183, 146);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(70, 28);
            lblEmployeeName.TabIndex = 24;
            lblEmployeeName.Text = "label1";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(751, 333);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 31);
            txtName.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPassword.Location = new Point(751, 692);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 31);
            txtPassword.TabIndex = 26;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1246, 863);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(lblEmployeeName);
            Controls.Add(txtRole);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtSex);
            Controls.Add(txtEmployeeID);
            Controls.Add(btnEdit);
            Controls.Add(pnlLogOut);
            Controls.Add(pnlReports);
            Controls.Add(pnlBorrowReturn);
            Controls.Add(pnlManageBooks);
            Controls.Add(pnlManageUsers);
            Controls.Add(pnlProfile);
            Controls.Add(pnlDashBoard);
            Controls.Add(lblWelcome);
            Controls.Add(picAvatar);
            ForeColor = Color.DarkSlateBlue;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            FormClosing += Profile_FormClosing;
            Load += Profile_Load;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconDashBoard).EndInit();
            pnlDashBoard.ResumeLayout(false);
            pnlDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconLogOut).EndInit();
            pnlLogOut.ResumeLayout(false);
            pnlLogOut.PerformLayout();
            pnlReports.ResumeLayout(false);
            pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconBorrowReturn).EndInit();
            pnlBorrowReturn.ResumeLayout(false);
            pnlBorrowReturn.PerformLayout();
            pnlManageBooks.ResumeLayout(false);
            pnlManageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconManageBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picIconManageUsers).EndInit();
            pnlManageUsers.ResumeLayout(false);
            pnlManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIconProfile).EndInit();
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAvatar;
        private Label lblWelcome;
        private Label lblDashBoard;
        private PictureBox picIconDashBoard;
        private Panel pnlDashBoard;
        private PictureBox picIconLogOut;
        private Panel pnlLogOut;
        private Label lblLogOut;
        private Panel pnlReports;
        private Label lblReports;
        private PictureBox picIconReports;
        private Label lblBorrowReturn;
        private PictureBox picIconBorrowReturn;
        private Panel pnlBorrowReturn;
        private Panel pnlManageBooks;
        private Label lblManageBooks;
        private PictureBox picIconManageBooks;
        private Label lblManageUsers;
        private PictureBox picIconManageUsers;
        private Panel pnlManageUsers;
        private Label lblProfile;
        private PictureBox picIconProfile;
        private Panel pnlProfile;
        private Button btnEdit;
        private TextBox txtEmployeeID;
        private TextBox txtSex;
        private TextBox txtPhoneNo;
        private TextBox txtDateOfBirth;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtRole;
        private Label lblEmployeeName;
        private TextBox txtName;
        private TextBox txtPassword;
    }
}