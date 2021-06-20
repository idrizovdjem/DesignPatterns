namespace StrategyPattern.QuackStrategy
{
    public class SimpleQuackStrategy : IQuackStrategy
    {
        public string Quack()
        {
            return "Simple quack strategy";
        }
    }
}