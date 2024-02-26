using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrous_win.form
{
    class Warrior : Hero
    {
            public int Armor { get; set; }

            public Warrior(string name, int health, int attackPower, double resistanceToPhysical, double resistanceToMagical, double criticalChance, double dodgeChance, int armor)
                : base(name, health, attackPower, resistanceToPhysical, resistanceToMagical, criticalChance, dodgeChance)
            {
                Armor = armor;
            }
        }
    }

