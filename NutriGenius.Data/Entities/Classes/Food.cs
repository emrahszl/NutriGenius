using NutriGenius.Data.Entities.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class Food
    {
        public int Id { get; set; }

        public string FoodName { get; set; } = null!;

        public byte[]? Image { get; set; }

        public int FoodCategoryId { get; set; }




        public FoodCategory FoodCategory { get; set; } = null!;

        public List<Portion> Portions { get; set; } = new();

        public List<Meal> Meals { get; set; } = new();


        public override string ToString()
        {
            return FoodName;
        }
    }
}
