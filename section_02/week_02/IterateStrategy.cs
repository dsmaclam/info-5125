using System.Collections.Generic;

namespace _2_Strategy
{
    public class IterateStrategy : IStrategy
    {
        public int Count(List<int> input)
        {
            int accumulator = 0;
            foreach (int i in input)
            {
                accumulator += i;
            }

            return accumulator;
        }
    }
}