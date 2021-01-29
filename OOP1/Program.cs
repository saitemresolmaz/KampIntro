using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 15;

            Product product2 = new Product()
            {
                Id = 2,
                CategoryId = 1,
                ProductName = "Kapı",
                UnitPrice = 1000,
                UnitsInStock = 10
            };

            //PascalCase    //camelCase

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
