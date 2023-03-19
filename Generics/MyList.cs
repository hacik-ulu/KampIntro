using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyList<T> //Generic class
    {
        T[] cityArray; // gönderilen şehirlerin array olarak tutulması.
        T[] tempArray;  // eski elemanların kaybolmasını engellemek için geçici array oluşturuyoruz.
        public MyList()
        {
            cityArray = new T[0]; // MyList<string> cities2 = new MyList<string>(); işlem yapıldığında 0 elemanlı boş array oluşturulur.
        }


        public void Add(T item)
        {
            tempArray = cityArray; // geçici array ana arrayin elemanlarını tutuyor.
            cityArray = new T[cityArray.Length + 1]; // eleman eklendikçe 1 artıyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                cityArray[i] = tempArray[i];
            }

            cityArray[cityArray.Length - 1] = item; // en son eklediğimiz itemi arrayın en son indexine dahil ediyoruz.

        }

        public int Count
        {
            get { return cityArray.Length; }

        }

    }
}
