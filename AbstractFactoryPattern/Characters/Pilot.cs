using System;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;

namespace AbstractFactoryPattern.Characters
{
    public class Pilot : Character
    {
        public Pilot()
        {
            Weapon = new StarFighter();
        }

        public override void Fight()
        {
            Console.WriteLine("The Pilot attacks...");
            Weapon.UseWeapon();
        }
    }
}