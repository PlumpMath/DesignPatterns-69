using System.Collections.Generic;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public class Infantry : IFaction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IWeapon StandardIssueWeapon { get; set; }
        public IList<ICharacter> Soldiers { get; set; }

        public Infantry()
        {
            Name = "Infantry";
            Description = "First line of attack or defense";
            StandardIssueWeapon = new BlasterRifle();
            Soldiers = new List<ICharacter>();
        }
    }
}