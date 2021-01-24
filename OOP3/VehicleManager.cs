using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasit");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
