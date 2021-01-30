using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Gerçek Müşteri
    class IndividualCustomer : Customer
    {
        public string TcNo { get; set; }   //Neden string yaptık ? Üzerinde Matematiksel işlem yapmadık. Mantıklı olan string.

        public string Name { get; set; }
        public string Surname { get; set; }
    } 
}
