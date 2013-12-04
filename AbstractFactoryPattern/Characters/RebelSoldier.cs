using System;
using AbstractFactoryPattern.Weapons;

namespace StrategyPattern2.Characters
{
    public class RebelSoldier : Character
    {
        public RebelSoldier()
        {
            Weapon = new Blaster();
        }
        public override void Fight()
        {
            Console.WriteLine("The rebel soldier fights...");
            Weapon.UseWeapon();
        }
    }
}