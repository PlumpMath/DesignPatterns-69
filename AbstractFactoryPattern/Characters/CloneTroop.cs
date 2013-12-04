using System;
using AbstractFactoryPattern.Weapons;

namespace StrategyPattern2.Characters
{
    public class CloneTroop : Character
    {
        public CloneTroop()
        {
            Weapon = new Blaster();
        }
        public override void Fight()
        {
            Console.WriteLine("The clone troop fights...");
            Weapon.UseWeapon();
        }
    }
}