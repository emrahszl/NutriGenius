namespace NutriGeniusForm
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            btnSignIn = new Button();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignIn.Location = new Point(344, 582);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(271, 38);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sağlık Yolculuğunu Başlat";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(510, 626);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 38);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 635);
            label1.Name = "label1";
            label1.Size = new Size(160, 38);
            label1.TabIndex = 2;
            label1.Text = "Zaten hesabım var";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 729);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnSignIn);
            DoubleBuffered = true;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSignIn;
        private Button btnLogin;
        private Label label1;
    }
}