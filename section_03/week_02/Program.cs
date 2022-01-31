using System;
using System.Collections.Generic;
using _2_Strategy.StrategyFlyweights;

namespace _2_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program gets the sum of the elements of a list of numbers

            List<int> input = new List<int>();
            input.Add(34);
            input.Add(55);
            input.Add(1);
            input.Add(22);
            input.Add(2);
            input.Add(50);

            //lets build on what we learned last week and
            //use the flyweight pattern for our strategies
            StrategyFlyweightFactory strategyFactory = new StrategyFlyweightFactory();
            //IStrategy strat = strategyFactory.GetStrategy(StrategyFlyweightFactory.StrategyType.Iterate);
            //IStrategy strat = strategyFactory.GetStrategy(StrategyFlyweightFactory.StrategyType.FirstThree);
            IStrategy strat = strategyFactory.GetStrategy(StrategyFlyweightFactory.StrategyType.Random);

            // ListContext could just be the client program
            // In the text/slides, Context just indicates something that stores a strategy instance
            ListContext context = new ListContext(strat, input);
            Console.WriteLine("Count is " + context.Count());
        }
    }
}
