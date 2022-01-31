using System;
using _3_Iterator.Aggregates;

namespace _3_Iterator.Iterators
{
    public class ConcreteDictionaryForwardIterator<TKey, TValue> : IIterator<TValue>
    {
        protected ConcreteDictionaryAggregate<TKey, TValue> aggregate;
        protected int index;

        public ConcreteDictionaryForwardIterator(ConcreteDictionaryAggregate<TKey, TValue> dictionary)
        {
            aggregate = dictionary;
            index = 0;
        }

        public TValue First()
        {
            return aggregate.At(0);
        }

        public void Next()
        {
            ++index;
        }

        public TValue CurrentItem()
        {
            return aggregate.At(index);
        }

        public bool IsDone()
        {
            return index >= aggregate.Count();
        }
    }

}