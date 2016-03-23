namespace DesignPatterns.Strategy
{
    using DesignPatterns.Strategy.Fly;
    using DesignPatterns.Strategy.Quack;

    public abstract class Duck
    {
        private IFlyBehaviour flyBehaviour;

        private IQuackBehavior quackBehavior;

        protected Duck(IQuackBehavior quackBehavior, IFlyBehaviour flyBehaviour)
        {
            this.quackBehavior = quackBehavior;
            this.flyBehaviour = flyBehaviour;
        }

        public abstract string Display();

        public string Swim()
        {
            return "All ducks float, even decoys!";
        }

        public string Quack()
        {
            return this.quackBehavior.Quack();
        }

        public string Fly()
        {
            return this.flyBehaviour.Fly();
        }

        public void SetQuackBehaviour(IQuackBehavior behaviour)
        {
            this.quackBehavior = behaviour;
        }

        public void SetFlyBehaviour(IFlyBehaviour behaviour)
        {
            this.flyBehaviour = behaviour;
        }
    }
}
