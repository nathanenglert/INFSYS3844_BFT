using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFT
{
    public partial class frmAddEditFood : Form
    {
        // Create conenction string variable for later use
        private string _connectionString;

        public frmAddEditFood()
        {
            InitializeComponent();

            // Capture the connection string for the db
            _connectionString = new DatabaseMethods().DBConnectionString();

            // Load users logged foods
            LoadFoodItemData(Program._accountID);
        }

        ///// Code to verify input data conforms to proper types /////
        // Evaluate data inputs to ensure numbers or data will not load to db
        private void tbCarbs_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbCarbs.Text, out decimal carbs) & tbCarbs.Text != "")
            {
                MessageBox.Show("Please enter only numbers");
                tbCarbs.Text = "";
            }
        }

        private void tbFats_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbFats.Text, out decimal fats) & tbFats.Text != "")
            {
                MessageBox.Show("Please enter only numbers");
                tbFats.Text = "";
            }
        }

        private void tbProtein_Leave(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbProtein.Text, out decimal protein) & tbProtein.Text != "")
            {
                MessageBox.Show("Please enter only numbers");
                tbProtein.Text = "";
            }
        }

        ///// Code block to manipulate food items /////
        // Write food input to table when save button is clicked
        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            // Make sure all fields are filled out
            if (tbFoodName.Text == "" | tbCarbs.Text == "" | tbFats.Text == "" | tbProtein.Text == "")
            {
                MessageBox.Show("Please fill out all fields!");
            }
            else
            {
                // Capture input values and transform to proper types
                Object[] foodObject = new Object[] {Program._accountID, // account id - 0
                                                    tbFoodName.Text, // food - 1
                                                    decimal.Parse(tbCarbs.Text), // carbohydrates - 2
                                                    decimal.Parse(tbFats.Text), // fats - 3
                                                    decimal.Parse(tbProtein.Text), // proteins - 4
                                                    (decimal.Parse(tbCarbs.Text) * 4) + (decimal.Parse(tbFats.Text) * 9) +
                                                    (decimal.Parse(tbProtein.Text) * 4) // calculated calories - 5
                };

                // Insert data into foods table
                InsertFoodItemData(foodObject);

                // Reset add food fields
                tbFoodName.Text = "";
                tbCarbs.Text = "";
                tbFats.Text = "";
                tbProtein.Text = "";

                // After table is written to, refresh food items data grid
                LoadFoodItemData(Program._accountID);
            }
        }

        // Load current food items user has entered on form load or when food item added / edited
        private void LoadFoodItemData(int accountID)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands and query
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT
                                id AS ID
                                ,name AS Name
                                ,carbohydrates AS Carbohydrates
                                ,proteins AS Proteins
                                ,fats AS Fats
                                ,calories AS Calories
                                ,CAST(created_at AS DATE) AS Date
                                FROM foods
                                WHERE
                                deleted_at IS NULL
                                AND added_by_account_id = " + accountID,
                    Connection = conn
                };
                SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                // Define dataset
                DataSet ds = new DataSet();

                // Fill dataset with query results
                dAdapter.Fill(ds);

                // Update data grid items to only allow edits to certain columns
                dgvFoodItems.DataSource = ds.Tables[0];
                dgvFoodItems.ReadOnly = false;
                dgvFoodItems.Columns[0].ReadOnly = true;
                dgvFoodItems.Columns[5].ReadOnly = true;
                dgvFoodItems.Columns[6].ReadOnly = true;
            }
        }

        // Load a new food item to the foods table
        private void InsertFoodItemData(Object[] foodObject)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands insert data
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"INSERT INTO foods (name, carbohydrates, proteins, fats, calories, added_by_account_id) VALUES ('" +
                                   foodObject[1] + "'," + foodObject[2] + "," + foodObject[4] + "," +
                                   foodObject[3] + "," + foodObject[5] + "," + foodObject[0] + ")",
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

        // Update selected row of data with changes
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            // Capture highlighted row
            int rowIndex = dgvFoodItems.CurrentCell.RowIndex;

            // Capture highlighted row
            DataGridViewRow row = dgvFoodItems.Rows[rowIndex];

            // Capture row values in an object
            Object[] rowObject = new Object[] {row.Cells[0].Value, // id
                                               row.Cells[1].Value, // name
                                               row.Cells[2].Value, // carbohydrates
                                               row.Cells[3].Value, // proteins
                                               row.Cells[4].Value, // fats
            };

            // Test values to see if there are changes - Do nothing if not
            if (EvaluateFoodUpdate(rowObject))
            {
                UpdateFood(rowObject);
            }

            // After table is written to, refresh food items data grid
            LoadFoodItemData(Program._accountID);
        }

        // Evaluate changes to a food in the database
        private bool EvaluateFoodUpdate(object[] rowObject)
        {
            // Variables to capture values query returns
            // Extract values from query
            string foodName = "food";
            decimal carbs = 0.0M, proteins = 0.0M, fats = 0.0M;

            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands and query
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT
                                id
                                ,name
                                ,carbohydrates
                                ,proteins
                                ,fats
                                FROM
                                foods
                                WHERE
                                id = " + rowObject[0],
                    Connection = conn
                };
                SqlDataReader reader;

                // Open connection
                conn.Open();

                // Query users table
                reader = cmd.ExecuteReader();

                // Read data returned and assign to above variables
                if (reader.Read())
                {
                    foodName = reader.GetString(reader.GetOrdinal("name"));
                    carbs = reader.GetDecimal(reader.GetOrdinal("carbohydrates"));
                    proteins = reader.GetDecimal(reader.GetOrdinal("proteins"));
                    fats = reader.GetDecimal(reader.GetOrdinal("fats"));
                }

                // Close connections
                reader.Close();
                cmd.Dispose();
                conn.Close();

                // Check database values against new values
                if (foodName != rowObject[1].ToString() | carbs != Convert.ToDecimal(rowObject[2]) |
                    proteins != Convert.ToDecimal(rowObject[3]) | fats != Convert.ToDecimal(rowObject[4]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        // Update food in the database
        private void UpdateFood(object[] rowObject)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands insert data
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"UPDATE foods SET name = '" + rowObject[1] + "', " +
                                    "carbohydrates = " + rowObject[2] + ", " +
                                    "proteins = " + rowObject[3] + ", " +
                                    "fats = " + rowObject[4] + ", " +
                                    "calories = (" + rowObject[2] + " * 4.0) + (" + rowObject[3] + " * 4.0) + (" + rowObject[4] + " * 9.0), " +
                                    "updated_at = GETDATE() " +
                                    "WHERE id = " + rowObject[0],
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

        // Delete selected row of data - This will only put a data into deleted at column
        private void btnDeleteFood_Click(object sender, EventArgs e)
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
                    CommandText = @"DELETE FROM foods WHERE id = " + foodID,
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

            // After the record is soft deleted, refresh food items data grid
            LoadFoodItemData(Program._accountID);
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

        private void frmAddEditFood_Closing(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Program._runProgram = false;
                Application.Exit();
            }
        }
    }
}
