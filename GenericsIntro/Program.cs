using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            //names.Add("Namık");

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

            MyDictionary<int, string> towns = new MyDictionary<int, string>();
            towns.Add(34, "İstanbul");
            towns.Add(35, "İzmir");

            foreach (var town in towns.Keys)
            {
                Console.WriteLine(town);
            }
        }
    }
}
