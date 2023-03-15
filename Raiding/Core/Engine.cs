using Raiding.Core.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            IHero druid = null;
            IHero paladin = null;
            IHero rogue = null;
            IHero warrior = null;
            List<IHero> heroes = new List<IHero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            while (heroes.Count < numberOfHeroes)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    druid = new Druid(heroName);
                    heroes.Add(druid);
                }
                else if (heroType == "Paladin")
                {
                    paladin = new Paladin(heroName);
                    heroes.Add(paladin);
                }
                else if (heroType == "Rogue")
                {
                    rogue = new Rogue(heroName);
                    heroes.Add(rogue);
                }
                else if (heroType == "Warrior")
                {
                    warrior = new Warrior(heroName);
                    heroes.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");//throw new ArgumentException("Invalid hero!");
                }

            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (IHero person in heroes)
            {
                Console.WriteLine(person.CastAbility());
            }

            if (heroes.Sum(h => h.Power) >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
