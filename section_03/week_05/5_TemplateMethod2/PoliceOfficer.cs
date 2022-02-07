using System;

namespace _5_TemplateMethod2
{
    public class PoliceOfficer : Worker
    {
        public override string GetWorkerType()
        {
            return "Police Officer";
        }

        protected override void WorkMorning()
        {
            Console.WriteLine("Arresting criminals...");
        }

        protected override void EatBreakfast()
        {
            Console.WriteLine("Have a doughnut!");
        }
    }
}