using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern2.Characters;
using StrategyPattern2.Weapons;

namespace StrategyPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            var UsageText = "<< Press any key to continue >>";
            var characters = new List<ICharacter>
                {
                    new King(),
                    new Queen(),
                    new Knight(),
                    new Troll()
                };

            foreach (var character in characters)
            {
                character.Fight();
                if (character.GetType() == typeof(Knight))
                {
                    character.Weapon = new Sword();
                    character.Fight();

                    character.Weapon = new Axe();
                    character.Fight();
                }
                Console.WriteLine(UsageText);
                Console.ReadLine();
            }

            var jedi = new Jedi();
            jedi.Fight();
            Console.WriteLine(UsageText);
            Console.ReadLine();

            var knightWithLightSaber = new Knight() {Weapon = new LightSaber()};
            knightWithLightSaber.Fight();

            Console.ReadLine();
        }
    }
}
