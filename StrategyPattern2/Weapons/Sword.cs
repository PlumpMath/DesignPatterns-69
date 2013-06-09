using System;

namespace StrategyPattern2.Weapons
{
    class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("cuts the enemy in half with a sword");
        }
    }
}