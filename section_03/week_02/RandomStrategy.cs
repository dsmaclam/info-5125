using System;
using System.Collections.Generic;
using _2_Strategy.StrategyFlyweights;

namespace _2_Strategy
{
    public class RandomStrategy : IStrategy
    {
        private int min;
        private int max;

        public RandomStrategy(int mn, int mx)
        {
            min = mn;
            max = mx;
        }

        public int Count(List<int> input)
        {
            if (input.Count == 0)
            {
                return 0;
            }

            int number = new Random().Next(min, max);
            int index = number % input.Count;

            return input[index];
        }
    }
}