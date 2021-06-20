using StrategyPattern.DisplayStrategy;
using StrategyPattern.FlyStrategy;
using StrategyPattern.QuackStrategy;

namespace StrategyPattern
{
    public class Duck
    {
        private readonly IQuackStrategy quackStrategy;
        private readonly IFlyStrategy flyStrategy;
        private readonly IDisplayStrategy displayStrategy;

        public Duck(
            IQuackStrategy quackStrategy,
            IFlyStrategy flyStrategy,
            IDisplayStrategy displayStrategy)
        {
            this.quackStrategy = quackStrategy;
            this.flyStrategy = flyStrategy;
            this.displayStrategy = displayStrategy;   
        }

        public string Quack() => this.quackStrategy.Quack();

        public string Fly() => this.flyStrategy.Fly();

        public string Display() => this.displayStrategy.Display();
    }
}