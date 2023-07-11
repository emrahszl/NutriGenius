using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;

namespace NutriGeniusForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form signInForm = new SignInForm();
            signInForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}