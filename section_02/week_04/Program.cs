using System;

namespace _4_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            User alice = new User();
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            alice.Rank = "Employee";

            User bob = alice.Clone() as User;
            bob.FirstName = "Bob";

            alice.Print();
            bob.Print();
        }
    }
}
