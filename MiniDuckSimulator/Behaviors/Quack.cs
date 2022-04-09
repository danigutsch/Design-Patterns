namespace MiniDuckSimulator.Behaviors
{
    internal class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}