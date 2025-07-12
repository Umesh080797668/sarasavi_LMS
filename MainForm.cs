using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace LibraryManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            // Set btnLogin color to #E74C3C
            btnLogin.BackColor = ColorTranslator.FromHtml("#E74C3C");

            // Set btnExit color to #95A5A6
            btnExit.BackColor = ColorTranslator.FromHtml("#95A5A6");

            // Decrease the visibility (opacity) of the background image with a dark overlay
            if (picLogo.Image != null)
            {
                // 0.35f = 35% black overlay (adjust as needed)
                picLogo.Image = SetImageDarkOverlay((Bitmap)picLogo.Image, 0.35f);
            }

            // Center controls horizontally
            CenterControlHorizontally(lblMainTitle);
            CenterControlHorizontally(lblSubtitle);
            CenterControlHorizontally(btnLogin);
            CenterControlHorizontally(btnExit);

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

        private void CenterControlHorizontally(Control ctrl)
        {
            if (ctrl != null && ctrl.Parent != null)
            {
                ctrl.Left = (ctrl.Parent.ClientSize.Width - ctrl.Width) / 2;
            }
        }

        private Bitmap SetImageOpacity(Bitmap image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private Bitmap SetImageDarkOverlay(Bitmap image, float darkness)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height));
                using (Brush overlay = new SolidBrush(Color.FromArgb((int)(255 * darkness), 0, 0, 0)))
                {
                    g.FillRectangle(overlay, 0, 0, bmp.Width, bmp.Height);
                }
            }
            return bmp;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
