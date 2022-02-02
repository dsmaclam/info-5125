using System;

namespace _4_Prototype
{
    public class User : Prototype
    {
        public string FirstName;
        public string LastName;
        public string Rank;
        public Prototype Clone()
        {
            User new_user = new User();

            new_user.FirstName = FirstName;
            new_user.LastName = LastName;
            new_user.Rank = Rank;

            return new_user;
        }

        public void Print()
        {
            Console.WriteLine(FirstName + " " + LastName + " - " + Rank);
        }
    }
}