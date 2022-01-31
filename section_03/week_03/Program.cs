using System;
using System.Collections.Generic;
using _3_Iterator.Aggregates;
using _3_Iterator.Iterators;

namespace _3_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * THE PROBLEM
             */

            //we will create 2 aggregate containers that have differing interfaces
            List<char> asciiCodes = new List<char>();
            Dictionary<int, char> asciiCodes2 = new Dictionary<int, char>();
            
            //load the lists and dictionary with the alphabet
            for (int i = 65; i < 91; ++i)
            {
                asciiCodes.Add((char)i);
                asciiCodes2.Add(i, (char)i);
            }

            //we cannot interchange the containers
            //in the for loop below as the interfaces are different on the List<T> vs Dictionary<T,U>
            //for (int i = 0; i < asciiCodes.Count; ++i)
            for (int i = 0; i < asciiCodes2.Count; ++i)
            {
                //Console.Write(asciiCodes[i] + ", ");
                //Console.Write(asciiCodes2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /*
             * LETS SOLVE THIS PROBLEM USING THE ITERATOR PATTERN
             */

            ConcreteListAggregate<char> listAggregate = new ConcreteListAggregate<char>();
            ConcreteDictionaryAggregate<int, char> dictionaryAggregate = new ConcreteDictionaryAggregate<int, char>();

            //load the lists and dictionary aggregates with the alphabet
            for (int i = 65; i < 91; ++i)
            {
                listAggregate.Add((char)i);
                dictionaryAggregate.Add(i, (char)i);
            }

            Console.WriteLine("Forward:");
            //for (IIterator<char> i = listAggregate.CreateIterator(); !i.IsDone(); i.Next())
            for (IIterator<char> i = dictionaryAggregate.CreateIterator(); !i.IsDone(); i.Next())
            {
                Console.Write(i.CurrentItem());
            }
            Console.WriteLine();

            Console.WriteLine("\nReverse:");
            //for (IIterator<char> i = listAggregate.CreateReverseIterator(); !i.IsDone(); i.Next())
            for (IIterator<char> i = dictionaryAggregate.CreateReverseIterator(); !i.IsDone(); i.Next())
            {
                Console.Write(i.CurrentItem());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /*
             * WHAT ELSE CAN WE DO WITH ITERATORS???
             */

            //lets print every second character
            for (IIterator<char> i = listAggregate.CreateEverySecondItemListIterator(); !i.IsDone(); i.Next())
            {
                Console.Write(i.CurrentItem());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //we can also specialize iterators
            //we will just 'new' our specialized iterator,
            //but normally this would be a function on the aggregate

            /*
             * BREAK UNTIL 1:00PM
             */

            int j = 0;
            OddAsciiOnlyListIterator specializedIterator = new OddAsciiOnlyListIterator(listAggregate);
            while (!specializedIterator.IsDone())
            {
                ++j;
                Console.Write(specializedIterator.CurrentItem());

                if (j % 2 == 0)
                {
                    specializedIterator.Next();
                }
                    
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
