using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Esnaf Kredisi
    class ArtisanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf Kredisi hesaplandı.");
        }

        public void Print()
        {

        }
    }
}
