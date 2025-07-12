namespace LibraryManagementSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.picDashboardLogo = new System.Windows.Forms.PictureBox();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.pnlSideNav = new System.Windows.Forms.Panel();
            this.btnUserRegistration = new System.Windows.Forms.Button();
            this.btnBookRegistration = new System.Windows.Forms.Button();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.btnBookReservation = new System.Windows.Forms.Button();
            this.btnBookReturn = new System.Windows.Forms.Button();
            this.btnBookLending = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.tableStats = new System.Windows.Forms.TableLayoutPanel();
            this.panelTotalBooks = new System.Windows.Forms.Panel();
            this.panelTotalBooksOverlay = new System.Windows.Forms.Panel();
            this.lblTotalBooksNumber = new System.Windows.Forms.Label();
            this.lblTotalBooksText = new System.Windows.Forms.Label();
            this.panelAvailableBooks = new System.Windows.Forms.Panel();
            this.panelAvailableBooksOverlay = new System.Windows.Forms.Panel();
            this.lblAvailableBooksNumber = new System.Windows.Forms.Label();
            this.lblAvailableBooksText = new System.Windows.Forms.Label();
            this.panelBorrowedBooks = new System.Windows.Forms.Panel();
            this.panelBorrowedBooksOverlay = new System.Windows.Forms.Panel();
            this.lblBorrowedBooksNumber = new System.Windows.Forms.Label();
            this.lblBorrowedBooksText = new System.Windows.Forms.Label();
            this.panelTotalMembers = new System.Windows.Forms.Panel();
            this.panelTotalMembersOverlay = new System.Windows.Forms.Panel();
            this.lblTotalMembersNumber = new System.Windows.Forms.Label();
            this.lblTotalMembersText = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlTopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDashboardLogo)).BeginInit();
            this.pnlSideNav.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.tableStats.SuspendLayout();
            this.panelTotalBooks.SuspendLayout();
            this.panelTotalBooksOverlay.SuspendLayout();
            this.panelAvailableBooks.SuspendLayout();
            this.panelAvailableBooksOverlay.SuspendLayout();
            this.panelBorrowedBooks.SuspendLayout();
            this.panelBorrowedBooksOverlay.SuspendLayout();
            this.panelTotalMembers.SuspendLayout();
            this.panelTotalMembersOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Controls.Add(this.btnLogout);
            this.pnlTopMenu.Controls.Add(this.lblUserInfo);
            this.pnlTopMenu.Controls.Add(this.lblDateTime);
            this.pnlTopMenu.Controls.Add(this.picDashboardLogo);
            this.pnlTopMenu.Controls.Add(this.lblSystemTitle);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1036, 65);
            this.pnlTopMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(942, 17);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 31);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.Location = new System.Drawing.Point(788, 20);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(150, 24);
            this.lblUserInfo.TabIndex = 2;
            this.lblUserInfo.Text = "Welcome, Librarian";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(574, 21);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(208, 24);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "December 15, 2024 - 2:30 PM";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picDashboardLogo
            // 
            this.picDashboardLogo.Image = ((System.Drawing.Image)(resources.GetObject("picDashboardLogo.Image")));
            this.picDashboardLogo.Location = new System.Drawing.Point(14, 8);
            this.picDashboardLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picDashboardLogo.Name = "picDashboardLogo";
            this.picDashboardLogo.Size = new System.Drawing.Size(45, 49);
            this.picDashboardLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDashboardLogo.TabIndex = 1;
            this.picDashboardLogo.TabStop = false;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.ForeColor = System.Drawing.Color.White;
            this.lblSystemTitle.Location = new System.Drawing.Point(58, 11);
            this.lblSystemTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(410, 41);
            this.lblSystemTitle.TabIndex = 0;
            this.lblSystemTitle.Text = "Sarasavi Library Management System";
            this.lblSystemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSideNav
            // 
            this.pnlSideNav.Controls.Add(this.btnUserRegistration);
            this.pnlSideNav.Controls.Add(this.btnBookRegistration);
            this.pnlSideNav.Controls.Add(this.btnInquiry);
            this.pnlSideNav.Controls.Add(this.btnBookReservation);
            this.pnlSideNav.Controls.Add(this.btnBookReturn);
            this.pnlSideNav.Controls.Add(this.btnBookLending);
            this.pnlSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideNav.Location = new System.Drawing.Point(0, 65);
            this.pnlSideNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideNav.Name = "pnlSideNav";
            this.pnlSideNav.Size = new System.Drawing.Size(262, 628);
            this.pnlSideNav.TabIndex = 4;
            // 
            // btnUserRegistration
            // 
            this.btnUserRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegistration.ForeColor = System.Drawing.Color.White;
            this.btnUserRegistration.Location = new System.Drawing.Point(8, 301);
            this.btnUserRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserRegistration.Name = "btnUserRegistration";
            this.btnUserRegistration.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUserRegistration.Size = new System.Drawing.Size(248, 49);
            this.btnUserRegistration.TabIndex = 10;
            this.btnUserRegistration.Text = "👤 User Registration";
            this.btnUserRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRegistration.UseVisualStyleBackColor = true;
            // 
            // btnBookRegistration
            // 
            this.btnBookRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRegistration.ForeColor = System.Drawing.Color.White;
            this.btnBookRegistration.Location = new System.Drawing.Point(8, 244);
            this.btnBookRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookRegistration.Name = "btnBookRegistration";
            this.btnBookRegistration.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookRegistration.Size = new System.Drawing.Size(248, 49);
            this.btnBookRegistration.TabIndex = 9;
            this.btnBookRegistration.Text = "📝 Book Registration";
            this.btnBookRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookRegistration.UseVisualStyleBackColor = true;
            // 
            // btnInquiry
            // 
            this.btnInquiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInquiry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.ForeColor = System.Drawing.Color.White;
            this.btnInquiry.Location = new System.Drawing.Point(8, 187);
            this.btnInquiry.Margin = new System.Windows.Forms.Padding(2);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInquiry.Size = new System.Drawing.Size(248, 49);
            this.btnInquiry.TabIndex = 8;
            this.btnInquiry.Text = "🔍 Inquiry Management";
            this.btnInquiry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInquiry.UseVisualStyleBackColor = true;
            // 
            // btnBookReservation
            // 
            this.btnBookReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReservation.ForeColor = System.Drawing.Color.White;
            this.btnBookReservation.Location = new System.Drawing.Point(8, 130);
            this.btnBookReservation.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookReservation.Name = "btnBookReservation";
            this.btnBookReservation.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookReservation.Size = new System.Drawing.Size(248, 49);
            this.btnBookReservation.TabIndex = 7;
            this.btnBookReservation.Text = "📋 Book Reservation";
            this.btnBookReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReservation.UseVisualStyleBackColor = true;
            // 
            // btnBookReturn
            // 
            this.btnBookReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookReturn.ForeColor = System.Drawing.Color.White;
            this.btnBookReturn.Location = new System.Drawing.Point(8, 73);
            this.btnBookReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookReturn.Name = "btnBookReturn";
            this.btnBookReturn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookReturn.Size = new System.Drawing.Size(248, 49);
            this.btnBookReturn.TabIndex = 6;
            this.btnBookReturn.Text = "📖 Book Return";
            this.btnBookReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookReturn.UseVisualStyleBackColor = true;
            // 
            // btnBookLending
            // 
            this.btnBookLending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookLending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookLending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookLending.ForeColor = System.Drawing.Color.White;
            this.btnBookLending.Location = new System.Drawing.Point(8, 16);
            this.btnBookLending.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookLending.Name = "btnBookLending";
            this.btnBookLending.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBookLending.Size = new System.Drawing.Size(248, 49);
            this.btnBookLending.TabIndex = 5;
            this.btnBookLending.Text = "📚 Book Lending";
            this.btnBookLending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookLending.UseVisualStyleBackColor = true;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pnlStats);
            this.pnlMainContent.Controls.Add(this.lblWelcome);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(262, 65);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(774, 628);
            this.pnlMainContent.TabIndex = 5;
            // 
            // pnlStats
            // 
            this.pnlStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.Add(this.tableStats);
            this.pnlStats.Location = new System.Drawing.Point(19, 81);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(736, 528);
            this.pnlStats.TabIndex = 1;
            // 
            // tableStats
            // 
            this.tableStats.ColumnCount = 2;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.Controls.Add(this.panelTotalBooks, 0, 0);
            this.tableStats.Controls.Add(this.panelAvailableBooks, 1, 0);
            this.tableStats.Controls.Add(this.panelBorrowedBooks, 0, 1);
            this.tableStats.Controls.Add(this.panelTotalMembers, 1, 1);
            this.tableStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableStats.Location = new System.Drawing.Point(0, 0);
            this.tableStats.Margin = new System.Windows.Forms.Padding(0);
            this.tableStats.Name = "tableStats";
            this.tableStats.Padding = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.tableStats.RowCount = 2;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.Size = new System.Drawing.Size(734, 526);
            this.tableStats.TabIndex = 0;
            // 
            // panelTotalBooks
            // 
            this.panelTotalBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTotalBooks.BackgroundImage")));
            this.panelTotalBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalBooks.Controls.Add(this.panelTotalBooksOverlay);
            this.panelTotalBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalBooks.Location = new System.Drawing.Point(32, 34);
            this.panelTotalBooks.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotalBooks.Name = "panelTotalBooks";
            this.panelTotalBooks.Size = new System.Drawing.Size(333, 227);
            this.panelTotalBooks.TabIndex = 0;
            // 
            // panelTotalBooksOverlay
            // 
            this.panelTotalBooksOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTotalBooksOverlay.Controls.Add(this.lblTotalBooksNumber);
            this.panelTotalBooksOverlay.Controls.Add(this.lblTotalBooksText);
            this.panelTotalBooksOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalBooksOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelTotalBooksOverlay.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotalBooksOverlay.Name = "panelTotalBooksOverlay";
            this.panelTotalBooksOverlay.Size = new System.Drawing.Size(333, 227);
            this.panelTotalBooksOverlay.TabIndex = 2;
            // 
            // lblTotalBooksNumber
            // 
            this.lblTotalBooksNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBooksNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBooksNumber.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksNumber.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalBooksNumber.Location = new System.Drawing.Point(0, 76);
            this.lblTotalBooksNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBooksNumber.Name = "lblTotalBooksNumber";
            this.lblTotalBooksNumber.Size = new System.Drawing.Size(333, 80);
            this.lblTotalBooksNumber.TabIndex = 0;
            this.lblTotalBooksNumber.Text = "1,247";
            this.lblTotalBooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBooksText
            // 
            this.lblTotalBooksText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBooksText.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalBooksText.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooksText.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalBooksText.Location = new System.Drawing.Point(0, 110);
            this.lblTotalBooksText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBooksText.Name = "lblTotalBooksText";
            this.lblTotalBooksText.Size = new System.Drawing.Size(333, 117);
            this.lblTotalBooksText.TabIndex = 1;
            this.lblTotalBooksText.Text = "Total Books";
            this.lblTotalBooksText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAvailableBooks
            // 
            this.panelAvailableBooks.BackColor = System.Drawing.Color.LightBlue;
            this.panelAvailableBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAvailableBooks.BackgroundImage")));
            this.panelAvailableBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAvailableBooks.Controls.Add(this.panelAvailableBooksOverlay);
            this.panelAvailableBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvailableBooks.Location = new System.Drawing.Point(369, 34);
            this.panelAvailableBooks.Margin = new System.Windows.Forms.Padding(2);
            this.panelAvailableBooks.Name = "panelAvailableBooks";
            this.panelAvailableBooks.Size = new System.Drawing.Size(333, 227);
            this.panelAvailableBooks.TabIndex = 1;
            // 
            // panelAvailableBooksOverlay
            // 
            this.panelAvailableBooksOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelAvailableBooksOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAvailableBooksOverlay.Controls.Add(this.lblAvailableBooksNumber);
            this.panelAvailableBooksOverlay.Controls.Add(this.lblAvailableBooksText);
            this.panelAvailableBooksOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAvailableBooksOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelAvailableBooksOverlay.Margin = new System.Windows.Forms.Padding(2);
            this.panelAvailableBooksOverlay.Name = "panelAvailableBooksOverlay";
            this.panelAvailableBooksOverlay.Size = new System.Drawing.Size(333, 227);
            this.panelAvailableBooksOverlay.TabIndex = 2;
            // 
            // lblAvailableBooksNumber
            // 
            this.lblAvailableBooksNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableBooksNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableBooksNumber.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBooksNumber.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAvailableBooksNumber.Location = new System.Drawing.Point(0, 76);
            this.lblAvailableBooksNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableBooksNumber.Name = "lblAvailableBooksNumber";
            this.lblAvailableBooksNumber.Size = new System.Drawing.Size(333, 80);
            this.lblAvailableBooksNumber.TabIndex = 0;
            this.lblAvailableBooksNumber.Text = "892";
            this.lblAvailableBooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableBooksText
            // 
            this.lblAvailableBooksText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableBooksText.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableBooksText.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBooksText.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblAvailableBooksText.Location = new System.Drawing.Point(0, 110);
            this.lblAvailableBooksText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableBooksText.Name = "lblAvailableBooksText";
            this.lblAvailableBooksText.Size = new System.Drawing.Size(333, 117);
            this.lblAvailableBooksText.TabIndex = 1;
            this.lblAvailableBooksText.Text = "Available Books";
            this.lblAvailableBooksText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBorrowedBooks
            // 
            this.panelBorrowedBooks.BackColor = System.Drawing.Color.LightCoral;
            this.panelBorrowedBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBorrowedBooks.BackgroundImage")));
            this.panelBorrowedBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBorrowedBooks.Controls.Add(this.panelBorrowedBooksOverlay);
            this.panelBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorrowedBooks.Location = new System.Drawing.Point(32, 265);
            this.panelBorrowedBooks.Margin = new System.Windows.Forms.Padding(2);
            this.panelBorrowedBooks.Name = "panelBorrowedBooks";
            this.panelBorrowedBooks.Size = new System.Drawing.Size(333, 227);
            this.panelBorrowedBooks.TabIndex = 2;
            // 
            // panelBorrowedBooksOverlay
            // 
            this.panelBorrowedBooksOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBorrowedBooksOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBorrowedBooksOverlay.Controls.Add(this.lblBorrowedBooksNumber);
            this.panelBorrowedBooksOverlay.Controls.Add(this.lblBorrowedBooksText);
            this.panelBorrowedBooksOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorrowedBooksOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelBorrowedBooksOverlay.Margin = new System.Windows.Forms.Padding(2);
            this.panelBorrowedBooksOverlay.Name = "panelBorrowedBooksOverlay";
            this.panelBorrowedBooksOverlay.Size = new System.Drawing.Size(333, 227);
            this.panelBorrowedBooksOverlay.TabIndex = 2;
            // 
            // lblBorrowedBooksNumber
            // 
            this.lblBorrowedBooksNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowedBooksNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowedBooksNumber.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblBorrowedBooksNumber.ForeColor = System.Drawing.Color.Orange;
            this.lblBorrowedBooksNumber.Location = new System.Drawing.Point(0, 76);
            this.lblBorrowedBooksNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrowedBooksNumber.Name = "lblBorrowedBooksNumber";
            this.lblBorrowedBooksNumber.Size = new System.Drawing.Size(333, 80);
            this.lblBorrowedBooksNumber.TabIndex = 0;
            this.lblBorrowedBooksNumber.Text = "355";
            this.lblBorrowedBooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowedBooksText
            // 
            this.lblBorrowedBooksText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowedBooksText.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowedBooksText.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedBooksText.ForeColor = System.Drawing.Color.Orange;
            this.lblBorrowedBooksText.Location = new System.Drawing.Point(0, 110);
            this.lblBorrowedBooksText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorrowedBooksText.Name = "lblBorrowedBooksText";
            this.lblBorrowedBooksText.Size = new System.Drawing.Size(333, 117);
            this.lblBorrowedBooksText.TabIndex = 1;
            this.lblBorrowedBooksText.Text = "Borrowed Books";
            this.lblBorrowedBooksText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTotalMembers
            // 
            this.panelTotalMembers.BackColor = System.Drawing.Color.LightGreen;
            this.panelTotalMembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTotalMembers.BackgroundImage")));
            this.panelTotalMembers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalMembers.Controls.Add(this.panelTotalMembersOverlay);
            this.panelTotalMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalMembers.Location = new System.Drawing.Point(369, 265);
            this.panelTotalMembers.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotalMembers.Name = "panelTotalMembers";
            this.panelTotalMembers.Size = new System.Drawing.Size(333, 227);
            this.panelTotalMembers.TabIndex = 3;
            // 
            // panelTotalMembersOverlay
            // 
            this.panelTotalMembersOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelTotalMembersOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTotalMembersOverlay.Controls.Add(this.lblTotalMembersNumber);
            this.panelTotalMembersOverlay.Controls.Add(this.lblTotalMembersText);
            this.panelTotalMembersOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalMembersOverlay.Location = new System.Drawing.Point(0, 0);
            this.panelTotalMembersOverlay.Margin = new System.Windows.Forms.Padding(2);
            this.panelTotalMembersOverlay.Name = "panelTotalMembersOverlay";
            this.panelTotalMembersOverlay.Size = new System.Drawing.Size(333, 227);
            this.panelTotalMembersOverlay.TabIndex = 2;
            // 
            // lblTotalMembersNumber
            // 
            this.lblTotalMembersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMembersNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMembersNumber.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalMembersNumber.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalMembersNumber.Location = new System.Drawing.Point(0, 76);
            this.lblTotalMembersNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMembersNumber.Name = "lblTotalMembersNumber";
            this.lblTotalMembersNumber.Size = new System.Drawing.Size(333, 80);
            this.lblTotalMembersNumber.TabIndex = 0;
            this.lblTotalMembersNumber.Text = "486";
            this.lblTotalMembersNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMembersText
            // 
            this.lblTotalMembersText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMembersText.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMembersText.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembersText.ForeColor = System.Drawing.Color.Cyan;
            this.lblTotalMembersText.Location = new System.Drawing.Point(0, 110);
            this.lblTotalMembersText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMembersText.Name = "lblTotalMembersText";
            this.lblTotalMembersText.Size = new System.Drawing.Size(333, 117);
            this.lblTotalMembersText.TabIndex = 1;
            this.lblTotalMembersText.Text = "Total Members";
            this.lblTotalMembersText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(19, 16);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(735, 49);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Sarasavi Library Management System";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 693);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSideNav);
            this.Controls.Add(this.pnlTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sarasavi Library - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDashboardLogo)).EndInit();
            this.pnlSideNav.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.tableStats.ResumeLayout(false);
            this.panelTotalBooks.ResumeLayout(false);
            this.panelTotalBooksOverlay.ResumeLayout(false);
            this.panelAvailableBooks.ResumeLayout(false);
            this.panelAvailableBooksOverlay.ResumeLayout(false);
            this.panelBorrowedBooks.ResumeLayout(false);
            this.panelBorrowedBooksOverlay.ResumeLayout(false);
            this.panelTotalMembers.ResumeLayout(false);
            this.panelTotalMembersOverlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.PictureBox picDashboardLogo;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlSideNav;
        private System.Windows.Forms.Button btnBookLending;
        private System.Windows.Forms.Button btnBookReturn;
        private System.Windows.Forms.Button btnBookReservation;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnBookRegistration;
        private System.Windows.Forms.Button btnUserRegistration;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.TableLayoutPanel tableStats;
        private System.Windows.Forms.Panel panelTotalBooks;
        private System.Windows.Forms.Panel panelTotalBooksOverlay;
        private System.Windows.Forms.Label lblTotalBooksNumber;
        private System.Windows.Forms.Label lblTotalBooksText;
        private System.Windows.Forms.Panel panelAvailableBooks;
        private System.Windows.Forms.Panel panelAvailableBooksOverlay;
        private System.Windows.Forms.Label lblAvailableBooksNumber;
        private System.Windows.Forms.Label lblAvailableBooksText;
        private System.Windows.Forms.Panel panelBorrowedBooks;
        private System.Windows.Forms.Panel panelBorrowedBooksOverlay;
        private System.Windows.Forms.Label lblBorrowedBooksNumber;
        private System.Windows.Forms.Label lblBorrowedBooksText;
        private System.Windows.Forms.Panel panelTotalMembers;
        private System.Windows.Forms.Panel panelTotalMembersOverlay;
        private System.Windows.Forms.Label lblTotalMembersNumber;
        private System.Windows.Forms.Label lblTotalMembersText;
    }
}