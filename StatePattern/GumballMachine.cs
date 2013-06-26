using System;

namespace StatePattern
{
    public class GumballMachine
    {
        public const int SOLD_OUT = 0;
        public const int NO_QUARTER = 1;
        public const int HAS_QUARTER = 2;
        public const int SOLD = 3;

        public int State = SOLD_OUT;
        public int Count = 0;

        public GumballMachine(int count)
        {
            Count = count;
            if (count > 0)
            {
                State = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            switch (State)
            {
                case HAS_QUARTER:
                    Console.WriteLine("You can't insert another quarter");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You inserted a quarter");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You can't insert a quarter, the machine is sold out");
                    break;
                case SOLD:
                    Console.WriteLine("Please wait, we're already giving you a gumball");
                    break;
            }
        }

        public void EjectQuarter() 
        {
            switch (State)
            {
                case HAS_QUARTER:
                    State = NO_QUARTER;
                    Console.WriteLine("Quarter returned");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You haven’t inserted a quarter");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You can’t eject, you haven’t inserted a quarter yet");
                    break;
                case SOLD:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
            }
        }
        public void TurnCrank() 
        {
            switch (State)
            {
                case HAS_QUARTER:
                    State = NO_QUARTER;
                    Console.WriteLine("You turned...");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You turned but there’s no quarter");
                    State = SOLD;
                    Dispense();
                    break;
                case SOLD_OUT:
                    Console.WriteLine("You turned, but there are no gumballs");
                    break;
                case SOLD:
                    Console.WriteLine("Turning twice doesn’t get you another gumball!");
                    break;
            }
        }
        public void Dispense() 
        {
            switch (State)
            {
                case HAS_QUARTER:
                    State = NO_QUARTER;
                    Console.WriteLine("No gumball dispensed");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You need to pay first");
                    State = SOLD;
                    Dispense();
                    break;
                case SOLD_OUT:
                    Console.WriteLine("No gumball dispensed");
                    break;
                case SOLD:
                    Console.WriteLine("A gumball comes rolling out the slot");
                    Count = Count - 1;
                    if (Count == 0) {
                        Console.WriteLine("Oops, out of gumballs!");
                        State = SOLD_OUT;
                    } else {
                        State = NO_QUARTER;
                    }
                    break;
            }
        }
    }
}