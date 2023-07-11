using NutriGenius.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class Portion
    {
        public int Id { get; set; }

        public double Amount { get; set; }

        public Unit Unit { get; set; }

        public double? Calorie { get; set; }




        public List<Food> Foods { get; set; } = new();
    }
}
