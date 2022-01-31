using System.Collections.Generic;
using System.Linq;
using _3_Iterator.Iterators;

namespace _3_Iterator.Aggregates
{
    public class ConcreteDictionaryAggregate<TKey, TValue> : IAggregate<TValue>
    {
        protected Dictionary<TKey, TValue> container = new Dictionary<TKey, TValue>();


        public IIterator<TValue> CreateIterator()
        {
            return new ConcreteDictionaryForwardIterator<TKey, TValue>(this);
        }

        public IIterator<TValue> CreateReverseIterator()
        {
            return new ConcreteDictionaryReverseIterator<TKey, TValue>(this);
        }

        public void Add(TKey key, TValue value)
        {
            container.Add(key, value);
        }

        public TValue At(int index)
        {
            return container.ElementAt(index).Value;
        }

        public int Count()
        {
            return container.Count;
        }
    }
}