using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici yemek yiyebilir");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yönetici maaş alabilir");
        }

        public void Work()
        {
            Console.WriteLine("Yönetici çalışabilir");
        }
    }
}
