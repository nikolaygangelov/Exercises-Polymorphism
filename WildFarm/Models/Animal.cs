using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        

        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract string ProduceSound();
        public virtual void Feed(IFood food)
        {

        }
    }

}
