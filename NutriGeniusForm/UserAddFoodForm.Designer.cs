namespace NutriGeniusForm
{
    partial class UserAddFoodForm
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
            cbFoodCategories = new ComboBox();
            txtFoodName = new TextBox();
            label3 = new Label();
            cbPortions = new ComboBox();
            txtCalorie = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnAddFood = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(314, 325);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Yemek Adı : ";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.DisplayMember = "CategoryName";
            cbFoodCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(489, 365);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(222, 23);
            cbFoodCategories.TabIndex = 1;
            // 
            // txtFoodName
            // 
            txtFoodName.BorderStyle = BorderStyle.FixedSingle;
            txtFoodName.Location = new Point(489, 325);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(222, 23);
            txtFoodName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(314, 366);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.TabIndex = 0;
            label3.Text = "Yemek Kategorisi : ";
            // 
            // cbPortions
            // 
            cbPortions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPortions.FormattingEnabled = true;
            cbPortions.Items.AddRange(new object[] { "Porsiyon", "Gram", "Adet", "Bardak", "Yemek Kaşığı" });
            cbPortions.Location = new Point(514, 406);
            cbPortions.Name = "cbPortions";
            cbPortions.Size = new Size(197, 23);
            cbPortions.TabIndex = 3;
            // 
            // txtCalorie
            // 
            txtCalorie.BorderStyle = BorderStyle.FixedSingle;
            txtCalorie.Location = new Point(489, 448);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(222, 23);
            txtCalorie.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(314, 407);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 0;
            label2.Text = "Porsiyon : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(314, 445);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 0;
            label4.Text = "Kalori : ";
            // 
            // btnAddFood
            // 
            btnAddFood.BackColor = Color.DarkSalmon;
            btnAddFood.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddFood.Location = new Point(489, 492);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(222, 31);
            btnAddFood.TabIndex = 5;
            btnAddFood.Text = "Yemek Ekle";
            btnAddFood.UseVisualStyleBackColor = false;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.calorie;
            pictureBox1.Location = new Point(314, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(489, 404);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 7;
            label5.Text = "1";
            // 
            // UserAddFoodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            ClientSize = new Size(1008, 729);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddFood);
            Controls.Add(txtCalorie);
            Controls.Add(cbPortions);
            Controls.Add(txtFoodName);
            Controls.Add(cbFoodCategories);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UserAddFoodForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UserAddFoodForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbFoodCategories;
        private TextBox txtFoodName;
        private Label label3;
        private ComboBox cbPortions;
        private TextBox txtCalorie;
        private Label label2;
        private Label label4;
        private Button btnAddFood;
        private PictureBox pictureBox1;
        private Label label5;
    }
}