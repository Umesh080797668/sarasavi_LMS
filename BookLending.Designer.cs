
namespace LibraryManagementSystem
{
    partial class BookLending
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBookLendingTitle = new System.Windows.Forms.Label();
            this.grpBorrowerInfo = new System.Windows.Forms.GroupBox();
            this.lblCurrentBooksValue = new System.Windows.Forms.Label();
            this.lblCurrentBooks = new System.Windows.Forms.Label();
            this.lblBorrowerNameValue = new System.Windows.Forms.Label();
            this.lblBorrowerName = new System.Windows.Forms.Label();
            this.btnSearchBorrower = new System.Windows.Forms.Button();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.lblBorrowerID = new System.Windows.Forms.Label();
            this.grpBooksToLend = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.dgvBooksToLend = new System.Windows.Forms.DataGridView();
            this.AccessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookAccession = new System.Windows.Forms.TextBox();
            this.lblBookAccession = new System.Windows.Forms.Label();
            this.grpLoanDetails = new System.Windows.Forms.GroupBox();
            this.lblTotalBooksValue = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblReturnDateValue = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblLoanDateValue = new System.Windows.Forms.Label();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.btnConfirmLoan = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBorrowerInfo.SuspendLayout();
            this.grpBooksToLend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksToLend)).BeginInit();
            this.grpLoanDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBack.Location = new System.Drawing.Point(20, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBookLendingTitle
            // 
            this.lblBookLendingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookLendingTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookLendingTitle.Location = new System.Drawing.Point(70, 10);
            this.lblBookLendingTitle.Name = "lblBookLendingTitle";
            this.lblBookLendingTitle.Size = new System.Drawing.Size(1060, 50);
            this.lblBookLendingTitle.TabIndex = 0;
            this.lblBookLendingTitle.Text = "Book Lending Process";
            this.lblBookLendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBorrowerInfo
            // 
            this.grpBorrowerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBorrowerInfo.Controls.Add(this.lblCurrentBooksValue);
            this.grpBorrowerInfo.Controls.Add(this.lblCurrentBooks);
            this.grpBorrowerInfo.Controls.Add(this.lblBorrowerNameValue);
            this.grpBorrowerInfo.Controls.Add(this.lblBorrowerName);
            this.grpBorrowerInfo.Controls.Add(this.btnSearchBorrower);
            this.grpBorrowerInfo.Controls.Add(this.txtBorrowerID);
            this.grpBorrowerInfo.Controls.Add(this.lblBorrowerID);
            this.grpBorrowerInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowerInfo.Location = new System.Drawing.Point(20, 70);
            this.grpBorrowerInfo.Name = "grpBorrowerInfo";
            this.grpBorrowerInfo.Size = new System.Drawing.Size(1110, 100);
            this.grpBorrowerInfo.TabIndex = 1;
            this.grpBorrowerInfo.TabStop = false;
            this.grpBorrowerInfo.Text = "Borrower Information";
            // 
            // lblCurrentBooksValue
            // 
            this.lblCurrentBooksValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentBooksValue.AutoSize = true;
            this.lblCurrentBooksValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBooksValue.Location = new System.Drawing.Point(981, 47);
            this.lblCurrentBooksValue.Name = "lblCurrentBooksValue";
            this.lblCurrentBooksValue.Size = new System.Drawing.Size(42, 25);
            this.lblCurrentBooksValue.TabIndex = 8;
            this.lblCurrentBooksValue.Text = "0/5";
            // 
            // lblCurrentBooks
            // 
            this.lblCurrentBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentBooks.AutoSize = true;
            this.lblCurrentBooks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBooks.Location = new System.Drawing.Point(840, 47);
            this.lblCurrentBooks.Name = "lblCurrentBooks";
            this.lblCurrentBooks.Size = new System.Drawing.Size(135, 25);
            this.lblCurrentBooks.TabIndex = 7;
            this.lblCurrentBooks.Text = "Current Books:";
            // 
            // lblBorrowerNameValue
            // 
            this.lblBorrowerNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowerNameValue.AutoSize = true;
            this.lblBorrowerNameValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerNameValue.Location = new System.Drawing.Point(482, 47);
            this.lblBorrowerNameValue.Name = "lblBorrowerNameValue";
            this.lblBorrowerNameValue.Size = new System.Drawing.Size(168, 25);
            this.lblBorrowerNameValue.TabIndex = 6;
            this.lblBorrowerNameValue.Text = "[Borrower Name]";
            // 
            // lblBorrowerName
            // 
            this.lblBorrowerName.AutoSize = true;
            this.lblBorrowerName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerName.Location = new System.Drawing.Point(420, 47);
            this.lblBorrowerName.Name = "lblBorrowerName";
            this.lblBorrowerName.Size = new System.Drawing.Size(66, 25);
            this.lblBorrowerName.TabIndex = 5;
            this.lblBorrowerName.Text = "Name:";
            // 
            // btnSearchBorrower
            // 
            this.btnSearchBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSearchBorrower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBorrower.ForeColor = System.Drawing.Color.White;
            this.btnSearchBorrower.Location = new System.Drawing.Point(305, 35);
            this.btnSearchBorrower.Name = "btnSearchBorrower";
            this.btnSearchBorrower.Size = new System.Drawing.Size(100, 35);
            this.btnSearchBorrower.TabIndex = 4;
            this.btnSearchBorrower.Text = "Search";
            this.btnSearchBorrower.UseVisualStyleBackColor = false;
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowerID.Location = new System.Drawing.Point(143, 44);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(150, 31);
            this.txtBorrowerID.TabIndex = 3;
            // 
            // lblBorrowerID
            // 
            this.lblBorrowerID.AutoSize = true;
            this.lblBorrowerID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerID.Location = new System.Drawing.Point(20, 47);
            this.lblBorrowerID.Name = "lblBorrowerID";
            this.lblBorrowerID.Size = new System.Drawing.Size(117, 25);
            this.lblBorrowerID.TabIndex = 2;
            this.lblBorrowerID.Text = "Borrower ID:";
            // 
            // grpBooksToLend
            // 
            this.grpBooksToLend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBooksToLend.Controls.Add(this.btnRemoveSelected);
            this.grpBooksToLend.Controls.Add(this.dgvBooksToLend);
            this.grpBooksToLend.Controls.Add(this.btnAddBook);
            this.grpBooksToLend.Controls.Add(this.txtBookAccession);
            this.grpBooksToLend.Controls.Add(this.lblBookAccession);
            this.grpBooksToLend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooksToLend.Location = new System.Drawing.Point(20, 180);
            this.grpBooksToLend.Name = "grpBooksToLend";
            this.grpBooksToLend.Size = new System.Drawing.Size(1110, 400);
            this.grpBooksToLend.TabIndex = 2;
            this.grpBooksToLend.TabStop = false;
            this.grpBooksToLend.Text = "Books to Lend";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemoveSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(20, 360);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(204, 35);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            // 
            // dgvBooksToLend
            // 
            this.dgvBooksToLend.AllowUserToAddRows = false;
            this.dgvBooksToLend.AllowUserToDeleteRows = false;
            this.dgvBooksToLend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBooksToLend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooksToLend.BackgroundColor = System.Drawing.Color.White;
            this.dgvBooksToLend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksToLend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessionNumber,
            this.Title,
            this.Author,
            this.Classification,
            this.Status,
            this.Action});
            this.dgvBooksToLend.Location = new System.Drawing.Point(20, 80);
            this.dgvBooksToLend.Name = "dgvBooksToLend";
            this.dgvBooksToLend.ReadOnly = true;
            this.dgvBooksToLend.RowHeadersWidth = 25;
            this.dgvBooksToLend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooksToLend.Size = new System.Drawing.Size(1070, 270);
            this.dgvBooksToLend.TabIndex = 3;
            // 
            // AccessionNumber
            // 
            this.AccessionNumber.FillWeight = 15F;
            this.AccessionNumber.HeaderText = "Accession Number";
            this.AccessionNumber.MinimumWidth = 120;
            this.AccessionNumber.Name = "AccessionNumber";
            this.AccessionNumber.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.FillWeight = 35F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 200;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.FillWeight = 25F;
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 150;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Classification
            // 
            this.Classification.FillWeight = 12F;
            this.Classification.HeaderText = "Classification";
            this.Classification.MinimumWidth = 100;
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 8F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 80;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.FillWeight = 5F;
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 80;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(363, 38);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(100, 31);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            // 
            // txtBookAccession
            // 
            this.txtBookAccession.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAccession.Location = new System.Drawing.Point(209, 40);
            this.txtBookAccession.Name = "txtBookAccession";
            this.txtBookAccession.Size = new System.Drawing.Size(144, 31);
            this.txtBookAccession.TabIndex = 1;
            // 
            // lblBookAccession
            // 
            this.lblBookAccession.AutoSize = true;
            this.lblBookAccession.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAccession.Location = new System.Drawing.Point(20, 43);
            this.lblBookAccession.Name = "lblBookAccession";
            this.lblBookAccession.Size = new System.Drawing.Size(220, 25);
            this.lblBookAccession.TabIndex = 0;
            this.lblBookAccession.Text = "Book Accession Number:";
            // 
            // grpLoanDetails
            // 
            this.grpLoanDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoanDetails.Controls.Add(this.lblTotalBooksValue);
            this.grpLoanDetails.Controls.Add(this.lblTotalBooks);
            this.grpLoanDetails.Controls.Add(this.lblReturnDateValue);
            this.grpLoanDetails.Controls.Add(this.lblReturnDate);
            this.grpLoanDetails.Controls.Add(this.lblLoanDateValue);
            this.grpLoanDetails.Controls.Add(this.lblLoanDate);
            this.grpLoanDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoanDetails.Location = new System.Drawing.Point(20, 590);
            this.grpLoanDetails.Name = "grpLoanDetails";
            this.grpLoanDetails.Size = new System.Drawing.Size(1110, 90);
            this.grpLoanDetails.TabIndex = 3;
            this.grpLoanDetails.TabStop = false;
            this.grpLoanDetails.Text = "Loan Details";
            // 
            // lblTotalBooksValue
            // 
            this.lblTotalBooksValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBooksValue.AutoSize = true;
            this.lblTotalBooksValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooksValue.Location = new System.Drawing.Point(1040, 45);
            this.lblTotalBooksValue.Name = "lblTotalBooksValue";
            this.lblTotalBooksValue.Size = new System.Drawing.Size(23, 25);
            this.lblTotalBooksValue.TabIndex = 5;
            this.lblTotalBooksValue.Text = "0";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooks.Location = new System.Drawing.Point(850, 45);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(179, 25);
            this.lblTotalBooks.TabIndex = 4;
            this.lblTotalBooks.Text = "Total Books to Lend:";
            // 
            // lblReturnDateValue
            // 
            this.lblReturnDateValue.AutoSize = true;
            this.lblReturnDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDateValue.Location = new System.Drawing.Point(420, 45);
            this.lblReturnDateValue.Name = "lblReturnDateValue";
            this.lblReturnDateValue.Size = new System.Drawing.Size(116, 25);
            this.lblReturnDateValue.TabIndex = 3;
            this.lblReturnDateValue.Text = "2025-07-10";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(300, 45);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(115, 25);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblLoanDateValue
            // 
            this.lblLoanDateValue.AutoSize = true;
            this.lblLoanDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDateValue.Location = new System.Drawing.Point(130, 45);
            this.lblLoanDateValue.Name = "lblLoanDateValue";
            this.lblLoanDateValue.Size = new System.Drawing.Size(116, 25);
            this.lblLoanDateValue.TabIndex = 1;
            this.lblLoanDateValue.Text = "2025-07-10";
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDate.Location = new System.Drawing.Point(20, 45);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(101, 25);
            this.lblLoanDate.TabIndex = 0;
            this.lblLoanDate.Text = "Loan Date:";
            // 
            // btnConfirmLoan
            // 
            this.btnConfirmLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmLoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmLoan.ForeColor = System.Drawing.Color.White;
            this.btnConfirmLoan.Location = new System.Drawing.Point(850, 690);
            this.btnConfirmLoan.Name = "btnConfirmLoan";
            this.btnConfirmLoan.Size = new System.Drawing.Size(150, 40);
            this.btnConfirmLoan.TabIndex = 6;
            this.btnConfirmLoan.Text = "CONFIRM LOAN";
            this.btnConfirmLoan.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1010, 690);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // BookLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirmLoan);
            this.Controls.Add(this.grpLoanDetails);
            this.Controls.Add(this.grpBooksToLend);
            this.Controls.Add(this.grpBorrowerInfo);
            this.Controls.Add(this.lblBookLendingTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "BookLending";
            this.Size = new System.Drawing.Size(1150, 750);
            this.grpBorrowerInfo.ResumeLayout(false);
            this.grpBorrowerInfo.PerformLayout();
            this.grpBooksToLend.ResumeLayout(false);
            this.grpBooksToLend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksToLend)).EndInit();
            this.grpLoanDetails.ResumeLayout(false);
            this.grpLoanDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBookLendingTitle;
        private System.Windows.Forms.GroupBox grpBorrowerInfo;
        private System.Windows.Forms.Label lblBorrowerID;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.Button btnSearchBorrower;
        private System.Windows.Forms.Label lblBorrowerName;
        private System.Windows.Forms.Label lblBorrowerNameValue;
        private System.Windows.Forms.Label lblCurrentBooksValue;
        private System.Windows.Forms.Label lblCurrentBooks;
        private System.Windows.Forms.GroupBox grpBooksToLend;
        private System.Windows.Forms.Label lblBookAccession;
        private System.Windows.Forms.TextBox txtBookAccession;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.DataGridView dgvBooksToLend;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.GroupBox grpLoanDetails;
        private System.Windows.Forms.Label lblLoanDateValue;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Label lblReturnDateValue;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblTotalBooksValue;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Button btnConfirmLoan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}
