namespace MiniDuckSimulator.Behaviors
{
    internal class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}