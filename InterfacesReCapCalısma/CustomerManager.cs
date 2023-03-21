using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesReCapCalısma
{
    class CustomerManager : IPersonManager
    {
        // müşteri ekleme kodları
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
}
