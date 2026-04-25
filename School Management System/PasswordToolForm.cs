using System;
using System.Data;
using System.Windows.Forms;
using School_Management_System.Data;
using School_Management_System.Security;

namespace School_Management_System
{
    public partial class PasswordToolForm : Form
    {
        private readonly DatabaseHelper _db;

        public PasswordToolForm()
        {
            InitializeComponent();
            _db = new DatabaseHelper();
        }

        private void PasswordToolForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                var dt = _db.ExecuteDataTable("SELECT Username, Role FROM Users ORDER BY Username");
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string pwd = txtPassword.Text ?? string.Empty;
            if (string.IsNullOrWhiteSpace(pwd))
            {
                MessageBox.Show("Enter password to generate hash.");
                return;
            }

            try
            {
                txtHash.Text = PasswordHelper.Hash(pwd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hash generation failed: " + ex.Message);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHash.Text))
                Clipboard.SetText(txtHash.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Select a user from the list to update.");
                return;
            }

            var username = dgvUsers.CurrentRow.Cells["Username"].Value?.ToString();
            var hash = txtHash.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hash))
            {
                MessageBox.Show("Select user and generate a hash first.");
                return;
            }

            try
            {
                string sql = "UPDATE Users SET Password=@p WHERE Username=@u";
                var p1 = DatabaseHelper.CreateParam("@p", hash);
                var p2 = DatabaseHelper.CreateParam("@u", username);
                _db.ExecuteNonQuery(sql, p1, p2);
                MessageBox.Show("Password updated for user: " + username);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                txtUser.Text = dgvUsers.CurrentRow.Cells["Username"].Value?.ToString();
            }
        }
    }
}
