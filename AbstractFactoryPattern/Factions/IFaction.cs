using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Legions;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public interface IFaction
    {
        String Name { get; set; }
        String Description { get; set; }
        IWeapon StandardIssueWeapon { get; set; }
        IList<ICharacter> Soldiers { get; set; }
    }
}
