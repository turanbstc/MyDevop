using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Yazilim Gelistirici Kampi";
            string course2 = "Programlamaya Baslangic Icin Temel Kurs";
            string course3 = "Java";

            string[] courses = new string[] { "Yazilim Gelistirici Kampi", "Programlamaya Baslangic Icin Temel Kurs", "Java", "Python", "C++" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("For Döngüsü Bitti");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
