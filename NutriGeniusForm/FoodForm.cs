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
        User currentUser = SessionManager.CurrentUser;
        Meal currentMeal = SessionManager.CurrentMeal;
        List<Food> selectedFoods = new List<Food>();
        FoodCategory? foodCategory;
        Food? food;
        Portion? portion;
        double piece;

        public FoodForm()
        {
            InitializeComponent();
            ShowMealName();
            ListFoodCategories();
            LoadData();
            UpdateFoods();
        }

        private void LoadData()
        {
            db.Entry(currentUser).State = EntityState.Unchanged;
            db.Entry(currentUser).Collection(u => u.Meals).Load();
            selectedFoods.AddRange(db.Users.Include(u => u.Meals).ThenInclude(m => m.Foods).ThenInclude(m => m.Portions).FirstOrDefault(u => u.Id == currentUser.Id)!.Meals.FirstOrDefault(m => m.MealName == currentMeal.MealName)!.Foods);
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
            if (cbFoods.SelectedIndex == -1) return;

            ListPortions();
        }

        private void ListFoods()
        {
            cbFoods.DataSource = null;
            cbFoods.DataSource = db.Foods
                .Where(x => x.FoodCategory.Id == ((FoodCategory)cbFoodCategory.SelectedItem).Id)
                .ToList();
        }

        private void ListPortions()
        {
            cbPortions.DataSource = null;
            Food food = (Food)cbFoods.SelectedItem;
            cbPortions.DataSource = (db.Foods.Include(x => x.Portions).First(x => x.Id == food.Id))
                .Portions.ToList();


        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            new UserAddFoodForm().ShowDialog();
        }

        private void btnSaveFoods_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Yemekleri {currentMeal.MealName} öğünüze eklemek istediğinize emin misiniz?", "Ekleme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            currentMeal = currentUser.Meals.FirstOrDefault(m => m.MealName == currentMeal.MealName)!;
            currentMeal.Foods.RemoveRange(0, currentMeal.Foods.Count());
            if (result == DialogResult.Yes)
            {
                currentMeal.Foods.AddRange(selectedFoods);

                currentMeal.Calorie = 0;

                foreach (Food food in currentMeal.Foods)
                {
                    currentMeal.Calorie += food.Portions.Sum(p => p.Calorie);
                }

                db.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count < 0)
                return;

            string deletedFoodName = dgvFoods.SelectedRows[0].Cells[0].Value.ToString()!;
            Food deletedFood = selectedFoods.FirstOrDefault(x => x.FoodName == deletedFoodName)!;


            DialogResult dialogResult = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                selectedFoods.Remove(deletedFood);
                UpdateFoods();
            }
        }

        private void UpdateFoods()
        {
            dgvFoods.DataSource = null;
            dgvFoods.DataSource = selectedFoods.Select(f => new
            {
                f.FoodName,
                FoodCalorie = f.Portions.First().Calorie * f.Portions.FirstOrDefault()!.Amount
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foodCategory = (FoodCategory)cbFoodCategory.SelectedItem;
            food = (Food)cbFoods.SelectedItem;
            portion = (Portion)cbPortions.SelectedItem;
            piece = (double)nudPiece.Value;

            portion.Amount = piece;

            Food selectedFood = new Food()
            {
                FoodName = food.FoodName,
                FoodCategoryId = foodCategory.Id,
            };

            selectedFood.Portions.Add(portion);

            if (selectedFoods.Any(x => x.FoodName == selectedFood.FoodName))
            {
                MessageBox.Show("Eklemek istediğiniz ürün listede mevcuttur.");
                return;
            }

            selectedFoods.Add(selectedFood);

            UpdateFoods();
        }
    }
}
