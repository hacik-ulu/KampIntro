using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        //ICreditManager interface olarak tüm classlar tarafından alındığı için bunu yollamalıyız.
        //Method İnjection
        public void ApplyCredit(ICreditManager creditManager,List<ILoggerService> loggerService) // tek bir kredi türü için başvuru
        {
            //başvuran bilgilerini değerlendirme
            //Hangi kredi türü ekrandan yollanırsa ona ait olan Calculate() metodu çalışacak
            creditManager.Calculate();

            foreach (ILoggerService service in loggerService)
            {
                service.Log();
            }

        } // Tek bir kredi için yapılan hesaplama

        //KrediÖnBilgilerndirme metodu
        public void CreditPreInfo(List<ICreditManager> credits) // çok sayıda kredi türünün değerlendirmesi olabileceğinden liste döndürdük
        {
            foreach (ICreditManager credit in credits)
            {
                credit.Calculate();
                
            }
        }
        //kredi listesindeki bulunan tüm krediler için yapılan hesaplama


    }

}

