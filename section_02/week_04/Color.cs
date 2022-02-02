namespace _4_Prototype
{
    public class Color : Prototype
    {
        public int r;
        public int g;
        public int b;
        public Prototype Clone()
        {
            Color c = new Color();

            c.r = r;
            c.g = g;
            c.b = b;

            return c;
        }
    }
}