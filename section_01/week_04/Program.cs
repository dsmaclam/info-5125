using System;

namespace _4_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color();
            red.r = 255;

            Color blue = (Color)red.Clone();
            //change values of the clone as needed

            User alice = new User();
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            alice.Rank = "Employee";
            alice.Print();

            var bob = (User)alice.Clone();
            bob.FirstName = "Bob";
            bob.Rank = "Customer";
            
            bob.Print();
        }
    }
}
