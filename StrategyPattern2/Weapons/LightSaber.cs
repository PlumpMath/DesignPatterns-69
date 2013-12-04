using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Weapons
{
    class LightSaber : IWeapon
    {
        public string Name { get; set; }

        public LightSaber()
        {
            Name = "LightSaber";
        }

        public void UseWeapon()
        {
            Console.WriteLine("wielding a light saber cuting and burning thru the enemies");
        }
    }
}
