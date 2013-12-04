using System;
using AbstractFactoryPattern.Legions;

namespace AbstractFactoryPattern.Factories
{
    class LegionFactory : ILegionFactory
    {
        public ILegion Legion { get; set; }

        public ILegion CreateLegion(string legionType)
        {

                IFactionFactory factionFactory = null; 
                switch (legionType.ToLower())
                {
                    case "rebel":
                        Legion = new RebelArmy();
                        factionFactory = new RebelFactionFactory();
                        break;
                    case "imperial":
                        Legion = new ImperialArmy();
                        factionFactory = new ImperialFactionFactory();
                        break;
                    case "imperialimpostors":
                        Legion = new RebelArmy();
                        factionFactory = new ImperialFactionFactory();
                        break;
                }
                if (factionFactory != null)
                {
                    Legion.PrepareArmy(factionFactory);
                    return Legion;
                }
                else
                {
                    throw new ArgumentException("Could not initialize IFactionFactory");
                }
        }
    }
}