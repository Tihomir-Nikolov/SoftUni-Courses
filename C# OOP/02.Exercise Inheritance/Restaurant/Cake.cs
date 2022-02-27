using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const decimal PriceCake = 5;
        private const double CaloriesCake = 1000;
        private const double CakeGrams = 250;
        public Cake(string name) 
            : base(name, PriceCake, CakeGrams, CaloriesCake)
        {
        }
    }
}
