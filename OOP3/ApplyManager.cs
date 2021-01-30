using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager  //Kredi Basvurusu
    {
        public void Apply(ICreditManager creditManager)
        {
            //Başvuru bilgilerini değerlendirme

            creditManager.Calculate();

        }

        public void CreditPreInform(List<ICreditManager> credits)  //Kredi Ön Bilgilendirmesi Yap
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
