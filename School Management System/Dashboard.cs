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

        private void Dashboard_Load(object sender, EventArgs e)
        {

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
                this.Hide();
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}