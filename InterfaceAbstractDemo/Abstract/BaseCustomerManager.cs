using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //her iki kahve türündeki yapılan alışverişler "aynı" veritabanına kaydedilecek , abstract görevi gerekiyor.
    // Kod Implementasyonu yapılacak, overriding.
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db "+customer.FirstName);
        }
    }
}
