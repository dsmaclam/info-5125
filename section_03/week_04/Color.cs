namespace _4_Prototype
{
    public class Color : Prototype
    {
        public float r;
        public float g;
        public float b;
        public float a;

        public Prototype Clone()
        {
            Color c = new Color();
            
            c.r = r;
            c.g = g;
            c.b = b;
            c.a = a;

            return c;
        }
    }
}