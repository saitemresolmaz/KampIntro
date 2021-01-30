using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //ihtiyaç kredisi
    class PersonalCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Bireysel kredi ödeme planı hesaplandı.");
        }

        public void Print()
        {

        }
    }
}
