using System.Collections.Generic;

namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweight_pool;

        public FlyweightFactory()
        {
            flyweight_pool = new Dictionary<string, Flyweight>();
        }

        public Flyweight GetFlyweight(string key)
        {
            if (flyweight_pool.ContainsKey(key))
            {
                return flyweight_pool[key];
            }

            Flyweight flyweight = new ConcreteFlyweight(key);
            flyweight_pool.Add(key, flyweight);

            return flyweight;
        }
    }
}