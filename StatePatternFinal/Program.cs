using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePatternFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("---------------------Mighty Gumball, Inc.---------------------");
            Console.WriteLine("--------.NET/Mono powered Gumball Machine Model #2103---------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Booting GumballOS (GNU LINUX)...                              ");
            Console.WriteLine("Starting Gumball Service...                                   ");
            Console.WriteLine("                                                              ");
            Console.ResetColor();

            var gumballMachine = new GumballMachine(5);

            gumballMachine.Status();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.Status();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.Status();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();

            gumballMachine.Status();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

            gumballMachine.InsertQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.Status();

            Console.ReadLine();
        }
    }
}
