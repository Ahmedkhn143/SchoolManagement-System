using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Login : Form
    {
        private readonly string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=schoolmanagement; Integrated Security=True; Encrypt=False";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT TOP 1 Role FROM Users WHERE Username=@u AND Password=@p";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    object roleObj = cmd.ExecuteScalar();
                    if (roleObj == null || roleObj == DBNull.Value)
                    {
                        MessageBox.Show("Invalid username or password.");
                        return;
                    }

                    string role = roleObj.ToString();
                    if (!role.Equals("Admin", StringComparison.OrdinalIgnoreCase) &&
                        !role.Equals("Principal", StringComparison.OrdinalIgnoreCase) &&
                        !role.Equals("Principle", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Unauthorized role. Contact admin.");
                        return;
                    }

                    Dashboard dash = new Dashboard(username, role);
                    dash.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var bg = new Bitmap(ClientSize.Width, ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bg))
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Rectangle(0, 0, bg.Width, bg.Height),
                Color.FromArgb(33, 150, 243),
                Color.FromArgb(13, 71, 161),
                45f))
            {
                g.FillRectangle(brush, 0, 0, bg.Width, bg.Height);
            }

            BackgroundImage = bg;
            BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}