namespace DesignPatterns.Behavioural.Strategy
{
    using DesignPatterns.Behavioural.Strategy.Fly;
    using DesignPatterns.Behavioural.Strategy.Quack;

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
