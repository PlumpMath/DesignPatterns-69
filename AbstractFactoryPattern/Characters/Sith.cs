using System;

namespace StrategyPattern2.Characters
{
    public class Sith : Jedi
    {
        public Sith() : base() { }

        public override void Fight()
        {
            Console.WriteLine("The Sith Lord uses the force and fights...");
            Weapon.UseWeapon();
        }
    }
}