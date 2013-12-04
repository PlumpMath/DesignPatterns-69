using System;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;

namespace AbstractFactoryPattern.Characters
{
    public class Droid : Character
    {
        public Droid()
        {
            Weapon = new Blaster();
        }
        public override void Fight()
        {
            Console.WriteLine("The droid fights...");
            Weapon.UseWeapon();
        }
    }
}