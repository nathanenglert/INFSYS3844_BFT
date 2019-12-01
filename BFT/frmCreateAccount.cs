using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BFT
{
    public partial class frmCreateAccount : Form
    {
        // Create conenction string variable
        private string _connectionString;

        public frmCreateAccount()
        {
            InitializeComponent();

            // Capture the connection string for the db
            _connectionString = new DatabaseMethods().DBConnectionString();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Check if all the fields are filled out
            if (tbFirstName.Text == "" | tbLastName.Text == "" | 
                tbEmail.Text == "" | tbPassword.Text == "")
            {
                MessageBox.Show("Please fill out all fields.");
            }
            else
            {
                // Capture account details
                string firstName = tbFirstName.Text;
                string lastName = tbLastName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;

                // Check if email already exists
                if (!ValidateEmail(email))
                {
                    // If email does not exist, load into accounts table
                    LoadNewUser(firstName, lastName, email, password);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email already exists. Create new account or login.");
                }
            }
        }

        // Validate email entered
        private bool ValidateEmail(string email)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands to check if user already exists
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = $"SELECT id, email from accounts where email = '{email}'",
                    Connection = conn
                };
                SqlDataReader reader;

                // Open connection
                conn.Open();

                // Query users table
                reader = cmd.ExecuteReader();

                // Loop over and print results
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Load new user
        private void LoadNewUser(string firstName, string lastName, string email, string password)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands insert data
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"INSERT INTO accounts (first_name,last_name,email,password) VALUES ('" + firstName +
                                    "','" + lastName + "','" + email + "','" + password + "')",
                    Connection = conn
                };

                // Open connection
                conn.Open();

                // Execute insert
                cmd.ExecuteNonQuery();

                // Close connections
                cmd.Dispose();
                conn.Close();
            }
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program._runProgram = false;
            Application.Exit();
        }

        private void frmCreateAccount_Closing(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Program._runProgram = false;
                Application.Exit();
            }
        }
    }
}
