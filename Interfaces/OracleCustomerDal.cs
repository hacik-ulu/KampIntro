using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
           Console.WriteLine("Oracle ile eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle ile silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oracle ile Güncellendi");
        }
    }
}
