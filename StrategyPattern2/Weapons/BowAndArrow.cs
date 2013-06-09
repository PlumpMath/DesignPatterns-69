using System;

namespace StrategyPattern2.Weapons
{
    class BowAndArrow : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("shoot arrows into enemies hearts");
        }
    }
}