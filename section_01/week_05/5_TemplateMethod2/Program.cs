using System;
using System.Collections.Generic;

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
                new FireFighter(), 
                new Teacher(),
                new PoliceOfficer(),
                new SWATOfficer()
            };

            /*
             *  Create a concrete police officer class
             *  have them eat a doughnut for breakfast
             *  have them arrest criminals for work
             *
             *  Then create a swat officer concrete class
             *  derived from your police officer class
             *
             *  have them conduct police raids in the afternoon
             *
             *  BREAK until 12:00
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
