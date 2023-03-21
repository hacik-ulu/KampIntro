using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("İşçi yemek yiyebilir");
        }

        public void GetSalary()
        {
            Console.WriteLine("İşçi maaş alabilir");
        }

        public void Work()
        {
            Console.WriteLine("İşçi çalışabilir");
        }
    }
}
