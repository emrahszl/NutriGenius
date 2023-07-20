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
                .Include(u => u.UserMealFoodPortions)
                .ThenInclude(uf => uf.Portion)
                .FirstOrDefault(u => u.Id == currentUser.Id)!;
        }

        private void ListOfMeals()
        {
            foreach (ListBox listbox in Controls.OfType<ListBox>())
            {
                listbox.Items.Clear();
            }

            var userMeals = currentUser.UserMealFoodPortions.Where(uf => uf.Meal?.MealDate == dtpDate.Value.Date).ToList();

            foreach (var item in userMeals!.Where(x => x.Meal!.MealName == "Kahvaltı"))
            {
                lstBreakfast.Items.Add(string.Join(" - ", item.Food!.FoodName, item.Portion!.Calorie));
            }

            foreach (var item in userMeals.Where(x => x.Meal!.MealName == "Ara Öğün"))
            {
                lstSnack.Items.Add(string.Join(" - ", item.Food!.FoodName, item.Portion!.Calorie));
            }

            foreach (var item in userMeals.Where(x => x.Meal!.MealName == "Öğle Yemeği"))
            {
                lstLunch.Items.Add(string.Join(" - ", item.Food!.FoodName, item.Portion!.Calorie));
            }

            foreach (var item in userMeals.Where(x => x.Meal!.MealName == "Akşam Yemeği"))
            {
                lstDinner.Items.Add(string.Join(" - ", item.Food!.FoodName, item.Portion!.Calorie));
            }

            ShowMealCalorie(userMeals);
        }

        private void ShowMealCalorie(List<UserMealFoodPortion> userMeals)
        {
            if (userMeals.Count == 0)
            {
                lblBreakfastCalorie.Text = lblLunchCalorie.Text = lblDinnerCalorie.Text = lblSnackCalorie.Text = lblTotalMealCalorie.Text = userMeals.Count.ToString();
                return;
            }

            lblBreakfastCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Kahvaltı")?.Meal?.Calorie.ToString();
            lblLunchCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Öğle Yemeği")?.Meal?.Calorie.ToString();
            lblDinnerCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Akşam Yemeği")?.Meal?.Calorie.ToString();
            lblSnackCalorie.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Ara Öğün")?.Meal?.Calorie.ToString();
            lblTotalMealCalorie.Text = userMeals.Sum(uf => uf.Portion!.Calorie * uf.Portion.Amount).ToString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ListOfMeals();
        }
    }
}
