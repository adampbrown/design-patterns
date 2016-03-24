namespace DesignPatterns.Behavioural.Strategy
{
    using DesignPatterns.Behavioural.Strategy.Fly;
    using DesignPatterns.Behavioural.Strategy.Quack;

    /// <summary>
    /// The duck that does not understand the implementation details of it's behaviors.
    /// </summary>
    public abstract class Duck
    {
        private IFlyBehaviour flyBehaviour;

        private IQuackBehavior quackBehavior;

        /// <summary>
        /// Initializes a new instance of the <see cref="Duck"/> class.
        /// </summary>
        /// <param name="quackBehavior">The <see cref="IQuackBehavior"/></param>
        /// <param name="flyBehaviour">The <see cref="IFlyBehaviour"/>.</param>
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
