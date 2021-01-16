using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 10;
            int num2 = 30;
            num1 = num2;
            num2 = 65;

            Console.WriteLine(num1);
        }
    }
}
