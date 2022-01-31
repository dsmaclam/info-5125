using _3_Iterator.Aggregates;

namespace _3_Iterator.Iterators
{
    public class CreateEverySecondItemListIterator<T> : IIterator<T>
    {
        protected ConcreteListAggregate<T> aggregate;
        protected int index;

        public CreateEverySecondItemListIterator(ConcreteListAggregate<T> list)
        {
            aggregate = list;
            index = 0;
        }
        public T First()
        {
            return aggregate.At(0);
        }

        public void Next()
        {
            index += 2;
        }

        public T CurrentItem()
        {
            return aggregate.At(index);
        }

        public bool IsDone()
        {
            return index >= aggregate.Count();
        }
    }
}