using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }
        public string LastName { get; set; }
        public string City { get; set; }

        public Customer(int Id, string FirstName, string LastName, string City)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.City = City;
        }
    }
}
