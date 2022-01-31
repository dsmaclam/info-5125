using System;
using _3_Iterator.Aggregates;

namespace _3_Iterator.Iterators
{
    public class ConcreteListForwardIterator<T> : IIterator<T>
    {
        protected ConcreteListAggregate<T> aggregate;
        protected int index;

        public ConcreteListForwardIterator(ConcreteListAggregate<T> list)
        {
            aggregate = list;
            index = 0;
        }

        public T First()
        {
            if (aggregate.Count() == 0)
            {
                throw new Exception("Index out of bounds. list is empty");
            }

            return aggregate.At(0);
        }

        public void Next()
        {
            ++index;
        }

        public T CurrentItem()
        {
            if (index >= aggregate.Count())
            {
                throw new Exception("Index out of bounds. >= count");
            }
            return aggregate.At(index);
        }

        public bool IsDone()
        {
            return index >= aggregate.Count();
        }
    }
}