using _3_Iterator.Iterators;

namespace _3_Iterator.Aggregates
{
    public interface IAggregate<out T>
    {
       
        IIterator<T> CreateIterator();

        IIterator<T> CreateReverseIterator();
    }
}