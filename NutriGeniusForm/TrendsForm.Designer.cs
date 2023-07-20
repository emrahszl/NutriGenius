namespace NutriGeniusForm
{
    partial class TrendsForm
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
            dgvTop5 = new DataGridView();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            mtnMonthly = new Button();
            btnWeekly = new Button();
            pictureBox1 = new PictureBox();
            lblName = new Label();
            label2 = new Label();
            lstUserBreakfast = new ListBox();
            lstAllUserBreakfast = new ListBox();
            lstUserLunch = new ListBox();
            lstAllUserLunch = new ListBox();
            lstUserDinner = new ListBox();
            lstAllUserDinner = new ListBox();
            lstUserSnack = new ListBox();
            lstAllUserSnack = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTop5
            // 
            dgvTop5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTop5.Location = new Point(31, 560);
            dgvTop5.Margin = new Padding(3, 2, 3, 2);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.RowTemplate.Height = 29;
            dgvTop5.Size = new Size(949, 158);
            dgvTop5.TabIndex = 47;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.top_5;
            pictureBox2.Location = new Point(31, 481);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(949, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Orange;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(779, 171);
            label6.Name = "label6";
            label6.Size = new Size(201, 30);
            label6.TabIndex = 32;
            label6.Text = "Ara Öğün";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Orange;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(568, 171);
            label5.Name = "label5";
            label5.Size = new Size(201, 30);
            label5.TabIndex = 31;
            label5.Text = "Akşam Yemeği";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Orange;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(357, 171);
            label4.Name = "label4";
            label4.Size = new Size(201, 30);
            label4.TabIndex = 30;
            label4.Text = " Öğle Yemeği";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Orange;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(146, 171);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 29;
            label3.Text = "Kahvaltı";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 85);
            label1.Name = "label1";
            label1.Size = new Size(206, 30);
            label1.TabIndex = 27;
            label1.Text = "KALORİ YARIŞLARI!";
            // 
            // mtnMonthly
            // 
            mtnMonthly.BackColor = Color.LightGray;
            mtnMonthly.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mtnMonthly.Location = new Point(99, 122);
            mtnMonthly.Margin = new Padding(3, 2, 3, 2);
            mtnMonthly.Name = "mtnMonthly";
            mtnMonthly.Size = new Size(93, 32);
            mtnMonthly.TabIndex = 26;
            mtnMonthly.Text = "Aylık";
            mtnMonthly.UseVisualStyleBackColor = false;
            mtnMonthly.Click += mtnMonthly_Click;
            // 
            // btnWeekly
            // 
            btnWeekly.BackColor = Color.LightGray;
            btnWeekly.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnWeekly.Location = new Point(99, 86);
            btnWeekly.Margin = new Padding(3, 2, 3, 2);
            btnWeekly.Name = "btnWeekly";
            btnWeekly.Size = new Size(93, 32);
            btnWeekly.TabIndex = 25;
            btnWeekly.Text = "Haftalık";
            btnWeekly.UseVisualStyleBackColor = false;
            btnWeekly.Click += btnWeekly_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.racing_flag;
            pictureBox1.Location = new Point(31, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            lblName.BackColor = Color.DarkSeaGreen;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(31, 223);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 112);
            lblName.TabIndex = 33;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 344);
            label2.Name = "label2";
            label2.Size = new Size(100, 112);
            label2.TabIndex = 34;
            label2.Text = "Diğer Kullanıcılar";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstUserBreakfast
            // 
            lstUserBreakfast.FormattingEnabled = true;
            lstUserBreakfast.ItemHeight = 15;
            lstUserBreakfast.Location = new Point(146, 223);
            lstUserBreakfast.Name = "lstUserBreakfast";
            lstUserBreakfast.Size = new Size(201, 109);
            lstUserBreakfast.TabIndex = 48;
            // 
            // lstAllUserBreakfast
            // 
            lstAllUserBreakfast.FormattingEnabled = true;
            lstAllUserBreakfast.ItemHeight = 15;
            lstAllUserBreakfast.Location = new Point(146, 347);
            lstAllUserBreakfast.Name = "lstAllUserBreakfast";
            lstAllUserBreakfast.Size = new Size(201, 109);
            lstAllUserBreakfast.TabIndex = 48;
            // 
            // lstUserLunch
            // 
            lstUserLunch.FormattingEnabled = true;
            lstUserLunch.ItemHeight = 15;
            lstUserLunch.Location = new Point(357, 226);
            lstUserLunch.Name = "lstUserLunch";
            lstUserLunch.Size = new Size(201, 109);
            lstUserLunch.TabIndex = 48;
            // 
            // lstAllUserLunch
            // 
            lstAllUserLunch.FormattingEnabled = true;
            lstAllUserLunch.ItemHeight = 15;
            lstAllUserLunch.Location = new Point(357, 350);
            lstAllUserLunch.Name = "lstAllUserLunch";
            lstAllUserLunch.Size = new Size(201, 109);
            lstAllUserLunch.TabIndex = 48;
            // 
            // lstUserDinner
            // 
            lstUserDinner.FormattingEnabled = true;
            lstUserDinner.ItemHeight = 15;
            lstUserDinner.Location = new Point(568, 226);
            lstUserDinner.Name = "lstUserDinner";
            lstUserDinner.Size = new Size(201, 109);
            lstUserDinner.TabIndex = 48;
            // 
            // lstAllUserDinner
            // 
            lstAllUserDinner.FormattingEnabled = true;
            lstAllUserDinner.ItemHeight = 15;
            lstAllUserDinner.Location = new Point(568, 350);
            lstAllUserDinner.Name = "lstAllUserDinner";
            lstAllUserDinner.Size = new Size(201, 109);
            lstAllUserDinner.TabIndex = 48;
            // 
            // lstUserSnack
            // 
            lstUserSnack.FormattingEnabled = true;
            lstUserSnack.ItemHeight = 15;
            lstUserSnack.Location = new Point(779, 226);
            lstUserSnack.Name = "lstUserSnack";
            lstUserSnack.Size = new Size(201, 109);
            lstUserSnack.TabIndex = 48;
            // 
            // lstAllUserSnack
            // 
            lstAllUserSnack.FormattingEnabled = true;
            lstAllUserSnack.ItemHeight = 15;
            lstAllUserSnack.Location = new Point(779, 350);
            lstAllUserSnack.Name = "lstAllUserSnack";
            lstAllUserSnack.Size = new Size(201, 109);
            lstAllUserSnack.TabIndex = 48;
            // 
            // TrendsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(lstAllUserSnack);
            Controls.Add(lstAllUserDinner);
            Controls.Add(lstAllUserLunch);
            Controls.Add(lstAllUserBreakfast);
            Controls.Add(lstUserSnack);
            Controls.Add(lstUserDinner);
            Controls.Add(lstUserLunch);
            Controls.Add(lstUserBreakfast);
            Controls.Add(dgvTop5);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(mtnMonthly);
            Controls.Add(btnWeekly);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "TrendsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TrendsForm";
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTop5;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button mtnMonthly;
        private Button btnWeekly;
        private PictureBox pictureBox1;
        private Label lblName;
        private Label label2;
        private ListBox lstUserBreakfast;
        private ListBox lstAllUserBreakfast;
        private ListBox lstUserLunch;
        private ListBox lstAllUserLunch;
        private ListBox lstUserDinner;
        private ListBox lstAllUserDinner;
        private ListBox lstUserSnack;
        private ListBox lstAllUserSnack;
    }
}