﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
