using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.AbstractClasses;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.SessionManager;
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
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        private readonly User _currentUser;
        User? dbUser;
        Meal? currentMeal;

        public UserMainForm()
        {
            _currentUser = SessionManager.CurrentUser;
            dbUser = db.Users.Include(u => u.Meals).ThenInclude(m => m.Foods).ThenInclude(f => f.Portions).FirstOrDefault(u => u.UserName == _currentUser.UserName)!;
            InitializeComponent();
            ShowUserName();
        }

        private void ShowUserName()
        {
            lblName.Text = lblProfileName.Text = _currentUser.FirstName;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            currentMeal = new Breakfast() { MealDate = DateTime.Now.Date };
            CheckMeal();
            new FoodForm().ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            currentMeal = new Lunch() { MealDate = DateTime.Now.Date };
            CheckMeal();
            new FoodForm().ShowDialog();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            currentMeal = new Dinner() { MealDate = DateTime.Now.Date };
            CheckMeal();
            new FoodForm().ShowDialog();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            currentMeal = new Snack() { MealDate = DateTime.Now.Date };
            CheckMeal();
            new FoodForm().ShowDialog();
        }

        private void CheckMeal()
        {
            bool shouldAddMeal = true;

            if (dbUser!.Meals.Any(m => m.MealName.Equals(currentMeal!.MealName) && m.MealDate == currentMeal.MealDate))
                shouldAddMeal = false;

            if (shouldAddMeal)
            {
                dbUser.Meals.Add(currentMeal!);
                db.SaveChanges();
            }

            SessionManager.CurrentMeal = dbUser!.Meals.FirstOrDefault(m => m.MealName == currentMeal!.MealName)!;
        }
    }
}
