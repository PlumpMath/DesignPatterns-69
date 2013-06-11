using System;
using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public class Knight : Character
    {
        public Knight()
        {
            Weapon = new BowAndArrow();
        }
        public Knight(IWeapon weapon)
        {
            Weapon = weapon;
        }
        public override void Fight()
        {
            Console.WriteLine("The Knight fights...");
            Weapon.UseWeapon();
        }
    }
}