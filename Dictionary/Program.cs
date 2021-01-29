using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> towns = new Dictionary<int, string>();
            towns.Add(6, "Ankara");
            towns.Add(34, "İstanbul");
            towns.Add(35, "İzmir");
            towns.Add(82, "İzmir");

            foreach (var town in towns)
            {
                Console.WriteLine(towns[town.Key]);
                Console.WriteLine(town.Key);
            }

        }
    }
}
