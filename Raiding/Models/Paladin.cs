﻿using Raiding.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : Hero
    {
        private const int PaladinPower = 100;
        public Paladin(string name) :
            base(name, PaladinPower)
        {
         
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
