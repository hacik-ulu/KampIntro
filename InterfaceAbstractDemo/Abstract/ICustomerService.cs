using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    //operasyonlar tutulur.
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
