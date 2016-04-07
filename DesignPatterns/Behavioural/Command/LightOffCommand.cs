namespace DesignPatterns.Behavioural.Command
{
    using DesignPatterns.Behavioural.Command.Receivers;

    /// <summary>
    /// The command for turning a light off. Ideally, commands should be "dumb" and should just be responsible for executing a command on a receiver.
    /// </summary>
    /// <seealso cref="DesignPatterns.Behavioural.Command.ICommand" />
    public class LightOffCommand : ICommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            this.light.Off();
        }

        public void Undo()
        {
            this.light.On();
        }
    }
}
