namespace DesignPatterns
{
    using System;

    using DesignPatterns.Strategy;
    using DesignPatterns.Strategy.Fly;
    using DesignPatterns.Strategy.Quack;

    public class Program
    {
        static void Main(string[] args)
        {
            Strategy();
        }

        /// <summary>
        /// The Strategy Pattern defines a family of algorithms, encapsulates each one and makes them interchangeable.
        /// The algorithm can vary independently from the clients that use it.
        /// </summary>
        private static void Strategy()
        {
            Duck rubber = new RubberDuck(new Squeaker(), new Flightless());

            Console.WriteLine(rubber.Display());
            Console.WriteLine(rubber.Quack());
            Console.WriteLine(rubber.Fly());

            rubber.SetFlyBehaviour(new FlyWithWings());

            Console.WriteLine(rubber.Fly());

            Duck mallard = new MallardDuck(new Quacker(), new FlyWithWings());

            Console.WriteLine(mallard.Display());
            Console.WriteLine(mallard.Quack());
            Console.WriteLine(mallard.Fly());
        }
    }
}
