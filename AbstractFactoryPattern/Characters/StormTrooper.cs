using System;
using AbstractFactoryPattern.Weapons;

namespace StrategyPattern2.Characters
{
    public class StormTrooper : Character
    {
        public StormTrooper()
        {
            Weapon = new Blaster();
        }
        public override void Fight()
        {
            Console.WriteLine("The storm troop fights...");
            Weapon.UseWeapon();
        }
    }
}