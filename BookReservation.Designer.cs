
namespace LibraryManagementSystem
{
    partial class pnlBookReservation
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
            this.lblBookReservationTitle = new System.Windows.Forms.Label();
            this.grpMemberInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberTypeDisplay = new System.Windows.Forms.Label();
            this.lblMemberNameDisplay = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.grpBookSearch = new System.Windows.Forms.GroupBox();
            this.dgvAvailableCopies = new System.Windows.Forms.DataGridView();
            this.AccessionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReservedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.lblReservationDateValue = new System.Windows.Forms.Label();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.lblSelectedBookValue = new System.Windows.Forms.Label();
            this.lblSelectedBook = new System.Windows.Forms.Label();
            this.btnConfirmReservation = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpMemberInfo.SuspendLayout();
            this.grpBookSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCopies)).BeginInit();
            this.grpReservationDetails.SuspendLayout();
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
            this.btnBack.Location = new System.Drawing.Point(15, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 45);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBookReservationTitle
            // 
            this.lblBookReservationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookReservationTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReservationTitle.Location = new System.Drawing.Point(70, 15);
            this.lblBookReservationTitle.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.lblBookReservationTitle.Name = "lblBookReservationTitle";
            this.lblBookReservationTitle.Size = new System.Drawing.Size(1065, 45);
            this.lblBookReservationTitle.TabIndex = 0;
            this.lblBookReservationTitle.Text = "Book Reservation Process";
            this.lblBookReservationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMemberInfo
            // 
            this.grpMemberInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMemberInfo.Controls.Add(this.lblMemberTypeDisplay);
            this.grpMemberInfo.Controls.Add(this.lblMemberNameDisplay);
            this.grpMemberInfo.Controls.Add(this.btnSearchMember);
            this.grpMemberInfo.Controls.Add(this.txtMemberID);
            this.grpMemberInfo.Controls.Add(this.lblMemberID);
            this.grpMemberInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMemberInfo.Location = new System.Drawing.Point(15, 75);
            this.grpMemberInfo.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.grpMemberInfo.Name = "grpMemberInfo";
            this.grpMemberInfo.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.grpMemberInfo.Size = new System.Drawing.Size(1120, 110);
            this.grpMemberInfo.TabIndex = 1;
            this.grpMemberInfo.TabStop = false;
            this.grpMemberInfo.Text = "Member Information";
            // 
            // lblMemberTypeDisplay
            // 
            this.lblMemberTypeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberTypeDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberTypeDisplay.Location = new System.Drawing.Point(395, 76);
            this.lblMemberTypeDisplay.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.lblMemberTypeDisplay.Name = "lblMemberTypeDisplay";
            this.lblMemberTypeDisplay.Size = new System.Drawing.Size(690, 25);
            this.lblMemberTypeDisplay.TabIndex = 4;
            this.lblMemberTypeDisplay.Text = "Type: Registered Member";
            this.lblMemberTypeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemberNameDisplay
            // 
            this.lblMemberNameDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberNameDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberNameDisplay.Location = new System.Drawing.Point(420, 45);
            this.lblMemberNameDisplay.Margin = new System.Windows.Forms.Padding(15, 3, 10, 3);
            this.lblMemberNameDisplay.Name = "lblMemberNameDisplay";
            this.lblMemberNameDisplay.Size = new System.Drawing.Size(665, 25);
            this.lblMemberNameDisplay.TabIndex = 3;
            this.lblMemberNameDisplay.Text = "Name: [Member Name]";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.ForeColor = System.Drawing.Color.White;
            this.btnSearchMember.Location = new System.Drawing.Point(270, 40);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(110, 33);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberID.Location = new System.Drawing.Point(125, 42);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(5, 3, 10, 3);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(130, 31);
            this.txtMemberID.TabIndex = 1;
            // 
            // lblMemberID
            // 
            this.lblMemberID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(20, 45);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(140, 25);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            this.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpBookSearch
            // 
            this.grpBookSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBookSearch.Controls.Add(this.dgvAvailableCopies);
            this.grpBookSearch.Controls.Add(this.btnSearchBook);
            this.grpBookSearch.Controls.Add(this.txtSearchValue);
            this.grpBookSearch.Controls.Add(this.cmbSearchType);
            this.grpBookSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookSearch.Location = new System.Drawing.Point(15, 195);
            this.grpBookSearch.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.grpBookSearch.Name = "grpBookSearch";
            this.grpBookSearch.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.grpBookSearch.Size = new System.Drawing.Size(1120, 320);
            this.grpBookSearch.TabIndex = 5;
            this.grpBookSearch.TabStop = false;
            this.grpBookSearch.Text = "Book Search";
            // 
            // dgvAvailableCopies
            // 
            this.dgvAvailableCopies.AllowUserToAddRows = false;
            this.dgvAvailableCopies.AllowUserToDeleteRows = false;
            this.dgvAvailableCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAvailableCopies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableCopies.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCopies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccessionNumber,
            this.Title,
            this.Author,
            this.Status,
            this.Location,
            this.ReservedBy,
            this.Action});
            this.dgvAvailableCopies.Location = new System.Drawing.Point(20, 80);
            this.dgvAvailableCopies.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.dgvAvailableCopies.Name = "dgvAvailableCopies";
            this.dgvAvailableCopies.ReadOnly = true;
            this.dgvAvailableCopies.RowHeadersWidth = 25;
            this.dgvAvailableCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableCopies.Size = new System.Drawing.Size(1080, 225);
            this.dgvAvailableCopies.TabIndex = 6;
            // 
            // AccessionNumber
            // 
            this.AccessionNumber.HeaderText = "Accession Number";
            this.AccessionNumber.MinimumWidth = 6;
            this.AccessionNumber.Name = "AccessionNumber";
            this.AccessionNumber.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // ReservedBy
            // 
            this.ReservedBy.HeaderText = "Reserved By";
            this.ReservedBy.MinimumWidth = 6;
            this.ReservedBy.Name = "ReservedBy";
            this.ReservedBy.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBook.ForeColor = System.Drawing.Color.White;
            this.btnSearchBook.Location = new System.Drawing.Point(580, 35);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(15, 3, 5, 3);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(140, 35);
            this.btnSearchBook.TabIndex = 5;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchValue.Location = new System.Drawing.Point(235, 37);
            this.txtSearchValue.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(320, 31);
            this.txtSearchValue.TabIndex = 5;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Accession Number",
            "Title",
            "Author",
            "ISBN"});
            this.cmbSearchType.Location = new System.Drawing.Point(20, 37);
            this.cmbSearchType.Margin = new System.Windows.Forms.Padding(5, 3, 10, 3);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(190, 33);
            this.cmbSearchType.TabIndex = 0;
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReservationDetails.Controls.Add(this.lblReservationDateValue);
            this.grpReservationDetails.Controls.Add(this.lblReservationDate);
            this.grpReservationDetails.Controls.Add(this.lblSelectedBookValue);
            this.grpReservationDetails.Controls.Add(this.lblSelectedBook);
            this.grpReservationDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReservationDetails.Location = new System.Drawing.Point(15, 546);
            this.grpReservationDetails.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.grpReservationDetails.Size = new System.Drawing.Size(1120, 80);
            this.grpReservationDetails.TabIndex = 6;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "Reservation Details";
            // 
            // lblReservationDateValue
            // 
            this.lblReservationDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDateValue.Location = new System.Drawing.Point(819, 38);
            this.lblReservationDateValue.Margin = new System.Windows.Forms.Padding(5, 3, 15, 3);
            this.lblReservationDateValue.Name = "lblReservationDateValue";
            this.lblReservationDateValue.Size = new System.Drawing.Size(125, 25);
            this.lblReservationDateValue.TabIndex = 7;
            this.lblReservationDateValue.Text = "2025-07-10";
            this.lblReservationDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationDate.Location = new System.Drawing.Point(650, 38);
            this.lblReservationDate.Margin = new System.Windows.Forms.Padding(20, 3, 5, 3);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(170, 25);
            this.lblReservationDate.TabIndex = 6;
            this.lblReservationDate.Text = "Reservation Date:";
            this.lblReservationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedBookValue
            // 
            this.lblSelectedBookValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedBookValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBookValue.Location = new System.Drawing.Point(151, 38);
            this.lblSelectedBookValue.Margin = new System.Windows.Forms.Padding(5, 3, 20, 3);
            this.lblSelectedBookValue.Name = "lblSelectedBookValue";
            this.lblSelectedBookValue.Size = new System.Drawing.Size(420, 25);
            this.lblSelectedBookValue.TabIndex = 5;
            this.lblSelectedBookValue.Text = "[No book selected]";
            // 
            // lblSelectedBook
            // 
            this.lblSelectedBook.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBook.Location = new System.Drawing.Point(20, 38);
            this.lblSelectedBook.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.lblSelectedBook.Name = "lblSelectedBook";
            this.lblSelectedBook.Size = new System.Drawing.Size(160, 25);
            this.lblSelectedBook.TabIndex = 5;
            this.lblSelectedBook.Text = "Selected Book:";
            this.lblSelectedBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirmReservation
            // 
            this.btnConfirmReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReservation.ForeColor = System.Drawing.Color.White;
            this.btnConfirmReservation.Location = new System.Drawing.Point(700, 671);
            this.btnConfirmReservation.Margin = new System.Windows.Forms.Padding(5, 5, 10, 10);
            this.btnConfirmReservation.Name = "btnConfirmReservation";
            this.btnConfirmReservation.Size = new System.Drawing.Size(280, 45);
            this.btnConfirmReservation.TabIndex = 7;
            this.btnConfirmReservation.Text = "CONFIRM RESERVATION";
            this.btnConfirmReservation.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(995, 671);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 15, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlBookReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirmReservation);
            this.Controls.Add(this.grpReservationDetails);
            this.Controls.Add(this.grpBookSearch);
            this.Controls.Add(this.grpMemberInfo);
            this.Controls.Add(this.lblBookReservationTitle);
            this.Controls.Add(this.btnBack);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "pnlBookReservation";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(1150, 750);
            this.grpMemberInfo.ResumeLayout(false);
            this.grpMemberInfo.PerformLayout();
            this.grpBookSearch.ResumeLayout(false);
            this.grpBookSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCopies)).EndInit();
            this.grpReservationDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBookReservationTitle;
        private System.Windows.Forms.GroupBox grpMemberInfo;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberNameDisplay;
        private System.Windows.Forms.Label lblMemberTypeDisplay;
        private System.Windows.Forms.GroupBox grpBookSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView dgvAvailableCopies;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservedBy;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Label lblReservationDateValue;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.Label lblSelectedBookValue;
        private System.Windows.Forms.Label lblSelectedBook;
        private System.Windows.Forms.Button btnConfirmReservation;
        private System.Windows.Forms.Button btnClear;
    }
}
