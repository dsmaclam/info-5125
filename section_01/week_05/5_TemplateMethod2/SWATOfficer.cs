using System;

namespace _5_TemplateMethod2
{
    public class SWATOfficer : PoliceOfficer
    {
        public override string GetWorkerType()
        {
            return "SWAT Officer";
        }

        protected override void WorkAfternoon()
        {
            Console.WriteLine("conducting police raids...");
        }
    }
}