using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Her iki veritabanına kaydedilme senaryosu
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new SqlServerCustomerDal()
            };

            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }

            //InterfacesIntro();
            //Demo2();


            // CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());
        }

        private static void Demo2()
        {
            ICustomerDal customerDal = new OracleCustomerDal();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customerDal);
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer(1, "Engin", "Demiroğ", "Ankara");
            Student student = new Student(2, "Haçik", "Ulu", "Bilgisayar Mühendisliği");


            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(student);
            //personManager.Add(new Worker(3, "Murat", "Gözüpek", 12000));
        }
    }
}
