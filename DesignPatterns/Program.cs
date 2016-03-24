namespace DesignPatterns
{
    using System;

    using DesignPatterns.Behavioural.Strategy;
    using DesignPatterns.Behavioural.Strategy.Fly;
    using DesignPatterns.Behavioural.Strategy.Quack;
    using DesignPatterns.Creational.Singleton;

    public class Program
    {
        /// <summary>
        /// The entry point for the design pattern demos.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Behavioural.
            Strategy();

            // Creational.
            Singleton();

            Console.ReadKey();
        }

        /// <summary>
        /// A 'behavioural' pattern, the Strategy Pattern defines a family of algorithms/behaviours, encapsulates each one and makes them interchangeable.
        /// The algorithm can vary independently from the clients that use it.
        /// </summary>
        private static void Strategy()
        {
            Duck rubber = new RubberDuck(new Squeaker(), new Flightless());

            Console.WriteLine(rubber.Swim());
            Console.WriteLine(rubber.Display());
            Console.WriteLine(rubber.Quack());
            Console.WriteLine(rubber.Fly());

            rubber.SetFlyBehaviour(new FlyWithWings());

            Console.WriteLine(rubber.Fly());

            Duck mallard = new MallardDuck(new Quacker(), new FlyWithWings());

            Console.WriteLine(mallard.Swim());
            Console.WriteLine(mallard.Display());
            Console.WriteLine(mallard.Quack());
            Console.WriteLine(mallard.Fly());
        }

        /// <summary>
        /// A 'creational' pattern, the Singleton Pattern ensures only one instance of an object can exist
        /// </summary>
        private static void Singleton()
        {
            var a = SimpleSingleton.GetInstance;
            var b = SimpleSingleton.GetInstance;

            if (ReferenceEquals(a, b))
            {
                Console.WriteLine("Got instance of the simple singleton.");
            }

            var c = LazySingleton.GetInstance;
            var d = LazySingleton.GetInstance;

            if (object.ReferenceEquals(c, d))
            {
                Console.WriteLine("Got instance of the lazy singleton.");
            }
        }
    }
}
