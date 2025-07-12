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
    public partial class pnlBookReturn : UserControl
    {
        public event EventHandler BackToDashboard;
        
        public pnlBookReturn()
        {
            InitializeComponent();

            //set backcolor of the panel to #FFFFFF
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            //set lblBookReturnTitle forecolor to #2C3E50
            lblBookReturnTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            //set btnProcessReturn backcolor to #2ECC71
            btnProcessReturn.BackColor = ColorTranslator.FromHtml("#2ECC71");

            //set lblDaysOverdueValue forecolor to #E74C3C
            lblDaysOverdueValue.ForeColor = ColorTranslator.FromHtml("#E74C3C");

            //set lblReservationMessage forecolor to #27AE60
            lblReservationMessage.ForeColor = ColorTranslator.FromHtml("#27AE60");

            //set btnNotifyReserved backcolor to #F39C12
            btnNotifyReserved.BackColor = ColorTranslator.FromHtml("#F39C12");

            //set btnConfirmReturn backcolor to #27AE60
            btnConfirmReturn.BackColor = ColorTranslator.FromHtml("#27AE60");

            //set btnClearReturn backcolor to #95A5A6
            btnClearReturn.BackColor = ColorTranslator.FromHtml("#95A5A6");

            // Handle resize events for responsive layout
            this.Resize += PnlBookReturn_Resize;
            this.ParentChanged += PnlBookReturn_ParentChanged;
            
            // Attach event handlers for buttons
            btnConfirmReturn.Click += btnConfirmReturn_Click;
            btnClearReturn.Click += btnClearReturn_Click;
        }

        private void PnlBookReturn_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                AdjustReturnDatePosition();
            }
        }

        private void PnlBookReturn_Resize(object sender, EventArgs e)
        {
            AdjustReturnDatePosition();
        }

        private void AdjustReturnDatePosition()
        {
            if (grpReturnInfo == null || lblReturnDateDisplay == null) return;

            // Check if window is maximized by checking available width
            bool isMaximized = this.Width > 1000;

            if (isMaximized)
            {
                // Position return date on same line with big gap from accession textbox
                lblReturnDateDisplay.Location = new Point(700, 50);
            }
            else
            {
                // Position return date below accession number
                lblReturnDateDisplay.Location = new Point(20, 80);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDashboard?.Invoke(this, EventArgs.Empty);
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            // Simple check - if accession number is entered, show success, otherwise show error
            if (!string.IsNullOrWhiteSpace(txtReturnAccession.Text))
            {
                ShowReturnConfirmedMessage();
            }
            else
            {
                ShowReturnConfirmErrorMessage();
            }
        }

        private void btnClearReturn_Click(object sender, EventArgs e)
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
            txtReturnAccession.Clear();
            lblBookTitleValue.Text = "[Book Title]";
            lblAuthorValue.Text = "[Author Name]";
            lblLoanDateReturnValue.Text = "[Loan Date]";
            lblDueDateValue.Text = "[Due Date]";
            lblDaysOverdueValue.Text = "0";
            lblBorrowerNameReturnValue.Text = "[Borrower Name]";
            lblBorrowerIDReturnValue.Text = "[Borrower ID]";
            lblReservationMessage.Text = "No reservations for this title.";
        }

        private void ShowReturnConfirmedMessage()
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
                Text = "Return Confirmed Successfully!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Book has been returned successfully",
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

        private void ShowReturnConfirmErrorMessage()
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
                Text = "Cannot Confirm Return!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Please enter an accession number first",
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
