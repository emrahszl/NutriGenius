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
            lstFoods = new ListBox();
            btnSaveFoods = new Button();
            label4 = new Label();
            lblMealName = new Label();
            btnAddFood = new Button();
            cbFoods = new ComboBox();
            label5 = new Label();
            cbPortions = new ComboBox();
            nudPiece = new NumericUpDown();
            label6 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPiece).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 197);
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
            label2.Location = new Point(59, 252);
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
            cbFoodCategory.Location = new Point(59, 287);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(322, 23);
            cbFoodCategory.TabIndex = 1;
            cbFoodCategory.SelectedIndexChanged += cbFoodCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 324);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 0;
            label3.Text = "Yemekler";
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
            btnAddFood.Location = new Point(59, 598);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(322, 33);
            btnAddFood.TabIndex = 6;
            btnAddFood.Text = "Aradığım yemek listede yok";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbFoods
            // 
            cbFoods.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoods.FormattingEnabled = true;
            cbFoods.Location = new Point(59, 359);
            cbFoods.Name = "cbFoods";
            cbFoods.Size = new Size(322, 23);
            cbFoods.TabIndex = 7;
            cbFoods.SelectedIndexChanged += cbFoods_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(59, 396);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 0;
            label5.Text = "Porsiyon";
            // 
            // cbPortions
            // 
            cbPortions.DisplayMember = "Unit";
            cbPortions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPortions.FormattingEnabled = true;
            cbPortions.Location = new Point(59, 431);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(322, 23);
            cbPortions.TabIndex = 7;
            // 
            // nudPiece
            // 
            nudPiece.Location = new Point(62, 503);
            nudPiece.Name = "nudPiece";
            nudPiece.Size = new Size(319, 23);
            nudPiece.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(63, 468);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 9;
            label6.Text = "Adet";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(59, 548);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(322, 33);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(1008, 729);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(nudPiece);
            Controls.Add(cbPortions);
            Controls.Add(cbFoods);
            Controls.Add(btnAddFood);
            Controls.Add(lblMealName);
            Controls.Add(label4);
            Controls.Add(btnSaveFoods);
            Controls.Add(lstFoods);
            Controls.Add(label5);
            Controls.Add(cbFoodCategory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)nudPiece).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbFoodCategory;
        private Label label3;
        private ListBox lstFoods;
        private Button btnSaveFoods;
        private Label label4;
        private Label lblMealName;
        private Button btnAddFood;
        private ComboBox cbFoods;
        private Label label5;
        private ComboBox cbPortions;
        private NumericUpDown nudPiece;
        private Label label6;
        private Button btnAdd;
    }
}