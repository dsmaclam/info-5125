using System.Collections.Generic;

namespace _2_Strategy.StrategyFlyweights
{
    public class FirstThreeStrategy : IStrategy
    {
        public int Count(List<int> input)
        {
            int count = 0;
            for (int i = 0; i < 3 && i<input.Count; ++i)
            {
                count += input[i];
            }

            return count;
        }
    }
}