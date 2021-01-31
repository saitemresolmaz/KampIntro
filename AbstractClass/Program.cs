using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract class new'lenemez.
            //Database database = new Database();
            Database database1 = new MySql();
            database1.Add();

            Database database2 = new Oracle();
            database2.Add();


            database1.Update();
            database2.Update();

        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public abstract void Update();

    }

    class MySql : Database
    {
        public override void Update()
        {
            Console.WriteLine("Updated by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Update()
        {
            Console.WriteLine("Updated by Oracle");
        }
    }
}
