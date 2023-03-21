using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1, "Engin", "Demiroğ", "Ankara");
            Customer customer2 = new Customer(2, "Haçik", "Ulu", "İstanbul");

            //Müşterilerin Liste Yöntemiyle saklanması

            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);

            CustomerManager customerManager = new CustomerManager();
            customerManager.ListCustomer(customers);



        }
    }
}
