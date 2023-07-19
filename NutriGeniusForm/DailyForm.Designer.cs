namespace NutriGeniusForm
{
    partial class DailyForm
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
            dtpDate = new DateTimePicker();
            label4 = new Label();
            lstSnack = new ListBox();
            label3 = new Label();
            lstDinner = new ListBox();
            label2 = new Label();
            lstLunch = new ListBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            lstBreakfast = new ListBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(383, 81);
            dtpDate.Margin = new Padding(3, 2, 3, 2);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(219, 23);
            dtpDate.TabIndex = 44;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(818, 306);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 43;
            label4.Text = "Ara Öğün";
            // 
            // lstSnack
            // 
            lstSnack.FormattingEnabled = true;
            lstSnack.ItemHeight = 15;
            lstSnack.Location = new Point(757, 331);
            lstSnack.Margin = new Padding(3, 2, 3, 2);
            lstSnack.Name = "lstSnack";
            lstSnack.Size = new Size(193, 289);
            lstSnack.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(569, 306);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 41;
            label3.Text = "Akşam Yemeği";
            // 
            // lstDinner
            // 
            lstDinner.FormattingEnabled = true;
            lstDinner.ItemHeight = 15;
            lstDinner.Location = new Point(527, 331);
            lstDinner.Margin = new Padding(3, 2, 3, 2);
            lstDinner.Name = "lstDinner";
            lstDinner.Size = new Size(193, 289);
            lstDinner.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(349, 306);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 39;
            label2.Text = "Öğle Yemeği";
            // 
            // lstLunch
            // 
            lstLunch.FormattingEnabled = true;
            lstLunch.ItemHeight = 15;
            lstLunch.Location = new Point(299, 331);
            lstLunch.Margin = new Padding(3, 2, 3, 2);
            lstLunch.Name = "lstLunch";
            lstLunch.Size = new Size(193, 289);
            lstLunch.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(137, 306);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 37;
            label1.Text = "Kahvaltı";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.christmas_dinner;
            pictureBox2.Location = new Point(568, 251);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // lstBreakfast
            // 
            lstBreakfast.FormattingEnabled = true;
            lstBreakfast.ItemHeight = 15;
            lstBreakfast.Location = new Point(73, 331);
            lstBreakfast.Margin = new Padding(3, 2, 3, 2);
            lstBreakfast.Name = "lstBreakfast";
            lstBreakfast.Size = new Size(193, 289);
            lstBreakfast.TabIndex = 32;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.snacks;
            pictureBox4.Location = new Point(799, 251);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.lunch_time;
            pictureBox3.Location = new Point(342, 251);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.english_breakfast;
            pictureBox1.Location = new Point(114, 251);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // DailyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arasayfalar;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(lstSnack);
            Controls.Add(label3);
            Controls.Add(lstDinner);
            Controls.Add(label2);
            Controls.Add(lstLunch);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(lstBreakfast);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "DailyForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DailyForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Label label4;
        private ListBox lstSnack;
        private Label label3;
        private ListBox lstDinner;
        private Label label2;
        private ListBox lstLunch;
        private Label label1;
        private PictureBox pictureBox2;
        private ListBox lstBreakfast;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}