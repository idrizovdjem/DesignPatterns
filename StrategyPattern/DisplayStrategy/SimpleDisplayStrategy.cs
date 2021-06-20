namespace StrategyPattern.DisplayStrategy
{
    public class SimpleDisplayStrategy : IDisplayStrategy
    {
        public string Display()
        {
            return "Simple display";
        }
    }
}