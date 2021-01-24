using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager needManager = new NeedManager();
            IKrediManager vehicleManager = new VehicleManager();
            IKrediManager mortgageManager = new MortgageManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> logger = new List<ILoggerService>() { new DatabaseLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(vehicleManager, logger);

            List<IKrediManager> credis = new List<IKrediManager>() {needManager, vehicleManager };
           // applicationManager.CreditPreInformation(credis);
        }
    }
}
