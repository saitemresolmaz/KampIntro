using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //Interface
        static void Main(string[] args)
        {
            //Bireysel Kredi
            ICreditManager personalCreditManager = new PersonalCreditManager();
            //Ev Kredisi
            ICreditManager homeCreditManager = new HomeCreditManager();
            //Araba Kredisi
            ICreditManager carCreditManager = new CarCreditManager();

            //Ev Kredisi Basvurusu Yap
            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(new ArtisanCreditManager(), new List<ILoggerService>
            {
                new DatabaseLoggerService(), new SmsLoggerService()
            });

            // çoklu kredi seçip hesaplatarak hangisi uygun kıyaslamak
            List<ICreditManager> credits = new List<ICreditManager>()
            {
            personalCreditManager,
            homeCreditManager
            };

            applyManager.CreditPreInform(credits);

        }
    }
}
