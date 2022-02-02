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

            User b = (User)red.Clone();
            b.FirstName = "Bob";
            b.Rank = "Customer";

            alice.Print();
            b.Print();
        }
    }
}
