namespace MiniDuckSimulator.Behaviors
{
    internal class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}