using System.Collections.Generic;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public class Battery : IFaction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IWeapon StandardIssueWeapon { get; set; }
        public IList<ICharacter> Soldiers { get; set; }

        public Battery()
        {
            Name = "Battery";
            Description = "This unit is armed with heavy artillery like hover tanks and blaster canons";
            StandardIssueWeapon = new BlasterCanons();
            Soldiers = new List<ICharacter>();
        }
    }
}