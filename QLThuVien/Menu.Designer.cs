namespace QLThuVien
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pnlLogOutBTN = new Panel();
            pnlReportsBTN = new Panel();
            pnlBorrowReturnBTN = new Panel();
            pnlManageBooksBTN = new Panel();
            pnlManageUsersBTN = new Panel();
            pnlProfileBTN = new Panel();
            lblDashBoardTitle = new Label();
            SuspendLayout();
            // 
            // pnlLogOutBTN
            // 
            pnlLogOutBTN.BackColor = Color.Transparent;
            pnlLogOutBTN.Cursor = Cursors.Hand;
            pnlLogOutBTN.Location = new Point(605, 323);
            pnlLogOutBTN.Name = "pnlLogOutBTN";
            pnlLogOutBTN.Size = new Size(225, 196);
            pnlLogOutBTN.TabIndex = 17;
            // 
            // pnlReportsBTN
            // 
            pnlReportsBTN.BackColor = Color.Transparent;
            pnlReportsBTN.Cursor = Cursors.Hand;
            pnlReportsBTN.Location = new Point(333, 323);
            pnlReportsBTN.Name = "pnlReportsBTN";
            pnlReportsBTN.Size = new Size(225, 196);
            pnlReportsBTN.TabIndex = 13;
            // 
            // pnlBorrowReturnBTN
            // 
            pnlBorrowReturnBTN.BackColor = Color.Transparent;
            pnlBorrowReturnBTN.Cursor = Cursors.Hand;
            pnlBorrowReturnBTN.Location = new Point(64, 323);
            pnlBorrowReturnBTN.Name = "pnlBorrowReturnBTN";
            pnlBorrowReturnBTN.Size = new Size(225, 196);
            pnlBorrowReturnBTN.TabIndex = 16;
            // 
            // pnlManageBooksBTN
            // 
            pnlManageBooksBTN.BackColor = Color.Transparent;
            pnlManageBooksBTN.Cursor = Cursors.Hand;
            pnlManageBooksBTN.Location = new Point(605, 85);
            pnlManageBooksBTN.Name = "pnlManageBooksBTN";
            pnlManageBooksBTN.Size = new Size(225, 196);
            pnlManageBooksBTN.TabIndex = 15;
            // 
            // pnlManageUsersBTN
            // 
            pnlManageUsersBTN.BackColor = Color.Transparent;
            pnlManageUsersBTN.Cursor = Cursors.Hand;
            pnlManageUsersBTN.Location = new Point(333, 85);
            pnlManageUsersBTN.Name = "pnlManageUsersBTN";
            pnlManageUsersBTN.Size = new Size(225, 196);
            pnlManageUsersBTN.TabIndex = 14;
            // 
            // pnlProfileBTN
            // 
            pnlProfileBTN.BackColor = Color.Transparent;
            pnlProfileBTN.Cursor = Cursors.Hand;
            pnlProfileBTN.Location = new Point(64, 85);
            pnlProfileBTN.Name = "pnlProfileBTN";
            pnlProfileBTN.Size = new Size(225, 196);
            pnlProfileBTN.TabIndex = 12;
            // 
            // lblDashBoardTitle
            // 
            lblDashBoardTitle.AutoSize = true;
            lblDashBoardTitle.BackColor = Color.Transparent;
            lblDashBoardTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblDashBoardTitle.ForeColor = Color.DarkSlateBlue;
            lblDashBoardTitle.Location = new Point(247, -56);
            lblDashBoardTitle.Name = "lblDashBoardTitle";
            lblDashBoardTitle.Size = new Size(0, 35);
            lblDashBoardTitle.TabIndex = 11;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(911, 724);
            Controls.Add(pnlLogOutBTN);
            Controls.Add(pnlReportsBTN);
            Controls.Add(pnlBorrowReturnBTN);
            Controls.Add(pnlManageBooksBTN);
            Controls.Add(pnlManageUsersBTN);
            Controls.Add(pnlProfileBTN);
            Controls.Add(lblDashBoardTitle);
            DoubleBuffered = true;
            Name = "Menu";
            ShowIcon = false;
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlLogOutBTN;
        private Panel pnlReportsBTN;
        private Panel pnlBorrowReturnBTN;
        private Panel pnlManageBooksBTN;
        private Panel pnlManageUsersBTN;
        private Panel pnlProfileBTN;
        private Label lblDashBoardTitle;
    }
}