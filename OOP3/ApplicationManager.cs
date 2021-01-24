using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(IKrediManager krediManager, List<ILoggerService> loggerService) //Method Injection - Dependency Injection
        {
            krediManager.Calculate();

            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void CreditPreInformation(List<IKrediManager> credis)
        {
            foreach (var credit in credis)
            {
                credit.Calculate();
            }
        }
    }
}
