using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Owl : Bird
    {
        private const double Multiplier = 0.25;
        public Owl(string name, double weight, double wingSize) : 
            base(name, weight, wingSize, Multiplier)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override void Feed(IFood food)
        {
            if (food.GetType().Name == "Meat")
            {
                Weight += Multiplier * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{ WingSize}, { Weight}, { FoodEaten}]";
        }
    }
}
