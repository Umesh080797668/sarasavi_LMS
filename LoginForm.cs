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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Set background color of form to #ECF0F1
            this.BackColor = ColorTranslator.FromHtml("#ECF0F1");

            // Set lblLoginTitle forecolor to #2C3E50
            lblLoginTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // Set lblUsername forecolor to #34495E
            lblUsername.ForeColor = ColorTranslator.FromHtml("#34495E");

            // Set lblPassword forecolor to #34495E
            lblPassword.ForeColor = ColorTranslator.FromHtml("#34495E");

            // Set btnLoginSubmit backcolor to #27AE60
            btnLoginSubmit.BackColor = ColorTranslator.FromHtml("#27AE60");

            // Set btnCancel backcolor to #E74C3C
            btnCancel.BackColor = ColorTranslator.FromHtml("#E74C3C");

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

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateLogin())
            {
                ShowSuccessMessage();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowErrorMessage();
            }
        }

        private bool ValidateLogin()
        {
            return txtUsername.Text.Trim() == "admin" && txtPassword.Text == "admin";
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
                Text = "Login Successful!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Welcome to Library Management System",
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
                Text = "Login Failed!",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(50, 100),
                Size = new Size(300, 30)
            };

            Label subLabel = new Label()
            {
                Text = "Invalid username or password",
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTogglePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '●')
            {
                txtPassword.PasswordChar = '\0';
                btnTogglePassword.Text = "🙈";
            }
            else
            {
                txtPassword.PasswordChar = '●';
                btnTogglePassword.Text = "👁";
            }
        }
    }
}
