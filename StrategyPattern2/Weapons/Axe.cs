using System;

namespace StrategyPattern2.Weapons
{
    class Axe : IWeapon
    {
        public string Name { get; set; }

        public Axe()
        {
            Name = "Axe";
        }

        public void UseWeapon()
        {
            Console.WriteLine("swings battle axe around chopping off enemy heads");
        }
    }
}