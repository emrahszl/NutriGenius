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
        List<UserMealFoodPortion> selectedUfs = new List<UserMealFoodPortion>();

        Food? food;
        Portion? portion;
        double piece;

        public FoodForm()
        {
            LoadData();
            InitializeComponent();
            ShowMealName();
            ListFoodCategories();
            UpdateFoods();
        }

        private void LoadData()
        {
            if (db.Entry(currentMeal).State == EntityState.Detached)
            {
                db.Attach(currentMeal);
            }

            selectedUfs.AddRange(db.UserMealFoodPortions.Include(uf => uf.User).Include(uf => uf.Meal).Include(uf => uf.Food).Include(uf => uf.Portion)
                .Where(uf => uf.UserId == currentUser.Id && uf.MealId == currentMeal.Id && uf.Meal!.MealDate == currentMeal.MealDate));
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
            food = (Food)cbFoods.SelectedItem;
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

            if (result == DialogResult.No) return;

            currentMeal.UserMealFoodPortions.RemoveAll(uf => uf.UserId == currentUser.Id);
            currentMeal.UserMealFoodPortions.AddRange(selectedUfs);
            currentMeal.Calorie = 0;
            currentMeal.Calorie += currentMeal.UserMealFoodPortions.Sum(uf => uf.Portion!.Calorie * uf.Portion.Amount);

            db.SaveChanges();
            MessageBox.Show($"Yemekler {currentMeal.MealName} öğününüze başarıyla eklenmiştir.");
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count < 0)
                return;

            UserMealFoodPortion deletedUfpm = (UserMealFoodPortion)dgvFoods.SelectedRows[0].DataBoundItem;

            DialogResult dialogResult = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dialogResult == DialogResult.Yes)
            {
                selectedUfs.Remove(deletedUfpm);
                UpdateFoods();
            }
        }

        private void UpdateFoods()
        {
            dgvFoods.DataSource = null;
            dgvFoods.DataSource = selectedUfs.Select(uf => new
            {
                uf.Food!.FoodName,
                FoodCalorie = uf.Portion!.Calorie * uf.Portion.Amount
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            portion = (Portion)cbPortions.SelectedItem;
            piece = (double)nudPiece.Value;

            portion.Amount = piece;

            if (selectedUfs.Any(x => x.FoodId == food!.Id))
            {
                MessageBox.Show("Eklemek istediğiniz ürün listede mevcuttur.");
                return;
            }

            selectedUfs.Add(new UserMealFoodPortion()
            {
                User = db.Users.FirstOrDefault(u => u.Id == currentUser.Id),
                UserId = db.Users.FirstOrDefault(u => u.Id == currentUser.Id)!.Id,
                Meal = currentMeal,
                MealId = currentMeal.Id,
                Food = food,
                FoodId = food!.Id,
                Portion = portion,
                PortionId = portion.Id
            });

            UpdateFoods();
        }

        private void FoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new UserMainForm().ShowDialog();
        }
    }
}
