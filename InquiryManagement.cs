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
    public partial class pnlInquiryManagement : UserControl
    {
        public event EventHandler BackToDashboard;
        
        public pnlInquiryManagement()
        {
            InitializeComponent();

            // set panel background color for #FFFFFF
            this.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            // set lblInquiryTitle forcolor color for #2C3E50
            lblInquiryTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // set btnSearch backcolor color for #9B59B6
            btnSearch.BackColor = ColorTranslator.FromHtml("#9B59B6");

            // set btnClearSearch backcolor color for #95A5A6
            btnClearSearch.BackColor = ColorTranslator.FromHtml("#95A5A6");

            // set pnlSelectedBookInfo backcolor color for #F8F9FA
            pnlSelectedBookInfo.BackColor = ColorTranslator.FromHtml("#F8F9FA");

            // set lblAvailableCopies forcolor color for #27AE60
            lblAvailableCopies.ForeColor = ColorTranslator.FromHtml("#27AE60");

            // set lblBorrowedCopies forcolor color for #E74C3C
            lblBorrowedCopies.ForeColor = ColorTranslator.FromHtml("#E74C3C");

            // set lblReservedCopies forcolor color for #F39C12
            lblReservedCopies.ForeColor = ColorTranslator.FromHtml("#F39C12");

            // set btnExportResults backcolor color for #34495E
            btnExportResults.BackColor = ColorTranslator.FromHtml("#34495E");

            // set btnPrintDetails backcolor color for #2C3E50
            btnPrintDetails.BackColor = ColorTranslator.FromHtml("#2C3E50");

            // set btnClear backcolor to #95A5A6
            btnClear.BackColor = ColorTranslator.FromHtml("#95A5A6");

            // Handle resize events for responsive layout
            this.Resize += PnlInquiryManagement_Resize;
            this.ParentChanged += PnlInquiryManagement_ParentChanged;
            
            // Attach event handler for clear button
            btnClear.Click += btnClear_Click;
        }

        private void PnlInquiryManagement_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                AdjustInquiryLayout();
            }
        }

        private void PnlInquiryManagement_Resize(object sender, EventArgs e)
        {
            AdjustInquiryLayout();
        }

        private void AdjustInquiryLayout()
        {
            if (grpSearchOptions == null) return;

            // Check if window is maximized by checking available width
            bool isMaximized = this.Width > 1000;

            if (isMaximized)
            {
                // Maximized layout - spread radio buttons evenly
                rbAccessionNumber.Location = new Point(50, 40);
                rbTitle.Location = new Point(280, 40);
                rbAuthor.Location = new Point(490, 40);
                rbISBN.Location = new Point(670, 40);
                
                // Search input and buttons positioning
                txtSearchInput.Location = new Point(50, 80);
                txtSearchInput.Size = new Size(400, 31);
                btnSearch.Location = new Point(470, 76);
                btnClearSearch.Location = new Point(576, 76);
                
                // Adjust DataGrid column widths for maximized mode
                dgvSearchResults.Columns["AccessionNumber"].Width = 150;
                dgvSearchResults.Columns["Title"].Width = 300;
                dgvSearchResults.Columns["Author"].Width = 200;
                dgvSearchResults.Columns["Classification"].Width = 150;
                dgvSearchResults.Columns["Status"].Width = 120;
                dgvSearchResults.Columns["Borrower"].Width = 150;
                dgvSearchResults.Columns["DueDate"].Width = 130;
                
                // Bottom buttons positioning for maximized
                btnExportResults.Location = new Point(this.Width - 456, this.Height - 60);
                btnPrintDetails.Location = new Point(this.Width - 267, this.Height - 60);
                btnClear.Location = new Point(this.Width - 140, this.Height - 60);
            }
            else
            {
                // Windowed layout - more compact spacing
                rbAccessionNumber.Location = new Point(30, 40);
                rbTitle.Location = new Point(200, 40);
                rbAuthor.Location = new Point(350, 40);
                rbISBN.Location = new Point(480, 40);
                
                // Compact search input and buttons
                txtSearchInput.Location = new Point(30, 80);
                txtSearchInput.Size = new Size(320, 31);
                btnSearch.Location = new Point(360, 76);
                btnClearSearch.Location = new Point(470, 76);
                
                // Adjust DataGrid column widths for windowed mode
                dgvSearchResults.Columns["AccessionNumber"].Width = 120;
                dgvSearchResults.Columns["Title"].Width = 200;
                dgvSearchResults.Columns["Author"].Width = 150;
                dgvSearchResults.Columns["Classification"].Width = 100;
                dgvSearchResults.Columns["Status"].Width = 80;
                dgvSearchResults.Columns["Borrower"].Width = 120;
                dgvSearchResults.Columns["DueDate"].Width = 100;
                
                // Bottom buttons positioning for windowed mode
                btnExportResults.Location = new Point(this.Width - 456, this.Height - 50);
                btnPrintDetails.Location = new Point(this.Width - 267, this.Height - 50);
                btnClear.Location = new Point(this.Width - 140, this.Height - 50);
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
                Text = "This will clear all search data",
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
            txtSearchInput.Clear();
            dgvSearchResults.Rows.Clear();
            lblBookTitleInquiry.Text = "Title: [Select a book to view details]";
            lblAuthorInquiry.Text = "Author:";
            lblTotalCopies.Text = "Total Copies:";
            lblAvailableCopies.Text = "Available:";
            lblBorrowedCopies.Text = "Borrowed:";
            lblReservedCopies.Text = "Reserved:";
            lblPublisherInfo.Text = "Publisher:";
            rbAccessionNumber.Checked = true;
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToDashboard?.Invoke(this, EventArgs.Empty);
        }
    }
}
