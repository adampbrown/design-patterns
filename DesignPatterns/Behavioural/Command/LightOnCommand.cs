namespace DesignPatterns.Behavioural.Command
{
    using DesignPatterns.Behavioural.Command.Receivers;

    /// <summary>
    /// This command is tied to the receiver (the Light object) which implements the action that the command relates to.
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.On();
        }

        public void Undo()
        {
            this.light.Off();
        }
    }
}
