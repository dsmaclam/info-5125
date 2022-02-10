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
                //new Firefighter(), 
                //new Teacher(),
                //new Police_Officer(),
                //new SWATOfficer()
            };

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
