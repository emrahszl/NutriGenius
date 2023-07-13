using NutriGenius.Data.Entities.AbstractClasses;
using NutriGenius.Data.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.SessionManager
{
    public class SessionManager
    {
		private static User _currentUser = null!;

		public static User CurrentUser
		{
			get { return _currentUser; }
			set { _currentUser = value; }
		}

		private static Meal _currentMeal = null!;

		public static Meal CurrentMeal
		{
			get { return _currentMeal; }
			set { _currentMeal = value; }
		}
	}
}
