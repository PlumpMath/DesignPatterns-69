using System;
using AbstractFactoryPattern.Characters;
using AbstractFactoryPattern.Factions;
using AbstractFactoryPattern.Legions;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;

namespace AbstractFactoryPattern.Factories
{
    public class RebelFactionFactory : IFactionFactory
    {
        public ILegion Legion { get; set; }
        
        public void RecruitInfantry()
        {
            var faction = new Infantry();
            var counter = 0;
            for (var i=0; i < 500; i++)
            {
                var soldier = new RebelSoldier();
                if (counter > 3)
                {
                    soldier.Weapon = new BlasterRifle();
                    counter++;
                }
                else
                {
                    soldier.Weapon = faction.StandardIssueWeapon;
                    counter = 0;
                }
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitAuxiliary()
        {
            var faction = new Auxiliary();
            var counter = 0;
            for (var i=0; i < 100; i++)
            {
                var soldier = new RebelSoldier();
                if (counter > 3)
                {
                    soldier.Weapon = new BlasterCanons();
                    counter++;
                }
                else
                {
                    soldier.Weapon = faction.StandardIssueWeapon;
                    counter = 0;
                }
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitReconnaissance()
        {
            var faction = new Reconnaissance();
            var counter = 0;
            for (var i=0; i < 5; i++)
            {
                var soldier = new RebelSoldier();
                if (counter > 3)
                {
                    soldier.Weapon = new BlasterRifle();
                    counter++;
                }
                else
                {
                    soldier.Weapon = faction.StandardIssueWeapon;
                    counter = 0;
                }
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitBattery()
        {
            var faction = new Reconnaissance();
            var counter = 0;
            for (var i=0; i < 4; i++)
            {
                var soldier = new RebelSoldier();
                soldier.Weapon = new HoverTank();
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitAeronautical()
        {
            var faction = new Aeronautical();
            var counter = 0;
            for (var i = 0; i < 10; i++)
            {
                var soldier = new Pilot();
                soldier.Weapon = faction.StandardIssueWeapon;
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitKnights()
        {
            var faction = new Knights();
            var counter = 0;
            for (var i = 0; i < 5; i++)
            {
                var soldier = new Jedi();
                soldier.Weapon = faction.StandardIssueWeapon;
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }
    }
}