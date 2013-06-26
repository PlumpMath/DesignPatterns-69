namespace StatePatternFinal.States
{
    public interface IState
    {
        GumballMachine GumballMachine { get; set; }
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}