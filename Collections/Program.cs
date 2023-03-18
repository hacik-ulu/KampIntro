using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Koleksiyonlar ile listeleme

            
            List<string> names = new List<string> { "Ekrem", "Kerem", "Engin", "Umut" };
            names.Add("İlker");

            Console.WriteLine("Koleksiyonun Foreach ile Gösterilmesi");
            Console.WriteLine();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Koleksiyonu array indexleme ile gösterme
            Console.WriteLine("Koleksiyonun İndexleme Mantığı ile Gösterilmesi");
            Console.WriteLine();
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
        }
    }
}
