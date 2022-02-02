using System;

namespace _4_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Hello World!";
            String copy = (String)str.Clone();

            Color red = new Color();
            red.r = 255;

            User alice = new User();
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            alice.Rank = "Employee";

            User bob = (User)red.Clone();
            bob.FirstName = "Bob";

            alice.Print();
            bob.Print();
        }
    }
}
