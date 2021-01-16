using System;

namespace MyDevop
{
    class Program
    {
        static void Main(string[] args)
        {
            string categorySticker = "Category";
            int numberOfStudents = 32000;
            double faiz = 1.45;
            bool systemAccess = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Decrease Button");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Increase Button");
            }
            else
            {
                Console.WriteLine("Not Changed");
            }

            if (systemAccess == true)
            {
                Console.WriteLine("User Settings Button");
            }
            else
            {
                Console.WriteLine("LogIn Button");
            }
           
        }
    }
}
