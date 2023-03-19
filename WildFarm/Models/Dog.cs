using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        private const double Multiplier = 0.40;
        public Dog(string name, double weight, string livingRegion) : 
            base(name, weight, livingRegion, Multiplier)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
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
            return base.ToString() + $"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
