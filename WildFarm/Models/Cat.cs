using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public class Cat : Feline
    {
        private const double Multiplier = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed) :
            base(name, weight, livingRegion, breed, Multiplier)
        {
        }

        public override void Feed(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                Weight += Multiplier * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
