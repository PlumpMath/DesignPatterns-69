using System;
using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public class Queen : Character
    {
        public Queen()
        {
            Weapon = new Knife();
        }

        public override void Fight()
        {
            Console.WriteLine("The Queen fights...");
            Weapon.UseWeapon();
        }
    }
}