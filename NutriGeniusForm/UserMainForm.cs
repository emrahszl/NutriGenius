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
        List<UserMealFoodPortion>? userMeals;

        public UserMainForm()
        {
            _currentUser = SessionManager.CurrentUser;
            LoadData();
            InitializeComponent();
            ShowUserName();
            ShowMealCalorie();
            LoadGlasses();
        }

        private void LoadData()
        {
            dbUser = db.Users
                .Include(u => u.UserMealFoodPortions)
                .ThenInclude(uf => uf.Meal)
                .Include(u => u.UserMealFoodPortions)
                .ThenInclude(uf => uf.Portion)
                .FirstOrDefault(u => u.Id == _currentUser.Id);
        }

        private void ShowUserName()
        {
            lblName.Text = lblProfileName.Text = _currentUser.FirstName;
        }

        private void ShowMealCalorie()
        {
            userMeals = dbUser!.UserMealFoodPortions.Where(uf => uf.Meal?.MealDate == dtpSelectDate.Value.Date).ToList();

            if (userMeals.Count == 0)
            {
                lblBreakfast.Text = lblLunch.Text = lblDinner.Text = lblSnack.Text = lblSumCalorie.Text = userMeals.Count.ToString();
                return;
            }

            lblBreakfast.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Kahvaltı")?.Meal?.Calorie.ToString();
            lblLunch.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Öğle Yemeği")?.Meal?.Calorie.ToString();
            lblDinner.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Akşam Yemeği")?.Meal?.Calorie.ToString();
            lblSnack.Text = userMeals.FirstOrDefault(um => um.Meal?.MealName == "Ara Öğün")?.Meal?.Calorie.ToString();
            lblSumCalorie.Text = userMeals.Sum(uf => uf.Portion!.Calorie * uf.Portion.Amount).ToString();
        }

        private void LoadGlasses()
        {
            //Bardaklar tıklandıkça bir bir yüklenecek.

            lvWater.Items.Clear();
            lblWater.Text = (dbUser!.TotalGlass * 0.2).ToString("F1");

            for (int i = 0; i < 10; i++)
            {
                var lvi = new ListViewItem();

                if (i < dbUser.TotalGlass)
                    lvi.ImageKey = "dolubardak";
                else
                    lvi.ImageKey = "bosbardak";

                lvWater.Items.Add(lvi);
            }
        }

        private void lvWater_DoubleClick(object sender, EventArgs e)
        {
            double waterLiter = dbUser!.TotalGlass * 0.2;
            var lviClicked = lvWater.SelectedItems[0];

            if (lviClicked.ImageKey == "bosbardak")
            {
                lviClicked.ImageKey = "dolubardak";
                waterLiter += 0.2;
                lblWater.Text = waterLiter.ToString("F1");
                dbUser!.TotalGlass++;
            }
            else
            {
                lviClicked.ImageKey = "bosbardak";
                waterLiter -= 0.2;
                lblWater.Text = waterLiter.ToString("F1");
                dbUser!.TotalGlass--;
            }

            lblGreeting.Visible = waterLiter >= 2 ? true : false;

            db.SaveChanges();
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Kahvaltı")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Breakfast() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(currentMeal);
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Öğle Yemeği")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Lunch() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(currentMeal);
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Akşam Yemeği")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Dinner() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(currentMeal);
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            currentMeal = userMeals?.FirstOrDefault(uf => uf.Meal!.MealName == "Ara Öğün")?.Meal;

            if (currentMeal == null)
            {
                currentMeal = new Snack() { MealDate = DateTime.Now.Date };
            }

            CheckMeal(currentMeal);
        }

        private void CheckMeal(Meal meal)
        {
            SessionManager.CurrentMeal = meal;
            db.Entry(meal).State = EntityState.Detached;
            db.SaveChanges();

            Close();
            new FoodForm().ShowDialog();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().ShowDialog();
        }

        private void dtpSelectDate_ValueChanged(object sender, EventArgs e)
        {
            ShowMealCalorie();
            LoadGlasses();
        }
    }
}
