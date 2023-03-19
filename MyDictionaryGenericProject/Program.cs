using System;
using System.Collections.Generic;

namespace MyDictionaryGenericProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,string> myDictionary = new MyDictionary<string,string>();
            myDictionary.Add("Hacik Ulu", "Haliç Üniversitesi");
            myDictionary.Add("Engin Demiroğ", "ODTÜ ");
            myDictionary.Add("Ali İhsan", "Beykent Üniversitesi");
            myDictionary.Add("Veli Akaydın", "Yeditepe Üniversitesi");
            myDictionary.Add("Samet Kadıoğlu", "Yıldız Teknik Üniversitesi");

            Console.WriteLine("Eklenen Kişi Sayısı:"+myDictionary.Count);
            
        }
    }
}


