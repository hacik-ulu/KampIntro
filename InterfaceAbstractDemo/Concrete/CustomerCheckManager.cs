using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        //Starbucksa bağlı olmadan mernis kontrolü.
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
