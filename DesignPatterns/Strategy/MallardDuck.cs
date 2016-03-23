namespace DesignPatterns.Strategy
{
    using DesignPatterns.Strategy.Fly;
    using DesignPatterns.Strategy.Quack;

    public class MallardDuck : Duck
    {
        public MallardDuck(IQuackBehavior quackBehavior, IFlyBehaviour flyBehaviour)
            : base(quackBehavior, flyBehaviour)
        {
        }

        public override string Display()
        {
            return "I'm a real duck.";
        }
    }
}
