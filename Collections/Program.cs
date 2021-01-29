using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Mustafa Kemal", "İsmet", "Kazım" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //names[3] = "Ali Fethi"; //patlar.

            List<string> names2 = new List<string> {"Fatih", "Yavuz", "Kanuni"};
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Murat");
            Console.WriteLine(names2[3]);
            Console.WriteLine(names2[0]);
        }
    }
}
