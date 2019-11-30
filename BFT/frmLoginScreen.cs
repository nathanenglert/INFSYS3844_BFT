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
using BFT;

namespace BFT
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Call Login function.
            bool success = loginUser(username_box.Text, pw_box.Text);
            if (!success)
            {
                pw_box.Clear();
                MessageBox.Show("Invalid user email or password, please try again.");
            }
            else {
                this.Hide();
                frmMainScreen main_screen = new frmMainScreen();
                main_screen.Show();
            }
        }

        // Login in user if email and password valid. Otherwise raise exeption.
        private bool loginUser(string email, string password)
        {
            // Setup connection
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BFT_DB.mdf;Integrated Security=True");

            // Setup SQL commands to check if user already exists
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = $"SELECT * from accounts where email = {email} AND password = {password}",
                Connection = conn
            };
            SqlDataReader reader;

            // Open connection
            conn.Open();

            // Query users table
            reader = cmd.ExecuteReader();

            // Loop over and print results
            if (!reader.HasRows) {
                return false;
            }
            if (reader.Read())
            {
                BFT.LoggedInUser.user_email = Convert.ToString(reader["email"]);
                BFT.LoggedInUser.account_id = Convert.ToInt32(reader["id"]);
            }
            return true;
        }
    }
}
