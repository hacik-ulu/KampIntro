using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL ile veritabanına eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL ile veritabanından silindi");
        }

        public void Update()
        {
            Console.WriteLine("MySQL ile güncellendi");
        }
    }
}
