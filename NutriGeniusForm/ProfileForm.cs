using Microsoft.EntityFrameworkCore;
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
    public partial class ProfileForm : Form
    {

        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User currentUser = SessionManager.CurrentUser;

        public ProfileForm()
        {
            InitializeComponent();
            LoadPersonalInformations();
        }

        private void LoadPersonalInformations()
        {
            txtFirstName.Text = currentUser.FirstName;
            txtLastName.Text = currentUser.LastName;
            txtHeight.Text = currentUser.Height.ToString();
            txtWeight.Text = currentUser.Weight.ToString();
            dtpBirthDate.Value = currentUser.BirthDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                   string.IsNullOrEmpty(txtLastName.Text) ||
                   string.IsNullOrEmpty(txtHeight.Text) ||
                   string.IsNullOrEmpty(txtWeight.Text))
            {
                MessageBox.Show("İlgili alanlar boş olamaz!");
                return;
            }

            db.Entry(currentUser).State = EntityState.Unchanged;

            currentUser.FirstName = txtFirstName.Text;
            currentUser.LastName = txtLastName.Text;
            currentUser.Height = Convert.ToInt32(txtHeight.Text);
            currentUser.Weight = Convert.ToDouble(txtWeight.Text);

            DialogResult dialogResult = MessageBox.Show("Değişiklikleri kaydetmek istediğinize emin misiniz?", "Kayıt Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                db.SaveChanges();
                MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.");
            }
        }

        private void pbTrends_Click(object sender, EventArgs e)
        {
            new TrendsForm().ShowDialog();
        }

        private void pbDaily_Click(object sender, EventArgs e)
        {
            new DailyForm().ShowDialog();
        }
    }
}
