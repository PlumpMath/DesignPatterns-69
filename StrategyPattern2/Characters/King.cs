using System;
using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public class King : Character
    {

        public King()
        {
            Weapon = new Sword();
        }

        public override void Fight()
        {
            Console.WriteLine("The King fights...");
            Weapon.UseWeapon();
        }
    }
}