using System;

namespace ClassIntrpo
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.CourseInstructor = "Turan Bastacioglu";
            course1.WatchingRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.CourseInstructor = "Alp Bastacioglu";
            course2.WatchingRate = 75;

            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.CourseInstructor = "Gokce Alparslan";
            course3.WatchingRate = 48;

            //Console.WriteLine(course1.CourseName + " : " + course1.CourseInstructor + " " + course1.WatchingRate + "%");

            Course[] courses = new Course[] {course1, course2, course3};

            foreach (Course kurs in courses)
            {
               Console.WriteLine(kurs.CourseName + " : " + kurs.CourseInstructor + "  İzlenme Oranı : " + kurs.WatchingRate);
            }
        }
    }

    class Course
    {
        public string CourseName { get; set; }

        public  string CourseInstructor { get; set; }

        public int WatchingRate { get; set; }
    }
}
