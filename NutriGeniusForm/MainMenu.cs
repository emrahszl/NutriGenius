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
            new SignInForm().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }
    }
}