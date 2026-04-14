using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace School_Management_System
{
    public partial class StudentForm : Form
    {
        // Connection String
        private string connString = @"Data Source=.\SQLEXPRESS; Initial Catalog=schoolmanagement; Integrated Security=True; Encrypt=False";

        public StudentForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Check karein ke fields khali to nahi
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtFather.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // 2. Query jo data SQL table mein insert karegi
                    string query = "INSERT INTO Students (FullName, FatherName, Contact) VALUES (@name, @father, @contact)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@father", txtFather.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                    // 3. Query run karna
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student Data Saved Successfully!");

                    // 4. Fields ko khali kar dena
                    txtName.Clear();
                    txtFather.Clear();
                    txtContact.Clear();

                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Ye function data ko grid mein dikhaye ga
        public void DisplayData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    // Sab students ka data mangwane ki query
                    string query = "SELECT * FROM Students";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt); // Data table mein bhar diya
                    dgvStudents.DataSource = dt; // Grid ko table dikha diya
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying data: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Form band karne ke liye
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students WHERE FullName LIKE '" + txtSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;
            }
        }
    }
}
