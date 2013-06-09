using System;

namespace StrategyPattern2.Weapons
{
    class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("swings battle axe around chopping off enemy heads");
        }
    }
}