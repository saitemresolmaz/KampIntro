using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager  //Kredi Basvurusu
    {
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuru bilgilerini değerlendirme

            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
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
