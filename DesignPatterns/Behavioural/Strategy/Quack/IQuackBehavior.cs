namespace DesignPatterns.Behavioural.Strategy.Quack
{
    /// <summary>
    /// The quacking interface to separate this behaviour from the Duck.
    /// </summary>
    public interface IQuackBehavior
    {
        string Quack();
    }
}