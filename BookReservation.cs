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
    public partial class pnlBookReservation : UserControl
    {
        public event EventHandler BackToDashboard;

        public pnlBookReservation()
        {
            InitializeComponent();

            // set panel backcolor to #FFFFFF
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            // set lblBookReservationTitle forecolor to #2C3E50
            lblBookReservationTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // set btnSearchMember backcolor to #3498DB
            btnSearchMember.BackColor = ColorTranslator.FromHtml("#3498DB");

            // set lblMemberNameDisplay forecolor to #27AE60
            lblMemberNameDisplay.ForeColor = ColorTranslator.FromHtml("#27AE60");

            // set btnSearchBook backcolor to #9B59B6
            btnSearchBook.BackColor = ColorTranslator.FromHtml("#9B59B6");

            // set btnConfirmReservation backcolor to #F39C12
            btnConfirmReservation.BackColor = ColorTranslator.FromHtml("#F39C12");

            // set btnClear backcolor to #95A5A6
            btnClear.BackColor = ColorTranslator.FromHtml("#95A5A6");
            
            // Attach event handlers for buttons
            btnConfirmReservation.Click += btnConfirmReservation_Click;
            btnClear.Click += btnClear_Click;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDashboard?.Invoke(this, EventArgs.Empty);
        }

        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            // Simple check - if member ID is entered, show success, otherwise show error
            if (!string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                ShowReservationConfirmedMessage();
            }
            else
            {
                ShowReservationConfirmErrorMessage();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ShowClearConfirmation())
            {
                ClearAllFields();
            }
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
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
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

        private void ClearAllFields()
        {
            txtMemberID.Clear();
            txtSearchValue.Clear();
            cmbSearchType.SelectedIndex = -1;
            lblMemberNameDisplay.Text = "Name: [Member Name]";
            lblMemberTypeDisplay.Text = "Type: Registered Member";
            lblSelectedBookValue.Text = "[No book selected]";
            dgvAvailableCopies.Rows.Clear();
        }

        private void ShowReservationConfirmedMessage()
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
                Text = "Reservation Confirmed Successfully!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Book has been reserved successfully",
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

        private void ShowReservationConfirmErrorMessage()
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
                Text = "Cannot Confirm Reservation!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Please enter a member ID first",
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
    }
}
