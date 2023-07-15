using NutriGenius.Data.Entities.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class UserMealFoodPortion
    {
        public int UserId { get; set; }

        public int MealId { get; set; }

        public int FoodId { get; set; }

        public int PortionId { get; set; }



        public User? User { get; set; }

        public Meal? Meal { get; set; }

        public Food? Food { get; set; }

        public Portion? Portion { get; set; }
    }
}
