using System;
using StatePatternFinal.States;

namespace StatePatternFinal
{
    public class GumballMachine
    {
        public IState SoldOutState;
        public IState NoQuarterState;
        public IState HasQuarterState;
        public IState SoldState;

        private IState _state;
        public IState State
        {
            set
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("[StateChanged] from {0} to {1}", _state.GetType().Name, value.GetType().Name);
                    Console.ResetColor();
                }
                catch{}
                _state = value;
            }
            get { return _state; }
        }

        private int _count = 0;
        public int Count
        {
            set
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("[CountChange] from {0} to {1}", _count, value);
                    Console.ResetColor();
                }
                catch{}
                _count = value;
            }
            get { return _count; }
        }

        public GumballMachine(int count)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            Count = count;

            State = SoldOutState;
            if (count > 0)
            {
                State = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            LogUser("Inserting Quarter");
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            LogMachine("Ejecting Quarter");
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            LogUser("Turn Crank");
            State.TurnCrank();

            LogMachine("Dispense Gumball");
            State.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count = Count - 1;
            }
        }

        public void Status()
        {
            LogStatus(string.Format("\n\n----------------------------------------\nGumball Count: {0} State: {1}\n----------------------------------------\n\n", Count, State.GetType().Name));
        }

        public void LogStatus(string message)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void LogMachine(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[MachineAction] " + message);
            Console.ResetColor();
        }

        public void LogUser(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[UserAction] "+message);
            Console.ResetColor();
        }
    }
}