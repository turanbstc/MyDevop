using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Turan", "Gokce", "Alp", "Omer" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            List<string> names2 = new List<string> { "Turan", "Gokce", "Alp", "Omer" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Zeynep");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);


        }
    }
}
