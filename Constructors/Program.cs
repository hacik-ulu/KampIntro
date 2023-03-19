using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // default const.
            Customer customer2 = new Customer() { Id = "1", FirstName = "Murat", LastName = "Aydın", City = "Ankara" };

            // parametreli const.
            Customer customer1 = new Customer("1", "Haçik", "Ulu", "İstanbul");

            Customer[] customers = new Customer[] { customer1, customer2 };

            //müşterilerin listelenmesi
            CustomerManager customerManager = new CustomerManager();
            customerManager.ListCustomer(customers);







        }
    }
}
