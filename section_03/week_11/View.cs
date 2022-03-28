using System;
using System.Collections.Generic;
using System.Text;

namespace _11_MVC
{
    internal class View
    {
        public void Print(string name, string id)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine("\tName: " + name);
            Console.WriteLine("\tID: " + id);
        }
    }
}
