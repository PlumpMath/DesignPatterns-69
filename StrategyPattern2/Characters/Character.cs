using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern2.Weapons;

namespace StrategyPattern2.Characters
{
    public abstract class Character : ICharacter
    {
        public IWeapon Weapon { get; set; }
        public abstract void Fight();
    }
}
