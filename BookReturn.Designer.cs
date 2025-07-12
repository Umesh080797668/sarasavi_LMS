
namespace LibraryManagementSystem
{
    partial class pnlBookReturn
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
            this.lblBookReturnTitle = new System.Windows.Forms.Label();
            this.grpReturnInfo = new System.Windows.Forms.GroupBox();
            this.lblReturnDateDisplay = new System.Windows.Forms.Label();
            this.btnProcessReturn = new System.Windows.Forms.Button();
            this.txtReturnAccession = new System.Windows.Forms.TextBox();
            this.lblReturnAccession = new System.Windows.Forms.Label();
            this.grpBookDetails = new System.Windows.Forms.GroupBox();
            this.lblDaysOverdueValue = new System.Windows.Forms.Label();
            this.lblDaysOverdue = new System.Windows.Forms.Label();
            this.lblDueDateValue = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblLoanDateReturnValue = new System.Windows.Forms.Label();
            this.lblLoanDateReturn = new System.Windows.Forms.Label();
            this.lblAuthorValue = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookTitleValue = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.grpBorrowerDetailsReturn = new System.Windows.Forms.GroupBox();
            this.lblBorrowerIDReturnValue = new System.Windows.Forms.Label();
            this.lblBorrowerIDReturn = new System.Windows.Forms.Label();
            this.lblBorrowerNameReturnValue = new System.Windows.Forms.Label();
            this.lblBorrowerNameReturn = new System.Windows.Forms.Label();
            this.grpReservationStatus = new System.Windows.Forms.GroupBox();
            this.btnNotifyReserved = new System.Windows.Forms.Button();
            this.lblReservationMessage = new System.Windows.Forms.Label();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.btnClearReturn = new System.Windows.Forms.Button();
            this.grpReturnInfo.SuspendLayout();
            this.grpBookDetails.SuspendLayout();
            this.grpBorrowerDetailsReturn.SuspendLayout();
            this.grpReservationStatus.SuspendLayout();
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
            // lblBookReturnTitle
            // 
            this.lblBookReturnTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookReturnTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReturnTitle.Location = new System.Drawing.Point(70, 10);
            this.lblBookReturnTitle.Name = "lblBookReturnTitle";
            this.lblBookReturnTitle.Size = new System.Drawing.Size(1060, 50);
            this.lblBookReturnTitle.TabIndex = 0;
            this.lblBookReturnTitle.Text = "Book Return Process";
            this.lblBookReturnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpReturnInfo
            // 
            this.grpReturnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReturnInfo.Controls.Add(this.lblReturnDateDisplay);
            this.grpReturnInfo.Controls.Add(this.btnProcessReturn);
            this.grpReturnInfo.Controls.Add(this.txtReturnAccession);
            this.grpReturnInfo.Controls.Add(this.lblReturnAccession);
            this.grpReturnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturnInfo.Location = new System.Drawing.Point(20, 70);
            this.grpReturnInfo.Name = "grpReturnInfo";
            this.grpReturnInfo.Size = new System.Drawing.Size(1110, 110);
            this.grpReturnInfo.TabIndex = 1;
            this.grpReturnInfo.TabStop = false;
            this.grpReturnInfo.Text = "Return Information";
            // 
            // lblReturnDateDisplay
            // 
            this.lblReturnDateDisplay.AutoSize = true;
            this.lblReturnDateDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDateDisplay.Location = new System.Drawing.Point(20, 80);
            this.lblReturnDateDisplay.Name = "lblReturnDateDisplay";
            this.lblReturnDateDisplay.Size = new System.Drawing.Size(314, 25);
            this.lblReturnDateDisplay.TabIndex = 3;
            this.lblReturnDateDisplay.Text = "Return Date: 2025-07-10 09:59:24";
            // 
            // btnProcessReturn
            // 
            this.btnProcessReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnProcessReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessReturn.ForeColor = System.Drawing.Color.White;
            this.btnProcessReturn.Location = new System.Drawing.Point(390, 43);
            this.btnProcessReturn.Name = "btnProcessReturn";
            this.btnProcessReturn.Size = new System.Drawing.Size(150, 35);
            this.btnProcessReturn.TabIndex = 2;
            this.btnProcessReturn.Text = "Process Return";
            this.btnProcessReturn.UseVisualStyleBackColor = false;
            // 
            // txtReturnAccession
            // 
            this.txtReturnAccession.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAccession.Location = new System.Drawing.Point(250, 47);
            this.txtReturnAccession.Name = "txtReturnAccession";
            this.txtReturnAccession.Size = new System.Drawing.Size(130, 31);
            this.txtReturnAccession.TabIndex = 1;
            // 
            // lblReturnAccession
            // 
            this.lblReturnAccession.AutoSize = true;
            this.lblReturnAccession.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAccession.Location = new System.Drawing.Point(20, 50);
            this.lblReturnAccession.Name = "lblReturnAccession";
            this.lblReturnAccession.Size = new System.Drawing.Size(220, 25);
            this.lblReturnAccession.TabIndex = 0;
            this.lblReturnAccession.Text = "Book Accession Number:";
            // 
            // grpBookDetails
            // 
            this.grpBookDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBookDetails.Controls.Add(this.lblDaysOverdueValue);
            this.grpBookDetails.Controls.Add(this.lblDaysOverdue);
            this.grpBookDetails.Controls.Add(this.lblDueDateValue);
            this.grpBookDetails.Controls.Add(this.lblDueDate);
            this.grpBookDetails.Controls.Add(this.lblLoanDateReturnValue);
            this.grpBookDetails.Controls.Add(this.lblLoanDateReturn);
            this.grpBookDetails.Controls.Add(this.lblAuthorValue);
            this.grpBookDetails.Controls.Add(this.lblAuthor);
            this.grpBookDetails.Controls.Add(this.lblBookTitleValue);
            this.grpBookDetails.Controls.Add(this.lblBookTitle);
            this.grpBookDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookDetails.Location = new System.Drawing.Point(20, 190);
            this.grpBookDetails.Name = "grpBookDetails";
            this.grpBookDetails.Size = new System.Drawing.Size(1110, 160);
            this.grpBookDetails.TabIndex = 3;
            this.grpBookDetails.TabStop = false;
            this.grpBookDetails.Text = "Book Details";
            // 
            // lblDaysOverdueValue
            // 
            this.lblDaysOverdueValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysOverdueValue.AutoSize = true;
            this.lblDaysOverdueValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysOverdueValue.Location = new System.Drawing.Point(970, 115);
            this.lblDaysOverdueValue.Name = "lblDaysOverdueValue";
            this.lblDaysOverdueValue.Size = new System.Drawing.Size(23, 25);
            this.lblDaysOverdueValue.TabIndex = 9;
            this.lblDaysOverdueValue.Text = "0";
            // 
            // lblDaysOverdue
            // 
            this.lblDaysOverdue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaysOverdue.AutoSize = true;
            this.lblDaysOverdue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysOverdue.Location = new System.Drawing.Point(830, 115);
            this.lblDaysOverdue.Name = "lblDaysOverdue";
            this.lblDaysOverdue.Size = new System.Drawing.Size(133, 25);
            this.lblDaysOverdue.TabIndex = 8;
            this.lblDaysOverdue.Text = "Days Overdue:";
            // 
            // lblDueDateValue
            // 
            this.lblDueDateValue.AutoSize = true;
            this.lblDueDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDateValue.Location = new System.Drawing.Point(420, 115);
            this.lblDueDateValue.Name = "lblDueDateValue";
            this.lblDueDateValue.Size = new System.Drawing.Size(108, 25);
            this.lblDueDateValue.TabIndex = 7;
            this.lblDueDateValue.Text = "[Due Date]";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(320, 115);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(94, 25);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblLoanDateReturnValue
            // 
            this.lblLoanDateReturnValue.AutoSize = true;
            this.lblLoanDateReturnValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDateReturnValue.Location = new System.Drawing.Point(147, 115);
            this.lblLoanDateReturnValue.Name = "lblLoanDateReturnValue";
            this.lblLoanDateReturnValue.Size = new System.Drawing.Size(116, 25);
            this.lblLoanDateReturnValue.TabIndex = 5;
            this.lblLoanDateReturnValue.Text = "[Loan Date]";
            // 
            // lblLoanDateReturn
            // 
            this.lblLoanDateReturn.AutoSize = true;
            this.lblLoanDateReturn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDateReturn.Location = new System.Drawing.Point(20, 115);
            this.lblLoanDateReturn.Name = "lblLoanDateReturn";
            this.lblLoanDateReturn.Size = new System.Drawing.Size(101, 25);
            this.lblLoanDateReturn.TabIndex = 4;
            this.lblLoanDateReturn.Text = "Loan Date:";
            // 
            // lblAuthorValue
            // 
            this.lblAuthorValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthorValue.AutoSize = true;
            this.lblAuthorValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorValue.Location = new System.Drawing.Point(100, 80);
            this.lblAuthorValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblAuthorValue.Name = "lblAuthorValue";
            this.lblAuthorValue.Size = new System.Drawing.Size(146, 25);
            this.lblAuthorValue.TabIndex = 3;
            this.lblAuthorValue.Text = "[Author Name]";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(20, 80);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(74, 25);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // lblBookTitleValue
            // 
            this.lblBookTitleValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookTitleValue.AutoSize = true;
            this.lblBookTitleValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitleValue.Location = new System.Drawing.Point(80, 45);
            this.lblBookTitleValue.MaximumSize = new System.Drawing.Size(1000, 0);
            this.lblBookTitleValue.Name = "lblBookTitleValue";
            this.lblBookTitleValue.Size = new System.Drawing.Size(116, 25);
            this.lblBookTitleValue.TabIndex = 1;
            this.lblBookTitleValue.Text = "[Book Title]";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(20, 45);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(52, 25);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Title:";
            // 
            // grpBorrowerDetailsReturn
            // 
            this.grpBorrowerDetailsReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBorrowerDetailsReturn.Controls.Add(this.lblBorrowerIDReturnValue);
            this.grpBorrowerDetailsReturn.Controls.Add(this.lblBorrowerIDReturn);
            this.grpBorrowerDetailsReturn.Controls.Add(this.lblBorrowerNameReturnValue);
            this.grpBorrowerDetailsReturn.Controls.Add(this.lblBorrowerNameReturn);
            this.grpBorrowerDetailsReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowerDetailsReturn.Location = new System.Drawing.Point(20, 360);
            this.grpBorrowerDetailsReturn.Name = "grpBorrowerDetailsReturn";
            this.grpBorrowerDetailsReturn.Size = new System.Drawing.Size(1110, 100);
            this.grpBorrowerDetailsReturn.TabIndex = 4;
            this.grpBorrowerDetailsReturn.TabStop = false;
            this.grpBorrowerDetailsReturn.Text = "Borrower Details";
            // 
            // lblBorrowerIDReturnValue
            // 
            this.lblBorrowerIDReturnValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowerIDReturnValue.AutoSize = true;
            this.lblBorrowerIDReturnValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerIDReturnValue.Location = new System.Drawing.Point(840, 50);
            this.lblBorrowerIDReturnValue.Name = "lblBorrowerIDReturnValue";
            this.lblBorrowerIDReturnValue.Size = new System.Drawing.Size(136, 25);
            this.lblBorrowerIDReturnValue.TabIndex = 12;
            this.lblBorrowerIDReturnValue.Text = "[Borrower ID]";
            // 
            // lblBorrowerIDReturn
            // 
            this.lblBorrowerIDReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowerIDReturn.AutoSize = true;
            this.lblBorrowerIDReturn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerIDReturn.Location = new System.Drawing.Point(715, 50);
            this.lblBorrowerIDReturn.Name = "lblBorrowerIDReturn";
            this.lblBorrowerIDReturn.Size = new System.Drawing.Size(117, 25);
            this.lblBorrowerIDReturn.TabIndex = 11;
            this.lblBorrowerIDReturn.Text = "Borrower ID:";
            // 
            // lblBorrowerNameReturnValue
            // 
            this.lblBorrowerNameReturnValue.AutoSize = true;
            this.lblBorrowerNameReturnValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerNameReturnValue.Location = new System.Drawing.Point(200, 50);
            this.lblBorrowerNameReturnValue.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblBorrowerNameReturnValue.Name = "lblBorrowerNameReturnValue";
            this.lblBorrowerNameReturnValue.Size = new System.Drawing.Size(168, 25);
            this.lblBorrowerNameReturnValue.TabIndex = 10;
            this.lblBorrowerNameReturnValue.Text = "[Borrower Name]";
            // 
            // lblBorrowerNameReturn
            // 
            this.lblBorrowerNameReturn.AutoSize = true;
            this.lblBorrowerNameReturn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowerNameReturn.Location = new System.Drawing.Point(20, 50);
            this.lblBorrowerNameReturn.Name = "lblBorrowerNameReturn";
            this.lblBorrowerNameReturn.Size = new System.Drawing.Size(149, 25);
            this.lblBorrowerNameReturn.TabIndex = 10;
            this.lblBorrowerNameReturn.Text = "Borrower Name:";
            // 
            // grpReservationStatus
            // 
            this.grpReservationStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReservationStatus.Controls.Add(this.btnNotifyReserved);
            this.grpReservationStatus.Controls.Add(this.lblReservationMessage);
            this.grpReservationStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReservationStatus.Location = new System.Drawing.Point(20, 470);
            this.grpReservationStatus.Name = "grpReservationStatus";
            this.grpReservationStatus.Size = new System.Drawing.Size(1110, 100);
            this.grpReservationStatus.TabIndex = 13;
            this.grpReservationStatus.TabStop = false;
            this.grpReservationStatus.Text = "Reservation Status";
            // 
            // btnNotifyReserved
            // 
            this.btnNotifyReserved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotifyReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnNotifyReserved.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifyReserved.Enabled = false;
            this.btnNotifyReserved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifyReserved.ForeColor = System.Drawing.Color.Black;
            this.btnNotifyReserved.Location = new System.Drawing.Point(880, 40);
            this.btnNotifyReserved.Name = "btnNotifyReserved";
            this.btnNotifyReserved.Size = new System.Drawing.Size(200, 40);
            this.btnNotifyReserved.TabIndex = 11;
            this.btnNotifyReserved.Text = "Notify Reserved Member";
            this.btnNotifyReserved.UseVisualStyleBackColor = false;
            // 
            // lblReservationMessage
            // 
            this.lblReservationMessage.AutoSize = true;
            this.lblReservationMessage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationMessage.Location = new System.Drawing.Point(20, 50);
            this.lblReservationMessage.MaximumSize = new System.Drawing.Size(850, 0);
            this.lblReservationMessage.Name = "lblReservationMessage";
            this.lblReservationMessage.Size = new System.Drawing.Size(249, 25);
            this.lblReservationMessage.TabIndex = 10;
            this.lblReservationMessage.Text = "No reservations for this title.";
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReturn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReturn.Location = new System.Drawing.Point(780, 580);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(200, 45);
            this.btnConfirmReturn.TabIndex = 14;
            this.btnConfirmReturn.Text = "CONFIRM RETURN";
            this.btnConfirmReturn.UseVisualStyleBackColor = false;
            // 
            // btnClearReturn
            // 
            this.btnClearReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClearReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearReturn.ForeColor = System.Drawing.Color.White;
            this.btnClearReturn.Location = new System.Drawing.Point(990, 580);
            this.btnClearReturn.Name = "btnClearReturn";
            this.btnClearReturn.Size = new System.Drawing.Size(140, 45);
            this.btnClearReturn.TabIndex = 15;
            this.btnClearReturn.Text = "CLEAR";
            this.btnClearReturn.UseVisualStyleBackColor = false;
            // 
            // pnlBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnClearReturn);
            this.Controls.Add(this.btnConfirmReturn);
            this.Controls.Add(this.grpReservationStatus);
            this.Controls.Add(this.grpBorrowerDetailsReturn);
            this.Controls.Add(this.grpBookDetails);
            this.Controls.Add(this.grpReturnInfo);
            this.Controls.Add(this.lblBookReturnTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "pnlBookReturn";
            this.Size = new System.Drawing.Size(1150, 650);
            this.grpReturnInfo.ResumeLayout(false);
            this.grpReturnInfo.PerformLayout();
            this.grpBookDetails.ResumeLayout(false);
            this.grpBookDetails.PerformLayout();
            this.grpBorrowerDetailsReturn.ResumeLayout(false);
            this.grpBorrowerDetailsReturn.PerformLayout();
            this.grpReservationStatus.ResumeLayout(false);
            this.grpReservationStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBookReturnTitle;
        private System.Windows.Forms.GroupBox grpReturnInfo;
        private System.Windows.Forms.Label lblReturnAccession;
        private System.Windows.Forms.TextBox txtReturnAccession;
        private System.Windows.Forms.Button btnProcessReturn;
        private System.Windows.Forms.Label lblReturnDateDisplay;
        private System.Windows.Forms.GroupBox grpBookDetails;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookTitleValue;
        private System.Windows.Forms.Label lblAuthorValue;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLoanDateReturnValue;
        private System.Windows.Forms.Label lblLoanDateReturn;
        private System.Windows.Forms.Label lblDueDateValue;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDaysOverdueValue;
        private System.Windows.Forms.Label lblDaysOverdue;
        private System.Windows.Forms.GroupBox grpBorrowerDetailsReturn;
        private System.Windows.Forms.Label lblBorrowerNameReturnValue;
        private System.Windows.Forms.Label lblBorrowerNameReturn;
        private System.Windows.Forms.Label lblBorrowerIDReturnValue;
        private System.Windows.Forms.Label lblBorrowerIDReturn;
        private System.Windows.Forms.GroupBox grpReservationStatus;
        private System.Windows.Forms.Label lblReservationMessage;
        private System.Windows.Forms.Button btnNotifyReserved;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.Button btnClearReturn;
    }
}
