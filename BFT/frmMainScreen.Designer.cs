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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblWelcomeText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDailyCalories = new System.Windows.Forms.Label();
            this.dgvFoodLog = new System.Windows.Forms.DataGridView();
            this.chartFoodLog = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydrates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoodLog)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeText
            // 
            this.lblWelcomeText.AutoSize = true;
            this.lblWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeText.Location = new System.Drawing.Point(12, 9);
            this.lblWelcomeText.Name = "lblWelcomeText";
            this.lblWelcomeText.Size = new System.Drawing.Size(107, 20);
            this.lblWelcomeText.TabIndex = 0;
            this.lblWelcomeText.Text = "Hello, [Name]!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manage";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Track";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 562);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(588, 591);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Daily Calories";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDailyCalories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(588, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 100);
            this.panel1.TabIndex = 6;
            // 
            // lblDailyCalories
            // 
            this.lblDailyCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyCalories.Location = new System.Drawing.Point(3, 49);
            this.lblDailyCalories.Name = "lblDailyCalories";
            this.lblDailyCalories.Size = new System.Drawing.Size(145, 51);
            this.lblDailyCalories.TabIndex = 6;
            this.lblDailyCalories.Text = "0";
            this.lblDailyCalories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvFoodLog
            // 
            this.dgvFoodLog.AllowUserToAddRows = false;
            this.dgvFoodLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.calories,
            this.carbohydrates,
            this.fats,
            this.proteins,
            this.created_at});
            this.dgvFoodLog.Location = new System.Drawing.Point(16, 241);
            this.dgvFoodLog.Name = "dgvFoodLog";
            this.dgvFoodLog.ReadOnly = true;
            this.dgvFoodLog.Size = new System.Drawing.Size(566, 373);
            this.dgvFoodLog.TabIndex = 7;
            // 
            // chartFoodLog
            // 
            chartArea9.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX2.Maximum = 2000D;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea9.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea9.Name = "ChartArea1";
            this.chartFoodLog.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartFoodLog.Legends.Add(legend9);
            this.chartFoodLog.Location = new System.Drawing.Point(16, 42);
            this.chartFoodLog.Name = "chartFoodLog";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series33.Legend = "Legend1";
            series33.Name = "Calories";
            series33.XValueMember = "created_at";
            series33.YValueMembers = "calories";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series34.Legend = "Legend1";
            series34.Name = "Carbs";
            series34.XValueMember = "created_at";
            series34.YValueMembers = "carbohydrates";
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series35.Legend = "Legend1";
            series35.Name = "Fats";
            series35.XValueMember = "created_at";
            series35.YValueMembers = "fats";
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series36.Legend = "Legend1";
            series36.Name = "Proteins";
            series36.XValueMember = "proteins";
            series36.YValueMembers = "created_at";
            this.chartFoodLog.Series.Add(series33);
            this.chartFoodLog.Series.Add(series34);
            this.chartFoodLog.Series.Add(series35);
            this.chartFoodLog.Series.Add(series36);
            this.chartFoodLog.Size = new System.Drawing.Size(566, 193);
            this.chartFoodLog.TabIndex = 8;
            this.chartFoodLog.Text = "chart1";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // calories
            // 
            this.calories.DataPropertyName = "calories";
            this.calories.HeaderText = "Calories";
            this.calories.Name = "calories";
            this.calories.ReadOnly = true;
            // 
            // carbohydrates
            // 
            this.carbohydrates.DataPropertyName = "carbohydrates";
            this.carbohydrates.HeaderText = "Carbs";
            this.carbohydrates.Name = "carbohydrates";
            this.carbohydrates.ReadOnly = true;
            // 
            // fats
            // 
            this.fats.DataPropertyName = "fats";
            this.fats.HeaderText = "Fats";
            this.fats.Name = "fats";
            this.fats.ReadOnly = true;
            // 
            // proteins
            // 
            this.proteins.DataPropertyName = "proteins";
            this.proteins.HeaderText = "Proteins";
            this.proteins.Name = "proteins";
            this.proteins.ReadOnly = true;
            // 
            // created_at
            // 
            this.created_at.DataPropertyName = "created_at";
            this.created_at.HeaderText = "Date";
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 626);
            this.Controls.Add(this.chartFoodLog);
            this.Controls.Add(this.dgvFoodLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcomeText);
            this.Name = "frmMainScreen";
            this.Text = "frmMainScreen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFoodLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDailyCalories;
        private System.Windows.Forms.DataGridView dgvFoodLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFoodLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn calories;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydrates;
        private System.Windows.Forms.DataGridViewTextBoxColumn fats;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteins;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
    }
}