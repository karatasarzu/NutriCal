﻿using NutriCal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public double Calorie { get; set; }
        public Porsions Porsion { get; set; }
        public int? FoodCategoryId { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual ICollection<Meal> Meals { get; set; }
    }
}