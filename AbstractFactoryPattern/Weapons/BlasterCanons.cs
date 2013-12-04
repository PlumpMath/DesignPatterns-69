using System;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Weapons
{
    public class BlasterCanons : IWeapon
    {
        public string Name { get; set; }

        public BlasterCanons()
        {
            Name = "Blaster Canon";
        }

        public void UseWeapon()
        {
            Console.WriteLine("fire canon blaster");
        }
    }
}