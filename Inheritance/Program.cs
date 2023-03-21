using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[] { new Person { FirstName = "Haçik" },
                new Customer { FirstName = "Murat" },
                new Student { FirstName = "Salih" } };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
