using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _5_TemplateMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            //all worker have the same daily routine
            //that will be implemented by using a template method
            var workers = new List<Worker>
            {
                new Firefighter(), 
                new Teacher(),
                new PoliceOfficer(),
                new SWATOfficer()
            };

            /*
             *  Create a police officer
             *  Have them arrest criminals for work in the morning and afternoon
             *  For breakfast they will eat doughnut.
             *
             *  BREAK UNTIL 12:00PM
             *
             */

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.GetWorkerType() + ":");

                //call the template method on the worker
                worker.DailyRoutine();

                Console.WriteLine();
            }
        }
    }
}
