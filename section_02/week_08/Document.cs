using System;

namespace _7_Command
{
    public class Document
    {
        private string path;

        public void Open(string filepath)
        {
            Console.WriteLine("Opened document " + filepath);
            path = filepath;
        }

        public void Print()
        {
            Console.WriteLine("Printing " + path);
        }
    }
}