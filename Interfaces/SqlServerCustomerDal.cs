using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql servera eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Sql serverdan silindi");
        }

        public void Update()
        {
            Console.WriteLine("Sql ile Güncellendi!");
        }
    }
}
