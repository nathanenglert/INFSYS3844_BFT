namespace BFT
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.btnManageFood = new System.Windows.Forms.Button();
            this.btnLogFood = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDailyCals = new System.Windows.Forms.Label();
            this.pnlDailyCals = new System.Windows.Forms.Panel();
            this.lblDailyCalories = new System.Windows.Forms.Label();
            this.dgvFoodLog = new System.Windows.Forms.DataGridView();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            this.btnRefreshScreen = new System.Windows.Forms.Button();
            this.chartFoodLog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDailyCals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoodLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(24, 17);
            this.lblWelcomeText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(220, 37);
            this.lblWelcomeText.TabIndex = 0;
            this.lblWelcomeText.Text = "Hello, [Name]!";
            // 
            // btnManageFood
            // 
            this.btnManageFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageFood.Location = new System.Drawing.Point(1657, 744);
            this.btnManageFood.Margin = new System.Windows.Forms.Padding(6);
            this.btnManageFood.Name = "btnManageFood";
            this.btnManageFood.Size = new System.Drawing.Size(300, 100);
            this.btnManageFood.TabIndex = 1;
            this.btnManageFood.Text = "Manage Food";
            this.btnManageFood.UseVisualStyleBackColor = true;
            this.btnManageFood.Click += new System.EventHandler(this.btnManageFood_Click);
            // 
            // btnLogFood
            // 
            this.btnLogFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogFood.Location = new System.Drawing.Point(1657, 632);
            this.btnLogFood.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogFood.Name = "btnLogFood";
            this.btnLogFood.Size = new System.Drawing.Size(300, 100);
            this.btnLogFood.TabIndex = 2;
            this.btnLogFood.Text = "Log Food";
            this.btnLogFood.UseVisualStyleBackColor = true;
            this.btnLogFood.Click += new System.EventHandler(this.btnLogFood_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1657, 968);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(300, 100);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1657, 1080);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 100);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDailyCals
            // 
            this.lblDailyCals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyCals.Location = new System.Drawing.Point(6, 35);
            this.lblDailyCals.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDailyCals.Name = "lblDailyCals";
            this.lblDailyCals.Size = new System.Drawing.Size(290, 44);
            this.lblDailyCals.TabIndex = 5;
            this.lblDailyCals.Text = "Daily Calories";
            this.lblDailyCals.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDailyCals
            // 
            this.pnlDailyCals.Controls.Add(this.lblDailyCalories);
            this.pnlDailyCals.Controls.Add(this.lblDailyCals);
            this.pnlDailyCals.Location = new System.Drawing.Point(1657, 81);
            this.pnlDailyCals.Margin = new System.Windows.Forms.Padding(6);
            this.pnlDailyCals.Name = "pnlDailyCals";
            this.pnlDailyCals.Size = new System.Drawing.Size(300, 200);
            this.pnlDailyCals.TabIndex = 6;
            // 
            // lblDailyCalories
            // 
            this.lblDailyCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyCalories.Location = new System.Drawing.Point(6, 86);
            this.lblDailyCalories.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDailyCalories.Name = "lblDailyCalories";
            this.lblDailyCalories.Size = new System.Drawing.Size(290, 98);
            this.lblDailyCalories.TabIndex = 6;
            this.lblDailyCalories.Text = "0";
            this.lblDailyCalories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvFoodLog
            // 
            this.dgvFoodLog.AllowUserToAddRows = false;
            this.dgvFoodLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoodLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodLog.Location = new System.Drawing.Point(32, 463);
            this.dgvFoodLog.Margin = new System.Windows.Forms.Padding(6);
            this.dgvFoodLog.Name = "dgvFoodLog";
            this.dgvFoodLog.ReadOnly = true;
            this.dgvFoodLog.RowHeadersWidth = 82;
            this.dgvFoodLog.Size = new System.Drawing.Size(1613, 717);
            this.dgvFoodLog.TabIndex = 7;
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMeal.Location = new System.Drawing.Point(1657, 856);
            this.btnDeleteMeal.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(300, 100);
            this.btnDeleteMeal.TabIndex = 9;
            this.btnDeleteMeal.Text = "Delete Selected Meal";
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            this.btnDeleteMeal.Click += new System.EventHandler(this.btnDeleteMeal_Click);
            // 
            // btnRefreshScreen
            // 
            this.btnRefreshScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshScreen.Location = new System.Drawing.Point(1657, 293);
            this.btnRefreshScreen.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefreshScreen.Name = "btnRefreshScreen";
            this.btnRefreshScreen.Size = new System.Drawing.Size(300, 100);
            this.btnRefreshScreen.TabIndex = 10;
            this.btnRefreshScreen.Text = "Refresh Screen";
            this.btnRefreshScreen.UseVisualStyleBackColor = true;
            this.btnRefreshScreen.Click += new System.EventHandler(this.btnRefreshScreen_Click);
            // 
            // chartFoodLog
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFoodLog.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFoodLog.Legends.Add(legend1);
            this.chartFoodLog.Location = new System.Drawing.Point(32, 57);
            this.chartFoodLog.Name = "chartFoodLog";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Calories";
            series1.XValueMember = "date";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueMembers = "calories";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Carbs";
            series2.XValueMember = "date";
            series2.YValueMembers = "carbs";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Fats";
            series3.XValueMember = "date";
            series3.YValueMembers = "fats";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Proteins";
            series4.XValueMember = "date";
            series4.YValueMembers = "proteins";
            this.chartFoodLog.Series.Add(series1);
            this.chartFoodLog.Series.Add(series2);
            this.chartFoodLog.Series.Add(series3);
            this.chartFoodLog.Series.Add(series4);
            this.chartFoodLog.Size = new System.Drawing.Size(1613, 397);
            this.chartFoodLog.TabIndex = 11;
            this.chartFoodLog.Text = "chart1";
            this.chartFoodLog.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chartFoodLog.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.chartFoodLog.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1974, 1229);
            this.Controls.Add(this.chartFoodLog);
            this.Controls.Add(this.btnRefreshScreen);
            this.Controls.Add(this.btnDeleteMeal);
            this.Controls.Add(this.dgvFoodLog);
            this.Controls.Add(this.pnlDailyCals);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLogFood);
            this.Controls.Add(this.btnManageFood);
            this.Controls.Add(this.lblWelcomeText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMainScreen";
            this.Text = "frmMainScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainScreen_Closing);
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.pnlDailyCals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoodLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Button btnManageFood;
        private System.Windows.Forms.Button btnLogFood;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDailyCals;
        private System.Windows.Forms.Panel pnlDailyCals;
        private System.Windows.Forms.Label lblDailyCalories;
        private System.Windows.Forms.DataGridView dgvFoodLog;
        private System.Windows.Forms.Button btnDeleteMeal;
        private System.Windows.Forms.Button btnRefreshScreen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFoodLog;
    }
}