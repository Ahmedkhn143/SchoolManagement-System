using System;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // 1. Manage Students Button: Naya window kholne ke liye
        private void btnStudents_Click(object sender, EventArgs e)
        {
            StudentForm st = new StudentForm(); // Student Form ka object
            st.Show();              // Use show kar do
        }

        // 2. Logout Button: Wapas Login par jane ke liye
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close(); // Dashboard ko band kar do
        }

        // 3. Exit Button: Poora software band karne ke liye
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}