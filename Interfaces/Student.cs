using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //Somut Nesne
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentDepartment { get; set; }

        public Student(int ıd, string firstName, string lastName, string studentDepartment)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            StudentDepartment = studentDepartment;
        }
    }
}
