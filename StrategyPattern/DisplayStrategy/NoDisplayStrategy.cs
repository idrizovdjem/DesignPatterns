namespace StrategyPattern.DisplayStrategy
{
    public class NoDisplayStrategy : IDisplayStrategy
    {
        public string Display()
        {
            return "No display strategy";
        }
    }
}