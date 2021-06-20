namespace StrategyPattern.FlyStrategy
{
    public class SimpleFlyStrategy : IFlyStrategy
    {
        public string Fly()
        {
            return "Simple fly strategy!";
        }
    }
}