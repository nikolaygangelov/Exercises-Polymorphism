using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : Hero
    {
        private const int RoguePower = 80;
        public Rogue(string name) :
            base(name, RoguePower)
        {
            
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
