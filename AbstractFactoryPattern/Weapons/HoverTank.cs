using System;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Weapons
{
    public class HoverTank : IWeapon
    {
        public string Name { get; set; }

        public HoverTank()
        {
            Name = "Hover Tank";
        }

        public void UseWeapon()
        {
            Console.WriteLine("drive tank to position and fire tank's blaster");
        }
    }
}