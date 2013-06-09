using System;

namespace StrategyPattern2.Weapons
{
    class Knife : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("stabs enemies to death with knife");
        }
    }
}