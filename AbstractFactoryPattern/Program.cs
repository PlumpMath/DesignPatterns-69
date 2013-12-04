using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPattern.Factions;
using AbstractFactoryPattern.Factories;
using StrategyPattern2.Characters;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var legionFactory = new LegionFactory();
            var rebelLegion = legionFactory.CreateLegion("rebel");
            var imperialImpostorsLegion = legionFactory.CreateLegion("imperialimpostors");
            var imperialLegion = legionFactory.CreateLegion("imperial");

            DisplayLegion.Render(rebelLegion);
            DisplayLegion.Render(imperialImpostorsLegion);
            DisplayLegion.Render(imperialLegion);

            Console.ReadLine();
        }
    }
}
