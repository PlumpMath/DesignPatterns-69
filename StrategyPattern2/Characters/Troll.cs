using System;
using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public class Troll : Character
    {
        public Troll()
        {
            Weapon = new Axe();
        }
        public override void Fight()
        {
            Console.WriteLine("The Troll fights...");
            Weapon.UseWeapon();
        }
    }
}