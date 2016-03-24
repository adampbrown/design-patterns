namespace DesignPatterns.Creational.Singleton
{
    /// <summary>
    /// A simple implementation of a Singleton with double-check locking for thread safety.
    /// </summary>
    public class SimpleSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static SimpleSingleton instance;

        /// <summary>
        /// The padlock for thead-safe locking.
        /// </summary>
        private static readonly object padlock = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="SimpleSingleton"/> class from being created. 
        /// Private constructor to allow only this to create an instance.
        /// </summary>
        private SimpleSingleton()
        {
        }

        /// <summary>
        /// Gets the instance using double-check locking.
        /// </summary>
        public static SimpleSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SimpleSingleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}
