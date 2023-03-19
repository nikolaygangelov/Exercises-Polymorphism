using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        private const double Multiplier = 0.10;
        public Mouse(string name, double weight, string livingRegion) : 
            base(name, weight, livingRegion, Multiplier)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Feed(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
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
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
