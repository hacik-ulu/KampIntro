using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    abstract class MevzuatBase
    {
        //abstract classlar newlenemez (gövdesiz metod içerdiğinden)
        //tanımlanmamış(gövdesiz) operasyonlar yazılır bunu kullanan classlar kendine göre override eder.
        //constructor da kullanılabilir.protected yazılı şekilde olması clean koddur.
        protected MevzuatBase()
        {
            Console.WriteLine("Abstract classlar protected/public şekilde constructor oluşturabilir.");
        }
        public abstract void Degerlendir(); //imza

        //tanımlanmış(gövdeli) operasyonlar yazılır tüm classlarda değiştirilmeden/özelleştirilmeden aynı şekilde kullanılır.
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");
        }
    }
}
