using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SessionManager;
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
        NutriGeniusDbContext db = new NutriGeniusDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogın_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı veya parola girilmedi!");
                return;
            }


            if (new User().Login(db, userName, password))
            {
                SessionManager.CurrentUser = db.Users.FirstOrDefault(u => u.UserName == userName)!;

                new UserMainForm().ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
