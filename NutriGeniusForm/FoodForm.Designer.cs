namespace NutriGeniusForm
{
    partial class FoodForm
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
            label1 = new Label();
            label2 = new Label();
            cbFoodCategory = new ComboBox();
            label3 = new Label();
            clbFoods = new CheckedListBox();
            lstFoods = new ListBox();
            btnSaveFoods = new Button();
            label4 = new Label();
            lblMealName = new Label();
            btnAddFood = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 56);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Yemek Ekle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 111);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "Kategoriler";
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.DisplayMember = "CategoryName";
            cbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(55, 135);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(266, 23);
            cbFoodCategory.TabIndex = 1;
            cbFoodCategory.SelectedIndexChanged += cbFoodCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 177);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 0;
            label3.Text = "Yemekler";
            // 
            // clbFoods
            // 
            clbFoods.FormattingEnabled = true;
            clbFoods.Location = new Point(55, 213);
            clbFoods.Name = "clbFoods";
            clbFoods.Size = new Size(368, 364);
            clbFoods.TabIndex = 2;
            clbFoods.ItemCheck += clbFoods_ItemCheck;
            // 
            // lstFoods
            // 
            lstFoods.FormattingEnabled = true;
            lstFoods.ItemHeight = 15;
            lstFoods.Location = new Point(552, 213);
            lstFoods.Name = "lstFoods";
            lstFoods.Size = new Size(404, 379);
            lstFoods.TabIndex = 3;
            // 
            // btnSaveFoods
            // 
            btnSaveFoods.BackColor = Color.Orange;
            btnSaveFoods.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFoods.Location = new Point(552, 598);
            btnSaveFoods.Name = "btnSaveFoods";
            btnSaveFoods.Size = new Size(404, 33);
            btnSaveFoods.TabIndex = 4;
            btnSaveFoods.Text = "Kaydet";
            btnSaveFoods.UseVisualStyleBackColor = false;
            btnSaveFoods.Click += btnSaveFoods_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(552, 183);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 5;
            label4.Text = "Seçilenler";
            // 
            // lblMealName
            // 
            lblMealName.AutoSize = true;
            lblMealName.BackColor = Color.Transparent;
            lblMealName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMealName.Location = new Point(871, 56);
            lblMealName.Name = "lblMealName";
            lblMealName.Size = new Size(48, 21);
            lblMealName.TabIndex = 5;
            lblMealName.Text = "label";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.YellowGreen;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(55, 598);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(368, 33);
            btnAddFood.TabIndex = 6;
            btnAddFood.Text = "Aradığım yemek listede yok";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnAddFood);
            Controls.Add(lblMealName);
            Controls.Add(label4);
            Controls.Add(btnSaveFoods);
            Controls.Add(lstFoods);
            Controls.Add(clbFoods);
            Controls.Add(cbFoodCategory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FoodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbFoodCategory;
        private Label label3;
        private CheckedListBox clbFoods;
        private ListBox lstFoods;
        private Button btnSaveFoods;
        private Label label4;
        private Label lblMealName;
        private Button btnAddFood;
    }
}