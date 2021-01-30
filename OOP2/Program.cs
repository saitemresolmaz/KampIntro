using System;

namespace OOP2
{
    class Program
    {
        //Inheritance
        static void Main(string[] args)
        {
            //Kazım Karabekir -Gerçek Müşteri
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustumerNo = "12345";
            customer1.Name = "Kazım";
            customer1.Surname = "Karabekir";
            customer1.TcNo = "123456789000";

            //Yazılımcılar Clup- Tüzel Müşteri

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustumerNo = "13579";
            customer2.CompanyName = "Yazılımcılar Clup";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
