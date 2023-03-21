using System;

namespace AbstractClasses
{
    class Program
    {
        // Abstract classes hem tamamlanmış hem de tamamlanmamış metodları içeren sınıftır.
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Kaydet();
        }
    }
}
