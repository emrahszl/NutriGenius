﻿using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.AbstractClasses;
using NutriGenius.Data.Entities.Enums;
using NutriGenius.Data.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Classes
{
    public class User
    {
        private int _height;

        private double _weight;

        private string _password = null!;


        public int Id { get; set; }

        public string UserName { get; set; } = null!;

        public string Password 
        { 
            get => _password;

            set 
            {
                if (value.Length < 8 || !(value.Any(x => Char.IsUpper(x)) && value.Any(x => Char.IsLower(x))))
                {
                    throw new PasswordException();
                }
            }
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public int Height
        {
            get => _height;

            set
            {
                if (value < 70 || value > 250)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _height = value;
            }
        }

        public double Weight
        {
            get => _weight;

            set
            {
                if (value < 30 || value > 300)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _weight = value;
            }
        }
        public List<Meal> Meals { get; set; } = new();


        private string Sha256(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password))
                    .Select(x => x.ToString("X2")));
            }
        }

        public void SignIn(User user, NutriGeniusDbContext db)
        {
            user.Password = Sha256(user.Password);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public bool Login(string password, NutriGeniusDbContext db)
        {
            if (db.Users.Any(x => x.Password == Sha256(password)))
            {
                return true;
            }

            return false;
        }
    }
}
