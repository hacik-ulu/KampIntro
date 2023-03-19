using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryGenericProject
{
    class MyDictionary<T1, T2>
    {
        T1[] items1;
        T2[] items2;

        T1[] tempArray1;
        T2[] tempArray2;
        public MyDictionary()
        {
            items1 = new T1[0]; // boş anahtar arrayi oluşturuldu.
            items2 = new T2[0]; // boş değer arrayi oluşturuldu.
        }

        public void Add(T1 item1, T2 item2)
        {
            tempArray1 = items1; // önceki elemanların kaybolmaması için geçici array oluşturuldu.
            items1 = new T1[items1.Length + 1]; // boş olan arraye eleman ekleyip eleman sayısını 1 artır.

            tempArray2 = items2;
            items2 = new T2[items2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)
            {
                items1[i] = tempArray1[i];
            }

            items1[items1.Length - 1] = item1; // en son eklediğimiz değer arrayin en sonuna eklenecek.

            for (int i = 0; i < tempArray2.Length; i++)
            {
                items2[i] = tempArray2[i];
            }

            items2[items2.Length - 1] = item2; // en son eklediğimiz değer arrayin en sonuna eklenecek.
        }

        // Eklenen kişilerin sayısınını bulunması
        public int Count
        {
            get { return items2.Length; }
            

        }
    }
}
