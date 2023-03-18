using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of string
            MyList<string> names = new MyList<string>();
            names.Add("Ali");

            Console.WriteLine(names.Lenght);

            names.Add("Hakan");

            Console.WriteLine(names.Lenght);

            Console.WriteLine();
            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
