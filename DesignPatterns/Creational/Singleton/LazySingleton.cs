namespace DesignPatterns.Creational.Singleton
{
    using System;

    /// <summary>
    /// An implementation of a lazy Singleton
    /// </summary>
    public class LazySingleton
    {
        /// <summary>
        /// The lazy instance, supplied with a delegate to the constructor via a lambda.
        /// </summary>
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());

        /// <summary>
        /// Prevents a default instance of the <see cref="LazySingleton"/> class from being created.
        /// </summary>
        private LazySingleton()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static LazySingleton GetInstance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}