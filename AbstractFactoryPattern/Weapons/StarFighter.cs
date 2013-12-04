using System;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Weapons
{
    public class StarFighter : IWeapon
    {
        public string Name { get; set; }

        public StarFighter()
        {
            Name = "Star Fighter";
        }

        public void UseWeapon()
        {
            Console.WriteLine("Fly Starfighter into position and fire blasters");
        }
    }
}