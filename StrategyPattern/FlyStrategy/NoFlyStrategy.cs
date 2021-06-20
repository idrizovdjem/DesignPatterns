namespace StrategyPattern.FlyStrategy
{
    public class NoFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "No fly strategy";
        }
    }
}