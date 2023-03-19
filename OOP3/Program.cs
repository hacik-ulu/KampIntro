using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interfaceler classların referans adresini tutabilir.
            //Ekrandaki Açılır Kutu
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            //Kredi Başvurusu
            ApplyManager applyManager = new ApplyManager();
            List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerService, smsLoggerService };
            //applyManager.ApplyCredit(new EsnafCreditManager(),
            //      new List<ILoggerService>() new DatabaseLoggerService, new SmsLoggerService() );
            applyManager.ApplyCredit(new EsnafCreditManager(),loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager,
            vehicleCreditManager};
            //applyManager.CreditPreInfo(credits);

        }

    }
}

