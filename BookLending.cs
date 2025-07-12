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
    public partial class BookLending : UserControl
    {
        public event EventHandler BackToDashboard;
        public BookLending()
        {
            InitializeComponent();

            // set backcolor of the panel #FFFFFF
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            // set lblBookLendingTitle forecolor to the #2C3E50
            lblBookLendingTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // set grpBorrowerInfo forecolor to the #34495E
            grpBorrowerInfo.ForeColor = ColorTranslator.FromHtml("#34495E");

            // set btnSearchBorrower backcolor to the #3498DB
            btnSearchBorrower.BackColor = ColorTranslator.FromHtml("#3498DB");

            // set lblBorrowerNameValue forecolor to the #27AE60
            lblBorrowerNameValue.ForeColor = ColorTranslator.FromHtml("#27AE60");

            // set lblCurrentBooksValue forecolor to the #E74C3C
            lblCurrentBooksValue.ForeColor = ColorTranslator.FromHtml("#E74C3C");

            // set btnAddBook backcolor to the #27AE60
            btnAddBook.BackColor = ColorTranslator.FromHtml("#27AE60");

            // set btnRemoveSelected backcolor to the #E74C3C
            btnRemoveSelected.BackColor = ColorTranslator.FromHtml("#E74C3C");

            // set lblReturnDateValue forecolor to the #E74C3C
            lblReturnDateValue.ForeColor = ColorTranslator.FromHtml("#E74C3C");

            // set btnConfirmLoan backcolor to the #27AE60
            btnConfirmLoan.BackColor = ColorTranslator.FromHtml("#27AE60");

            // set btnClear backcolor to the #95A5A6
            btnClear.BackColor = ColorTranslator.FromHtml("#95A5A6");

            // Initialize proper layout management
            InitializeBorrowerInfoLayout();
            
            // Attach resize event handler for responsive layout
            this.Resize += BookLending_Resize;
            
            // Attach event handler for Add Book button
            btnAddBook.Click += btnAddBook_Click;
            
            // Attach event handler for Remove Selected button
            btnRemoveSelected.Click += btnRemoveSelected_Click;
            
            // Attach event handler for Confirm Loan button
            btnConfirmLoan.Click += btnConfirmLoan_Click;
            
            // Attach event handler for Clear button
            btnClear.Click += btnClear_Click;
        }

        private void InitializeBorrowerInfoLayout()
        {
            // Set up proper control positioning and spacing within grpBorrowerInfo
            AdjustBorrowerInfoControls();
        }

        private void BookLending_Resize(object sender, EventArgs e)
        {
            // Adjust controls when the form is resized (maximized/restored)
            AdjustBorrowerInfoControls();
        }

        private void AdjustBorrowerInfoControls()
        {
            if (grpBorrowerInfo == null) return;

            // Suspend layout operations for better performance
            grpBorrowerInfo.SuspendLayout();

            try
            {
                // Calculate available width within the group box
                int availableWidth = grpBorrowerInfo.Width - 40; // 20px margin on each side
                int verticalCenter = 45; // Vertical center position for all controls

                // Position Borrower ID label (fixed position)
                lblBorrowerID.Location = new Point(20, verticalCenter);

                // Position Borrower ID textbox (right after the label)
                txtBorrowerID.Location = new Point(lblBorrowerID.Right + 10, verticalCenter - 3);
                txtBorrowerID.Size = new Size(150, txtBorrowerID.Height);

                // Position Search button (right after the textbox)
                btnSearchBorrower.Location = new Point(txtBorrowerID.Right + 10, verticalCenter - 5);
                btnSearchBorrower.Size = new Size(100, 35);

                // Position Name label (with some spacing from search button)
                lblBorrowerName.Location = new Point(btnSearchBorrower.Right + 30, verticalCenter);

                // Position Name value label (right after name label)
                lblBorrowerNameValue.Location = new Point(lblBorrowerName.Right + 5, verticalCenter);

                // Calculate position for Current Books labels (right-aligned)
                int currentBooksValueWidth = 50; // Estimated width for "0/5" text
                int currentBooksLabelWidth = 135; // Width of "Current Books:" text
                int totalCurrentBooksWidth = currentBooksLabelWidth + currentBooksValueWidth + 5; // 5px spacing

                // Position Current Books labels from the right edge
                lblCurrentBooksValue.Location = new Point(availableWidth - currentBooksValueWidth + 20, verticalCenter);
                lblCurrentBooks.Location = new Point(lblCurrentBooksValue.Left - currentBooksLabelWidth - 5, verticalCenter);

                // Ensure Name value label doesn't overlap with Current Books section
                int maxNameValueWidth = lblCurrentBooks.Left - lblBorrowerNameValue.Left - 20;
                if (maxNameValueWidth > 0)
                {
                    lblBorrowerNameValue.MaximumSize = new Size(maxNameValueWidth, 0);
                }
            }
            finally
            {
                grpBorrowerInfo.ResumeLayout(true);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDashboard?.Invoke(this, EventArgs.Empty);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            // Simple check - if borrower ID is entered, show success, otherwise show error
            if (!string.IsNullOrWhiteSpace(txtBorrowerID.Text))
            {
                ShowBookAddedMessage();
            }
            else
            {
                ShowBookAddErrorMessage();
            }
        }

        private void ShowBookAddedMessage()
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
                Text = "Book Added Successfully!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Book has been added to lending list",
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

        private void ShowBookAddErrorMessage()
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
                Text = "Cannot Add Book!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Please enter a borrower ID first",
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

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            // Simple check - if borrower ID is entered, show success, otherwise show error
            if (!string.IsNullOrWhiteSpace(txtBorrowerID.Text))
            {
                ShowBookRemovedMessage();
            }
            else
            {
                ShowBookRemoveErrorMessage();
            }
        }

        private void ShowBookRemovedMessage()
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
                Text = "Book Removed Successfully!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Book has been removed from lending list",
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

        private void ShowBookRemoveErrorMessage()
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
                Text = "Cannot Remove Book!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Please enter a borrower ID first",
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

        private void btnConfirmLoan_Click(object sender, EventArgs e)
        {
            // Simple check - if borrower ID is entered, show success, otherwise show error
            if (!string.IsNullOrWhiteSpace(txtBorrowerID.Text))
            {
                ShowLoanConfirmedMessage();
            }
            else
            {
                ShowLoanConfirmErrorMessage();
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

        private void ClearAllFields()
        {
            txtBorrowerID.Clear();
            txtBookAccession.Clear();
            lblBorrowerNameValue.Text = "[Borrower Name]";
            lblCurrentBooksValue.Text = "0/5";
            lblTotalBooksValue.Text = "0";
            dgvBooksToLend.Rows.Clear();
        }

        private void ShowLoanConfirmedMessage()
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
                Text = "Loan Confirmed Successfully!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Books have been lent successfully",
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

        private void ShowLoanConfirmErrorMessage()
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
                Text = "Cannot Confirm Loan!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Please enter a borrower ID first",
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
