using _3_Iterator.Aggregates;

namespace _3_Iterator.Iterators
{
    public class OddAsciiOnlyListIterator : ConcreteListForwardIterator<char>
    {
        public OddAsciiOnlyListIterator(ConcreteListAggregate<char> list) : base(list)
        {
            index = 0;
        }

        public new char? First()
        {
            for (int i = 0; i < aggregate.Count(); ++i)
            {
                if (aggregate.At(i) % 2 == 1)
                {
                    return aggregate.At(i);
                }
            }

            return null;
        }

        public new void Next()
        {
            ++index;
            if (IsDone())
            {
                return;
            }

            if (aggregate.At(index) % 2 == 0)
            {
                Next();
            }
        }
    }
}