using System;

namespace StrategyPattern2.Weapons
{
    class BowAndArrow : IWeapon
    {
        public string Name { get; set; }

        public BowAndArrow()
        {
            Name = "Bow and Arrow";
        }

        public void UseWeapon()
        {
            Console.WriteLine("shoot arrows into enemies hearts");
        }
    }
}