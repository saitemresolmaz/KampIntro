using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Elma";
            product1.Price = 8;
            product1.Description = "Amasya Elması";
            product1.Stock = 5;

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";
            product2.Stock = 15;

            Product[] products = new Product[] { product1, product2};

                     //var da olur, C#'a sonradan girdi:)
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price +" TL");
                Console.WriteLine(product.Description);
                Console.WriteLine("----------------------------");
            }
                
            Console.WriteLine("----------------Methodlar-----------------------");

            //instance -örnek
            //encapsulation

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Armut", "Yeşil Armut", 12, 20);
            basketManager.Add2("Kiraz", "Ekşi Kiraz", 20, 9);
            basketManager.Add2("Kavun", "Sulu Kavun", 30,15);

        }
    }
}

// Don't repeat yourself - DRY - Best Practice