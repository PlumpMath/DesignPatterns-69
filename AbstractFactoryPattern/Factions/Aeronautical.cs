using System.Collections.Generic;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public class Aeronautical : IFaction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IWeapon StandardIssueWeapon { get; set; }
        public IList<ICharacter> Soldiers { get; set; }

        public Aeronautical()
        {
            Name = "Aeronautics and Space";
            Description = "A fleet of pilots flying aircraft and spacecraft";
            StandardIssueWeapon = new StarFighter();
            Soldiers = new List<ICharacter>();
        }
    }
}