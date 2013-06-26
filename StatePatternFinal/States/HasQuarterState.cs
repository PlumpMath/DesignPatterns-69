using System;

namespace StatePatternFinal.States
{
    public class HasQuarterState : IState
    {
        public GumballMachine GumballMachine { get; set; }

        public HasQuarterState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("\tYou can't insert another quarter");
        }

        public void EjectQuarter()
        {
            GumballMachine.State = GumballMachine.NoQuarterState;
            Console.WriteLine("\tQuarter returned");
        }

        public void TurnCrank()
        {
            GumballMachine.State = GumballMachine.SoldState;
            Console.WriteLine("\tYou turned...");
        }

        public void Dispense()
        {
            GumballMachine.State =  GumballMachine.NoQuarterState;
            Console.WriteLine("\tNo gumball dispensed");
        }
    }
}