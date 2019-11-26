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
            // Need to make sure this is updated to capture global userID variable
            LoadFoodItemData(1);
        }
        
        ///// Code to add food items to the foods table /////
        // Evaluate data inputs to ensure numbers or data will not load to db
        private void tbCarbs_Leave(object sender, EventArgs e)
        {
            decimal carbs;
            
            if (!decimal.TryParse(tbCarbs.Text, out carbs))
            {
                MessageBox.Show("Please enter only numbers");
                tbCarbs.Text = "";

            }
        }

        private void tbFats_Leave(object sender, EventArgs e)
        {
            decimal fats;

            if (!decimal.TryParse(tbFats.Text, out fats))
            {
                MessageBox.Show("Please enter only numbers");
                tbFats.Text = "";
            }
        }

        private void tbProtein_Leave(object sender, EventArgs e)
        {
            decimal protein;

            if (!decimal.TryParse(tbProtein.Text, out protein))
            {
                MessageBox.Show("Please enter only numbers");
                tbProtein.Text = "";
            }

        }

        // Write food input to table
        private void btnSaveFood_Click(object sender, EventArgs e)
        {
            // Capture input values and transform to proper types
            string foodName = tbFoodName.Text;
            decimal carbs = decimal.Parse(tbCarbs.Text);
            decimal fats = decimal.Parse(tbFats.Text);
            decimal proteins = decimal.Parse(tbProtein.Text);

            // Insert data into foods table
            // Need to make sure this is updated to capture global userID variable
            InsertFoodItemData(1, foodName, carbs, fats, proteins);

            // Reset add food fields
            tbFoodName.Text = "";
            tbCarbs.Text = "";
            tbFats.Text = "";
            tbProtein.Text = "";

            // After table is written to, refresh food items data grid
            // Need to make sure this is updated to capture global userID variable
            LoadFoodItemData(1);
        }

        private void InsertFoodItemData(int userID, string foodName, decimal carbs, decimal fats, decimal proteins)
        {
            //Console.WriteLine("User ID: " + userID);
            //Console.WriteLine("Food Name: " + foodName);
            //Console.WriteLine("Carbohydrates: " + carbs);
            //Console.WriteLine("Fats: " + fats);
            //Console.WriteLine("Proteins: " + proteins);

            // Setup connection
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BFT_DB.mdf;Integrated Security=True");

            // Setup SQL commands to check if user already exists
            SqlCommand cmd = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "",
                Connection = conn
            };
            SqlDataReader reader;

            // Open connection
            conn.Open();

            // Execute insert
            cmd.ExecuteNonQuery();

            // Close connections
            cmd.Dispose();
            conn.Close();
        }

        ///// Code to edit food items to the foods table /////
        // Load current food items user has entered on form load or change
        private void LoadFoodItemData(int userID)
        {
            Console.WriteLine("Load Data Grid Data");
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
