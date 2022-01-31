using System;
using System.Collections.Generic;

namespace _2_Strategy
{
    public class StrategyFlyweightFactory
    {
        protected Dictionary<StrategyType, IStrategy> strategies 
            = new Dictionary<StrategyType, IStrategy>();

        public enum StrategyType
        {
            Iterate,
            FirstThree,
            Random
        }

        public IStrategy GetStrategy(StrategyType key)
        {
            if (strategies.ContainsKey(key))
            {
                return strategies[key];
            }

            IStrategy strategy = null;
            switch (key)
            {
                case StrategyType.Iterate:
                    strategy = new IterateStrategy();
                    break;
                case StrategyType.FirstThree:
                    strategy = new FirstThreeStrategy();
                    break;
                case StrategyType.Random:
                    strategy = new RandomStrategy(1,9001);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(key), key, 
                        "unknown strategy type");
            }
            
            strategies.Add(key, strategy);

            return strategy;
        }
    }
}