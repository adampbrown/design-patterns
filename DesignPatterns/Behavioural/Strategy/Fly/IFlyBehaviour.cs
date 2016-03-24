namespace DesignPatterns.Behavioural.Strategy.Fly
{
    /// <summary>
    /// The fly interface to separate this behaviour from the Duck.
    /// </summary>
    public interface IFlyBehaviour
    {
        string Fly();
    }
}