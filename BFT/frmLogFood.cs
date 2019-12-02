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

namespace BFT
{
    public partial class frmLogFood : Form
    {
        // Create conenction string variable for later use
        private string _connectionString;

        public frmLogFood()
        {
            InitializeComponent();

            _connectionString = new DatabaseMethods().DBConnectionString();

            LoadFoodItems();
        }

        private void LoadFoodItems()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands and query
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT 
                                foods.id AS ID
                                ,foods.name AS Name
                                ,foods.carbohydrates AS Carbohydrates
                                ,foods.proteins AS Proteins
                                ,foods.fats AS Fats
                                ,foods.calories AS Calories
                                FROM
                                foods
                                WHERE
                                foods.deleted_at IS NULL
                                AND foods.added_by_account_id = " + Program._accountID +
                                "ORDER BY name",
                    Connection = conn
                };
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                // Define dataset
                DataSet ds = new DataSet();

                // Fill dataset with query results
                dAdapter.Fill(ds);
                dgvFoodItems.DataSource = ds.Tables[0];
            }
        }

        private void btnLogFood_Click(object sender, EventArgs e)
        {
            // Capture highlighted row
            int rowIndex = dgvFoodItems.CurrentCell.RowIndex;

            // Capture highlighted row
            DataGridViewRow row = dgvFoodItems.Rows[rowIndex];

            // Capture food id row
            int foodID = Convert.ToInt32(row.Cells[0].Value);

            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands insert data
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"INSERT INTO food_log (account_id,food_id) VALUES (" +
                                    Program._accountID + "," + foodID + ")",
                    Connection = conn
                };

                //// Open connection
                conn.Open();

                // Execute insert
                cmd.ExecuteNonQuery();

                // Close connections
                cmd.Dispose();
                conn.Close();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program._runProgram = false;
            Application.Exit();
        }
    }
}