namespace _3_Iterator.Iterators
{
    public interface IIterator<out T>
    {
        T First();
        void Next();
        T CurrentItem();
        bool IsDone();

    }
}