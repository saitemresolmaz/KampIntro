using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[]
            {
                "Java Beginner Course","Oracle Pl/Sql Course", "Network Programming","Python", "C++"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("For döngüsü bitti");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("Foreach döngüsü bitti");
        }
    }
}
