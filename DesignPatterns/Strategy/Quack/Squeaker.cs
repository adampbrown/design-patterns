namespace DesignPatterns.Strategy.Quack
{
    public class Squeaker : IQuackBehavior
    {
        public string Quack()
        {
            return "Squeak";
        }
    }
}
