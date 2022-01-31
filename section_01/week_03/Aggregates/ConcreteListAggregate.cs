using System.Collections.Generic;
using _3_Iterator.Iterators;

namespace _3_Iterator.Aggregates
{
    public class ConcreteListAggregate<T> : IAggregate<T>
    {
        protected List<T> container = new List<T>();

        public IIterator<T> CreateIterator()
        {
            return new ConcreteListForwardIterator<T>(this);
        }

        public IIterator<T> CreateReverseIterator()
        {
            return new ConcreteListReverseIterator<T>(this);
        }

        public IIterator<T> CreateEverySecondItemListIterator()
        {
            return new CreateEverySecondItemListIterator<T>(this);
        }

        public void Add(T item)
        {
            container.Add(item);
        }

        public T At(int index)
        {
            return container[index];
        }

        public int Count()
        {
            return container.Count;
        }
    }
}