namespace BFT
{
    partial class frmLogFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogFood));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogFood = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.dgvFoodItems = new System.Windows.Forms.DataGridView();
            this.lblSelectFood = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(659, 502);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 100);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogFood
            // 
            this.btnLogFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogFood.Location = new System.Drawing.Point(25, 502);
            this.btnLogFood.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogFood.Name = "btnLogFood";
            this.btnLogFood.Size = new System.Drawing.Size(300, 100);
            this.btnLogFood.TabIndex = 6;
            this.btnLogFood.Text = "Log Food";
            this.btnLogFood.UseVisualStyleBackColor = true;
            this.btnLogFood.Click += new System.EventHandler(this.btnLogFood_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(347, 502);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(6);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(300, 100);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Return to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // dgvFoodItems
            // 
            this.dgvFoodItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoodItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodItems.Location = new System.Drawing.Point(25, 116);
            this.dgvFoodItems.Name = "dgvFoodItems";
            this.dgvFoodItems.ReadOnly = true;
            this.dgvFoodItems.RowHeadersWidth = 82;
            this.dgvFoodItems.RowTemplate.Height = 33;
            this.dgvFoodItems.Size = new System.Drawing.Size(934, 360);
            this.dgvFoodItems.TabIndex = 8;
            // 
            // lblSelectFood
            // 
            this.lblSelectFood.AutoSize = true;
            this.lblSelectFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFood.Location = new System.Drawing.Point(16, 62);
            this.lblSelectFood.Name = "lblSelectFood";
            this.lblSelectFood.Size = new System.Drawing.Size(394, 51);
            this.lblSelectFood.TabIndex = 9;
            this.lblSelectFood.Text = "Select Food to Log:";
            // 
            // frmLogFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.lblSelectFood);
            this.Controls.Add(this.dgvFoodItems);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnLogFood);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogFood";
            this.Text = "Log Food";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogFood;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.DataGridView dgvFoodItems;
        private System.Windows.Forms.Label lblSelectFood;
    }
}