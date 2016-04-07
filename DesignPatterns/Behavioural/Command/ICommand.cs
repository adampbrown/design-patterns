namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// The command interface.
    /// </summary>
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}