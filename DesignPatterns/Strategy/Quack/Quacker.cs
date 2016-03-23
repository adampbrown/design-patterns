namespace DesignPatterns.Strategy.Quack
{
    class Quacker : IQuackBehavior
    {
        public string Quack()
        {
            return "Quack!";
        }
    }
}
