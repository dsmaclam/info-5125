using System.Collections.Generic;

namespace _2_Strategy
{
    public class FirstThreeStrategy : IStrategy
    {
        public int Count(List<int> input)
        {
            int accumulator = 0;
            for (int i = 0; i < 3 && i < input.Count; ++i)
            {
                accumulator += input[i];
            }

            return accumulator;
        }
    }
}