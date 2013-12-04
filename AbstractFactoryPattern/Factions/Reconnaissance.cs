using System.Collections.Generic;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace AbstractFactoryPattern.Factions
{
    public class Reconnaissance : IFaction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IWeapon StandardIssueWeapon { get; set; }
        public IList<ICharacter> Soldiers { get; set; }

        public Reconnaissance()
        {
            Name = "Reconnaissance";
            Description = "A special forces unit that scouts and spys on the enemy";
            StandardIssueWeapon = new Blaster();
            Soldiers = new List<ICharacter>();
        }
    }
}