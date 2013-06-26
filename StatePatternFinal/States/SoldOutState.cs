using System;

namespace StatePatternFinal.States
{
    public class SoldOutState : IState
    {
        public GumballMachine GumballMachine { get; set; }

        public SoldOutState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("\tYou can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("\tYou can’t eject, you haven’t inserted a quarter yet");
        }

        public void TurnCrank()
        {
            Console.WriteLine("\tYou turned, but there are no gumballs");
        }

        public void Dispense()
        {
            Console.WriteLine("\tNo gumball dispensed");
        }
    }
}