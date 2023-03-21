using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        /*public Worker(int ıd, string firstName, string lastName, double salary)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }*/
    }
}
