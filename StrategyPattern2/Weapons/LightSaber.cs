using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern2.Weapons
{
    class LightSaber : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("wielding a light saber cuting and burning thru the enemies");
        }
    }
}
