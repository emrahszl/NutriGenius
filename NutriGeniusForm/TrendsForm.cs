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
    public partial class TrendsForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        User currentUser = SessionManager.CurrentUser;

        public TrendsForm()
        {
            LoadData();
            InitializeComponent();
            ShowUserName();
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
        private void ShowUserName()
        {
            lblName.Text = currentUser.FirstName;
        }

        private void AllUserFoods(int day)
        {
            List<UserMealFoodPortion> breakfasts = FindUserMealFoodPortion(day, "Kahvaltı");
            List<UserMealFoodPortion> lunches = FindUserMealFoodPortion(day, "Öğle Yemeği");
            List<UserMealFoodPortion> dinners = FindUserMealFoodPortion(day, "Akşam Yemeği");
            List<UserMealFoodPortion> snacks = FindUserMealFoodPortion(day, "Ara Öğün");

            int maxBreakfastFoodId = FindFoodId(breakfasts);
            int maxLunchFoodId = FindFoodId(lunches);
            int maxDinnerFoodId = FindFoodId(dinners);
            int maxSnackFoodId = FindFoodId(snacks);

            lblBreakfastSum.Text = FindFoodName(maxBreakfastFoodId);
            lblLunchSum.Text = FindFoodName(maxLunchFoodId);
            lblDinnerSum.Text = FindFoodName(maxDinnerFoodId);
            lblSnackSum.Text = FindFoodName(maxSnackFoodId);

        }

        private void UserFoods(int day)
        {
            List<UserMealFoodPortion> ufListBr = FindUserMealFoodPortion(day, "Kahvaltı");
            List<UserMealFoodPortion> ufListLn = FindUserMealFoodPortion(day, "Öğle Yemeği");
            List<UserMealFoodPortion> ufListDn = FindUserMealFoodPortion(day, "Akşam Yemeği");
            List<UserMealFoodPortion> ufListSn = FindUserMealFoodPortion(day, "Ara Öğün");

            int maxBreakfastFoodId = FindFoodId(ufListBr);
            int maxLunchFoodId = FindFoodId(ufListLn);
            int maxDinnerFoodId = FindFoodId(ufListDn);
            int maxSnackFoodId = FindFoodId(ufListSn);

            lblBreakfastUser.Text = currentUser.UserMealFoodPortions.Where(x => x.FoodId == maxBreakfastFoodId).FirstOrDefault()?.Food?.FoodName;
            lblLunchUser.Text = currentUser.UserMealFoodPortions.Where(x => x.FoodId == maxLunchFoodId).FirstOrDefault()?.Food?.FoodName;
            lblDinnerUser.Text = currentUser.UserMealFoodPortions.Where(x => x.FoodId == maxDinnerFoodId).FirstOrDefault()?.Food?.FoodName;
            lblSnackUser.Text = currentUser.UserMealFoodPortions.Where(x => x.FoodId == maxSnackFoodId).FirstOrDefault()?.Food?.FoodName;
        }

        private int FindFoodId(List<UserMealFoodPortion> ufList)
        {
            int maxCount = 0;
            int count = 0;
            int maxFoodId = 0;

            for (int i = 0; i < ufList.Count - 1; i++)
            {
                count = 0;

                for (int j = i + 1; j < ufList.Count; j++)
                {
                    if (ufList[i].FoodId == ufList[j].FoodId)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxFoodId = ufList[i].FoodId;
                }
            }

            if (maxFoodId == 0)
            {
                maxFoodId = ufList[0].FoodId;
            }

            return maxFoodId;
        }

        private string FindFoodName(int foodId)
        {
            return currentUser.UserMealFoodPortions.Where(x => x.FoodId == foodId).FirstOrDefault()!.Food!.FoodName;
        }

        private List<UserMealFoodPortion> FindUserMealFoodPortion(int day, string mealName)
        {
            return currentUser.UserMealFoodPortions.Where(x => x.Meal!.MealName == mealName).Where(x => x.Meal!.MealDate.Day > DateTime.Now.AddDays(day).Day && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList();
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            UserFoods(-7);
            AllUserFoods(-7);
        }

        private void mtnMonthly_Click(object sender, EventArgs e)
        {
            UserFoods(-30);
            AllUserFoods(-30);
        }
    }
}
