using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Bird : Animal, IBird
    {
        private double multiplier;
        protected Bird(string name, double weight, double wingSize, double multiplier) : 
            base(name, weight)
        {
            WingSize = wingSize;
            this.multiplier = multiplier;
        }

        public double WingSize { get; set; }


        //public abstract string ProduceSound();

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, ";
        }
    }
}
