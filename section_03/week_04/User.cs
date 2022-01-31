using System;

namespace _4_Prototype
{
    public class User : Prototype
    {
        public string FirstName;
        public string LastName;
        public string Rank;

        public void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - " + Rank);
        }

        public Prototype Clone()
        {
            User new_instance = new User();

            new_instance.FirstName = FirstName;
            new_instance.LastName = LastName;
            new_instance.Rank = Rank;

            return new_instance;
        }
    }
}