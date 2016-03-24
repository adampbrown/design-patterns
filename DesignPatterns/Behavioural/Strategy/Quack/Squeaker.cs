namespace DesignPatterns.Behavioural.Strategy.Quack
{
    public class Squeaker : IQuackBehavior
    {
        public string Quack()
        {
            return "Squeak";
        }
    }
}
