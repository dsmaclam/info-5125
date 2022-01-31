using System;
using _3_Iterator.Aggregates;

namespace _3_Iterator.Iterators
{
    public class ConcreteListReverseIterator<T> : IIterator<T>
    {
        protected ConcreteListAggregate<T> aggregate;
        protected int index;

        public ConcreteListReverseIterator(ConcreteListAggregate<T> list)
        {
            aggregate = list;
            index = list.Count() - 1;
        }

        public T First()
        {
            if (aggregate.Count() == 0)
            {
                throw new Exception("index out of bounds. list is empty");
            }

            return aggregate.At(aggregate.Count() - 1);
        }

        public void Next()
        {
            --index;
        }

        public T CurrentItem()
        {
            if (aggregate.Count() == 0)
            {
                throw new Exception("index out of bounds. list is empty");
            }

            if (index >= aggregate.Count() || index < 0)
            {
                throw new Exception("index out of bounds.");
            }

            return aggregate.At(index);
        }

        public bool IsDone()
        {
            return index < 0;
        }
    }
}