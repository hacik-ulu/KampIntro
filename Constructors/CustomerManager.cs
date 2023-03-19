using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class CustomerManager
    {
        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("Müşteri Bilgileri");
            Console.WriteLine();
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Id:" + customer.Id);
                Console.WriteLine("Müşteri Adı:" + customer.FirstName);
                Console.WriteLine("Müşteri Soyadı:" + customer.LastName);
                Console.WriteLine("Müşteri Adresi:" + customer.City);
                Console.WriteLine();
            }
        }
    }
}
