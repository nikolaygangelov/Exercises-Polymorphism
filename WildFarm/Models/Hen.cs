using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Hen : Bird
    {
        private const double Multiplier = 0.35;
        public Hen(string name, double weight, double wingSize) :
            base(name, weight, wingSize, Multiplier)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override void Feed(IFood food)
        {
            Weight += Multiplier * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return base.ToString() + $"{ WingSize}, { Weight}, { FoodEaten}]";
        }
    }
}
