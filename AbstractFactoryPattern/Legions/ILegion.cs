using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Factions;
using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Legions
{
    public interface ILegion
    {
        string Name { get; set; }
        IList<IFaction> Factions { get; set; }
        void PrepareArmy(IFactionFactory factionFactory);
    }
}
