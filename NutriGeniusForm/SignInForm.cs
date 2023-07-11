using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.Enums;
using NutriGenius.Data.Entities.Exceptions;
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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (var db = new NutriGeniusDbContext())
            {
                try
                {
                    if (string.IsNullOrEmpty(txtFirstName.Text) ||
                        string.IsNullOrEmpty(txtLastName.Text) ||
                        string.IsNullOrEmpty(txtUserName.Text) ||
                        string.IsNullOrEmpty(txtPassword.Text) ||
                        (!rbMale.Checked && !rbFemale.Checked) ||
                        dtpBirthDate.Value >= DateTime.Now ||
                        string.IsNullOrEmpty(txtHeight.Text) ||
                        string.IsNullOrEmpty(txtWeight.Text) ||
                        cbMail.SelectedIndex == -1)
                    {
                        MessageBox.Show("*'lı alanların doldurulması zorunludur!");
                        return;
                    }

                    if (txtUserName.Text.Contains("@"))
                    {
                        MessageBox.Show("Kullanıcı adı birden fazla \'@\' içeremez!");
                    }

                    if (db.Users.Any(x => x.UserName == string.Join("", txtUserName.Text, cbMail.SelectedItem.ToString())))
                    {
                        MessageBox.Show("Girilen kullanıcı adı sistemde mevcut olduğu için kullanılamaz!");
                    }

                    User newUser = new User()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = rbMale.Checked ? Gender.Male : Gender.Female,
                        BirthDate = dtpBirthDate.Value,
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                        Height = Convert.ToInt32(txtHeight.Text),
                        Weight = Convert.ToDouble(txtWeight.Text)
                    };

                    newUser.SignIn(newUser, db);
                    MessageBox.Show("Kayıt başarıyla tamamlandı.");
                    Close();
                    OpenLoginForm();
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(FormatException))
                    {
                        MessageBox.Show("Boy/Kilo girişi sayısal olmalıdır!\nÖrnek giriş => Boy : 170, Kilo : 65");
                    }
                    else if (ex.GetType() == typeof(ArgumentOutOfRangeException))
                    {
                        MessageBox.Show("Boy veya kilo kriterler dışındadır! Boy => (Min : 70cm, Max : 250cm), Kilo => (Min : 30kg, Max : 300 kg)");
                    }
                    else if (ex.GetType() == typeof(PasswordException))
                    {
                        MessageBox.Show("Şifre uzunluğu en az 8 karakter olmalı, en az 1 büyük harf ve 1 küçük harf içermelidir!");
                    }
                    else if (ex.GetType() == typeof(AgeException))
                    {
                        MessageBox.Show("Uygulamayı kullanabilmek için 15 yaş ve üzeri olmanız gerekmektedir!");
                    }
                    else
                    {
                        MessageBox.Show($"Bir hata oluştu! Hata Mesajı : {ex.Message}");
                    }
                }
            }
        }

        private static void OpenLoginForm()
        {
            new LoginForm().ShowDialog();
        }
    }
}
