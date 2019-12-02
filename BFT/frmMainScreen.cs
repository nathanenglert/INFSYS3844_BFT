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
    public partial class frmMainScreen : Form
    {
        // Create conenction string variable for later use
        private string _connectionString;

        public frmMainScreen()
        {
            InitializeComponent();

            // Get connection string
            _connectionString = new DatabaseMethods().DBConnectionString();
        }

        public void frmMainScreen_Load(object sender, EventArgs e)
        {
            // Welcome message
            lblWelcomeText.Text = $"Hello {Program._firstName}!";

            // Load data
            LoadData();
        }

        private void LoadData()
        {
            // Load Logs for data grid
            var log = GetFoodLog();

            // Load data for line chart
            var summary = GetFoodSummary();
            
            // Load daily total
            var dailyTotals = GetDailyTotals();

            // Render if fields contain data
            if (log.Tables[0].Rows.Count != 0)
            {
                RenderFoodLog(log);
                RenderFoodSummary(summary);
                RenderTotals(dailyTotals);
            }
        }

        // Load account row level data to data grid
        private DataSet GetFoodLog()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT
                                    food_log.id AS ID
                                    ,foods.name AS Name
                                    ,foods.carbohydrates AS Carbohydrates
                                    ,foods.fats AS Fats
                                    ,foods.proteins AS Proteins
                                    ,foods.calories AS Calories
                                    ,CAST(food_log.created_at AS DATE) AS Date
                                    FROM
                                    food_log
                                    LEFT JOIN foods ON (foods.id = food_log.food_id)
                                    WHERE
                                    foods.deleted_at IS NULL
                                    AND food_log.account_id = " + Program._accountID +
                                  @"ORDER BY
                                    food_log.created_at DESC",
                    Connection = conn
                };
                var adapter = new SqlDataAdapter(cmd);
                var dataset = new DataSet();

                conn.Open();
                adapter.Fill(dataset);

                return dataset;
            }
        }

        private void RenderFoodLog(DataSet log)
        {
            dgvFoodLog.DataSource = log.Tables[0];
        }

        // Load aggregate account level data to line chart
        private DataSet GetFoodSummary()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT
                                    CAST(food_log.created_at AS DATE) AS date
                                    ,SUM(foods.carbohydrates) AS carbs
                                    ,SUM(foods.fats) AS fats
                                    ,SUM(foods.proteins) AS proteins
                                    ,SUM(foods.calories) AS calories
                                    FROM
                                    food_log
                                    LEFT JOIN foods ON (foods.id = food_log.food_id)
                                    WHERE
                                    foods.deleted_at IS NULL
                                    AND CAST(food_log.created_at AS DATE) BETWEEN DATEADD(day, -7, GETDATE()) AND CAST(GETDATE() AS DATE)
                                    AND food_log.account_id =" + Program._accountID +
                                  @"GROUP BY
                                    CAST(food_log.created_at AS DATE)",
                    Connection = conn
                };
                var adapter = new SqlDataAdapter(cmd);
                var dataset = new DataSet();

                conn.Open();
                adapter.Fill(dataset);

                return dataset;
            }
        }

        private void RenderFoodSummary(DataSet summary)
        {
            var xMin = DateTime.MaxValue;
            var xMax = DateTime.MinValue;
            var yMaxPrime = decimal.MinValue;
            var yMinPrime = decimal.MaxValue;
            var yMaxSecond = decimal.MinValue;
            var yMinSecond = decimal.MaxValue;

            // Calculate min / max for axes
            foreach (DataRow row in summary.Tables[0].Rows)
            {
                var date = row["date"] as DateTime?; // X-axis
                var carb = row["carbs"] as Decimal?; // Primary y-axis
                var cal = row["calories"] as Decimal?; // Secondary y-axis

                if (date < xMin) xMin = date.Value;
                if (date > xMax) xMax = date.Value;
                if (carb < yMinPrime) yMinPrime = carb.Value;
                if (carb > yMaxPrime) yMaxPrime = carb.Value;
                if (carb < yMinSecond) yMinSecond = cal.Value;
                if (cal > yMaxSecond) yMaxSecond = cal.Value;
            }

            chartFoodLog.DataSource = summary.Tables[0];
            chartFoodLog.ChartAreas[0].AxisX.Maximum = xMax.ToOADate();
            chartFoodLog.ChartAreas[0].AxisX.Minimum = xMin.ToOADate();
            // Primary axis
            chartFoodLog.ChartAreas[0].AxisY.Maximum = (double) yMaxPrime;
            chartFoodLog.ChartAreas[0].AxisY.Minimum = (double) yMinPrime;

            // Secondary axis
            chartFoodLog.ChartAreas[0].AxisY2.Maximum = (double) yMaxSecond;
            chartFoodLog.ChartAreas[0].AxisY2.Minimum = (double) yMinPrime;
        }

        // Load daily caloric intake to daily calorie panel
        private decimal GetDailyTotals()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                // Capture daily calories
                decimal dailyCalories = 0.0M;
                
                var cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT
                                    SUM(foods.calories) AS calories
                                    FROM
                                    food_log
                                    LEFT JOIN foods ON (foods.id = food_log.food_id)
                                    WHERE
                                    foods.deleted_at IS NULL
                                    AND CAST(food_log.created_at AS DATE) = CAST(GETDATE() AS DATE)
                                    AND food_log.account_id = " + Program._accountID,
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
                    if (reader.Read())
                    {
                    dailyCalories = Convert.ToDecimal(reader["calories"]);
                    }
                    else
                    {
                        dailyCalories = 0.0M;
                    }
                }

                return dailyCalories;
            }
        }

        private void RenderTotals(decimal dailyCalories)
        {
            lblDailyCalories.Text = string.Format("{0:0}", dailyCalories);
        }

        private void btnRefreshScreen_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLogFood_Click(object sender, EventArgs e)
        {
            frmLogFood frmLogFood = new frmLogFood();
            frmLogFood.Show();
        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {
            frmAddEditFood frmAddEditFood = new frmAddEditFood();
            frmAddEditFood.Show();
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            // Capture highlighted row
            int rowIndex = dgvFoodLog.CurrentCell.RowIndex;

            // Capture highlighted row
            DataGridViewRow row = dgvFoodLog.Rows[rowIndex];

            // Capture food id row
            int foodID = Convert.ToInt32(row.Cells[0].Value);

            using (var conn = new SqlConnection(_connectionString))
            {
                // Setup SQL commands insert data
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"DELETE FROM food_log WHERE id = " + foodID,
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

            // Reload data
            LoadData();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program._runProgram = false;
            Application.Exit();
        }

        private void frmMainScreen_Closing(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Program._runProgram = false;
                Application.Exit();
            }
        }
    }
}
