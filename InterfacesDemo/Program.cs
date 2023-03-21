using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IWorker worker = new Worker();
            IWorker manager = new Manager();
            IWorker robot = new Robot();
            */

            IWorker[] workers = new IWorker[] { new Manager(), new Worker(), new Robot() };

            foreach (IWorker worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[] { new Manager(), new Worker() };

            foreach (IEat eat in eats)
            {
                eat.Eat();
            }
        }
    }
}
