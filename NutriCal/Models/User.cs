﻿using NutriCal.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriCal.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public Genders Gender { get; set; }
        public virtual ICollection<Exercise> Exercises { get; set; }
        public virtual ICollection<UserExercise> UserExercises { get; set; }
        public virtual UserLogin UserLogin { get; set; }
    }
}
