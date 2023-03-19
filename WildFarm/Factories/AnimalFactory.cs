using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Factories.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string [] animalInfo)
        {

            string type = animalInfo[0];
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);

            switch (type)
            {
                case "Owl":
                    return new Owl(name, weight, double.Parse(animalInfo[3]));
                case "Hen":
                    return new Hen(name, weight, double.Parse(animalInfo[3]));
                case "Mouse":
                    return new Mouse(name, weight, animalInfo[3]);
                case "Dog":
                    return new Dog(name, weight, animalInfo[3]);
                case "Cat":
                    return new Cat(name, weight, animalInfo[3], animalInfo[4]);
                case "Tiger":
                    return new Tiger(name, weight, animalInfo[3], animalInfo[4]);
                default:
                    throw new ArgumentException("Invalid animal type!");
            }
        }
    }
}
