namespace DesignPatterns.Behavioural.Command
{
    using DesignPatterns.Behavioural.Command.Receivers;

    public class MuteStereoCommand : ICommand
    {
        readonly Stereo stereo;

        public MuteStereoCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.SetVolume(0);
        }

        public void Undo()
        {
            this.stereo.SetVolume(10);
        }
    }
}
