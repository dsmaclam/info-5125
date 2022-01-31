using System;
using System.Collections.Generic;

namespace _4_Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a built in clone / prototype method on the C# string class
            String s = "Hello World!";
            String str = (String)s.Clone();

            //we can have many type of prototypes in a single project
            Color red = new Color();
            red.r = 1.0f;
            red.a = 1.0f;

            //this is our user prototype that we will copy
            User alice = new User();
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            alice.Rank = "Employee";

            //(must be a User object)
            User bobb = (User)alice.Clone();
            bobb.FirstName = "Bob";
            bobb.Rank = "Customer";

            //'as' cast (can result in a null reference)
            //User sally = red.Clone() as User; // this is the wrong type of object
            User sally = bobb.Clone() as User;
            sally.FirstName = "Sally";

            alice.Print();
            bobb.Print();
            sally.Print();
        }
    }
}
