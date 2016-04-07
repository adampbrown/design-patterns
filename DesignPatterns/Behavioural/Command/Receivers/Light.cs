using System;

namespace DesignPatterns.Behavioural.Command.Receivers
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Switching light on.");
        }

        public void Off()
        {
            Console.WriteLine("Switching light off.");
        }
    }
}
