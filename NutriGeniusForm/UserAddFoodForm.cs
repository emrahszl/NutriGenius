using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.Enums;
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
    public partial class UserAddFoodForm : Form
    {
        NutriGeniusDbContext db = new NutriGeniusDbContext();

        public UserAddFoodForm()
        {
            InitializeComponent();
            ListFoodCategories();
        }

        private void ListFoodCategories()
        {
            cbFoodCategories.DataSource = null;
            cbFoodCategories.DataSource = db.FoodCategories.ToList();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string foodName = txtFoodName.Text;
                string calorie = txtCalorie.Text;
                int categoryId = ((FoodCategory)cbFoodCategories.SelectedItem).Id;

                if (string.IsNullOrEmpty(foodName) || string.IsNullOrEmpty(calorie) || cbFoodCategories.SelectedIndex == -1 || cbPortions.SelectedIndex == -1)
                {
                    MessageBox.Show("Tüm alanlar doldurulmalıdır!");
                    return;
                }

                if (db.Foods.Any(f => f.FoodName.Equals(foodName)))
                {
                    MessageBox.Show("Bu yemek zaten mevcut!");
                    return;
                }

                db.Foods.Add(new Food()
                {
                    FoodName = foodName,
                    FoodCategoryId = categoryId,
                    Portions = new List<Portion>()
                    {
                        new Portion() { Amount = 1, Unit = (Unit)cbPortions.SelectedIndex, Calorie = Convert.ToDouble(calorie) }
                    }
                }
                );

                db.SaveChanges();
                MessageBox.Show("Yemek başarıyla eklenmiştir.");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Kalori sayısal bir değer olmalıdır!");
            }
        }
    }
}
