using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Interface :  Şablondur.
    interface ICreditManager  // okunurluğu artırmak için interface başına I eklenir. Interface olduğunu böyle anlarız.
    {
        public void Calculate();
        public void Print();
    }
}
