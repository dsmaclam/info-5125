using System;

namespace _5_TemplateMethod2
{
    public class Firefighter : Worker
    {
        public override string GetWorkerType()
        {
            return "Firefighter";
        }

        protected override void WorkMorning()
        {
            Console.WriteLine("Putting out fires...");
        }

        protected override void WorkAfternoon()
        {
            Console.WriteLine("Saving cats from trees.");
        }

        protected override void Relax()
        {
            Console.WriteLine("Hanging out in the firehouse lounge...");
            base.Relax();
        }
    }
}