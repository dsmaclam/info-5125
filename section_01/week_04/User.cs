using System;

namespace _4_Prototype
{
    public class User : IPrototype
    {
        public string FirstName;
        public string LastName;
        public string Rank;

        public void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - " + Rank);
        }

        public IPrototype Clone()
        {
            User u = new User();

            u.FirstName = FirstName;
            u.LastName = LastName;
            u.Rank = Rank;

            return u;
        }
    }
}