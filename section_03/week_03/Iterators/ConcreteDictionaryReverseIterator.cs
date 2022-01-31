using _3_Iterator.Aggregates;

namespace _3_Iterator.Iterators
{
    public class ConcreteDictionaryReverseIterator<TKey, TValue> : IIterator<TValue>
    {
        protected ConcreteDictionaryAggregate<TKey, TValue> aggregate;
        protected int index;

        public ConcreteDictionaryReverseIterator(ConcreteDictionaryAggregate<TKey, TValue> dictionary)
        {
            aggregate = dictionary;
            index = aggregate.Count() - 1;
        }

        public TValue First()
        {
            return aggregate.At(aggregate.Count() - 1);
        }

        public void Next()
        {
            --index;
        }

        public TValue CurrentItem()
        {
            return aggregate.At(index);
        }

        public bool IsDone()
        {
            return index < 0;
        }
    }
}