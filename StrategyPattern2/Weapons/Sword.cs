using System;

namespace StrategyPattern2.Weapons
{
    class Sword : IWeapon
    {
        public string Name { get; set; }

        public Sword()
        {
            Name = "Sword";
        }

        public void UseWeapon()
        {
            Console.WriteLine("cuts the enemy in half with a sword");
        }
    }
}