using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{

    class Customer
    {
        //default Constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }

        // Parametreli Constructor
        public Customer(string id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }


}
