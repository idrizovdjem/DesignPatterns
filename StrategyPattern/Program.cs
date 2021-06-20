using System;
using StrategyPattern.DisplayStrategy;
using StrategyPattern.FlyStrategy;
using StrategyPattern.QuackStrategy;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var regularDuck = new Duck(new SimpleQuackStrategy(), new SimpleFlyStrategy(), new SimpleDisplayStrategy());
            var rubberDuck = new Duck(new NoQuackStrategy(), new NoFlyStrategy(), new NoDisplayStrategy());

            Console.WriteLine("Regular duck:");
            Console.WriteLine(regularDuck.Quack());
            Console.WriteLine(regularDuck.Fly());
            Console.WriteLine(regularDuck.Display());

            Console.WriteLine("Rubber duck:");
            Console.WriteLine(rubberDuck.Quack());
            Console.WriteLine(rubberDuck.Fly());
            Console.WriteLine(rubberDuck.Display());
        }
    }
}
