using System;

namespace _5_TemplateMethod2
{
    public class FireFighter : Worker
    {
        public override string GetWorkerType()
        {
            return "Fire Fighter";
        }

        protected override void WorkMorning()
        {
            Console.WriteLine("Putting out fires...");
        }

        protected override void WorkAfternoon()
        {
            Console.WriteLine("And Saving cats from trees...");
        }

        protected override void Relax()
        {
            Console.WriteLine("Relaxing in the firehouse lounge...");
        }
    }
}