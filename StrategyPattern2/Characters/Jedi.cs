using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public class Jedi : Character
    {
        public Jedi()
        {
            Weapon = new LightSaber();
        }
        public override void Fight()
        {
            Console.WriteLine("The Jedi Knight uses the force and fights...");
            Weapon.UseWeapon();
        }
    }
}
