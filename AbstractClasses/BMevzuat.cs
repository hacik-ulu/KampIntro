using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi.");
        }
    }
}
