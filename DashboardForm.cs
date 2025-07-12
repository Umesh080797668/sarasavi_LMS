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
    public partial class frmDashboard : Form
    {
        private Control[] originalDashboardContent;
        private Timer layoutRefreshTimer;

        public frmDashboard()
        {
            InitializeComponent();
            
            // Set minimum size for the form
            this.MinimumSize = new Size(1200, 800);
            
            // Set background color of form to #F8F9FA
            this.BackColor = ColorTranslator.FromHtml("#F8F9FA");

            // Set pnlTopMenu backcolor to #2C3E50
            pnlTopMenu.BackColor = ColorTranslator.FromHtml("#2C3E50");

            // set lblUserInfo forecolor to #BDC3C7
            lblUserInfo.ForeColor = ColorTranslator.FromHtml("#BDC3C7");

            // set btnLogout backcolor to #E74C3C
            btnLogout.BackColor = ColorTranslator.FromHtml("#E74C3C");

            // Set pnlSideNav backcolor to #34495E
            pnlSideNav.BackColor = ColorTranslator.FromHtml("#34495E");

            // Set btnBookLending backcolor to #3498DB
            btnBookLending.BackColor = ColorTranslator.FromHtml("#3498DB");

            // Set btnBookReturn backcolor to #2ECC71
            btnBookReturn.BackColor = ColorTranslator.FromHtml("#2ECC71");

            // Set btnBookReservation backcolor to #F39C12
            btnBookReservation.BackColor = ColorTranslator.FromHtml("#F39C12");

            // Set btnInquiry backcolor to #9B59B6
            btnInquiry.BackColor = ColorTranslator.FromHtml("#9B59B6");

            // Set btnBookRegistration backcolor to #E67E22
            btnBookRegistration.BackColor = ColorTranslator.FromHtml("#E67E22");

            // Set btnUserRegistration backcolor to #1ABC9C
            btnUserRegistration.BackColor = ColorTranslator.FromHtml("#1ABC9C");

            // Set pnlMainContent backcolor to #FFFFFF
            pnlMainContent.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            // Set lblWelcome forecolor to #2C3E50
            lblWelcome.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // Set pnlStats backcolor to #ECF0F1
            pnlStats.BackColor = ColorTranslator.FromHtml("#ECF0F1");

            // Ensure overlays are always on top of images
            panelTotalBooksOverlay.BringToFront();
            panelAvailableBooksOverlay.BringToFront();
            panelBorrowedBooksOverlay.BringToFront();
            panelTotalMembersOverlay.BringToFront();

            // Ensure welcome label is visible
            lblWelcome.BringToFront();

            this.FormClosing += frmDashboard_FormClosing;

            // Initialize dashboard layout properly
            InitializeDashboardLayout();
            
            // Initialize layout refresh timer
            layoutRefreshTimer = new Timer();
            layoutRefreshTimer.Interval = 100;
            layoutRefreshTimer.Tick += (sender, e) =>
            {
                layoutRefreshTimer.Stop();
                RefreshDashboardLayout();
            };

            // Attach event handler for Book Lending button
            btnBookLending.Click += btnBookLending_Click;
            
            // Attach event handler for Book Return button
            btnBookReturn.Click += btnBookReturn_Click;
            
            // Attach event handler for Book Reservation button
            btnBookReservation.Click += btnBookReservation_Click;
            
            // Attach event handler for Inquiry button
            btnInquiry.Click += btnInquiry_Click;
            
            // Attach event handler for Book Registration button
            btnBookRegistration.Click += btnBookRegistration_Click;
            
            // Attach event handler for User Registration button
            btnUserRegistration.Click += btnUserRegistration_Click;
            
            // Handle resize events to refresh layout
            this.Resize += frmDashboard_Resize;

            // Set the form icon
            try
            {
                string iconPath = System.IO.Path.Combine(Application.StartupPath, "Icon.ico");
                if (System.IO.File.Exists(iconPath))
                {
                    this.Icon = new Icon(iconPath);
                }
            }
            catch (Exception ex)
            {
                // Icon loading failed, will use default icon
                System.Diagnostics.Debug.WriteLine($"Icon load failed: {ex.Message}");
            }
        }
        
        private void frmDashboard_Resize(object sender, EventArgs e)
        {
            // Only refresh if we're on the dashboard (not in a sub-panel like BookLending)
            if (pnlStats != null && pnlStats.Visible && pnlStats.Parent == pnlMainContent)
            {
                // Use delayed refresh to avoid excessive layout operations during window resizing
                if (layoutRefreshTimer != null)
                {
                    layoutRefreshTimer.Stop();
                    layoutRefreshTimer.Start();
                }
                
                // For immediate response during window state changes (maximize/restore)
                if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
                {
                    RefreshDashboardLayout();
                }
            }
        }

        private void StoreOriginalDashboardContent()
        {
            originalDashboardContent = new Control[pnlMainContent.Controls.Count];
            pnlMainContent.Controls.CopyTo(originalDashboardContent, 0);
        }

        private void RestoreDashboardContent()
        {
            // Suspend all layout operations
            this.SuspendLayout();
            pnlMainContent.SuspendLayout();
            
            try
            {
                // Clear current content
                pnlMainContent.Controls.Clear();
                
                // Add controls back individually to ensure proper layout
                if (lblWelcome != null)
                {
                    pnlMainContent.Controls.Add(lblWelcome);
                    lblWelcome.Visible = true;
                    lblWelcome.BringToFront();
                }
                
                if (pnlStats != null)
                {
                    pnlMainContent.Controls.Add(pnlStats);
                    pnlStats.Visible = true;
                    
                    // Reset the stats panel layout properties to ensure proper anchoring
                    pnlStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    
                    // Ensure the table layout panel fills the stats panel
                    if (tableStats != null)
                    {
                        tableStats.Dock = DockStyle.Fill;
                        
                        // Force the overlay panels to front
                        if (panelTotalBooksOverlay != null) panelTotalBooksOverlay.BringToFront();
                        if (panelAvailableBooksOverlay != null) panelAvailableBooksOverlay.BringToFront();
                        if (panelBorrowedBooksOverlay != null) panelBorrowedBooksOverlay.BringToFront();
                        if (panelTotalMembersOverlay != null) panelTotalMembersOverlay.BringToFront();
                    }
                }
                
                // Refresh the dashboard layout immediately
                RefreshDashboardLayout();
            }
            finally
            {
                // Resume layout operations
                pnlMainContent.ResumeLayout(true);
                this.ResumeLayout(true);
            }
            
            // Use a delayed refresh to handle window state changes
            if (layoutRefreshTimer != null)
            {
                layoutRefreshTimer.Stop();
                layoutRefreshTimer.Start();
            }
            
            // Force immediate layout update
            Application.DoEvents();
            this.PerformLayout();
            pnlMainContent.PerformLayout();
            
            // Final refresh
            this.Invalidate(true);
            this.Update();
        }
        
        private void RefreshDashboardLayout()
        {
            if (pnlStats != null && pnlStats.Visible)
            {
                pnlStats.SuspendLayout();
                
                // Ensure proper positioning relative to the main content panel
                pnlStats.Location = new Point(19, 81);
                
                // Calculate proper size based on main content panel size
                int availableWidth = pnlMainContent.Width - 38; // Account for margins (19px on each side)
                int availableHeight = pnlMainContent.Height - 100; // Account for welcome label and margins
                
                pnlStats.Size = new Size(Math.Max(availableWidth, 300), Math.Max(availableHeight, 200));
                
                if (tableStats != null && tableStats.ColumnStyles.Count >= 2 && tableStats.RowStyles.Count >= 2)
                {
                    tableStats.SuspendLayout();
                    
                    // Ensure table fills the stats panel
                    tableStats.Dock = DockStyle.Fill;
                    
                    // Reset table layout percentages
                    tableStats.ColumnStyles[0].Width = 50F;
                    tableStats.ColumnStyles[1].Width = 50F;
                    tableStats.RowStyles[0].Height = 50F;
                    tableStats.RowStyles[1].Height = 50F;
                    
                    // Ensure proper sizing types
                    tableStats.ColumnStyles[0].SizeType = SizeType.Percent;
                    tableStats.ColumnStyles[1].SizeType = SizeType.Percent;
                    tableStats.RowStyles[0].SizeType = SizeType.Percent;
                    tableStats.RowStyles[1].SizeType = SizeType.Percent;
                    
                    tableStats.ResumeLayout(true);
                }
                
                pnlStats.ResumeLayout(true);
            }
            
            // Ensure welcome label is properly positioned
            if (lblWelcome != null)
            {
                lblWelcome.Location = new Point(19, 16);
                int availableWidth = pnlMainContent.Width - 38; // Account for margins
                lblWelcome.Size = new Size(Math.Max(availableWidth, 300), 49);
                lblWelcome.BringToFront();
            }
            
            // Force layout refresh
            pnlMainContent.PerformLayout();
            this.PerformLayout();
        }

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (ShowLogoutConfirmation())
            {
                ShowLogoutSuccessMessage();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ShowLogoutConfirmation()
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
                Text = "Confirm Logout",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(75, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Are you sure you want to logout?",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.FromArgb(127, 140, 141),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(75, 135),
                Size = new Size(300, 25)
            };

            Button btnYes = new Button()
            {
                Text = "YES",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(39, 174, 96),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(80, 35),
                Location = new Point(140, 180),
                Cursor = Cursors.Hand
            };

            Button btnNo = new Button()
            {
                Text = "NO",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(80, 35),
                Location = new Point(230, 180),
                Cursor = Cursors.Hand
            };

            bool result = false;
            btnYes.Click += (s, args) => { result = true; confirmForm.Close(); };
            btnNo.Click += (s, args) => { result = false; confirmForm.Close(); };

            contentPanel.Controls.AddRange(new Control[] { iconLabel, messageLabel, subLabel, btnYes, btnNo });
            mainPanel.Controls.Add(contentPanel);
            confirmForm.Controls.Add(mainPanel);

            confirmForm.ShowDialog(this);
            return result;
        }

        private void ShowLogoutSuccessMessage()
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
                Text = "Logout Successful!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Thank you for using the system",
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

        private void btnBookLending_Click(object sender, EventArgs e)
        {
            // Clear previous controls
            pnlMainContent.Controls.Clear();
            // Create BookLending UserControl instance
            BookLending bookLendingControl = new BookLending();
            bookLendingControl.Dock = DockStyle.Fill;
            bookLendingControl.BackToDashboard += BookLendingControl_BackToDashboard;
            pnlMainContent.Controls.Add(bookLendingControl);
        }

        private void BookLendingControl_BackToDashboard(object sender, EventArgs e)
        {
            RestoreDashboardContent();
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            // Clear previous controls
            pnlMainContent.Controls.Clear();
            // Create BookReturn UserControl instance
            pnlBookReturn bookReturnControl = new pnlBookReturn();
            bookReturnControl.Dock = DockStyle.Fill;
            bookReturnControl.BackToDashboard += BookReturnControl_BackToDashboard;
            pnlMainContent.Controls.Add(bookReturnControl);
        }

        private void BookReturnControl_BackToDashboard(object sender, EventArgs e)
        {
            RestoreDashboardContent();
        }

        private void btnBookReservation_Click(object sender, EventArgs e)
        {
            // Clear previous controls
            pnlMainContent.Controls.Clear();
            // Create BookReservation UserControl instance
            pnlBookReservation bookReservationControl = new pnlBookReservation();
            bookReservationControl.Dock = DockStyle.Fill;
            bookReservationControl.BackToDashboard += BookReservationControl_BackToDashboard;
            pnlMainContent.Controls.Add(bookReservationControl);
        }

        private void BookReservationControl_BackToDashboard(object sender, EventArgs e)
        {
            RestoreDashboardContent();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            // Clear previous controls
            pnlMainContent.Controls.Clear();
            // Create InquiryManagement UserControl instance
            pnlInquiryManagement inquiryManagementControl = new pnlInquiryManagement();
            inquiryManagementControl.Dock = DockStyle.Fill;
            inquiryManagementControl.BackToDashboard += InquiryManagementControl_BackToDashboard;
            pnlMainContent.Controls.Add(inquiryManagementControl);
        }

        private void InquiryManagementControl_BackToDashboard(object sender, EventArgs e)
        {
            RestoreDashboardContent();
        }

        private void btnBookRegistration_Click(object sender, EventArgs e)
        {
            // Clear previous controls
            pnlMainContent.Controls.Clear();
            // Enable vertical scrolling only
            pnlMainContent.AutoScroll = true;
            pnlMainContent.HorizontalScroll.Enabled = false;
            pnlMainContent.HorizontalScroll.Visible = false;
            // Create BookRegistration UserControl instance
            pnlBookRegistration bookRegistrationControl = new pnlBookRegistration();
            bookRegistrationControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bookRegistrationControl.Width = pnlMainContent.ClientSize.Width;
            bookRegistrationControl.BackToDashboard += BookRegistrationControl_BackToDashboard;
            pnlMainContent.Controls.Add(bookRegistrationControl);
        }

        private void BookRegistrationControl_BackToDashboard(object sender, EventArgs e)
        {
            pnlMainContent.AutoScroll = false;
            pnlMainContent.HorizontalScroll.Enabled = true;
            RestoreDashboardContent();
        }

        private void btnUserRegistration_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();
            pnlMainContent.AutoScroll = true;
            pnlMainContent.HorizontalScroll.Enabled = false;
            pnlMainContent.HorizontalScroll.Visible = false;
            pnlUserRegistration userRegistrationControl = new pnlUserRegistration();
            userRegistrationControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userRegistrationControl.Width = pnlMainContent.ClientSize.Width;
            userRegistrationControl.BackToDashboard += UserRegistrationControl_BackToDashboard;
            pnlMainContent.Controls.Add(userRegistrationControl);
            
            // Handle parent container resize to update user registration layout
            pnlMainContent.Resize += (s, args) => {
                if (userRegistrationControl != null && !userRegistrationControl.IsDisposed)
                {
                    userRegistrationControl.Width = pnlMainContent.ClientSize.Width;
                }
            };
        }

        private void UserRegistrationControl_BackToDashboard(object sender, EventArgs e)
        {
            pnlMainContent.AutoScroll = false;
            pnlMainContent.HorizontalScroll.Enabled = true;
            RestoreDashboardContent();
        }

        private void InitializeDashboardLayout()
        {
            // Ensure proper layout for main components
            if (pnlStats != null)
            {
                // Ensure stats panel has proper anchoring (not Dock.Fill to avoid covering welcome label)
                pnlStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                
                if (tableStats != null)
                {
                    tableStats.Dock = DockStyle.Fill;
                    
                    // Ensure overlay panels are properly positioned
                    if (panelTotalBooksOverlay != null) panelTotalBooksOverlay.BringToFront();
                    if (panelAvailableBooksOverlay != null) panelAvailableBooksOverlay.BringToFront();
                    if (panelBorrowedBooksOverlay != null) panelBorrowedBooksOverlay.BringToFront();
                    if (panelTotalMembersOverlay != null) panelTotalMembersOverlay.BringToFront();
                }
            }
            
            // Ensure welcome label is visible and on top
            if (lblWelcome != null)
            {
                lblWelcome.BringToFront();
            }
            
            // Perform initial layout refresh
            RefreshDashboardLayout();
            
            // Store original dashboard content after proper initialization
            StoreOriginalDashboardContent();
        }
    }
}
