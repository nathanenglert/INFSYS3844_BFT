namespace BFT
{
    partial class frmAddEditFood
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
            this.gbAddFoodItem = new System.Windows.Forms.GroupBox();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.tbFats = new System.Windows.Forms.TextBox();
            this.tbProtein = new System.Windows.Forms.TextBox();
            this.tbCarbs = new System.Windows.Forms.TextBox();
            this.btnSaveFood = new System.Windows.Forms.Button();
            this.lblFats = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.btnFoodName = new System.Windows.Forms.Label();
            this.gbEditFoodItems = new System.Windows.Forms.GroupBox();
            this.dgvFoodItems = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.gbAddFoodItem.SuspendLayout();
            this.gbEditFoodItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddFoodItem
            // 
            this.gbAddFoodItem.Controls.Add(this.tbFoodName);
            this.gbAddFoodItem.Controls.Add(this.tbFats);
            this.gbAddFoodItem.Controls.Add(this.tbProtein);
            this.gbAddFoodItem.Controls.Add(this.tbCarbs);
            this.gbAddFoodItem.Controls.Add(this.btnSaveFood);
            this.gbAddFoodItem.Controls.Add(this.lblFats);
            this.gbAddFoodItem.Controls.Add(this.lblProtein);
            this.gbAddFoodItem.Controls.Add(this.lblCarbs);
            this.gbAddFoodItem.Controls.Add(this.btnFoodName);
            this.gbAddFoodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddFoodItem.Location = new System.Drawing.Point(12, 12);
            this.gbAddFoodItem.Name = "gbAddFoodItem";
            this.gbAddFoodItem.Size = new System.Drawing.Size(1950, 478);
            this.gbAddFoodItem.TabIndex = 0;
            this.gbAddFoodItem.TabStop = false;
            this.gbAddFoodItem.Text = "Add Food Item";
            // 
            // tbFoodName
            // 
            this.tbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFoodName.Location = new System.Drawing.Point(466, 64);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(870, 62);
            this.tbFoodName.TabIndex = 1;
            // 
            // tbFats
            // 
            this.tbFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFats.Location = new System.Drawing.Point(990, 182);
            this.tbFats.Name = "tbFats";
            this.tbFats.Size = new System.Drawing.Size(346, 62);
            this.tbFats.TabIndex = 5;
            this.tbFats.Leave += new System.EventHandler(this.tbFats_Leave);
            // 
            // tbProtein
            // 
            this.tbProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProtein.Location = new System.Drawing.Point(466, 306);
            this.tbProtein.Name = "tbProtein";
            this.tbProtein.Size = new System.Drawing.Size(346, 62);
            this.tbProtein.TabIndex = 7;
            this.tbProtein.Leave += new System.EventHandler(this.tbProtein_Leave);
            // 
            // tbCarbs
            // 
            this.tbCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCarbs.Location = new System.Drawing.Point(466, 182);
            this.tbCarbs.Name = "tbCarbs";
            this.tbCarbs.Size = new System.Drawing.Size(346, 62);
            this.tbCarbs.TabIndex = 3;
            this.tbCarbs.Leave += new System.EventHandler(this.tbCarbs_Leave);
            // 
            // btnSaveFood
            // 
            this.btnSaveFood.Location = new System.Drawing.Point(990, 310);
            this.btnSaveFood.Name = "btnSaveFood";
            this.btnSaveFood.Size = new System.Drawing.Size(279, 71);
            this.btnSaveFood.TabIndex = 8;
            this.btnSaveFood.Text = "Save Food";
            this.btnSaveFood.UseVisualStyleBackColor = true;
            this.btnSaveFood.Click += new System.EventHandler(this.btnSaveFood_Click);
            // 
            // lblFats
            // 
            this.lblFats.AutoSize = true;
            this.lblFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFats.Location = new System.Drawing.Point(854, 186);
            this.lblFats.Name = "lblFats";
            this.lblFats.Size = new System.Drawing.Size(130, 55);
            this.lblFats.TabIndex = 4;
            this.lblFats.Text = "Fats:";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.Location = new System.Drawing.Point(106, 310);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(213, 55);
            this.lblProtein.TabIndex = 6;
            this.lblProtein.Text = "Proteins:";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarbs.Location = new System.Drawing.Point(106, 186);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(354, 55);
            this.lblCarbs.TabIndex = 2;
            this.lblCarbs.Text = "Carbohydrates:";
            // 
            // btnFoodName
            // 
            this.btnFoodName.AutoSize = true;
            this.btnFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodName.Location = new System.Drawing.Point(106, 68);
            this.btnFoodName.Name = "btnFoodName";
            this.btnFoodName.Size = new System.Drawing.Size(289, 55);
            this.btnFoodName.TabIndex = 0;
            this.btnFoodName.Text = "Food Name:";
            // 
            // gbEditFoodItems
            // 
            this.gbEditFoodItems.Controls.Add(this.btnDeleteFood);
            this.gbEditFoodItems.Controls.Add(this.btnUpdateFood);
            this.gbEditFoodItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditFoodItems.Location = new System.Drawing.Point(1640, 522);
            this.gbEditFoodItems.Name = "gbEditFoodItems";
            this.gbEditFoodItems.Size = new System.Drawing.Size(322, 283);
            this.gbEditFoodItems.TabIndex = 1;
            this.gbEditFoodItems.TabStop = false;
            this.gbEditFoodItems.Text = "Edit Food Items";
            // 
            // dgvFoodItems
            // 
            this.dgvFoodItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFoodItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodItems.Location = new System.Drawing.Point(13, 522);
            this.dgvFoodItems.Name = "dgvFoodItems";
            this.dgvFoodItems.ReadOnly = true;
            this.dgvFoodItems.RowHeadersWidth = 82;
            this.dgvFoodItems.RowTemplate.Height = 33;
            this.dgvFoodItems.Size = new System.Drawing.Size(1599, 695);
            this.dgvFoodItems.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1646, 1045);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 100);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(1646, 927);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(300, 100);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Return to Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.Location = new System.Drawing.Point(6, 53);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(300, 100);
            this.btnUpdateFood.TabIndex = 1;
            this.btnUpdateFood.Text = "Update Food";
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(6, 160);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(300, 100);
            this.btnDeleteFood.TabIndex = 2;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // frmAddEditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1974, 1229);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvFoodItems);
            this.Controls.Add(this.gbEditFoodItems);
            this.Controls.Add(this.gbAddFoodItem);
            this.Name = "frmAddEditFood";
            this.Text = "Manage Food Items";
            this.gbAddFoodItem.ResumeLayout(false);
            this.gbAddFoodItem.PerformLayout();
            this.gbEditFoodItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddFoodItem;
        private System.Windows.Forms.GroupBox gbEditFoodItems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label btnFoodName;
        private System.Windows.Forms.Label lblFats;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Button btnSaveFood;
        private System.Windows.Forms.TextBox tbFats;
        private System.Windows.Forms.TextBox tbProtein;
        private System.Windows.Forms.TextBox tbCarbs;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.DataGridView dgvFoodItems;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnUpdateFood;
    }
}