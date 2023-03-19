using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Feline : Mammal, IFeline
    {
        
        protected Feline(string name, double weight, string livingRegion, string breed, double multiplier) :
            base(name, weight, livingRegion, multiplier)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
