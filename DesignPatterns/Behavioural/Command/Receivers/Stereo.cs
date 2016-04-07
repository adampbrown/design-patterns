using System;

namespace DesignPatterns.Behavioural.Command.Receivers
{
    public class Stereo
    {
        public void SetVolume(int volume)
        {
            Console.WriteLine("Setting volume to {0}.", volume);
        }

        public void OpenTray()
        {
            Console.WriteLine("Opening CD tray...");
        }
    }
}
