using System;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Weapons
{
    public class BlasterRifle : IWeapon
    {
        public string Name { get; set; }

        public BlasterRifle()
        {
            Name = "Blaster Rifle";
        }

        public void UseWeapon()
        {
            Console.WriteLine("fire blaster rifle");
        }
    }
}