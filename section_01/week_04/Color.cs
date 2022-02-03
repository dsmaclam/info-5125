namespace _4_Prototype
{
    public class Color : IPrototype
    {
        public int r;
        public int g;
        public int b;
        public IPrototype Clone()
        {
            Color c = new Color();
            c.r = r;
            c.g = g;
            c.b = b;

            return c;
        }
    }
}