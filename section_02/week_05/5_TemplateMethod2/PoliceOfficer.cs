using System;

namespace _5_TemplateMethod2
{
    public class PoliceOfficer : Worker
    {
        public override string GetWorkerType()
        {
            return "Police Officer";
        }

        protected override void EatBreakfast()
        {
            Console.WriteLine("eat a doughnut...");
        }

        protected override void WorkMorning()
        {
            Console.WriteLine("Arrest some criminals.");
        }
    }
}