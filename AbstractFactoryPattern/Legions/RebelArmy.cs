using System.Collections.Generic;
using AbstractFactoryPattern.Factions;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Legions
{
    public class RebelArmy : ALegion
    {
        public RebelArmy()
        {
            Name = "Rebel Alliance Army";
            Factions = new List<IFaction>();
        }

        public override void PrepareArmy(IFactionFactory factionFactory)
        {
            factionFactory.Legion = this;
            factionFactory.RecruitAeronautical();
            factionFactory.RecruitAuxiliary();
            factionFactory.RecruitBattery();
            factionFactory.RecruitInfantry();
            factionFactory.RecruitKnights();
            factionFactory.RecruitReconnaissance();
        }
    }
}