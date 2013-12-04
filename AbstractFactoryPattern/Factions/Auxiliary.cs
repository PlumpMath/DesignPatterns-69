using System.Collections.Generic;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public class Auxiliary : IFaction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IWeapon StandardIssueWeapon { get; set; }
        public IList<ICharacter> Soldiers { get; set; }

        public Auxiliary()
        {
            Name = "Auxiliary";
            Description = "reserve units that serve as backup for infantry";
            StandardIssueWeapon = new BlasterRifle();
            Soldiers = new List<ICharacter>();
        }
    }
}