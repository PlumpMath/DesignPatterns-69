using System;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Weapons
{
    public class Blaster : IWeapon
    {
        public string Name { get; set; }

        public Blaster()
        {
            Name = "Blaster";
        }

        public void UseWeapon()
        {
            Console.WriteLine("fire blaster");
        }
    }
}