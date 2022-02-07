using System;

namespace _5_TemplateMethod2
{
    public abstract class Worker
    {
        public abstract string GetWorkerType();

        public void DailyRoutine()
        {
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
            Console.WriteLine("Eating breakfast... nom nom nom...");
        }

        protected virtual void WorkMorning()
        {
            Console.WriteLine("I don't have a job!");
        }

        protected virtual void EatLunch()
        {
            Console.WriteLine("Eating lunch... nom nom nom...");
        }

        protected virtual void WorkAfternoon()
        {
            WorkMorning();
        }

        protected virtual void Relax()
        {
            Console.WriteLine("Relaxing...watching TV");
        }

        protected virtual void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}