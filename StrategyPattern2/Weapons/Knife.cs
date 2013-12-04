using System;

namespace StrategyPattern2.Weapons
{
    class Knife : IWeapon
    {
        public string Name { get; set; }

        public Knife()
        {
            Name = "Knife";
        }

        public void UseWeapon()
        {
            Console.WriteLine("stabs enemies to death with knife");
        }
    }
}