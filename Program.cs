using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                // Show the main form
                using (frmMain main = new frmMain())
                {
                    var mainResult = main.ShowDialog();
                    if (mainResult != DialogResult.OK)
                    {
                        // If main form is closed, terminate the app
                        break;
                    }
                }

                // After main form, show login/dashboard loop
                while (true)
                {
                    using (frmLogin login = new frmLogin())
                    {
                        var loginResult = login.ShowDialog();
                        if (loginResult == DialogResult.OK)
                        {
                            using (frmDashboard dashboard = new frmDashboard())
                            {
                                var dashboardResult = dashboard.ShowDialog();
                                if (dashboardResult == DialogResult.OK)
                                {
                                    // Logout clicked, show login form again
                                    continue;
                                }
                            }
                            // Dashboard closed without logout, go back to main
                            break;
                        }
                        else
                        {
                            // If login is cancelled, go back to main form
                            break;
                        }
                    }
                }
            }
        }
    }
}
