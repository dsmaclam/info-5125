using System.Collections.Generic;

namespace _2_Strategy.StrategyFlyweights
{
    public class IterateStrategy : IStrategy
    {
        public int Count(List<int> input)
        {
            int count = 0;
            foreach (int i in input)
            {
                count += i;
            }

            return count;
        }
    }
}