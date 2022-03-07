using System;

namespace _7_Command
{
    public class Document
    {
        public void Open(string filePath)
        {
            Console.WriteLine("Opening file " + filePath);
        }
    }
}