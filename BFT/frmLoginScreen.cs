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
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        // Test to make sure DB connection works - Success
        //private void QueryUsersTable()
        //{
        //    // Setup connection
        //    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BFT_DB.mdf;Integrated Security=True");

        //    // Setup SQL commands to check if user already exists
        //    SqlCommand cmd = new SqlCommand
        //    {
        //        CommandType = CommandType.Text,
        //        CommandText = "SELECT * from accounts",
        //        Connection = conn
        //    };
        //    SqlDataReader reader;

        //    // Open connection
        //    conn.Open();

        //    // Query users table
        //    reader = cmd.ExecuteReader();

        //    // Loop over and print results
        //    int count = reader.FieldCount;
        //    while (reader.Read())
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            Console.WriteLine(reader.GetValue(i));
        //        }
        //    }
        //}
    }
}
