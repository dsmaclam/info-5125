using System;
using System.Collections.Generic;
using System.Text;

namespace _11_MVC
{
    internal class View
    {
        public void Print(string id, string name)
        {
            Console.WriteLine("Student:");
            Console.WriteLine("\tID: " + id);
            Console.WriteLine("\tName: " + name);
        }
    }
}
