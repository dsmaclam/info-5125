using System;

namespace _5_TemplateMethod2
{
    public class Teacher : Worker
    {
        public override string GetWorkerType()
        {
            return "Teacher";
        }

        protected override void WorkMorning()
        {
            Console.WriteLine("Teaching a class...");
        }

        protected override void WorkAfternoon()
        {
            Relax();
        }
    }
}