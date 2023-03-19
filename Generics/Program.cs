using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hazır Koleksiyonun Eleman Sayısı");
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("İzmir");
            cities.Add("Bolu");
            cities.Add("Sivas");
            Console.WriteLine(cities.Count);

            Console.WriteLine("Manuel Koleksiyonun Eleman Sayısı");
            MyList<string> cities2 = new MyList<string>(); // <string> generic ifadesi için classı <T> şeklinde generic yaparız.
            cities2.Add("Ankara");
            cities2.Add("Elazığ");
            cities2.Add("Muş");
            cities2.Add("İzmir");
            cities2.Add("Tunceli");
            cities2.Add("Konya");
            Console.WriteLine(cities2.Count);

        }
    }
}
