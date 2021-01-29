using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Namık");

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
