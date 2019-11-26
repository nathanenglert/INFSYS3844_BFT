using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFT
{
    public partial class frmAddEditFood : Form
    {
        public frmAddEditFood()
        {
            InitializeComponent();
            // Need to make sure this is updated to capture global account ID variable
            LoadFoodItemData(1);
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

        ///// Code to block to manipulate food items /////
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
                string foodName = tbFoodName.Text;
                decimal carbs = decimal.Parse(tbCarbs.Text);
                decimal fats = decimal.Parse(tbFats.Text);
                decimal proteins = decimal.Parse(tbProtein.Text);
                decimal calories = (carbs * 4) + (fats * 9) + (proteins * 4);

                // Insert data into foods table
                // Need to make sure this is updated to capture global account ID variable
                InsertFoodItemData(1, foodName, carbs, proteins, fats, calories);

                // Reset add food fields
                tbFoodName.Text = "";
                tbCarbs.Text = "";
                tbFats.Text = "";
                tbProtein.Text = "";

                // After table is written to, refresh food items data grid
                // Need to make sure this is updated to capture global account ID variable
                LoadFoodItemData(1);
            }
        }

        private void InsertFoodItemData(int accountID, string foodName, decimal carbs, decimal proteins, decimal fats, decimal calories)
        {
            // New DatabaseMethod instance
            DatabaseMethods db = new DatabaseMethods();

            // Setup connection
            SqlConnection conn = new SqlConnection(db.DBConnectionString());

            // Setup SQL commands insert data
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = @"INSERT INTO foods (name, carbohydrates, proteins, fats, calories, added_by_account_id) VALUES ('" +
                               foodName + "'," + carbs + "," + proteins + "," + fats + "," + calories + "," + accountID + ")",
                Connection = conn
            };

            Console.WriteLine(cmd.CommandText);

            // Open connection
            conn.Open();

            // Execute insert
            cmd.ExecuteNonQuery();

            // Close connections
            cmd.Dispose();
            conn.Close();
        }

        // Load current food items user has entered on form load or food item added
        private void LoadFoodItemData(int accountID)
        {
            // New DatabaseMethod instance
            DatabaseMethods db = new DatabaseMethods();

            // Setup connection
            SqlConnection conn = new SqlConnection(db.DBConnectionString());

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

            dgvFoodItems.DataSource = ds.Tables[0];
        }

        // Update selected row of data with changes
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {

        }

        // Delete selected row of data - This will only put a data into deleted at column
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
