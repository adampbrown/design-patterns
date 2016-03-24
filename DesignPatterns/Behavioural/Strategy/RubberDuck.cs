namespace DesignPatterns.Behavioural.Strategy
{
    using DesignPatterns.Behavioural.Strategy.Fly;
    using DesignPatterns.Behavioural.Strategy.Quack;

    public class RubberDuck : Duck
    {
        public RubberDuck(IQuackBehavior quackBehavior, IFlyBehaviour flyBehaviour)
            : base(quackBehavior, flyBehaviour)
        {
        }

        public override string Display()
        {
            return "I'm yellow and made of rubber.";
        }
    }
}
