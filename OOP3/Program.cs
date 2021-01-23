using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager esnafCreditManager = new EsnafCreditManager();

            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService smsLogger = new SmsLoggerService();

            //ihtiyacCreditManager.Calculate();
            //houseCreditManager.Calculate();
            //vehicleCreditManager.Calculate();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.DoBasvuru(vehicleCreditManager,fileLogger);
            basvuruManager.DoBasvuru(houseCreditManager,databaseLogger);
            basvuruManager.DoBasvuru(ihtiyacCreditManager,smsLogger);
            basvuruManager.DoBasvuru(esnafCreditManager, fileLogger);
            Console.WriteLine("----------------------");
            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager,houseCreditManager };
            basvuruManager.DoCreditPreview(credits);

        }
    }
}
