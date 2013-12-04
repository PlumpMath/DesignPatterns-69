using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public class Knights: IFaction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IWeapon StandardIssueWeapon { get; set; }
        public IList<ICharacter> Soldiers { get; set; }
        
        public Knights()
        {
            Name = "Jedi Knights";
            Description = "Elite warriors that are highly skilled with the force and lightsabers.";
            StandardIssueWeapon = new LightSaber();
            Soldiers = new List<ICharacter>();
        }
    }
}
