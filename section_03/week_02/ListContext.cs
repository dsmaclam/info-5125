using System.Collections.Generic;
using _2_Strategy.StrategyFlyweights;

namespace _2_Strategy
{
    public class ListContext
    {
        private IStrategy strategy;
        private List<int> data;

        public ListContext(IStrategy strat, List<int> input)
        {
            strategy = strat;
            data = input;
        }

        public int Count()
        {
            return strategy.Count(data);
        }
    }
}