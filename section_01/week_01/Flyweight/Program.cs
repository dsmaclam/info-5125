using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();

            Flyweight a = factory.GetFlyweight("a");
            a.Print(true);

            Flyweight b = factory.GetFlyweight("b");
            b.Print(false);

            Flyweight c = factory.GetFlyweight("a"); // it's the same letter
            c.Print(false);

            (c as ConcreteFlyweight).instrinsic_state = "new state";
            a.Print(true);
            b.Print(true);
            c.Print(false);

            Flyweight d = factory.GetFlyweight("a");

            //unshared (not created through the factory)
            Flyweight e = new ConcreteFlyweight("a");
            Flyweight f = new ConcreteFlyweight("a");

            (f as ConcreteFlyweight).instrinsic_state = "something else";

            e.Print(false);
            f.Print(false);

        }
    }
}
