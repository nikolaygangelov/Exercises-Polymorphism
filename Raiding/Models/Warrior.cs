using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : Hero
    {
        private const int WarriorPower = 100;
        public Warrior(string name) :
            base(name, WarriorPower)
        {
            
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
