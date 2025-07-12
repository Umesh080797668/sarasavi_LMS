
namespace LibraryManagementSystem
{
    partial class pnlInquiryManagement
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
            this.lblInquiryTitle = new System.Windows.Forms.Label();
            this.grpSearchOptions = new System.Windows.Forms.GroupBox();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.rbISBN = new System.Windows.Forms.RadioButton();
            this.rbAuthor = new System.Windows.Forms.RadioButton();
            this.rbTitle = new System.Windows.Forms.RadioButton();
            this.rbAccessionNumber = new System.Windows.Forms.RadioButton();
            this.grpSearchResults = new System.Windows.Forms.GroupBox();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.AccessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBookDetailsInquiry = new System.Windows.Forms.GroupBox();
            this.pnlSelectedBookInfo = new System.Windows.Forms.Panel();
            this.lblPublisherInfo = new System.Windows.Forms.Label();
            this.lblReservedCopies = new System.Windows.Forms.Label();
            this.lblBorrowedCopies = new System.Windows.Forms.Label();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.lblTotalCopies = new System.Windows.Forms.Label();
            this.lblAuthorInquiry = new System.Windows.Forms.Label();
            this.lblBookTitleInquiry = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintDetails = new System.Windows.Forms.Button();
            this.btnExportResults = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpSearchOptions.SuspendLayout();
            this.grpSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.grpBookDetailsInquiry.SuspendLayout();
            this.pnlSelectedBookInfo.SuspendLayout();
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
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInquiryTitle
            // 
            this.lblInquiryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInquiryTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInquiryTitle.Location = new System.Drawing.Point(70, 10);
            this.lblInquiryTitle.Name = "lblInquiryTitle";
            this.lblInquiryTitle.Size = new System.Drawing.Size(1060, 50);
            this.lblInquiryTitle.TabIndex = 0;
            this.lblInquiryTitle.Text = "Inquiry Management";
            this.lblInquiryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSearchOptions
            // 
            this.grpSearchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearchOptions.Controls.Add(this.btnClearSearch);
            this.grpSearchOptions.Controls.Add(this.btnSearch);
            this.grpSearchOptions.Controls.Add(this.txtSearchInput);
            this.grpSearchOptions.Controls.Add(this.rbISBN);
            this.grpSearchOptions.Controls.Add(this.rbAuthor);
            this.grpSearchOptions.Controls.Add(this.rbTitle);
            this.grpSearchOptions.Controls.Add(this.rbAccessionNumber);
            this.grpSearchOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchOptions.Location = new System.Drawing.Point(20, 56);
            this.grpSearchOptions.Name = "grpSearchOptions";
            this.grpSearchOptions.Size = new System.Drawing.Size(1110, 115);
            this.grpSearchOptions.TabIndex = 1;
            this.grpSearchOptions.TabStop = false;
            this.grpSearchOptions.Text = "Search Options";
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInput.Location = new System.Drawing.Point(50, 74);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(400, 31);
            this.txtSearchInput.TabIndex = 4;
            // 
            // rbISBN
            // 
            this.rbISBN.AutoSize = true;
            this.rbISBN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbISBN.Location = new System.Drawing.Point(670, 34);
            this.rbISBN.Name = "rbISBN";
            this.rbISBN.Size = new System.Drawing.Size(73, 29);
            this.rbISBN.TabIndex = 3;
            this.rbISBN.Text = "ISBN";
            this.rbISBN.UseVisualStyleBackColor = true;
            // 
            // rbAuthor
            // 
            this.rbAuthor.AutoSize = true;
            this.rbAuthor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAuthor.Location = new System.Drawing.Point(490, 34);
            this.rbAuthor.Name = "rbAuthor";
            this.rbAuthor.Size = new System.Drawing.Size(146, 29);
            this.rbAuthor.TabIndex = 2;
            this.rbAuthor.Text = "Author Name";
            this.rbAuthor.UseVisualStyleBackColor = true;
            // 
            // rbTitle
            // 
            this.rbTitle.AutoSize = true;
            this.rbTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitle.Location = new System.Drawing.Point(280, 34);
            this.rbTitle.Name = "rbTitle";
            this.rbTitle.Size = new System.Drawing.Size(176, 29);
            this.rbTitle.TabIndex = 1;
            this.rbTitle.Text = "Title (Partial/Full)";
            this.rbTitle.UseVisualStyleBackColor = true;
            // 
            // rbAccessionNumber
            // 
            this.rbAccessionNumber.AutoSize = true;
            this.rbAccessionNumber.Checked = true;
            this.rbAccessionNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAccessionNumber.Location = new System.Drawing.Point(50, 34);
            this.rbAccessionNumber.Name = "rbAccessionNumber";
            this.rbAccessionNumber.Size = new System.Drawing.Size(190, 29);
            this.rbAccessionNumber.TabIndex = 0;
            this.rbAccessionNumber.TabStop = true;
            this.rbAccessionNumber.Text = "Accession Number";
            this.rbAccessionNumber.UseVisualStyleBackColor = true;
            // 
            // grpSearchResults
            // 
            this.grpSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearchResults.Controls.Add(this.dgvSearchResults);
            this.grpSearchResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchResults.Location = new System.Drawing.Point(20, 172);
            this.grpSearchResults.Name = "grpSearchResults";
            this.grpSearchResults.Size = new System.Drawing.Size(1110, 289);
            this.grpSearchResults.TabIndex = 7;
            this.grpSearchResults.TabStop = false;
            this.grpSearchResults.Text = "Search Results";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSearchResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessionNumber,
            this.Title,
            this.Author,
            this.Classification,
            this.Status,
            this.Borrower,
            this.DueDate});
            this.dgvSearchResults.Location = new System.Drawing.Point(20, 30);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(1070, 241);
            this.dgvSearchResults.TabIndex = 0;
            // 
            // AccessionNumber
            // 
            this.AccessionNumber.HeaderText = "Accession Number";
            this.AccessionNumber.MinimumWidth = 6;
            this.AccessionNumber.Name = "AccessionNumber";
            this.AccessionNumber.ReadOnly = true;
            this.AccessionNumber.Width = 120;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 250;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 180;
            // 
            // Classification
            // 
            this.Classification.HeaderText = "Classification";
            this.Classification.MinimumWidth = 6;
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Borrower
            // 
            this.Borrower.HeaderText = "Borrower";
            this.Borrower.MinimumWidth = 6;
            this.Borrower.Name = "Borrower";
            this.Borrower.ReadOnly = true;
            this.Borrower.Width = 120;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 125;
            // 
            // grpBookDetailsInquiry
            // 
            this.grpBookDetailsInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBookDetailsInquiry.Controls.Add(this.pnlSelectedBookInfo);
            this.grpBookDetailsInquiry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookDetailsInquiry.Location = new System.Drawing.Point(20, 464);
            this.grpBookDetailsInquiry.Name = "grpBookDetailsInquiry";
            this.grpBookDetailsInquiry.Size = new System.Drawing.Size(1110, 180);
            this.grpBookDetailsInquiry.TabIndex = 7;
            this.grpBookDetailsInquiry.TabStop = false;
            this.grpBookDetailsInquiry.Text = "Book Details";
            // 
            // pnlSelectedBookInfo
            // 
            this.pnlSelectedBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectedBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedBookInfo.Controls.Add(this.lblPublisherInfo);
            this.pnlSelectedBookInfo.Controls.Add(this.lblReservedCopies);
            this.pnlSelectedBookInfo.Controls.Add(this.lblBorrowedCopies);
            this.pnlSelectedBookInfo.Controls.Add(this.lblAvailableCopies);
            this.pnlSelectedBookInfo.Controls.Add(this.lblTotalCopies);
            this.pnlSelectedBookInfo.Controls.Add(this.lblAuthorInquiry);
            this.pnlSelectedBookInfo.Controls.Add(this.lblBookTitleInquiry);
            this.pnlSelectedBookInfo.Location = new System.Drawing.Point(20, 30);
            this.pnlSelectedBookInfo.Name = "pnlSelectedBookInfo";
            this.pnlSelectedBookInfo.Size = new System.Drawing.Size(1070, 130);
            this.pnlSelectedBookInfo.TabIndex = 0;
            // 
            // lblPublisherInfo
            // 
            this.lblPublisherInfo.AutoSize = true;
            this.lblPublisherInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherInfo.Location = new System.Drawing.Point(20, 80);
            this.lblPublisherInfo.Name = "lblPublisherInfo";
            this.lblPublisherInfo.Size = new System.Drawing.Size(95, 25);
            this.lblPublisherInfo.TabIndex = 6;
            this.lblPublisherInfo.Text = "Publisher:";
            // 
            // lblReservedCopies
            // 
            this.lblReservedCopies.AutoSize = true;
            this.lblReservedCopies.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservedCopies.Location = new System.Drawing.Point(729, 50);
            this.lblReservedCopies.Name = "lblReservedCopies";
            this.lblReservedCopies.Size = new System.Drawing.Size(91, 25);
            this.lblReservedCopies.TabIndex = 5;
            this.lblReservedCopies.Text = "Reserved:";
            // 
            // lblBorrowedCopies
            // 
            this.lblBorrowedCopies.AutoSize = true;
            this.lblBorrowedCopies.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedCopies.Location = new System.Drawing.Point(433, 80);
            this.lblBorrowedCopies.Name = "lblBorrowedCopies";
            this.lblBorrowedCopies.Size = new System.Drawing.Size(98, 25);
            this.lblBorrowedCopies.TabIndex = 4;
            this.lblBorrowedCopies.Text = "Borrowed:";
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.AutoSize = true;
            this.lblAvailableCopies.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCopies.Location = new System.Drawing.Point(433, 50);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(93, 25);
            this.lblAvailableCopies.TabIndex = 3;
            this.lblAvailableCopies.Text = "Available:";
            // 
            // lblTotalCopies
            // 
            this.lblTotalCopies.AutoSize = true;
            this.lblTotalCopies.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCopies.Location = new System.Drawing.Point(433, 20);
            this.lblTotalCopies.Name = "lblTotalCopies";
            this.lblTotalCopies.Size = new System.Drawing.Size(118, 25);
            this.lblTotalCopies.TabIndex = 2;
            this.lblTotalCopies.Text = "Total Copies:";
            // 
            // lblAuthorInquiry
            // 
            this.lblAuthorInquiry.AutoSize = true;
            this.lblAuthorInquiry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorInquiry.Location = new System.Drawing.Point(20, 50);
            this.lblAuthorInquiry.Name = "lblAuthorInquiry";
            this.lblAuthorInquiry.Size = new System.Drawing.Size(74, 25);
            this.lblAuthorInquiry.TabIndex = 1;
            this.lblAuthorInquiry.Text = "Author:";
            // 
            // lblBookTitleInquiry
            // 
            this.lblBookTitleInquiry.AutoSize = true;
            this.lblBookTitleInquiry.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleInquiry.Location = new System.Drawing.Point(20, 20);
            this.lblBookTitleInquiry.Name = "lblBookTitleInquiry";
            this.lblBookTitleInquiry.Size = new System.Drawing.Size(324, 25);
            this.lblBookTitleInquiry.TabIndex = 0;
            this.lblBookTitleInquiry.Text = "Title: [Select a book to view details]";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(470, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPrintDetails
            // 
            this.btnPrintDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDetails.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDetails.ForeColor = System.Drawing.Color.White;
            this.btnPrintDetails.Location = new System.Drawing.Point(883, 700);
            this.btnPrintDetails.Name = "btnPrintDetails";
            this.btnPrintDetails.Size = new System.Drawing.Size(120, 42);
            this.btnPrintDetails.TabIndex = 9;
            this.btnPrintDetails.Text = "PRINT";
            this.btnPrintDetails.UseVisualStyleBackColor = true;
            // 
            // btnExportResults
            // 
            this.btnExportResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportResults.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportResults.ForeColor = System.Drawing.Color.White;
            this.btnExportResults.Location = new System.Drawing.Point(694, 700);
            this.btnExportResults.Name = "btnExportResults";
            this.btnExportResults.Size = new System.Drawing.Size(182, 42);
            this.btnExportResults.TabIndex = 8;
            this.btnExportResults.Text = "EXPORT RESULTS";
            this.btnExportResults.UseVisualStyleBackColor = true;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(576, 70);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(80, 36);
            this.btnClearSearch.TabIndex = 6;
            this.btnClearSearch.Text = "CLEAR";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1010, 700);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 42);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pnlInquiryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrintDetails);
            this.Controls.Add(this.btnExportResults);
            this.Controls.Add(this.grpBookDetailsInquiry);
            this.Controls.Add(this.grpSearchResults);
            this.Controls.Add(this.grpSearchOptions);
            this.Controls.Add(this.lblInquiryTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "pnlInquiryManagement";
            this.Size = new System.Drawing.Size(1150, 760);
            this.grpSearchOptions.ResumeLayout(false);
            this.grpSearchOptions.PerformLayout();
            this.grpSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.grpBookDetailsInquiry.ResumeLayout(false);
            this.pnlSelectedBookInfo.ResumeLayout(false);
            this.pnlSelectedBookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInquiryTitle;
        private System.Windows.Forms.GroupBox grpSearchOptions;
        private System.Windows.Forms.RadioButton rbAccessionNumber;
        private System.Windows.Forms.RadioButton rbTitle;
        private System.Windows.Forms.RadioButton rbAuthor;
        private System.Windows.Forms.RadioButton rbISBN;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.GroupBox grpSearchResults;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.GroupBox grpBookDetailsInquiry;
        private System.Windows.Forms.Panel pnlSelectedBookInfo;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.Label lblTotalCopies;
        private System.Windows.Forms.Label lblAuthorInquiry;
        private System.Windows.Forms.Label lblBookTitleInquiry;
        private System.Windows.Forms.Label lblBorrowedCopies;
        private System.Windows.Forms.Label lblReservedCopies;
        private System.Windows.Forms.Label lblPublisherInfo;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrintDetails;
        private System.Windows.Forms.Button btnExportResults;
        private System.Windows.Forms.Button btnClear;
    }
}
