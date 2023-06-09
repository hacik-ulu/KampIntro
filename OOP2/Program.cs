﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "4567";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.İdentityNumber = "123456789";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "7894";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "123456798";

            //Müşteri classı her ikisinin de referans numarasını tutar.

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
