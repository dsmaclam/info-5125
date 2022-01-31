using System.Collections.Generic;

namespace _2_Strategy.StrategyFlyweights
{
    public interface IStrategy
    {
        public int Count(List<int> input);
    }
}