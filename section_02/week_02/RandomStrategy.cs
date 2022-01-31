using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _2_Strategy
{
    public class RandomStrategy : IStrategy
    {
        protected int min;
        protected int max;

        public RandomStrategy(int mn, int mx)
        {
            min = mn;
            max = mx;
        }

        /*
        * 1. generate a random number between a min and max value
         *      min must be < max
         *      min and max can be any positive integer
         * 2. using that random value, generate a valid index within the list
         * 3. return the value at that index 
         *
         * take-up @ 12:35
        */
        public int Count(List<int> input)
        {
            if (input.Count == 0)
            {
                return 0;
            }

            int random_num = new Random().Next(min, max);
            int index = random_num % input.Count;

            return input[index];
        }
    }
}