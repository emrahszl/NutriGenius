using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.AbstractClasses;
using NutriGenius.Data.Entities.Classes;
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
        private readonly User _currentUser;
        private readonly Meal _selectedMeal;

        public FoodForm(User currentUser, Meal selectedMeal)
        {
            _currentUser = currentUser;
            _selectedMeal = selectedMeal;
            InitializeComponent();
            ListFoodCategories();
            ShowMealName();
        }

        private void ShowMealName()
        {
            lblMealName.Text = _selectedMeal.MealName;
        }

        private void ListFoodCategories()
        {
            cbFoodCategory.DataSource = null;
            cbFoodCategory.DataSource = db.FoodCategories.ToList();
        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategory.SelectedIndex == -1) return;

            UpdateList();
            CheckedControl();
        }

        private void CheckedControl()
        {
            clbFoods.ItemCheck -= clbFoods_ItemCheck!;

            foreach (Food item in lstFoods.Items)
            {
                if (clbFoods.Items.Contains(item))
                {
                    int index = clbFoods.Items.IndexOf(item);
                    clbFoods.SetItemCheckState(index, CheckState.Checked);
                }
            }

            clbFoods.ItemCheck += clbFoods_ItemCheck!;
        }

        private void clbFoods_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Food food = (Food)clbFoods.SelectedItem;

            if (e.NewValue == CheckState.Checked)
            {
                lstFoods.Items.Add(food);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                lstFoods.Items.Remove(food);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            new UserAddFoodForm().ShowDialog();
            UpdateList();
        }

        private void UpdateList()
        {
            int foodCategoryId = ((FoodCategory)cbFoodCategory.SelectedItem).Id;

            clbFoods.Items.Clear();

            foreach (Food food in db.Foods.Where(f => f.FoodCategoryId == foodCategoryId))
            {
                clbFoods.Items.Add(food);
            }
        }

        private void btnSaveFoods_Click(object sender, EventArgs e)
        {
            if (lstFoods.Items.Count == 0) return;
        }
    }
}
