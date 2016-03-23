namespace DesignPatterns.Strategy
{
    using DesignPatterns.Strategy.Fly;
    using DesignPatterns.Strategy.Quack;

    public class RubberDuck : Duck
    {
        public RubberDuck(IQuackBehavior quackBehavior, IFlyBehaviour flyBehaviour)
            : base(quackBehavior, flyBehaviour)
        {
        }

        public override string Display()
        {
            return "I'm yellow and mafe of rubber.";
        }
    }
}
