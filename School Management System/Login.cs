using System;
using System.Data.SqlClient; // <--- Ye line lazmi honi chahiye
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Login : Form
    {
        string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=schoolmanagement; Integrated Security=True; Encrypt=False";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Database se check karne ke bajaye direct Dashboard open kar rahe hain
            // taake aap aage ka kaam test kar sakein
            
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Login Successful!");

                // Naya Dashboard kholne ke liye
                Dashboard dash = new Dashboard();
                dash.Show();

                // Login window ko gayab karne ke liye
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username aur Password enter karein!");
            }

            /* 
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Name property check karein: txtUser aur txtPass sahi hona chahiye
                    cmd.Parameters.AddWithValue("@u", txtUser.Text);
                    cmd.Parameters.AddWithValue("@p", txtPass.Text);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!");

                        Dashboard dash = new Dashboard();
                        dash.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ghalat Username ya Password!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
            */
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}