using System;

namespace ReferencesTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";

            //Console.WriteLine("Personel2 ismi:" + person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = customer;
            customer.FirstName = "Ahmet";

            //Boxing Yöntemi
            // person3'ün Customer'ın özelliği olan "CreditCardNumber" propunu kullanıyoruz.
            //Console.WriteLine(((Customer)person3).CreditCardNumber);
            //Console.WriteLine(person3.); --> person3'de CreditCardNumber özelliği yok bunu Customerdan alıyoruz.
            //base class ->Person

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(employee);
        }
    }
}
