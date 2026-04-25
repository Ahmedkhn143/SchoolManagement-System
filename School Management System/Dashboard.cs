using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Dashboard : Form
    {
        private readonly string currentUser;
        private readonly string currentRole;
        private readonly string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=schoolmanagement; Integrated Security=True; Encrypt=False";

        public Dashboard() : this("User", "Admin")
        {
        }

        public Dashboard(string username, string role)
        {
            InitializeComponent();
            currentUser = username;
            currentRole = role;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUserInfo.Text = "Welcome: " + currentUser + " (" + currentRole + ")";

            if (currentRole.Equals("Principal", StringComparison.OrdinalIgnoreCase) ||
                currentRole.Equals("Principle", StringComparison.OrdinalIgnoreCase))
            {
                btnStudents.Text = "  View Students";
            }

            ShowHomeDashboard();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            // Placeholder: open teacher management UI (not implemented yet)
            MessageBox.Show("Teachers module coming soon.");
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attendance module coming soon.");
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fees module coming soon.");
        }

        private void btnPasswordTool_Click(object sender, EventArgs e)
        {
            // Only allow Admin to open
            if (!currentRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Only Admin can manage user passwords.");
                return;
            }

            var f = new PasswordToolForm();
            f.ShowDialog(this);
        }

        private void ShowHomeDashboard()
        {
            mainPanel.Controls.Clear();

            Label lblWelcome = new Label();
            lblWelcome.Text = "Dashboard Overview";
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 80);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(25, 20);
            mainPanel.Controls.Add(lblWelcome);

            int studentCount = GetCount("SELECT COUNT(*) FROM Students");
            int usersCount = GetCount("SELECT COUNT(*) FROM Users");

            Panel studentsCard = CreateInfoCard("Total Students", studentCount.ToString(), new Point(25, 80));
            Panel usersCard = CreateInfoCard("System Users", usersCount.ToString(), new Point(285, 80));

            mainPanel.Controls.Add(studentsCard);
            mainPanel.Controls.Add(usersCard);

            Label lblHint = new Label();
            lblHint.Text = "Tip: Use 'Manage Students' from left menu to add/update/delete records.";
            lblHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblHint.ForeColor = Color.DimGray;
            lblHint.AutoSize = true;
            lblHint.Location = new Point(25, 230);
            mainPanel.Controls.Add(lblHint);
        }

        private Panel CreateInfoCard(string title, string value, Point location)
        {
            Panel card = new Panel();
            card.BackColor = Color.WhiteSmoke;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Size = new Size(230, 120);
            card.Location = location;

            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(15, 15);

            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(33, 150, 243);
            lblValue.AutoSize = true;
            lblValue.Location = new Point(12, 45);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            return card;
        }

        private int GetCount(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        return result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                    }
                }
            }
            catch
            {
                return 0;
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm st = new StudentForm();
            st.TopLevel = false;
            st.FormBorderStyle = FormBorderStyle.None;
            st.Dock = DockStyle.Fill;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(st);
            st.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                Hide();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}