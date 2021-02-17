﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoRepository
{
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public MenuItem()
        {

        }

        public MenuItem(int mealNumber, string name, string description, string ingredients, double price)
        {
            MealNumber = mealNumber;
            MealName = name;
            MealDescription = description;
            Ingredients = ingredients;
            Price = price;
        }

    }
}
