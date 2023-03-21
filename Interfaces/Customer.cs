using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Somut Nesne
    class Customer : IPerson
    {
        public Customer(int Id,string FirstName,string LastName,string CustomerAdress)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CustomerAdress = CustomerAdress;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerAdress { get; set; }


    }
}
