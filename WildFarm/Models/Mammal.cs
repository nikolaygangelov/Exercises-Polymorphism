using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Mammal : Animal, IMammal
    {
        private double multiplier;

        public Mammal(string name, double weight, string livingRegion, double multiplier) : 
            base(name, weight)
        {
            LivingRegion = livingRegion;
            this.multiplier = multiplier;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, ";
        }
    }
}
