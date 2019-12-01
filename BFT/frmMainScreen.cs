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

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            // Welcome message
            lblWelcomeText.Text = $"Hello {Program._firstName}!";

            var log = GetFoodLog();
            var summary = GetFoodSummary();            

            RenderFoodLog(log);
            RenderFoodSummary(summary);
            RenderTotals(summary);
        }

        private void RenderFoodSummary(DataSet summary)
        {
            var xMin = DateTime.MaxValue;
            var xMax = DateTime.MinValue;
            var yMax = decimal.MinValue;

            foreach (DataRow row in summary.Tables[0].Rows)
            {
                var c = row["calories"] as decimal?;
                var d = row["created_at"] as DateTime?;

                if (d < xMin) xMin = d.Value;
                if (d > xMax) xMax = d.Value;

                if (c > yMax) yMax = c.Value;
            }

            chartFoodLog.DataSource = summary.Tables[0];
            chartFoodLog.ChartAreas[0].AxisX.Maximum = xMax.ToOADate();
            chartFoodLog.ChartAreas[0].AxisX.Minimum = xMin.ToOADate();
            chartFoodLog.ChartAreas[0].AxisY.Maximum = (double)yMax;
            chartFoodLog.ChartAreas[0].AxisY.Minimum = 0;
        }

        private void RenderFoodLog(DataSet log)
        {
            dgvFoodLog.AutoGenerateColumns = false;
            dgvFoodLog.DataSource = log.Tables[0];
        }

        private void RenderTotals(DataSet summary)
        {
            ///// This has an issue if user does not have data - Need to resolve /////
            var numberOfRows = summary.Tables[0].Rows.Count;
            var lastRow = summary.Tables[0].Rows[numberOfRows - 1];
            var totalCalories = lastRow["calories"];

            lblDailyCalories.Text = string.Format("{0:0}", totalCalories);
        }

        private DataSet GetFoodSummary()
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT round(sum(cast(f.calories as decimal))/100, 0) as calories
                                         , round(sum(cast(f.carbohydrates as int))/100, 0) as carbohydrates
                                         , round(sum(cast(f.fats as int))/100, 0) as fats
                                         , round(sum(cast(f.proteins as int))/100, 0) as proteins
                                         , cast(fl.created_at as DateTime) as created_at
                                    FROM dbo.food_log fl
                                    JOIN dbo.foods f ON f.id = fl.food_id
                                    WHERE fl.account_id = " + Program._accountID + @"
                                    GROUP BY fl.created_at
                                    ORDER BY fl.created_at ASC",
                    Connection = conn
                };
                var adapter = new SqlDataAdapter(cmd);
                var dataset = new DataSet();

                conn.Open();
                adapter.Fill(dataset);

                return dataset;
            }
        }

        private DataSet GetFoodLog()
        {
            using (var conn = new SqlConnection(_connectionString))
            {                
                var cmd = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = @"SELECT f.name
                                         , cast(f.calories as decimal) as calories
                                         , cast(f.carbohydrates as int) as carbohydrates
                                         , cast(f.fats as int) as fats
                                         , cast(f.proteins as int) as proteins
                                         , cast(fl.created_at as DateTime) as created_at
                                    FROM dbo.food_log fl
                                    JOIN dbo.foods f ON f.id = fl.food_id
                                    WHERE fl.account_id = " + Program._accountID + @"
                                    ORDER BY fl.created_at DESC",
                    Connection = conn
                };
                var adapter = new SqlDataAdapter(cmd);
                var dataset = new DataSet();

                conn.Open();
                adapter.Fill(dataset);                

                return dataset;
            }
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

        private void btnLogOut_Click(object sender, EventArgs e)
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
