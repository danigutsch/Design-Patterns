using System.Text;

namespace Gumball
{
    public class GumballMachine
    {
        private const int SOLD_OUT = 0;
        private const int NO_QUARTER = 1;
        private const int HAS_QUARTER = 2;
        private const int SOLD = 3;

        private int _state = SOLD_OUT;
        private int _count;

        public GumballMachine(int count)
        {
            _count = count;
            if (_count > 0)
            {
                _state = NO_QUARTER;
            }
        }

        public void InsertQuarter()
        {
            switch (_state)
            {
                case SOLD_OUT:
                    Console.WriteLine("You can't insert a quarter, the machine is sold out");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You inserted a quarter");
                    break;
                case HAS_QUARTER:
                    Console.WriteLine("You can't insert another quarter");
                    break;
                case SOLD:
                    Console.WriteLine("Please wait, we're already giving you a gumball");
                    break;
            }
        }

        public void EjectQuarter()
        {
            switch (_state)
            {
                case SOLD_OUT:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You haven't inserted a quarter");
                    break;
                case HAS_QUARTER:
                    Console.WriteLine("Quarter returned");
                    _state = NO_QUARTER;
                    break;
                case SOLD:
                    Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
                    break;
            }
        }

        public void TurnCrank()
        {
            switch (_state)
            {
                case SOLD_OUT:
                    Console.WriteLine("You turned, but there are no gumballs");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You turned but there's no quarter");
                    break;
                case HAS_QUARTER:
                    Console.WriteLine("You turned...");
                    _state = SOLD;
                    Dispense();
                    break;
                case SOLD:
                    Console.WriteLine("Sorry, you already turned the crank");
                    break;
            }
        }

        public void Dispense()
        {
            switch (_state)
            {
                case SOLD_OUT:
                    Console.WriteLine("No gumball dispensed");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("You need to pay first");
                    break;
                case HAS_QUARTER:
                    Console.WriteLine("You need to turn the crank");
                    break;
                case SOLD:
                    Console.WriteLine("A gumball comes rolling out the slot");
                    _count--;
                    if (_count == 0)
                    {
                        Console.WriteLine("Oops, out of gumballs!");
                        _state = SOLD_OUT;
                    }
                    else
                    {
                        _state = NO_QUARTER;
                    }
                    break;
            }
        }

        public void Refill(int count)
        {
            _count += count;
            _state = NO_QUARTER;
        }

        public override string ToString()
        {
            StringBuilder result = new();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nC#-enabled Standing Gumball Model #2016\n");
            result.Append("Inventory: ").Append(_count).Append(" gumball");
            if (_count != 1)
            {
                result.Append('s');
            }
            result.Append("\nMachine is ");
            if (_state == SOLD_OUT)
            {
                result.Append("sold out");
            }
            else if (_state == NO_QUARTER)
            {
                result.Append("waiting for quarter");
            }
            else if (_state == HAS_QUARTER)
            {
                result.Append("waiting for turn of crank");
            }
            else if (_state == SOLD)
            {
                result.Append("delivering a gumball");
            }
            result.Append('\n');
            return result.ToString();
        }
    }
}
