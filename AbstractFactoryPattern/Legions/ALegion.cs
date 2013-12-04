using System.Collections.Generic;
using AbstractFactoryPattern.Factions;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Legions
{
    public abstract class ALegion : ILegion
    {
        public string Name { get; set; }
        public IList<IFaction> Factions { get; set; }

        public virtual void PrepareArmy(IFactionFactory factionFactory)
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