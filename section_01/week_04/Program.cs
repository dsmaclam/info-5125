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
            

            var b = (User)alice.Clone();
            b.FirstName = "Bob";
            b.Rank = "Customer";
            
            alice.Print();
            b.Print();
        }
    }
}
