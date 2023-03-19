using System;

namespace ReferencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int,decimal float,enum,boolean-->değer tipi
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;
            Console.WriteLine("Sayı 1:" + sayi1); // sayi1=20 olacak

            /*
             * stack(değer tipli olan kısım)
             * ----------------------------
             * sayi1 = 10-->sayi1=20
             * sayi2 = 20-->sayi2=100 
             */

            /* arrays,interface,class--> reference types
             * int[]sayilar1 = new int[] {1,2,3}
             * int[]sayilar2 = new int[]{10,20,30}
             * sayilar1=sayilar2 --> sayılar2'nin referans adresi sayilarin1'in referans adresine atanır.
             * sayilar2[0]=1000-->sayilar2'nin referans adresinin 0.elemanı 1000'e atanır.
             * sayilar1[0]-->sayilar1'in tuttuğu referans adresinin 0.indexini sorar. Bu da 1000'dir. 
             */

            /*
             * stack                                          heap
             *(101 adres) sayilar1------>                (101 adres) {1,2,3}   
             *(102 adres) sayilar2------>                (102 adres) {10,20,30}  
             * 
             *(102 adres) sayilar1------                 (101 adres) {1,2,3}   
             *(102 adres) sayilar2------>                (102 adres) {10,20,30}  
             *
             *(102 adres) sayilar1------                 (101 adres) {1,2,3}-->Garbage collectore gider.   
             *(102 adres) sayilar2------>                (102 adres) {1000,20,30}  
             */
        }
    }
}
