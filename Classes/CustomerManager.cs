using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class CustomerManager
    {
        public void ListCustomer(List<Customer> customers)
        {
            foreach (Customer customer in customers) 
            {
                Console.WriteLine("Müşteri Id:" + customer.Id);
                Console.WriteLine("Müşteri Adı:"+customer.FirstName);
                Console.WriteLine("Müşteri Soyadı:"+customer.LastName);
                Console.WriteLine("Müşteri Adresi:"+customer.City);
                Console.WriteLine("");
            }
        }
    }
}
