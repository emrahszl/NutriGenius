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
    public partial class DailyForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User currentUser = SessionManager.CurrentUser;

        public DailyForm()
        {
            LoadData();
            InitializeComponent();
            ListOfMeals();
        }

        private void LoadData()
        {
            currentUser = db.Users
                .Include(u => u.UserMealFoodPortions)
                .ThenInclude(uf => uf.Meal)
                .Include(u => u.UserMealFoodPortions)
                .ThenInclude(uf => uf.Food)
                .FirstOrDefault(u => u.Id == currentUser.Id)!;
        }

        private void ListOfMeals()
        {
            foreach (ListBox listbox in Controls.OfType<ListBox>())
            {
                listbox.Items.Clear();
            }

            foreach (var item in currentUser!.UserMealFoodPortions.Where(x => x.Meal!.MealName == "Kahvaltı" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstBreakfast.Items.Add(item.Food!.FoodName);
            }

            foreach (var item in currentUser.UserMealFoodPortions.Where(x => x.Meal!.MealName == "Ara Öğün" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstSnack.Items.Add(item.Food!.FoodName);
            }

            foreach (var item in currentUser.UserMealFoodPortions.Where(x => x.Meal!.MealName == "Öğle Yemeği" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstLunch.Items.Add(item.Food!.FoodName);
            }

            foreach (var item in currentUser.UserMealFoodPortions.Where(x => x.Meal!.MealName == "Akşam Yemeği" && x.Meal.MealDate == dtpDate.Value.Date))
            {
                lstDinner.Items.Add(item.Food!.FoodName);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListOfMeals();
        }
    }
}
