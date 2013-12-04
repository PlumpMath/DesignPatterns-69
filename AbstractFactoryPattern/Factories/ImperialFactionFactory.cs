using AbstractFactoryPattern.Characters;
using AbstractFactoryPattern.Factions;
using AbstractFactoryPattern.Legions;
using AbstractFactoryPattern.Weapons;
using StrategyPattern2.Characters;

namespace AbstractFactoryPattern.Factories
{
    public class ImperialFactionFactory : IFactionFactory
    {
        public ILegion Legion { get; set; }

        public void RecruitInfantry()
        {
            var faction = new Infantry();
            var counter = 0;
            for (var i = 0; i < 6; i++)
            {
                var soldier = new StormTrooper();
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
            for (var i = 0; i < 5; i++)
            {
                var soldier = new Droid();
                if (counter > 2)
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
            for (var i = 0; i < 5; i++)
            {
                ICharacter soldier;
                if (counter > 2)
                {
                    soldier = new Sith();
                    counter++;
                }
                else
                {
                    soldier = new StormTrooper();
                    counter = 0;
                }
                soldier.Weapon = faction.StandardIssueWeapon;

                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitBattery()
        {
            var faction = new Reconnaissance();
            var counter = 0;
            for (var i = 0; i < 4; i++)
            {
                var soldier = new Droid();
                soldier.Weapon = new HoverTank();
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }

        public void RecruitAeronautical()
        {
            var faction = new Aeronautical();
            var counter = 0;
            for (var i = 0; i < 3; i++)
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
                var soldier = new Sith();
                soldier.Weapon = faction.StandardIssueWeapon;
                faction.Soldiers.Add(soldier);
            }
            Legion.Factions.Add(faction);
        }
    }
}