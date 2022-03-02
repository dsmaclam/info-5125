namespace Proxy_Pattern_Protection
{
    public class User
    {
        public enum Roles
        {
            Customer,
            Employee
        }

        public string Name { get; set; }
        public Roles Role { get; set; }

        public User(string name, Roles role)
        {
            Name = name;
            Role = role;
        }
    }
}