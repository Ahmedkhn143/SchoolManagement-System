using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace School_Management_System
{
    [DesignerCategory("Form")]
    public partial class StudentForm : Form
    {
        private string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=schoolmanagement; Integrated Security=True; Encrypt=False";
        private int? _selectedStudentId = null;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtFather.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            try
            {
                var repo = new School_Management_System.Data.StudentRepository();
                var s = new School_Management_System.Models.Student
                {
                    FirstName = txtName.Text,
                    LastName = "",
                    FatherName = txtFather.Text,
                    ClassName = "",
                    Contact = txtContact.Text
                };

                repo.Insert(s);
                MessageBox.Show("Student Data Saved Successfully!");

                txtName.Clear();
                txtFather.Clear();
                txtContact.Clear();

                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student: " + ex.Message);
            }
        }

        public void DisplayData()
        {
            try
            {
                var repo = new School_Management_System.Data.StudentRepository();
                dgvStudents.DataSource = repo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    var repo = new School_Management_System.Data.StudentRepository();
                    if (_selectedStudentId.HasValue)
                    {
                        repo.Delete(_selectedStudentId.Value);
                        MessageBox.Show("Student Deleted Successfully!");
                        DisplayData();
                        txtName.Clear(); txtFather.Clear(); txtContact.Clear();
                        _selectedStudentId = null;
                    }
                    else
                    {
                        MessageBox.Show("Please select a student from the list to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message);
                }
            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var repo = new School_Management_System.Data.StudentRepository();
                dgvStudents.DataSource = repo.SearchByName(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                // set selected student id if available
                if (row.Cells["StudentId"] != null && row.Cells["StudentId"].Value != null)
                {
                    _selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                }

                txtName.Text = row.Cells["FullName"].Value?.ToString() ?? string.Empty;
                txtFather.Text = row.Cells["FatherName"].Value?.ToString() ?? string.Empty;
                txtContact.Text = row.Cells["Contact"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please select a student from the list first!");
                return;
            }
            try
            {
                if (!_selectedStudentId.HasValue)
                {
                    MessageBox.Show("Please select a student row to update.");
                    return;
                }

                var repo = new School_Management_System.Data.StudentRepository();
                var s = new School_Management_System.Models.Student
                {
                    Id = _selectedStudentId.Value,
                    FirstName = txtName.Text,
                    LastName = "",
                    FatherName = txtFather.Text,
                    Contact = txtContact.Text
                };

                int rows = repo.Update(s);
                if (rows > 0)
                {
                    MessageBox.Show("Student Updated Successfully!");
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Student not found or no changes made.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }

        private void grpStudent_Enter(object sender, EventArgs e)
        {

        }
    }
}

