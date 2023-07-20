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
            Top5Food();
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

        private void Top5Food()
        {
            var foodIdList = db.UserMealFoodPortions.Include(uf => uf.Food).GroupBy(x => x.FoodId).OrderByDescending(x => x.Count()).Take(5).Select(uf => new
            {
                Ad = uf.FirstOrDefault()!.Food!.FoodName,
                Adet = uf.Count()
            });

            foreach (var item in foodIdList)
            {
                lstTop5.Items.Add(item);
            }
        }

        private void AllUserFoods(int reportType)
        {
            lblAllUserBreakfast.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Kahvaltı", 1, reportType)));
            lblAllUserLunch.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Öğle Yemeği", 1, reportType)));
            lblAllUserDinner.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Akşam Yemeği", 1, reportType)));
            lblAllUserSnack.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Ara Öğün", 1, reportType)));
        }

        private void UserFoods(int reportType)
        {
            lblUserBreakfast.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Kahvaltı", 0, reportType)));
            lblUserLunch.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Öğle Yemeği", 0, reportType)));
            lblUserDinner.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Akşam Yemeği", 0, reportType)));
            lblUserSnack.Text = FindFoodName(FindFoodId(FindUserMealFoodPortion("Ara Öğün", 0, reportType)));
        }

        private List<UserMealFoodPortion> FindUserMealFoodPortion(string mealName, int option, int reportType)
        {
            int dayNo = reportType == 0 ? -(int)DateTime.Now.DayOfWeek : -DateTime.Now.Day;

            if (option == 0)
            {
                return currentUser.UserMealFoodPortions.Where(x => x.Meal!.MealName == mealName).Where(x => x.Meal!.MealDate > DateTime.Now.AddDays(dayNo) && x.Meal.MealDate <= DateTime.Now).ToList();
            }
            else
            {
                var ufs = new List<UserMealFoodPortion>();

                foreach (User user in db.Users.Include(u => u.UserMealFoodPortions).ThenInclude(uf => uf.Meal))
                {
                    ufs.AddRange(user.UserMealFoodPortions.Where(x => x.Meal!.MealName == mealName).Where(x => x.Meal!.MealDate > DateTime.Now.AddDays(dayNo) && x.Meal.MealDate.Day <= DateTime.Now.Day).ToList());
                }

                return ufs;
            }
        }

        private int FindFoodId(List<UserMealFoodPortion> ufList)
        {
            int maxCount = 0;
            int count = 0;
            int maxFoodId = 0;

            var foodList = ufList.Select(uf => uf.FoodId).ToList();

            foreach (int foodId in foodList.Distinct())
            {
                count = foodList.Count(f => f == foodId);

                if (count > maxCount)
                {
                    maxCount = count;
                    maxFoodId = foodId;
                }
            }

            return maxFoodId;
        }

        private string FindFoodName(int foodId)
        {
            if (foodId == 0)
                return "Bu hafta öğünlerin boş :)";
            return db.Foods.Where(x => x.Id == foodId).FirstOrDefault()!.FoodName;
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            UserFoods(0);
            AllUserFoods(0);
        }

        private void mtnMonthly_Click(object sender, EventArgs e)
        {
            UserFoods(1);
            AllUserFoods(1);
        }
    }
}
