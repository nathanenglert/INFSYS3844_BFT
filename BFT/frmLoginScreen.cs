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
    public partial class frmLoginScreen : Form
    {
        // Create conenction string variable
        private string _connectionString;

        public frmLoginScreen()
        {
            InitializeComponent();

            // Get connection string
            _connectionString = new DatabaseMethods().DBConnectionString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Authenticate the user - If valid open main screen from Program.cs
            bool success = LoginUser(tbEmail.Text, tbPassword.Text);
            if (!success)
            {
                tbPassword.Clear();
                MessageBox.Show("Invalid email or password, please try again.");
            }
            else
            {
                this.Close();
            }
        }

        // Login in user if email and password valid
        private bool LoginUser(string email, string password)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands to check if user already exists
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = $"SELECT id, first_name, email, password from accounts where email = '{email}' AND password = '{password}'",
                    Connection = conn
                };
                SqlDataReader reader;

                // Open connection
                conn.Open();

                // Query users table
                reader = cmd.ExecuteReader();

                // Loop over and print results
                if (!reader.HasRows)
                {
                    return false;
                }
                if (reader.Read())
                {
                    Program._accountID = Convert.ToInt32(reader["id"]);
                    Program._firstName = Convert.ToString(reader["first_name"]);
                }
                return true;
            }            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Launch create account screen if new user
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program._runProgram = false;
            Application.Exit();
        }

        private void frmLoginScreen_Closing(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Program._runProgram = false;
                Application.Exit();
            }
        }
    }
}
