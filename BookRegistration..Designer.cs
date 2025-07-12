
namespace LibraryManagementSystem
{
    partial class pnlBookRegistration
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
            this.lblBookRegistrationTitle = new System.Windows.Forms.Label();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblClassification = new System.Windows.Forms.Label();
            this.cmbClassification = new System.Windows.Forms.ComboBox();
            this.lblBookNumberAuto = new System.Windows.Forms.Label();
            this.lblBookTitleReg = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblAuthorReg = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblPublicationYear = new System.Windows.Forms.Label();
            this.txtPublicationYear = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.grpCopyDetails = new System.Windows.Forms.GroupBox();
            this.lblNumberOfCopies = new System.Windows.Forms.Label();
            this.nudNumberOfCopies = new System.Windows.Forms.NumericUpDown();
            this.lblCopyType = new System.Windows.Forms.Label();
            this.rbBorrowable = new System.Windows.Forms.RadioButton();
            this.rbReferenceOnly = new System.Windows.Forms.RadioButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.dgvCopyPreview = new System.Windows.Forms.DataGridView();
            this.CopyNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRegistrationActions = new System.Windows.Forms.GroupBox();
            this.lblRegistrationStatus = new System.Windows.Forms.Label();
            this.lblLastRegistered = new System.Windows.Forms.Label();
            this.lblValidationMessage = new System.Windows.Forms.Label();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.grpBookInfo.SuspendLayout();
            this.grpCopyDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopyPreview)).BeginInit();
            this.grpRegistrationActions.SuspendLayout();
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
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBookRegistrationTitle
            // 
            this.lblBookRegistrationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookRegistrationTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookRegistrationTitle.Location = new System.Drawing.Point(70, 10);
            this.lblBookRegistrationTitle.Name = "lblBookRegistrationTitle";
            this.lblBookRegistrationTitle.Size = new System.Drawing.Size(1060, 50);
            this.lblBookRegistrationTitle.TabIndex = 0;
            this.lblBookRegistrationTitle.Text = "Book Registration";
            this.lblBookRegistrationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBookInfo.Controls.Add(this.txtDescription);
            this.grpBookInfo.Controls.Add(this.lblDescription);
            this.grpBookInfo.Controls.Add(this.txtPrice);
            this.grpBookInfo.Controls.Add(this.lblPrice);
            this.grpBookInfo.Controls.Add(this.txtPages);
            this.grpBookInfo.Controls.Add(this.lblPages);
            this.grpBookInfo.Controls.Add(this.txtPublicationYear);
            this.grpBookInfo.Controls.Add(this.lblPublicationYear);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.lblISBN);
            this.grpBookInfo.Controls.Add(this.txtPublisher);
            this.grpBookInfo.Controls.Add(this.lblPublisher);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblAuthorReg);
            this.grpBookInfo.Controls.Add(this.txtBookTitle);
            this.grpBookInfo.Controls.Add(this.lblBookTitleReg);
            this.grpBookInfo.Controls.Add(this.lblBookNumberAuto);
            this.grpBookInfo.Controls.Add(this.cmbClassification);
            this.grpBookInfo.Controls.Add(this.lblClassification);
            this.grpBookInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfo.Location = new System.Drawing.Point(20, 80);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(1110, 280);
            this.grpBookInfo.TabIndex = 1;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Information";
            // 
            // lblClassification
            // 
            this.lblClassification.AutoSize = true;
            this.lblClassification.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassification.Location = new System.Drawing.Point(50, 40);
            this.lblClassification.Name = "lblClassification";
            this.lblClassification.Size = new System.Drawing.Size(127, 25);
            this.lblClassification.TabIndex = 0;
            this.lblClassification.Text = "Classification:";
            // 
            // cmbClassification
            // 
            this.cmbClassification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassification.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassification.FormattingEnabled = true;
            this.cmbClassification.Items.AddRange(new object[] {
            "A - General Knowledge",
            "B - Philosophy",
            "C - Religion",
            "D - Social Sciences",
            "E - Language",
            "F - Natural Sciences",
            "G - Technology",
            "H - Arts",
            "I - Literature",
            "J - History & Geography"});
            this.cmbClassification.Location = new System.Drawing.Point(179, 37);
            this.cmbClassification.Name = "cmbClassification";
            this.cmbClassification.Size = new System.Drawing.Size(200, 33);
            this.cmbClassification.TabIndex = 1;
            // 
            // lblBookNumberAuto
            // 
            this.lblBookNumberAuto.AutoSize = true;
            this.lblBookNumberAuto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNumberAuto.Location = new System.Drawing.Point(400, 40);
            this.lblBookNumberAuto.Name = "lblBookNumberAuto";
            this.lblBookNumberAuto.Size = new System.Drawing.Size(206, 25);
            this.lblBookNumberAuto.TabIndex = 2;
            this.lblBookNumberAuto.Text = "Book Number: A0001";
            // 
            // lblBookTitleReg
            // 
            this.lblBookTitleReg.AutoSize = true;
            this.lblBookTitleReg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleReg.Location = new System.Drawing.Point(50, 80);
            this.lblBookTitleReg.Name = "lblBookTitleReg";
            this.lblBookTitleReg.Size = new System.Drawing.Size(99, 25);
            this.lblBookTitleReg.TabIndex = 3;
            this.lblBookTitleReg.Text = "Book Title:";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookTitle.Location = new System.Drawing.Point(160, 77);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(500, 31);
            this.txtBookTitle.TabIndex = 4;
            // 
            // lblAuthorReg
            // 
            this.lblAuthorReg.AutoSize = true;
            this.lblAuthorReg.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorReg.Location = new System.Drawing.Point(50, 120);
            this.lblAuthorReg.Name = "lblAuthorReg";
            this.lblAuthorReg.Size = new System.Drawing.Size(74, 25);
            this.lblAuthorReg.TabIndex = 5;
            this.lblAuthorReg.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(160, 117);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(400, 31);
            this.txtAuthor.TabIndex = 6;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(50, 160);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(95, 25);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(160, 157);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(300, 31);
            this.txtPublisher.TabIndex = 8;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(500, 160);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(56, 25);
            this.lblISBN.TabIndex = 9;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(560, 157);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 31);
            this.txtISBN.TabIndex = 10;
            // 
            // lblPublicationYear
            // 
            this.lblPublicationYear.AutoSize = true;
            this.lblPublicationYear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicationYear.Location = new System.Drawing.Point(50, 200);
            this.lblPublicationYear.Name = "lblPublicationYear";
            this.lblPublicationYear.Size = new System.Drawing.Size(152, 25);
            this.lblPublicationYear.TabIndex = 11;
            this.lblPublicationYear.Text = "Publication Year:";
            // 
            // txtPublicationYear
            // 
            this.txtPublicationYear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicationYear.Location = new System.Drawing.Point(211, 197);
            this.txtPublicationYear.Name = "txtPublicationYear";
            this.txtPublicationYear.Size = new System.Drawing.Size(100, 31);
            this.txtPublicationYear.TabIndex = 12;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(320, 200);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(65, 25);
            this.lblPages.TabIndex = 13;
            this.lblPages.Text = "Pages:";
            // 
            // txtPages
            // 
            this.txtPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPages.Location = new System.Drawing.Point(393, 197);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(100, 31);
            this.txtPages.TabIndex = 14;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(520, 200);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(98, 25);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price (Rs.):";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(625, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 31);
            this.txtPrice.TabIndex = 16;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(50, 240);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 25);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(174, 240);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(500, 31);
            this.txtDescription.TabIndex = 18;
            // 
            // grpCopyDetails
            // 
            this.grpCopyDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCopyDetails.Controls.Add(this.dgvCopyPreview);
            this.grpCopyDetails.Controls.Add(this.cmbCondition);
            this.grpCopyDetails.Controls.Add(this.lblCondition);
            this.grpCopyDetails.Controls.Add(this.txtLocation);
            this.grpCopyDetails.Controls.Add(this.lblLocation);
            this.grpCopyDetails.Controls.Add(this.rbReferenceOnly);
            this.grpCopyDetails.Controls.Add(this.rbBorrowable);
            this.grpCopyDetails.Controls.Add(this.lblCopyType);
            this.grpCopyDetails.Controls.Add(this.nudNumberOfCopies);
            this.grpCopyDetails.Controls.Add(this.lblNumberOfCopies);
            this.grpCopyDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCopyDetails.Location = new System.Drawing.Point(20, 376);
            this.grpCopyDetails.Name = "grpCopyDetails";
            this.grpCopyDetails.Size = new System.Drawing.Size(1110, 375);
            this.grpCopyDetails.TabIndex = 19;
            this.grpCopyDetails.TabStop = false;
            this.grpCopyDetails.Text = "Copy Details";
            // 
            // lblNumberOfCopies
            // 
            this.lblNumberOfCopies.AutoSize = true;
            this.lblNumberOfCopies.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfCopies.Location = new System.Drawing.Point(50, 40);
            this.lblNumberOfCopies.Name = "lblNumberOfCopies";
            this.lblNumberOfCopies.Size = new System.Drawing.Size(169, 25);
            this.lblNumberOfCopies.TabIndex = 19;
            this.lblNumberOfCopies.Text = "Number of Copies:";
            // 
            // nudNumberOfCopies
            // 
            this.nudNumberOfCopies.Location = new System.Drawing.Point(230, 37);
            this.nudNumberOfCopies.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfCopies.Name = "nudNumberOfCopies";
            this.nudNumberOfCopies.Size = new System.Drawing.Size(80, 34);
            this.nudNumberOfCopies.TabIndex = 20;
            this.nudNumberOfCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCopyType
            // 
            this.lblCopyType.AutoSize = true;
            this.lblCopyType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyType.Location = new System.Drawing.Point(326, 40);
            this.lblCopyType.Name = "lblCopyType";
            this.lblCopyType.Size = new System.Drawing.Size(103, 25);
            this.lblCopyType.TabIndex = 21;
            this.lblCopyType.Text = "Copy Type:";
            // 
            // rbBorrowable
            // 
            this.rbBorrowable.AutoSize = true;
            this.rbBorrowable.Checked = true;
            this.rbBorrowable.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrowable.Location = new System.Drawing.Point(435, 40);
            this.rbBorrowable.Name = "rbBorrowable";
            this.rbBorrowable.Size = new System.Drawing.Size(130, 29);
            this.rbBorrowable.TabIndex = 22;
            this.rbBorrowable.Text = "Borrowable";
            this.rbBorrowable.UseVisualStyleBackColor = true;
            // 
            // rbReferenceOnly
            // 
            this.rbReferenceOnly.AutoSize = true;
            this.rbReferenceOnly.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbReferenceOnly.Location = new System.Drawing.Point(571, 40);
            this.rbReferenceOnly.Name = "rbReferenceOnly";
            this.rbReferenceOnly.Size = new System.Drawing.Size(160, 29);
            this.rbReferenceOnly.TabIndex = 24;
            this.rbReferenceOnly.Text = "Reference Only";
            this.rbReferenceOnly.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(50, 80);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(135, 25);
            this.lblLocation.TabIndex = 25;
            this.lblLocation.Text = "Shelf Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(195, 77);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 31);
            this.txtLocation.TabIndex = 19;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(400, 80);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(99, 25);
            this.lblCondition.TabIndex = 26;
            this.lblCondition.Text = "Condition:";
            // 
            // cmbCondition
            // 
            this.cmbCondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Fair",
            "Poor"});
            this.cmbCondition.Location = new System.Drawing.Point(509, 77);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(150, 33);
            this.cmbCondition.TabIndex = 19;
            // 
            // dgvCopyPreview
            // 
            this.dgvCopyPreview.AllowUserToAddRows = false;
            this.dgvCopyPreview.AllowUserToDeleteRows = false;
            this.dgvCopyPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCopyPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCopyPreview.BackgroundColor = System.Drawing.Color.White;
            this.dgvCopyPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopyPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CopyNumber,
            this.AccessionNumber,
            this.Type,
            this.Location,
            this.Condition,
            this.Status});
            this.dgvCopyPreview.Location = new System.Drawing.Point(50, 120);
            this.dgvCopyPreview.Name = "dgvCopyPreview";
            this.dgvCopyPreview.ReadOnly = true;
            this.dgvCopyPreview.RowHeadersWidth = 51;
            this.dgvCopyPreview.Size = new System.Drawing.Size(1024, 235);
            this.dgvCopyPreview.TabIndex = 20;
            // 
            // CopyNumber
            // 
            this.CopyNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CopyNumber.HeaderText = "Copy Number";
            this.CopyNumber.MinimumWidth = 100;
            this.CopyNumber.Name = "CopyNumber";
            this.CopyNumber.ReadOnly = true;
            // 
            // AccessionNumber
            // 
            this.AccessionNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccessionNumber.HeaderText = "Accession Number";
            this.AccessionNumber.MinimumWidth = 120;
            this.AccessionNumber.Name = "AccessionNumber";
            this.AccessionNumber.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 80;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 100;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 100;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 80;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // grpRegistrationActions
            // 
            this.grpRegistrationActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpRegistrationActions.Controls.Add(this.lblValidationMessage);
            this.grpRegistrationActions.Controls.Add(this.lblLastRegistered);
            this.grpRegistrationActions.Controls.Add(this.lblRegistrationStatus);
            this.grpRegistrationActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistrationActions.Location = new System.Drawing.Point(20, 765);
            this.grpRegistrationActions.Name = "grpRegistrationActions";
            this.grpRegistrationActions.Size = new System.Drawing.Size(1110, 110);
            this.grpRegistrationActions.TabIndex = 27;
            this.grpRegistrationActions.TabStop = false;
            this.grpRegistrationActions.Text = "Registration Actions";
            // 
            // lblRegistrationStatus
            // 
            this.lblRegistrationStatus.AutoSize = true;
            this.lblRegistrationStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationStatus.Location = new System.Drawing.Point(50, 40);
            this.lblRegistrationStatus.Name = "lblRegistrationStatus";
            this.lblRegistrationStatus.Size = new System.Drawing.Size(340, 25);
            this.lblRegistrationStatus.TabIndex = 27;
            this.lblRegistrationStatus.Text = "Ready to register new book with copies";
            // 
            // lblLastRegistered
            // 
            this.lblLastRegistered.AutoSize = true;
            this.lblLastRegistered.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastRegistered.Location = new System.Drawing.Point(50, 70);
            this.lblLastRegistered.Name = "lblLastRegistered";
            this.lblLastRegistered.Size = new System.Drawing.Size(205, 25);
            this.lblLastRegistered.TabIndex = 28;
            this.lblLastRegistered.Text = "Last Registered: [None]";
            // 
            // lblValidationMessage
            // 
            this.lblValidationMessage.AutoSize = true;
            this.lblValidationMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationMessage.Location = new System.Drawing.Point(500, 40);
            this.lblValidationMessage.Name = "lblValidationMessage";
            this.lblValidationMessage.Size = new System.Drawing.Size(24, 23);
            this.lblValidationMessage.TabIndex = 29;
            this.lblValidationMessage.Text = "\"\"";
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterBook.ForeColor = System.Drawing.Color.White;
            this.btnRegisterBook.Location = new System.Drawing.Point(250, 885);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(194, 43);
            this.btnRegisterBook.TabIndex = 28;
            this.btnRegisterBook.Text = "REGISTER BOOK";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            // 
            // btnClearForm
            // 
            this.btnClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.ForeColor = System.Drawing.Color.White;
            this.btnClearForm.Location = new System.Drawing.Point(460, 885);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(194, 43);
            this.btnClearForm.TabIndex = 29;
            this.btnClearForm.Text = "CLEAR FORM";
            this.btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnSaveDraft
            // 
            this.btnSaveDraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDraft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDraft.ForeColor = System.Drawing.Color.White;
            this.btnSaveDraft.Location = new System.Drawing.Point(670, 885);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(194, 43);
            this.btnSaveDraft.TabIndex = 30;
            this.btnSaveDraft.Text = "SAVE DRAFT";
            this.btnSaveDraft.UseVisualStyleBackColor = true;
            // 
            // pnlBookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveDraft);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.grpRegistrationActions);
            this.Controls.Add(this.grpCopyDetails);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.lblBookRegistrationTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "pnlBookRegistration";
            this.Size = new System.Drawing.Size(1150, 970);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.grpCopyDetails.ResumeLayout(false);
            this.grpCopyDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopyPreview)).EndInit();
            this.grpRegistrationActions.ResumeLayout(false);
            this.grpRegistrationActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBookRegistrationTitle;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label lblClassification;
        private System.Windows.Forms.ComboBox cmbClassification;
        private System.Windows.Forms.Label lblBookNumberAuto;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitleReg;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthorReg;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtPublicationYear;
        private System.Windows.Forms.Label lblPublicationYear;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox grpCopyDetails;
        private System.Windows.Forms.NumericUpDown nudNumberOfCopies;
        private System.Windows.Forms.Label lblNumberOfCopies;
        private System.Windows.Forms.Label lblCopyType;
        private System.Windows.Forms.RadioButton rbBorrowable;
        private System.Windows.Forms.RadioButton rbReferenceOnly;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.DataGridView dgvCopyPreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn CopyNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox grpRegistrationActions;
        private System.Windows.Forms.Label lblRegistrationStatus;
        private System.Windows.Forms.Label lblLastRegistered;
        private System.Windows.Forms.Label lblValidationMessage;
        private System.Windows.Forms.Button btnRegisterBook;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnSaveDraft;
    }
}
