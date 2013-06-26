using System;

namespace StatePatternFinal.States
{
    public class SoldState : IState
    {
        public GumballMachine GumballMachine { get; set; }
       
        public SoldState(GumballMachine gumballMachine)
        {
            GumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("\tPlease wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("\tSorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("\tTurning twice doesn’t get you another gumball!");
        }

        public void Dispense()
        {
            //Console.WriteLine("A gumball comes rolling out the slot");
            GumballMachine.ReleaseBall();
            //GumballMachine.Count = GumballMachine.Count - 1;
            if (GumballMachine.Count == 0)
            {
                Console.WriteLine("\tOops, out of gumballs!");
                GumballMachine.State = GumballMachine.SoldOutState;
            }
            else
            {
                GumballMachine.State = GumballMachine.NoQuarterState;
            }
        }
    }
}