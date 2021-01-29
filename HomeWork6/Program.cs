using System;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Category = "Elektronik";
            product1.Name = "Huawei Matebook D 14";
            product1.Price = 7000;


            Product product2 = new Product()
            {
                Category = "Süpermarket",
                Name = "Sütaş Peynir",
                Price = 40
            };

            Product product3 = new Product()
            {
                Category = "Giyim",
                Name = "Pierre Cardin Hırka",
                Price = 300
            };

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Category + ", " + product.Name + ", " + product.Price+" TL");
            }
        }
    }

    class Product
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
