using System;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Dashboard : Form
    {
        // UI Elements define kar rahe hain
        Panel sidePanel, headerPanel, mainPanel;
        Button btnStudents, btnLogout;
        Label lblTitle;

        public Dashboard()
        {
            InitializeComponent();
            SetupProfessionalDesign(); // Design setup karne wala function
        }

        private void SetupProfessionalDesign()
        {
            // 1. Form Settings
            this.Text = "Admin Dashboard - School Management System";
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(240, 242, 245); // Light Gray Background

            // 2. Side Panel (Sidebar)
            sidePanel = new Panel();
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Width = 230;
            sidePanel.BackColor = Color.FromArgb(44, 62, 80); // Midnight Blue
            this.Controls.Add(sidePanel);

            // 3. Header Panel
            headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 70;
            headerPanel.BackColor = Color.White;
            this.Controls.Add(headerPanel);

            // 4. Main Content Panel (Jahan forms khulenge)
            mainPanel = new Panel();
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BackColor = Color.White;
            this.Controls.Add(mainPanel);
            mainPanel.BringToFront();

            // 5. Header Title
            lblTitle = new Label();
            lblTitle.Text = "SCHOOL MANAGEMENT SYSTEM";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 20);
            headerPanel.Controls.Add(lblTitle);

            // 6. Manage Students Button (Sidebar Button)
            btnStudents = new Button();
            btnStudents.Text = "  Manage Students";
            btnStudents.Dock = DockStyle.Top;
            btnStudents.Height = 60;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.FlatAppearance.BorderSize = 0;
            btnStudents.ForeColor = Color.White;
            btnStudents.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnStudents.TextAlign = ContentAlignment.MiddleLeft;
            btnStudents.Cursor = Cursors.Hand;
            btnStudents.Click += btnStudents_Click; // Click Event connect kiya
            sidePanel.Controls.Add(btnStudents);

            // 7. Logout Button (Bottom of Sidebar)
            btnLogout = new Button();
            btnLogout.Text = "  Logout";
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Height = 60;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.ForeColor = Color.IndianRed;
            btnLogout.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Click += btnLogout_Click;
            sidePanel.Controls.Add(btnLogout);
        }

        // --- Navigation Logic ---

        private void btnStudents_Click(object sender, EventArgs e)
        {
            // Apne Form2 (Student Form) ko open karne ke liye
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
                this.Hide();
            }
        }
    }
}