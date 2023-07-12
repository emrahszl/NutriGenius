using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutriGeniusForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        User? loginUser;
        private void btnLogın_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı veya parola girilmedi!");
                return;
            }

            loginUser = new User();

            using (var db = new NutriGeniusDbContext())
            {
                if (loginUser.Login(db, txtUserName.Text, txtPassword.Text))
                {
                    loginUser = db.Users.FirstOrDefault(u => u.UserName == txtUserName.Text);
                    new UserMainForm(loginUser!).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
        }
    }
}
