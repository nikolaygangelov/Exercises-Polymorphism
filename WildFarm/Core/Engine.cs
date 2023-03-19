using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;
using WildFarm.IO.Interfaces;
using WildFarm.Models;
using WildFarm.Models.Interfaces;
using WildFarm.Core.Interfaces;
using System.Linq;
using WildFarm.Factories;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IAnimalFactory animalFactory;
        private IFoodFactory foodFactory;

        private readonly ICollection<IFood> eatables;
        private readonly ICollection<IAnimal> animals;

        public Engine(IReader reader, IWriter writer,
            IAnimalFactory animalFactory, IFoodFactory foodFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;

            animals = new List<IAnimal>();
        }
        public void Run()
        {
            string command1 = string.Empty;
            while ((command1 = reader.ReadLine()) != "End")
            {
                string[] animalInfo = command1
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);


                IAnimal animal = null;

                try
                {
                    animal = animalFactory.CreateAnimal(animalInfo);

                    string command2 = reader.ReadLine();

                    if (command2 == "End")
                    {
                        break;
                    }


                    string[] foodInfo = command2
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string foodType = foodInfo[0];
                    int quantity = int.Parse(foodInfo[1]);

                    IFood food = foodFactory.CreateFood(foodType, quantity);

                    writer.WriteLine(animal.ProduceSound());

                    animal.Feed(food);

                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
                catch (Exception)
                {
                    throw;
                }

                animals.Add(animal);

                
            }

            foreach (IAnimal animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }
        }
    }
}
