namespace DesignPatterns.Behavioural.Command
{
    /// <summary>
    /// The invoker is responsible for taking requests for commands to be executed, but is not aware of how those commands are implemented.
    /// </summary>
    public class CommandInvoker
    {
        private ICommand currentCommand;

        private ICommand undoCommand;

        public void SetCommand(ICommand command)
        {
            this.currentCommand = command;
        }

        public void ExecuteCommand()
        {
            this.currentCommand.Execute();
            this.undoCommand = this.currentCommand;
        }

        public void Undo()
        {
            // A NullCommand implentation could be used to remove the responsibility of handling null from the client;
            this.undoCommand?.Undo();
        }
    }
}
