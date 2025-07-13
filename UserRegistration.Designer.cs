
namespace LibraryManagementSystem
{
    partial class pnlUserRegistration
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
            this.lblUserRegistrationTitle = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.lblEmergencyContact = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFullNameDisplay = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUserNumberAuto = new System.Windows.Forms.Label();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.grpAddressInfo = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.cmbDistrict = new System.Windows.Forms.ComboBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.lblAddressLine2 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.lblAddressLine1 = new System.Windows.Forms.Label();
            this.grpMembershipInfo = new System.Windows.Forms.GroupBox();
            this.lblMembershipFeeValue = new System.Windows.Forms.Label();
            this.lblMembershipFee = new System.Windows.Forms.Label();
            this.lblRegistrationDateValue = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.rbRegisteredMember = new System.Windows.Forms.RadioButton();
            this.rbBorrowingMember = new System.Windows.Forms.RadioButton();
            this.lblMembershipType = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnClearUserForm = new System.Windows.Forms.Button();
            this.btnPreviewRegistration = new System.Windows.Forms.Button();
            this.grpPersonalInfo.SuspendLayout();
            this.grpAddressInfo.SuspendLayout();
            this.grpMembershipInfo.SuspendLayout();
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
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUserRegistrationTitle
            // 
            this.lblUserRegistrationTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserRegistrationTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRegistrationTitle.Location = new System.Drawing.Point(70, 10);
            this.lblUserRegistrationTitle.Name = "lblUserRegistrationTitle";
            this.lblUserRegistrationTitle.Size = new System.Drawing.Size(1060, 50);
            this.lblUserRegistrationTitle.TabIndex = 0;
            this.lblUserRegistrationTitle.Text = "User Registration";
            this.lblUserRegistrationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPersonalInfo.Controls.Add(this.txtEmergencyContact);
            this.grpPersonalInfo.Controls.Add(this.lblEmergencyContact);
            this.grpPersonalInfo.Controls.Add(this.txtOccupation);
            this.grpPersonalInfo.Controls.Add(this.lblOccupation);
            this.grpPersonalInfo.Controls.Add(this.txtEmail);
            this.grpPersonalInfo.Controls.Add(this.lblEmail);
            this.grpPersonalInfo.Controls.Add(this.txtPhoneNumber);
            this.grpPersonalInfo.Controls.Add(this.lblPhoneNumber);
            this.grpPersonalInfo.Controls.Add(this.txtNIC);
            this.grpPersonalInfo.Controls.Add(this.lblNIC);
            this.grpPersonalInfo.Controls.Add(this.dtpDateOfBirth);
            this.grpPersonalInfo.Controls.Add(this.lblDateOfBirth);
            this.grpPersonalInfo.Controls.Add(this.rbOther);
            this.grpPersonalInfo.Controls.Add(this.rbFemale);
            this.grpPersonalInfo.Controls.Add(this.rbMale);
            this.grpPersonalInfo.Controls.Add(this.lblGender);
            this.grpPersonalInfo.Controls.Add(this.lblFullNameDisplay);
            this.grpPersonalInfo.Controls.Add(this.txtLastName);
            this.grpPersonalInfo.Controls.Add(this.lblLastName);
            this.grpPersonalInfo.Controls.Add(this.txtFirstName);
            this.grpPersonalInfo.Controls.Add(this.lblFirstName);
            this.grpPersonalInfo.Controls.Add(this.lblUserNumberAuto);
            this.grpPersonalInfo.Controls.Add(this.lblUserNumber);
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalInfo.Location = new System.Drawing.Point(20, 80);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(1110, 320);
            this.grpPersonalInfo.TabIndex = 1;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "Personal Information";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContact.Location = new System.Drawing.Point(200, 267);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(200, 31);
            this.txtEmergencyContact.TabIndex = 22;
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContact.Location = new System.Drawing.Point(50, 270);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(179, 25);
            this.lblEmergencyContact.TabIndex = 21;
            this.lblEmergencyContact.Text = "Emergency Contact:";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOccupation.Location = new System.Drawing.Point(480, 227);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(200, 31);
            this.txtOccupation.TabIndex = 20;
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupation.Location = new System.Drawing.Point(380, 230);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(113, 25);
            this.lblOccupation.TabIndex = 19;
            this.lblOccupation.Text = "Occupation:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(100, 227);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 31);
            this.txtEmail.TabIndex = 18;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(50, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 25);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(445, 187);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 31);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(380, 190);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(70, 25);
            this.lblPhoneNumber.TabIndex = 15;
            this.lblPhoneNumber.Text = "Phone:";
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(155, 187);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(200, 31);
            this.txtNIC.TabIndex = 14;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(50, 190);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(111, 25);
            this.lblNIC.TabIndex = 13;
            this.lblNIC.Text = "National ID:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(531, 147);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(150, 31);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(400, 150);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(122, 25);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOther.Location = new System.Drawing.Point(315, 150);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(81, 29);
            this.rbOther.TabIndex = 10;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(216, 150);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(93, 29);
            this.rbFemale.TabIndex = 9;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(135, 150);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 29);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(50, 150);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(78, 25);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender:";
            // 
            // lblFullNameDisplay
            // 
            this.lblFullNameDisplay.AutoSize = true;
            this.lblFullNameDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameDisplay.Location = new System.Drawing.Point(50, 110);
            this.lblFullNameDisplay.Name = "lblFullNameDisplay";
            this.lblFullNameDisplay.Size = new System.Drawing.Size(282, 25);
            this.lblFullNameDisplay.TabIndex = 6;
            this.lblFullNameDisplay.Text = "Full Name: [Will be generated]";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(478, 77);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 31);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(380, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(104, 25);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(150, 77);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 31);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(50, 80);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblUserNumberAuto
            // 
            this.lblUserNumberAuto.AutoSize = true;
            this.lblUserNumberAuto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumberAuto.Location = new System.Drawing.Point(180, 40);
            this.lblUserNumberAuto.Name = "lblUserNumberAuto";
            this.lblUserNumberAuto.Size = new System.Drawing.Size(247, 25);
            this.lblUserNumberAuto.TabIndex = 1;
            this.lblUserNumberAuto.Text = "AUTO-GENERATED: U0001";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumber.Location = new System.Drawing.Point(50, 40);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(128, 25);
            this.lblUserNumber.TabIndex = 0;
            this.lblUserNumber.Text = "User Number:";
            // 
            // grpAddressInfo
            // 
            this.grpAddressInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddressInfo.Controls.Add(this.txtPostalCode);
            this.grpAddressInfo.Controls.Add(this.lblPostalCode);
            this.grpAddressInfo.Controls.Add(this.cmbDistrict);
            this.grpAddressInfo.Controls.Add(this.lblDistrict);
            this.grpAddressInfo.Controls.Add(this.txtCity);
            this.grpAddressInfo.Controls.Add(this.lblCity);
            this.grpAddressInfo.Controls.Add(this.txtAddressLine2);
            this.grpAddressInfo.Controls.Add(this.lblAddressLine2);
            this.grpAddressInfo.Controls.Add(this.txtAddressLine1);
            this.grpAddressInfo.Controls.Add(this.lblAddressLine1);
            this.grpAddressInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddressInfo.Location = new System.Drawing.Point(20, 406);
            this.grpAddressInfo.Name = "grpAddressInfo";
            this.grpAddressInfo.Size = new System.Drawing.Size(1110, 177);
            this.grpAddressInfo.TabIndex = 23;
            this.grpAddressInfo.TabStop = false;
            this.grpAddressInfo.Text = "Address Information";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(640, 117);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 31);
            this.txtPostalCode.TabIndex = 31;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(530, 120);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(115, 25);
            this.lblPostalCode.TabIndex = 30;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // cmbDistrict
            // 
            this.cmbDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistrict.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistrict.FormattingEnabled = true;
            this.cmbDistrict.Items.AddRange(new object[] {
            "Colombo",
            "Gampaha",
            "Kalutara",
            "Kandy",
            "Matale",
            "Nuwara Eliya",
            "Galle",
            "Matara",
            "Hambantota",
            "Jaffna",
            "Kilinochchi",
            "Mannar",
            "Vavuniya",
            "Mullaitivu",
            "Batticaloa",
            "Ampara",
            "Trincomalee",
            "Kurunegala",
            "Puttalam",
            "Anuradhapura",
            "Polonnaruwa",
            "Badulla",
            "Moneragala",
            "Ratnapura",
            "Kegalle"});
            this.cmbDistrict.Location = new System.Drawing.Point(350, 117);
            this.cmbDistrict.Name = "cmbDistrict";
            this.cmbDistrict.Size = new System.Drawing.Size(150, 33);
            this.cmbDistrict.TabIndex = 29;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(280, 120);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(75, 25);
            this.lblDistrict.TabIndex = 28;
            this.lblDistrict.Text = "District:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(93, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 31);
            this.txtCity.TabIndex = 27;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(50, 120);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(48, 25);
            this.lblCity.TabIndex = 26;
            this.lblCity.Text = "City:";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine2.Location = new System.Drawing.Point(183, 77);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(300, 31);
            this.txtAddressLine2.TabIndex = 25;
            // 
            // lblAddressLine2
            // 
            this.lblAddressLine2.AutoSize = true;
            this.lblAddressLine2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2.Location = new System.Drawing.Point(50, 80);
            this.lblAddressLine2.Name = "lblAddressLine2";
            this.lblAddressLine2.Size = new System.Drawing.Size(138, 25);
            this.lblAddressLine2.TabIndex = 24;
            this.lblAddressLine2.Text = "Address Line 2:";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine1.Location = new System.Drawing.Point(183, 37);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(300, 31);
            this.txtAddressLine1.TabIndex = 23;
            // 
            // lblAddressLine1
            // 
            this.lblAddressLine1.AutoSize = true;
            this.lblAddressLine1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1.Location = new System.Drawing.Point(50, 40);
            this.lblAddressLine1.Name = "lblAddressLine1";
            this.lblAddressLine1.Size = new System.Drawing.Size(138, 25);
            this.lblAddressLine1.TabIndex = 23;
            this.lblAddressLine1.Text = "Address Line 1:";
            // 
            // grpMembershipInfo
            // 
            this.grpMembershipInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMembershipInfo.Controls.Add(this.lblMembershipFeeValue);
            this.grpMembershipInfo.Controls.Add(this.lblMembershipFee);
            this.grpMembershipInfo.Controls.Add(this.lblRegistrationDateValue);
            this.grpMembershipInfo.Controls.Add(this.lblRegistrationDate);
            this.grpMembershipInfo.Controls.Add(this.rbRegisteredMember);
            this.grpMembershipInfo.Controls.Add(this.rbBorrowingMember);
            this.grpMembershipInfo.Controls.Add(this.lblMembershipType);
            this.grpMembershipInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMembershipInfo.Location = new System.Drawing.Point(20, 597);
            this.grpMembershipInfo.Name = "grpMembershipInfo";
            this.grpMembershipInfo.Size = new System.Drawing.Size(1110, 120);
            this.grpMembershipInfo.TabIndex = 32;
            this.grpMembershipInfo.TabStop = false;
            this.grpMembershipInfo.Text = "Membership Information";
            // 
            // lblMembershipFeeValue
            // 
            this.lblMembershipFeeValue.AutoSize = true;
            this.lblMembershipFeeValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipFeeValue.Location = new System.Drawing.Point(509, 80);
            this.lblMembershipFeeValue.Name = "lblMembershipFeeValue";
            this.lblMembershipFeeValue.Size = new System.Drawing.Size(102, 25);
            this.lblMembershipFeeValue.TabIndex = 37;
            this.lblMembershipFeeValue.Text = "Rs. 500.00";
            // 
            // lblMembershipFee
            // 
            this.lblMembershipFee.AutoSize = true;
            this.lblMembershipFee.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipFee.Location = new System.Drawing.Point(350, 80);
            this.lblMembershipFee.Name = "lblMembershipFee";
            this.lblMembershipFee.Size = new System.Drawing.Size(156, 25);
            this.lblMembershipFee.TabIndex = 36;
            this.lblMembershipFee.Text = "Membership Fee:";
            // 
            // lblRegistrationDateValue
            // 
            this.lblRegistrationDateValue.AutoSize = true;
            this.lblRegistrationDateValue.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDateValue.Location = new System.Drawing.Point(215, 80);
            this.lblRegistrationDateValue.Name = "lblRegistrationDateValue";
            this.lblRegistrationDateValue.Size = new System.Drawing.Size(116, 25);
            this.lblRegistrationDateValue.TabIndex = 23;
            this.lblRegistrationDateValue.Text = "2025-07-10";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(50, 80);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(160, 25);
            this.lblRegistrationDate.TabIndex = 35;
            this.lblRegistrationDate.Text = "Registration Date:";
            // 
            // rbRegisteredMember
            // 
            this.rbRegisteredMember.AutoSize = true;
            this.rbRegisteredMember.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRegisteredMember.Location = new System.Drawing.Point(424, 40);
            this.rbRegisteredMember.Name = "rbRegisteredMember";
            this.rbRegisteredMember.Size = new System.Drawing.Size(341, 29);
            this.rbRegisteredMember.TabIndex = 34;
            this.rbRegisteredMember.Text = "Registered Member (Reference Only)";
            this.rbRegisteredMember.UseVisualStyleBackColor = true;
            // 
            // rbBorrowingMember
            // 
            this.rbBorrowingMember.AutoSize = true;
            this.rbBorrowingMember.Checked = true;
            this.rbBorrowingMember.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBorrowingMember.Location = new System.Drawing.Point(221, 40);
            this.rbBorrowingMember.Name = "rbBorrowingMember";
            this.rbBorrowingMember.Size = new System.Drawing.Size(197, 29);
            this.rbBorrowingMember.TabIndex = 33;
            this.rbBorrowingMember.TabStop = true;
            this.rbBorrowingMember.Text = "Borrowing Member";
            this.rbBorrowingMember.UseVisualStyleBackColor = true;
            // 
            // lblMembershipType
            // 
            this.lblMembershipType.AutoSize = true;
            this.lblMembershipType.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipType.Location = new System.Drawing.Point(50, 40);
            this.lblMembershipType.Name = "lblMembershipType";
            this.lblMembershipType.Size = new System.Drawing.Size(166, 25);
            this.lblMembershipType.TabIndex = 32;
            this.lblMembershipType.Text = "Membership Type:";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUser.Location = new System.Drawing.Point(654, 791);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(188, 38);
            this.btnRegisterUser.TabIndex = 33;
            this.btnRegisterUser.Text = "REGISTER USER";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            // 
            // btnClearUserForm
            // 
            this.btnClearUserForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUserForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUserForm.ForeColor = System.Drawing.Color.White;
            this.btnClearUserForm.Location = new System.Drawing.Point(848, 791);
            this.btnClearUserForm.Name = "btnClearUserForm";
            this.btnClearUserForm.Size = new System.Drawing.Size(161, 38);
            this.btnClearUserForm.TabIndex = 34;
            this.btnClearUserForm.Text = "CLEAR FORM";
            this.btnClearUserForm.UseVisualStyleBackColor = true;
            // 
            // btnPreviewRegistration
            // 
            this.btnPreviewRegistration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPreviewRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviewRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewRegistration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewRegistration.ForeColor = System.Drawing.Color.White;
            this.btnPreviewRegistration.Location = new System.Drawing.Point(1015, 791);
            this.btnPreviewRegistration.Name = "btnPreviewRegistration";
            this.btnPreviewRegistration.Size = new System.Drawing.Size(114, 38);
            this.btnPreviewRegistration.TabIndex = 35;
            this.btnPreviewRegistration.Text = "PREVIEW";
            this.btnPreviewRegistration.UseVisualStyleBackColor = true;
            // 
            // pnlUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPreviewRegistration);
            this.Controls.Add(this.btnClearUserForm);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.grpMembershipInfo);
            this.Controls.Add(this.grpAddressInfo);
            this.Controls.Add(this.grpPersonalInfo);
            this.Controls.Add(this.lblUserRegistrationTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "pnlUserRegistration";
            this.Size = new System.Drawing.Size(1150, 860);
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.grpAddressInfo.ResumeLayout(false);
            this.grpAddressInfo.PerformLayout();
            this.grpMembershipInfo.ResumeLayout(false);
            this.grpMembershipInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUserRegistrationTitle;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.Label lblUserNumberAuto;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFullNameDisplay;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.GroupBox grpAddressInfo;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label lblAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label lblAddressLine2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbDistrict;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.GroupBox grpMembershipInfo;
        private System.Windows.Forms.Label lblMembershipType;
        private System.Windows.Forms.RadioButton rbBorrowingMember;
        private System.Windows.Forms.RadioButton rbRegisteredMember;
        private System.Windows.Forms.Label lblRegistrationDateValue;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblMembershipFeeValue;
        private System.Windows.Forms.Label lblMembershipFee;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnClearUserForm;
        private System.Windows.Forms.Button btnPreviewRegistration;
    }
}
