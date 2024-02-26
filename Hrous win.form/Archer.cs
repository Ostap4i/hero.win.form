using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrous_win.form
{
    class Archer : Hero
    {
      
            public int BonusDamageOnTripleShot { get; set; }

            public Archer(string name, int health, int attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, int bonusDamageOnTripleShot)
                : base(name, health, attackPower, resistanceToPhysical, resistanceToMagical, criticalChance, dodgeChance)
            {
                BonusDamageOnTripleShot = bonusDamageOnTripleShot;
            }
        }
    }

