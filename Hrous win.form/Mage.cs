using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrous_win.form
{
   

        public class Mage : Hero
        {

            public double BonusDamageDuringStorm { get; set; }

            public Mage(string name, int health, int attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, double bonusDamageDuringStorm)
                : base(name, health, attackPower, resistanceToPhysical, resistanceToMagical, criticalChance, dodgeChance)
            {
                BonusDamageDuringStorm = bonusDamageDuringStorm;
            }
        }
}

