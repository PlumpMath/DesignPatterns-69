using System;

namespace StatePatternFinal.States
{
    public class NoQuarterState : IState
    {
        public GumballMachine GumballMachine { get; set; }

        public NoQuarterState(GumballMachine gumballMachine) {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter() {
            Console.WriteLine("\tYou inserted a quarter");
            GumballMachine.State = GumballMachine.HasQuarterState;
        }
        public void EjectQuarter() {
            Console.WriteLine("\tYou haven’t inserted a quarter");
        }
        public void TurnCrank() {
            Console.WriteLine("\tYou turned, but there’s no quarter");
        }
        public void Dispense() {
            Console.WriteLine("\tYou need to pay first");
        }
    }
}