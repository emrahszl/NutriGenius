using NutriGenius.Data.Entities.AbstractClasses;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SubClasses_Meal;
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
    public partial class UserMainForm : Form
    {
        private readonly User _currentUser;

        public UserMainForm(User currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
            ShowUserName();
        }

        private void ShowUserName()
        {
            lblName.Text = lblProfileName.Text = _currentUser.FirstName;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            Meal breakfast = new Breakfast() { MealDate = DateTime.Now };
            _currentUser.Meals.Add(breakfast);

            new FoodForm(_currentUser, breakfast).ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            Meal lunch = new Lunch() { MealDate = DateTime.Now };
            _currentUser.Meals.Add(lunch);

            new FoodForm(_currentUser, lunch).ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            Meal dinner = new Dinner() {  MealDate = DateTime.Now };
            _currentUser.Meals.Add(dinner);

            new FoodForm(_currentUser, dinner ).ShowDialog();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            Meal snack = new Snack() { MealDate = DateTime.Now };
            _currentUser.Meals.Add(snack);

            new FoodForm(_currentUser, snack).ShowDialog();
        }
    }
}
