using System;
using System.Collections.Generic;
using System.Text;

namespace ReferencesTypesDemo
{
    class PersonManager
    {
        public void Add(Person person) // base class değişkeni verildi , her class değişkenini kabul eder.
        {
            Console.WriteLine("Eklendi:"+person.FirstName);
        }
    }
}
