using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.AbstractClasses;
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
    public partial class FoodForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();
        Meal currentMeal = SessionManager.CurrentMeal;

        public FoodForm()
        {
            InitializeComponent();
            ShowMealName();
            ListFoodCategories();
        }

        private void ShowMealName()
        {
            lblMealName.Text = currentMeal.MealName;
        }

        private void ListFoodCategories()
        {
            cbFoodCategory.Items.Clear();

            foreach (FoodCategory foodCategory in db.FoodCategories)
            {
                cbFoodCategory.Items.Add(foodCategory);
            }
        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategory.SelectedIndex == -1) return;

            ListFoods();
        }

        private void cbFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFood = ((Food)cbFoods.SelectedItem).Id;
            cbPortions.DataSource = null;
            cbPortions.DataSource = db.Foods.Find(selectedFood)!.Portions.ToList();
        }

        private void ListFoods()
        {
            cbFoods.DataSource = null!;
            cbFoods.DataSource = db.Foods.Where(f => f.FoodCategoryId == ((FoodCategory)cbFoodCategory.SelectedItem).Id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            new UserAddFoodForm().ShowDialog();
        }

        private void btnSaveFoods_Click(object sender, EventArgs e)
        {

        }
    }
}
