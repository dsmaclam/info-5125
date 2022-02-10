using System;

namespace _5_TemplateMethod2
{
    public abstract class Worker
    {
        public abstract string GetWorkerType();

        //this is the template method
        public void DailyRoutine()
        {
            //steps to go here
            WakeUp();
            EatBreakfast();
            WorkMorning();
            EatLunch();
            WorkAfternoon();
            Relax();
            Sleep();
        }

        protected virtual void WakeUp()
        {
            Console.WriteLine("Crawl out of bed...");
        }

        protected virtual void EatBreakfast()
        {
            Console.WriteLine("Eat breakfast...nom..nom");
        }

        protected virtual void WorkMorning()
        {
            Console.WriteLine("Looking for a job...");
        }

        protected virtual void EatLunch()
        {
            Console.WriteLine("Eat lunch...nom..nom");
        }

        protected virtual void WorkAfternoon()
        {
            WorkMorning();
        }

        protected virtual void Relax()
        {
            Console.WriteLine("Relaxing watching TV.");
        }

        protected virtual void Sleep()
        {
            Console.WriteLine("Sleeping...zzz");
        }

    }
}