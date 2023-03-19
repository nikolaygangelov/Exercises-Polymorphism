using System;
using WildFarm.Core;
using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Factories.Interfaces;
using WildFarm.IO;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            //или първо се инициализират/създават извън конструктора на IEngine
            //IReader reader = new ConsoleReader();
            //IWriter writer = new ConsoleWriter(); 

            //или в конструктора
            IEngine engine = new Engine(new ConsoleReader(), new ConsoleWriter(), animalFactory, foodFactory);
            engine.Run();
        }
    }
}
