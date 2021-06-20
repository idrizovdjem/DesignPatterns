namespace StrategyPattern.QuackStrategy
{
    public class NoQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "No quack strategy";
        }
    }
}