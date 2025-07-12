using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class pnlUserRegistration : UserControl
    {
        public event EventHandler BackToDashboard;

        public pnlUserRegistration()
        {
            InitializeComponent();

            // set panel backcolor to #FFFFFF
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            // set lblUserRegistrationTitle forcolor to #2C3E50
            lblUserRegistrationTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // set lblUserNumberAuto forcolor to #E74C3C
            lblUserNumberAuto.ForeColor = ColorTranslator.FromHtml("#E74C3C");

            // set lblFullNameDisplay forcolor to #27AE60
            lblFullNameDisplay.ForeColor = ColorTranslator.FromHtml("#27AE60");

            // set lblMembershipFeeValue forcolor to #E74C3C
            lblMembershipFeeValue.ForeColor = ColorTranslator.FromHtml("#E74C3C");

            // set btnRegisterUser backcolor to #1ABC9C
            btnRegisterUser.BackColor = ColorTranslator.FromHtml("#1ABC9C");

            // set btnClearUserForm backcolor to #95A5A6
            btnClearUserForm.BackColor = ColorTranslator.FromHtml("#95A5A6");

            // set btnPreviewRegistration backcolor to #34495E
            btnPreviewRegistration.BackColor = ColorTranslator.FromHtml("#34495E");
            
            // Handle resize events for proper display in maximize/restore modes
            this.Resize += PnlUserRegistration_Resize;
            
            // Wire up button events
            btnRegisterUser.Click += btnRegisterUser_Click;
            btnClearUserForm.Click += btnClearUserForm_Click;
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDashboard?.Invoke(this, EventArgs.Empty);
        }
        
        private void PnlUserRegistration_Resize(object sender, EventArgs e)
        {
            AdjustLayoutForWindowSize();
        }
        
        private void AdjustLayoutForWindowSize()
        {
            if (this.Width > 0)
            {
                // Adjust group box widths to fit the container
                int availableWidth = this.Width - 40; // 20px margin on each side
                
                grpPersonalInfo.Width = availableWidth;
                grpAddressInfo.Width = availableWidth;
                grpMembershipInfo.Width = availableWidth;
                
                // Ensure proper positioning of buttons
                int buttonY = grpMembershipInfo.Bottom + 30;
                btnRegisterUser.Top = buttonY;
                btnClearUserForm.Top = buttonY;
                btnPreviewRegistration.Top = buttonY;
                
                // Adjust button positions for better spacing
                int totalButtonWidth = btnRegisterUser.Width + btnClearUserForm.Width + btnPreviewRegistration.Width;
                int spacing = 10;
                int startX = Math.Max(20, (availableWidth - totalButtonWidth - (2 * spacing)) / 2);
                
                btnRegisterUser.Left = startX;
                btnClearUserForm.Left = btnRegisterUser.Right + spacing;
                btnPreviewRegistration.Left = btnClearUserForm.Right + spacing;
            }
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AdjustLayoutForWindowSize();
        }
        
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (random.Next(0, 2) == 0)
            {
                ShowSuccessMessage();
            }
            else
            {
                ShowErrorMessage();
            }
        }
        
        private void btnClearUserForm_Click(object sender, EventArgs e)
        {
            if (ShowClearConfirmation())
            {
                ClearForm();
            }
        }
        
        private void ShowSuccessMessage()
        {
            Form successForm = new Form()
            {
                Size = new Size(400, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                TopMost = true
            };

            Panel mainPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(46, 204, 113),
                Padding = new Padding(2)
            };

            Panel contentPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label iconLabel = new Label()
            {
                Text = "✓",
                Font = new Font("Segoe UI", 36, FontStyle.Bold),
                ForeColor = Color.FromArgb(46, 204, 113),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(175, 30),
                Size = new Size(50, 60)
            };

            Label messageLabel = new Label()
            {
                Text = "User Registration Successful!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "User has been registered successfully",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(127, 140, 141),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 135),
                Size = new Size(300, 20)
            };

            contentPanel.Controls.AddRange(new Control[] { iconLabel, messageLabel, subLabel });
            mainPanel.Controls.Add(contentPanel);
            successForm.Controls.Add(mainPanel);

            Timer timer = new Timer() { Interval = 2000 };
            timer.Tick += (s, args) => { timer.Stop(); successForm.Close(); };
            timer.Start();

            successForm.ShowDialog(this);
        }
        
        private void ShowErrorMessage()
        {
            Form errorForm = new Form()
            {
                Size = new Size(400, 200),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                TopMost = true
            };

            Panel mainPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(231, 76, 60),
                Padding = new Padding(2)
            };

            Panel contentPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label iconLabel = new Label()
            {
                Text = "✕",
                Font = new Font("Segoe UI", 36, FontStyle.Bold),
                ForeColor = Color.FromArgb(231, 76, 60),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(175, 30),
                Size = new Size(50, 60)
            };

            Label messageLabel = new Label()
            {
                Text = "Registration Failed!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Please check the information and try again",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(127, 140, 141),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 135),
                Size = new Size(300, 20)
            };

            contentPanel.Controls.AddRange(new Control[] { iconLabel, messageLabel, subLabel });
            mainPanel.Controls.Add(contentPanel);
            errorForm.Controls.Add(mainPanel);

            Timer timer = new Timer() { Interval = 3000 };
            timer.Tick += (s, args) => { timer.Stop(); errorForm.Close(); };
            timer.Start();

            errorForm.ShowDialog(this);
        }
        
        private bool ShowClearConfirmation()
        {
            Form confirmForm = new Form()
            {
                Size = new Size(450, 250),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                TopMost = true
            };

            Panel mainPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(52, 152, 219),
                Padding = new Padding(2)
            };

            Panel contentPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Label iconLabel = new Label()
            {
                Text = "?",
                Font = new Font("Segoe UI", 36, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 152, 219),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(200, 30),
                Size = new Size(50, 60)
            };

            Label messageLabel = new Label()
            {
                Text = "Clear All Fields?",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(350, 30)
            };

            Label subLabel = new Label()
            {
                Text = "This will clear all entered data",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(127, 140, 141),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 135),
                Size = new Size(350, 20)
            };

            Button yesButton = new Button()
            {
                Text = "Yes",
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Size = new Size(80, 35),
                Location = new Point(140, 170),
                DialogResult = DialogResult.Yes
            };

            Button noButton = new Button()
            {
                Text = "No",
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(80, 35),
                Location = new Point(230, 170),
                DialogResult = DialogResult.No
            };

            contentPanel.Controls.AddRange(new Control[] { iconLabel, messageLabel, subLabel, yesButton, noButton });
            mainPanel.Controls.Add(contentPanel);
            confirmForm.Controls.Add(mainPanel);

            return confirmForm.ShowDialog(this) == DialogResult.Yes;
        }
        
        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNIC.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtOccupation.Clear();
            txtEmergencyContact.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtCity.Clear();
            txtPostalCode.Clear();
            cmbDistrict.SelectedIndex = -1;
            rbMale.Checked = true;
            rbBorrowingMember.Checked = true;
            dtpDateOfBirth.Value = DateTime.Now;
        }
    }
}
