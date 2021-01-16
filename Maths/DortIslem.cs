using System;
using System.Collections.Generic;
using System.Text;

namespace Maths
{
    class DortIslem
    {
        public void Toplama(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        public void Cikarma(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        public void Carpma(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }
        public void Bolme(double num1, double num2)
        {
            double result = num1 / num2;
        }
    }
}
