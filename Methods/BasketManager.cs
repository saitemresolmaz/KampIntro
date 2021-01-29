using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager  //Manager, Service, Dal, DataAccess, Controller gibi yapılar operasyon tutuyor demektir.
    {
        //naming convention> Method isimleri büyük harfle başlar.
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. " +product.Name + " sepete eklendi.");
        }

        public void Add2 (string productName, string description, double price ,int stokAdedi)
        {
            Console.WriteLine("Tebrikler. " + productName + " sepete eklendi.");
        }
    }
}