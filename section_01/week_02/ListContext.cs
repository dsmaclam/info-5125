using System.Collections.Generic;

namespace _2_Strategy
{
    public class ListContext
    {
        private IStrategy strategy;
        private List<int> data;

        public ListContext(List<int> dt, IStrategy strat)
        {
            data = dt;
            strategy = strat;
        }

        public int Count()
        {
            return strategy.Count(data);
        }
    }
}