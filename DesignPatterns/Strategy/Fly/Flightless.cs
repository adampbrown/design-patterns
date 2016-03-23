namespace DesignPatterns.Strategy.Fly
{
    public class Flightless : IFlyBehaviour
    {
        public string Fly()
        {
            return "I can't fly..";
        }
    }
}
