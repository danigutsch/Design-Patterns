using GumballStateWinner.States;
using System.Text;

namespace GumballStateWinner
{
    public class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState HasQuarterState { get; }
        public IState NoQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }

        public int Count { get; private set; }
        public IState State { get; private set; }

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            HasQuarterState = new HasQuarterState(this);
            NoQuarterState = new NoQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Count = numberGumballs;
            State = numberGumballs > 0 ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter()
        {
            State.InsertQuarter();
        }

        public void EjectQuarter()
        {
            State.EjectQuarter();
        }

        public void TurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void SetState(IState state)
        {
            State = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count > 0)
            {
                Count--;
            }
        }

        public void Refill(int count)
        {
            Count += count;
            Console.WriteLine($"The gumball machine was just refilled; its new count is: {Count}");
            State.Refill();
        }

        public override string ToString()
        {
            StringBuilder result = new();

            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2016");
            result.Append("\nInventory: ").Append(Count).Append(" gumball");
            if (Count != 1)
            {
                result.Append('s');
            }
            result.Append('\n');
            result.Append("Machine is ").Append(State).Append('\n');

            return result.ToString();
        }
    }
}
