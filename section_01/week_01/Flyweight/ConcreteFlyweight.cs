using System;

namespace Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public string instrinsic_state;

        public ConcreteFlyweight(string value)
        {
            instrinsic_state = value;
        }

        public void Print(bool bold)
        {
            Console.WriteLine((bold ? "[BOLD] " : "") + instrinsic_state);
        }
    }
}