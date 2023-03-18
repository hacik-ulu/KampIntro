using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList <T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];   
        }
        public void Add(T item) // Arrayi eklemek istiyorum. Array referans tipli olduğundan yukarda new'lenmek zorunda.
        {
            T[] tempArray = items; // items'ın referansını Geçici Diziye aktararak dizi elemanlarının kaybolmasını engelliyoruz.
            items = new T[items.Length+1]; // dizinin eleman sayısını arttırıyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // geçici dizideki tüm elemanları geri alıyoruz.
                
            }

            //items.Length - 1 - son index ( 6 elemanlıysa 5.indexe(son indexe) itemi yerleştirecek.)
            items[items.Length - 1] = item; // items tüm elemanlarını geri aldı, "items.Length - 1" ile en sonda item için yer açtı.
            //Console.WriteLine("Diziye eklenen ilk eleman:"+items[0]);
        }

        // Array eleman miktarının gösterir.
        public int Lenght
        {
            get { return items.Length; }
        }

        // Arraydeki elemanları gösterir.
        public T[] Items
        {
            get { return items; }
        }
    }
}
