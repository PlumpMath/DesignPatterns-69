using System;
using AbstractFactoryPattern.Legions;

namespace AbstractFactoryPattern
{
    public static class DisplayLegion
    {
        public static void Render(ILegion legion)
        {
            Console.WriteLine("Legion Type: {0}", legion.Name);
            foreach (var faction in legion.Factions)
            {
                Console.WriteLine("\tFaction Type: {0}", faction.Name);
                Console.WriteLine("\tFaction Description: {0}", faction.Description);
                Console.WriteLine("\tStandard Issue Weapon: {0}", faction.StandardIssueWeapon.Name);
                foreach (var soldier in faction.Soldiers)
                {
                    Console.WriteLine("\tSoldier Type: {0} Weapon: {1}", soldier.GetType(), soldier.Weapon.Name);
                }
                Console.ReadLine();
            }
        }
    }
}