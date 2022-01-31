using System;
using System.Collections.Generic;

namespace _2_Strategy.StrategyFlyweights
{
    public class StrategyFlyweightFactory
    {
        protected Dictionary<StrategyType, IStrategy> strategies;

        public StrategyFlyweightFactory()
        {
            strategies = new Dictionary<StrategyType, IStrategy>();
        }

        public enum StrategyType
        {
            Iterate,
            FirstThree,
            Random
        }

        public IStrategy GetStrategy(StrategyType type)
        {
            IStrategy strategy = null;

            if (strategies.ContainsKey(type))
            {
                strategy = strategies[type];
            }
            else
            {
                switch (type)
                {
                    case StrategyType.Iterate:
                        strategy = new IterateStrategy();
                        break;

                    case StrategyType.FirstThree:
                        strategy = new FirstThreeStrategy();
                        break;

                    case StrategyType.Random:
                        strategy = new RandomStrategy(0, 1000);
                        break;

                    default:
                        throw new ArgumentException("Cannot create strategy type");
                }

                strategies.Add(type, strategy);
            }

            return strategy;
        }
    }
}