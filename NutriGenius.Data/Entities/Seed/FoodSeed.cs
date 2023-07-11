using Microsoft.EntityFrameworkCore;
using NutriGenius.Data.Context;
using NutriGenius.Data.Entities.Classes;
using NutriGenius.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriGenius.Data.Entities.Seed
{
    public class FoodSeed
    {
        public static void Seed()
        {
            using (var db = new NutriGeniusDbContext())
            {
                if (db.Foods.Any())
                    return;

                var foods = new Food[]
                {
                    new Food()
                    {
                        FoodName = "Patlıcan Musakka",
                        FoodCategoryId = 1,
                        Portions = new List<Portion>(){ 
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 131 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Tavuk Sote",
                        FoodCategoryId = 1,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 288 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.7 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Et Sote",
                        FoodCategoryId = 1,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 225 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Balık Buğulama",
                        FoodCategoryId = 1,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 398 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Hamsi Kızartma",
                        FoodCategoryId = 1,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 555 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Zeytinyağlı Enginar",
                        FoodCategoryId = 2,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 147 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.7 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Taze Fasulye",
                        FoodCategoryId = 2,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 73 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Bezelye Yemeği",
                        FoodCategoryId = 2,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 235 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.7 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Patlıcan Yemeği",
                        FoodCategoryId = 2,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 130 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kabak Yemeği",
                        FoodCategoryId = 2,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 55 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kuru Fasulye",
                        FoodCategoryId = 3,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 197 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.8 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Nohut Yemeği",
                        FoodCategoryId = 3,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 147 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Barbunya Yemeği",
                        FoodCategoryId = 3,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 356 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Yeşil Mercimek Yemeği",
                        FoodCategoryId = 3,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 164 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.7 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Fellah Köfte",
                        FoodCategoryId = 3,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 332 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.2 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Hamburger",
                        FoodCategoryId = 4,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 313 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Karışık Pizza",
                        FoodCategoryId = 4,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 344 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.9 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Et Döner",
                        FoodCategoryId = 4,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 301 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Lahmacun",
                        FoodCategoryId = 4,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 221 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kıymalı Pide",
                        FoodCategoryId = 4,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 356 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Mercimek Çorbası",
                        FoodCategoryId = 5,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 137 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Domates Çorbası",
                        FoodCategoryId = 5,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 66 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Ezogelin Çorbası",
                        FoodCategoryId = 5,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 95 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Tavuk Çorbası",
                        FoodCategoryId = 5,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 132 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Tarhana Çorbası",
                        FoodCategoryId = 5,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 151 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Sezar Salata",
                        FoodCategoryId = 6,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 466 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Mevsim Salata",
                        FoodCategoryId = 6,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 59 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Çoban Salata",
                        FoodCategoryId = 6,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 115 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Makarna Salatası",
                        FoodCategoryId = 6,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 283 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.9 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Patates Salatası",
                        FoodCategoryId = 6,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 132 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.7 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Elma",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 47 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Portakal",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 101 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Şeftali",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 47 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Karpuz",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 45 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Armut",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 114 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Muz",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 151 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.9 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kayısı",
                        FoodCategoryId = 7,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 14 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Sütlaç",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 268 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Fıstıklı Baklava",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 336 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 4.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Supangle",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 159 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.2 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Dondurma",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 104 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Ekler",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 191 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Güllaç",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 143 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Mozaik Pasta",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 331 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 3.7 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Tavuk Göğsü",
                        FoodCategoryId = 8,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 165 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.8 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Badem",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 150 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Fındık",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 151 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 6.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Ceviz",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 33 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 6.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Yer Fıstığı",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 6 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kraker",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 150 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 3.8 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Form Bisküvi",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 18 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 3.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Çekirdek",
                        FoodCategoryId = 9,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 112 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 5.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Gazoz",
                        FoodCategoryId = 10,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 190 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kola",
                        FoodCategoryId = 10,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 122 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Meyve Suyu",
                        FoodCategoryId = 10,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 115 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Şalgam",
                        FoodCategoryId = 10,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 10 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Soğuk Çay",
                        FoodCategoryId = 10,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 66 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Şekerli Türk Kahvesi",
                        FoodCategoryId = 10,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 42 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Haşlanmış Yumurta",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 78 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Omlet",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 101 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.8 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Domates",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 20 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.2 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Salatalık",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 14 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Yeşil Biber",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 8 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.3 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kırmızı Biber",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 19 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Nutella",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.TableSpoon, Calorie = 54 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 5.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Zeytin",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Piece, Calorie = 8 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Süt",
                        FoodCategoryId = 12,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 122 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Yoğurt",
                        FoodCategoryId = 12,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 98 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Ayran",
                        FoodCategoryId = 12,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Glass, Calorie = 75 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 0.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kaşar Peyniri",
                        FoodCategoryId = 12,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 106 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 3.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Beyaz Peynir",
                        FoodCategoryId = 12,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 93 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 3.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Pirinç Pilavi",
                        FoodCategoryId = 13,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 259 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.6 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Bulgur Pilavi",
                        FoodCategoryId = 13,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 149 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.1 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kremalı Mantarlı Makarna",
                        FoodCategoryId = 13,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 396 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.5 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Napoliten Soslu Makarna",
                        FoodCategoryId = 13,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 435 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 1.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Beyaz Ekmek",
                        FoodCategoryId = 13,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.4 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Kepekli Ekmek",
                        FoodCategoryId = 13,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 2.2 }
                        }
                    },

                    new Food()
                    {
                        FoodName = "Yulaf Ezmesi",
                        FoodCategoryId = 11,
                        Portions = new List<Portion>(){
                            new Portion() { Amount = 1, Unit = Unit.Portion, Calorie = 389 },
                            new Portion() { Amount = 1, Unit = Unit.Gram, Calorie = 3.9 }
                        }
                    }
                };

                db.AddRange(foods);
                db.SaveChanges();
            }
        }
    }
}
